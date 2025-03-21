#r "PresentationFramework"
#r "WindowsBase"
#r "PresentationCore"

open System
open System.Windows
open System.Windows.Controls

// Define the main window with counter functionality
type MainWindow() as this =
    inherit Window()

    // Counter state
    let mutable count = 0

    // UI Elements
    let textBlock =
        TextBlock(
            Text = count.ToString(),
            FontSize = 48.0,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment = VerticalAlignment.Center
        )

    let incrementButton =
        Button(Content = "+", HorizontalAlignment = HorizontalAlignment.Stretch)

    let decrementButton =
        Button(Content = "-", HorizontalAlignment = HorizontalAlignment.Stretch)

    let dockPanel = DockPanel()

    // Initialize the window
    do
        this.Title <- "Counter Example"
        this.Width <- 600.0
        this.Height <- 400.0

        // Set DockPanel layout
        DockPanel.SetDock(incrementButton, Dock.Bottom)
        DockPanel.SetDock(decrementButton, Dock.Bottom)

        dockPanel.Children.Add(decrementButton) |> ignore
        dockPanel.Children.Add(incrementButton) |> ignore
        dockPanel.Children.Add(textBlock) |> ignore

        this.Content <- dockPanel

        // Button click events
        incrementButton.Click.Add(fun _ ->
            count <- count + 1
            textBlock.Text <- count.ToString())

        decrementButton.Click.Add(fun _ ->
            count <- count - 1
            textBlock.Text <- count.ToString())

// Start the WPF application
let main args =
    let app = Application()
    let window = MainWindow()
    app.Run(window)
//print dotnet framework version
printfn "%s" Runtime.InteropServices.RuntimeInformation.FrameworkDescription
main [||]
