#r "nuget: Avalonia, 11.2.5"
#r "nuget: Avalonia.Themes.Fluent, 11.2.5"
#r "nuget: Avalonia.Desktop, 11.2.5"
#r "nuget: Avalonia.ReactiveUI, 11.2.5"

#load "loadnative.fsx"

open Avalonia
open Avalonia.Controls
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Layout
open Avalonia.Themes.Fluent
open Avalonia.ReactiveUI

type MainWindow() as this =
    inherit Window()

    // Counter state
    let mutable count = 0

    // UI Elements
    let counterText =
        TextBlock(
            FontSize = 48.0,
            VerticalAlignment = VerticalAlignment.Center,
            HorizontalAlignment = HorizontalAlignment.Center,
            Text = count.ToString()
        )

    let incrementButton =
        Button(Content = "+", HorizontalAlignment = HorizontalAlignment.Stretch)

    let decrementButton =
        Button(Content = "-", HorizontalAlignment = HorizontalAlignment.Stretch)

    let dockPanel = DockPanel()

    do
        // Configure the window
        this.Title <- "Counter Example"

        // Set up DockPanel layout
        DockPanel.SetDock(incrementButton, Dock.Bottom)
        DockPanel.SetDock(decrementButton, Dock.Bottom)

        dockPanel.Children.Add(decrementButton) |> ignore
        dockPanel.Children.Add(incrementButton) |> ignore
        dockPanel.Children.Add(counterText) |> ignore

        this.Content <- dockPanel

        // Event handlers for buttons
        incrementButton.Click.Add(fun _ ->
            count <- count + 1
            counterText.Text <- count.ToString())

        decrementButton.Click.Add(fun _ ->
            count <- count - 1
            counterText.Text <- count.ToString())

type App() =
    inherit Application()

    override this.Initialize() =
        // Add Fluent theme for consistent styling
        this.Styles.Add(FluentTheme())
        this.RequestedThemeVariant <- Styling.ThemeVariant.Dark

    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktopLifetime ->
            // Set the main window of the application
            desktopLifetime.MainWindow <- MainWindow()
        | _ -> ()

module Program =
    let main args =
        AppBuilder.Configure<App>().UsePlatformDetect().UseSkia().UseReactiveUI().StartWithClassicDesktopLifetime(args)

printfn "%s" System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription
Program.main fsi.CommandLineArgs
