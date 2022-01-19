# Quic.NET
Quic.NET is a .NET binding library of [MsQuic](https://github.com/microsoft/msquic) from [.NET runtime](https://github.com/dotnet/runtime/tree/main/src/libraries/System.Net.Quic) back-ported to .NET 6.

>**WANING**:
>Codes in this repository are taken from [.NET runtime repository](https://github.com/dotnet/runtime/tree/main/src/libraries/System.Net.Quic)
and modified so that they can target .NET 6. `System.Net.Quic` is currently internal and scheduled to be delivered in .NET 7, which means the
APIs are subject to change. You should really use this library only for testing and experimental purposes.

## How to use
Install `Quic.NET` from NuGet package mananger in your project. Import namespace `System.Net.Quic` and enjoy.

To run the application, you'll also need to install MsQuic librabies:

- **Windows**: Install NuGet package `Microsoft.Native.Quic.MsQuic.OpenSSL` or `Microsoft.Native.Quic.MsQuic.Schannel` .
- **Linux**: Install `libmsquic` package via [Microsoft official Linux package]() repository.

You can also build MsQuic by yourself if there's no package available for your system. See [here](https://github.com/microsoft/msquic/blob/main/docs/BUILD.md) for detailed instructions.