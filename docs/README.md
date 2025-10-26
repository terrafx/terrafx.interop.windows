# TerraFX.Interop.Windows

Interop bindings for the Windows 11 (v10.0.26100.6584) and DirectX Agility (v1.618.2) SDKs

![ci](https://github.com/terrafx/terrafx.interop.windows/actions/workflows/ci.yml/badge.svg?branch=main&event=push)
[![Discord](https://img.shields.io/discord/593547387457372212.svg?label=Discord&style=plastic)](https://discord.terrafx.dev/)

Packages are available at: https://github.com/orgs/terrafx/packages or via the NuGet Feed URL: https://pkgs.terrafx.dev/index.json

## Table of Contents

* [Code of Conduct](#code-of-conduct)
* [License](#license)
* [Contributing](#contributing)
* [Goals](#goals)
* [Languages and Frameworks](#languages-and-frameworks)

### Code of Conduct

TerraFX and everyone contributing (this includes issues, pull requests, the
wiki, etc) must abide by the .NET Foundation Code of Conduct:
https://dotnetfoundation.org/about/code-of-conduct.

Instances of abusive, harassing, or otherwise unacceptable behavior may be
reported by contacting the project team at conduct@dotnetfoundation.org.

### License

Copyright © Tanner Gooding and Contributors. Licensed under the MIT License
(MIT). See [LICENSE](https://github.com/terrafx/terrafx.interop.windows/blob/main/LICENSE.md) in the repository root for more information.

### Contributing

If you are looking to contribute you should read our
[Contributing](https://github.com/terrafx/terrafx.interop.windows/blob/main/docs/CONTRIBUTING.md) documentation.

### Goals

Provide interop bindings for the Windows 11 (v10.0.26100.6584) and DirectX Agility (v1.618.2) SDKs

The bindings should be blittable, trim safe, AOT compatible, and as close to 1-to-1 with the underlying C API definitions as feasible. Put simply, they are as close to `#include <Windows.h>` as you can get in .NET

Not all headers are provided by default due to size, new ones are added upon request. Some of the most common headers provided are (this is non-exhaustive):
* DirectX
  * d2d1
  * d3d9
  * d3d10
  * d3d11
  * d3d12
  * d3dx12
  * dcomp
  * dinput
  * dwrite
  * dxgi
  * x3daudio
  * xapo
  * xaudio2
* GDI+
* Win32
  * COM
  * CommCtrl
  * ConsoleAPI
  * FileAPI
  * HeapAPI
  * MediaFoundation
  * OLE
  * SetupAPI
  * ShellApi
  * WIC
  * WinGdi
  * WinUser

### .NET Foundation

This project is supported by the [.NET Foundation](https://dotnetfoundation.org).
