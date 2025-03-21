#r "System.Windows.Forms"

open System
open System.Drawing
open System.Windows.Forms

// Create the main form
let form = new Form(Text = "Counter Example", Width = 300, Height = 200)

// Counter state
let mutable count = 0

// Create UI elements
let counterLabel =
    new Label(
        Text = count.ToString(),
        Font = new Font("Arial", 24.0f),
        Dock = DockStyle.Top,
        TextAlign = ContentAlignment.MiddleCenter
    )

let incrementButton = new Button(Text = "+", Dock = DockStyle.Bottom)
let decrementButton = new Button(Text = "-", Dock = DockStyle.Bottom)

// Add event handlers for buttons
incrementButton.Click.Add(fun _ ->
    count <- count + 1
    counterLabel.Text <- count.ToString())

decrementButton.Click.Add(fun _ ->
    count <- count - 1
    counterLabel.Text <- count.ToString())

// Add controls to the form
form.Controls.Add(counterLabel)
form.Controls.Add(incrementButton)
form.Controls.Add(decrementButton)

// Run the application
Application.Run(form)
