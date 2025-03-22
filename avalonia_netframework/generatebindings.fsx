module GenerateBindings

#r "nuget: PeNet" // Install the PeNet package for PE file analysis

open System.Runtime.InteropServices
open PeNet
open System
open System.Text
open System.IO

// Get the path relative to the current directory
let relativePath =
    match RuntimeInformation.ProcessArchitecture with
    | Architecture.X64 -> @".\skiasharp.nativeassets.win-x64\win-x64\native\libSkiaSharp.dll"
    | Architecture.X86 -> @".\skiasharp.nativeassets.win32\win-x86\native\libSkiaSharp.dll"
    | Architecture.Arm64 -> @".\skiasharp.nativeassets.win32\win-arm64\native\libSkiaSharp.dll"
    | _ -> failwith "Unsupported architecture"

let fullPath = Path.GetFullPath(relativePath)
printfn "Full Path: %s" fullPath

module SkiSharpNative =

    let generateBindings (dllPath: string) =
        try
            // Load the DLL
            let peFile = PeNet.PeFile(dllPath)

            if peFile.ExportedFunctions.Length = 0 then
                failwith "No exported functions found."

            // Start building the bindings
            let sb = StringBuilder()
            sb.AppendLine("module SkiaSharpNative") |> ignore
            sb.AppendLine("open System.Runtime.InteropServices") |> ignore
            sb.AppendLine("module SkiaNative =") |> ignore

            // Iterate over each exported function and generate bindings
            for func in peFile.ExportedFunctions do
                let functionName = func.Name

                if not (String.IsNullOrWhiteSpace functionName) then
                    sb.AppendLine(sprintf "    [<DllImport(\"libSkiaSharp\", EntryPoint = \"%s\")>]" functionName)
                    |> ignore

                    sb.AppendLine(sprintf "    extern void %s()" functionName) |> ignore

            sb.ToString()

        with ex ->
            sprintf "Error: %s" ex.Message
// Generate bindings
let bindings = SkiSharpNative.generateBindings (fullPath)
