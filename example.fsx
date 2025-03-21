#r "nuget: System.Text.Json, 10.0.0-preview.2.25163.2"

open System
open System.Text.Json
open System.IO

type Car =
    { Make: string
      Model: string
      Year: int
      Colour: string }

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

let Json: Stream = File.OpenRead("./cars.json")
let options = JsonSerializerOptions(PropertyNameCaseInsensitive = true)

try
    // Deserialize cars from the JSON file
    let cars: List<Car> =
        Json
        |> fun stream -> JsonSerializer.DeserializeAsync<List<Car>>(stream, options)
        |> fun valueTask -> valueTask.AsTask()
        |> Async.AwaitTask
        |> Async.RunSynchronously

    // Parse the arguments from the script
    let args = fsi.CommandLineArgs
    let colour, make, model = parseArguments args

    // Filter the list of cars
    let filteredCars =
        cars
        |> Seq.filter (fun car ->
            (car.Colour = colour || colour = "")
            && (car.Make = make || make = "")
            && (car.Model = model || model = ""))

    // Print the filtered results
    filteredCars
    |> Seq.iter (fun car -> printfn "%s %s %d %s" car.Make car.Model car.Year car.Colour)

with ex ->
    printfn "An error occurred: %s" ex.Message
