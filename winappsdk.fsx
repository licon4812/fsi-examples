#r "nuget: Microsoft.WindowsAppSDK, 1.7.250310001"
#r "nuget: System.Text.Json, 10.0.0-preview.2.25163.2"

open System
open System.Text.Json
open System.IO
open Microsoft.UI.Xaml
open Microsoft.UI.Xaml.Controls
open Microsoft.UI

type Car =
    { Make: string
      Model: string
      Year: int
      Colour: string }

// Deserialize cars from JSON
let loadCars filePath =
    let options = JsonSerializerOptions(PropertyNameCaseInsensitive = true)
    use stream = File.OpenRead(filePath)

    JsonSerializer.DeserializeAsync<Car list>(stream, options).AsTask()
    |> Async.AwaitTask
    |> Async.RunSynchronously

// Programmatically create a Window and display the cars
let createWindow cars =
    // Create the Window
    let window = new Window()
    let stackPanel = new StackPanel()

    // Add each car as a TextBlock
    cars
    |> List.iter (fun car ->
        let carText = sprintf "%s %s (%d) - %s" car.Make car.Model car.Year car.Colour
        stackPanel.Children.Add(new TextBlock(Text = carText)) |> ignore)

    // Set the Content of the Window
    window.Content <- stackPanel
    window.Activate() // Display the Window

[<EntryPoint>]
let main argv =
    // Initialize the App SDK
    let app = new Microsoft.UI.Xaml.Application()

    // Load cars from JSON
    let cars = loadCars "./cars.json"

    // Create the main Window
    createWindow cars

    // Start the App
    app.Run()
    0
