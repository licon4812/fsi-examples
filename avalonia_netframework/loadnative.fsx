#r "nuget: NativeLibraryLoader, 1.0.13"
#r "nuget: SkiaSharp.NativeAssets.Win32, 2.88.9"
#r "nuget: SkiaSharp.HarfBuzz, 2.88.9"

open System.Runtime.InteropServices
open System.IO

module LoadNative =

    let LoadNativeDlls =
        if RuntimeInformation.FrameworkDescription.Contains "Framework" then
            // Resolve the native library paths dynamically based on architecture
            let getNativeDllPaths () =
                match RuntimeInformation.ProcessArchitecture with
                | Architecture.X64 ->
                    [| @".\skiasharp.nativeassets\win-x64\native\libSkiaSharp.dll"
                       @".\harfbuzzsharp.nativeassets\win-x64\native\libHarfBuzzSharp.dll" |]
                | Architecture.X86 ->
                    [| @".\skiasharp.nativeassets\win-x86\native\libSkiaSharp.dll"
                       @".\harfbuzzsharp.nativeassets\win-x86\native\libHarfBuzzSharp.dll" |]
                | Architecture.Arm64 ->
                    [| @".\skiasharp.nativeassets\win-arm64\native\libSkiaSharp.dll"
                       @".\harfbuzzsharp.nativeassets\win-arm64\native\libHarfBuzzSharp.dll" |]
                | _ -> failwith "Unsupported architecture"

            let nativeDllPaths = getNativeDllPaths ()

            for nativeDllPath in nativeDllPaths do
                let fullPath = Path.GetFullPath(nativeDllPath)
                let dllName = Path.GetFileName(nativeDllPath)
                printfn "DLL Name: %s" dllName
                printfn "Full Path: %s" fullPath

                try
                    let nativeLibrary = new NativeLibraryLoader.NativeLibrary(fullPath)
                    printfn "Successfully loaded %s from: %s" dllName fullPath
                with ex ->
                    printfn "Failed to load %s: %s" dllName ex.Message
