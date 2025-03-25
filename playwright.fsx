#r "nuget: Microsoft.Playwright, 1.51.0"

open Microsoft.Playwright

let url = "https://www.google.com"

let googleSearch =
    async {
        use! pw = Playwright.CreateAsync() |> Async.AwaitTask

        let! browser =
            pw.Chromium.LaunchAsync(BrowserTypeLaunchOptions(Headless = false))
            |> Async.AwaitTask

        let! page = browser.NewPageAsync() |> Async.AwaitTask
        let! _ = page.GotoAsync(url) |> Async.AwaitTask

        return! page.TitleAsync() |> Async.AwaitTask
    }

googleSearch |> Async.RunSynchronously
