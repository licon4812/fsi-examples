#r "nuget: System.Text.Json, 10.0.0-preview.2.25163.2"

open System
open System.Text.Json
open System.IO
open System.Runtime.InteropServices

type Car =
    { Make: string
      Model: string
      Year: int
      Colour: string }

// Define the MessageBox function from the Win32 API
[<DllImport("user32.dll", CharSet = CharSet.Unicode)>]
extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType)

// Function to parse command-line arguments like --colour, --make, --model
let parseArguments (args: string[]) =
    let tryFindArg flag =
        args
        |> Array.tryFindIndex (fun arg -> arg = flag)
        |> Option.bind (fun index ->
            if index + 1 < args.Length then
                Some args.[index + 1]
            else
                None)

    let colour = tryFindArg "--colour" |> Option.defaultValue ""
    let make = tryFindArg "--make" |> Option.defaultValue ""
    let model = tryFindArg "--model" |> Option.defaultValue ""
    colour, make, model

// Load and deserialize the JSON file
let Json: Stream = File.OpenRead("./cars.json")
let options = JsonSerializerOptions(PropertyNameCaseInsensitive = true)

let cars: List<Car> =
    Json
    |> fun stream -> JsonSerializer.DeserializeAsync<List<Car>>(stream, options)
    |> fun valueTask -> valueTask.AsTask()
    |> Async.AwaitTask
    |> Async.RunSynchronously

// Parse the arguments from the command line
let args = fsi.CommandLineArgs
let colour, make, model = parseArguments args

// Filter the cars based on parsed arguments
let filteredCars =
    cars
    |> Seq.filter (fun car ->
        (car.Colour = colour || colour = "")
        && (car.Make = make || make = "")
        && (car.Model = model || model = ""))

// Format the filtered cars into a readable string
let carList =
    filteredCars
    |> Seq.mapi (fun index car -> sprintf "%d. %s %s (%d) - %s" (index + 1) car.Make car.Model car.Year car.Colour)
    |> fun lines -> String.Join("\n", lines)

// Display the filtered list of cars in a message box
if carList.Trim().Length = 0 then
    MessageBox(IntPtr.Zero, "No cars match the specified filters.", "Filtered Cars", 0u)
    |> ignore
else
    MessageBox(IntPtr.Zero, carList, "Filtered Cars", 0u) |> ignore
