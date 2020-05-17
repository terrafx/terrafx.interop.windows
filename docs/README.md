# TerraFX.Interop.Windows

Interop bindings for Windows.

| Job | Debug Status | Release Status |
| --- | ------------ | -------------- |
| Windows x86 | [![Build Status](https://ci.terrafx.dev/_apis/build/status/terrafx.terrafx.interop.windows-ci?branchName=master&jobName=windows_debug_x86)](https://ci.terrafx.dev/_build/latest?definitionId=12&branchName=master) | [![Build Status](https://ci.terrafx.dev/_apis/build/status/terrafx.terrafx.interop.windows-ci?branchName=master&jobName=windows_release_x86)](https://ci.terrafx.dev/_build/latest?definitionId=12&branchName=master) |
| Windows x64 | [![Build Status](https://ci.terrafx.dev/_apis/build/status/terrafx.terrafx.interop.windows-ci?branchName=master&jobName=windows_debug_x64)](https://ci.terrafx.dev/_build/latest?definitionId=12&branchName=master) | [![Build Status](https://ci.terrafx.dev/_apis/build/status/terrafx.terrafx.interop.windows-ci?branchName=master&jobName=windows_release_x64)](https://ci.terrafx.dev/_build/latest?definitionId=12&branchName=master) |
| Ubuntu x64 | [![Build Status](https://ci.terrafx.dev/_apis/build/status/terrafx.terrafx.interop.windows-ci?branchName=master&jobName=ubuntu_debug_x64)](https://ci.terrafx.dev/_build/latest?definitionId=12&branchName=master) | [![Build Status](https://ci.terrafx.dev/_apis/build/status/terrafx.terrafx.interop.windows-ci?branchName=master&jobName=ubuntu_release_x64)](https://ci.terrafx.dev/_build/latest?definitionId=12&branchName=master) |
| MacOS x64 | [![Build Status](https://ci.terrafx.dev/_apis/build/status/terrafx.terrafx.interop.windows-ci?branchName=master&jobName=macos_debug_x64)](https://ci.terrafx.dev/_build/latest?definitionId=12&branchName=master) | [![Build Status](https://ci.terrafx.dev/_apis/build/status/terrafx.terrafx.interop.windows-ci?branchName=master&jobName=macos_release_x64)](https://ci.terrafx.dev/_build/latest?definitionId=12&branchName=master) |

[![Discord](https://img.shields.io/discord/593547387457372212.svg?label=Discord&style=plastic)](https://discord.terrafx.dev/)

## Table of Contents

* [Goals](#goals)
* [Languages and Frameworks](#languages-and-frameworks)
* [License](#license)
* [Code of Conduct](#code-of-conduct)
* [Contributing](#contributing)
* [Using](#using)

### Goals

TerraFX is aiming to be a cross-platform framework for developing multimedia-
based applications.

* We plan on primarily supporting Linux and Windows and are looking at the
  possibility of supporting MacOS as well.
* We plan on providing an API that abstracts over the various lower-level
  graphics, audio, and windowing libraries APIs and makes them easy to use.

### Languages and Frameworks

TerraFX uses C# as its primary development language and .NET Core as our primary target framework.

### License

Copyright © Tanner Gooding and Contributors. Licensed under the MIT License
(MIT). See [LICENSE](../LICENSE.md) in the repository root for more information.

### Code of Conduct

TerraFX and everyone contributing (this includes issues, pull requests, the
wiki, etc) must abide by the [CODE_OF_CONDUCT](CODE_OF_CONDUCT.md).
Instances of abusive, harassing, or otherwise unacceptable behavior may be
reported by contacting the project team at admin@terrafx.dev.

### Using 
To use TerraFX you need to not only 
**clone the [github repository](https://github.com/terrafx/terrafx.interop.windows)** 
but also make sure you have the right tools and libraries installed. 

For Windows 10 you need 
[Visual Studio 2019 Preview](https://visualstudio.microsoft.com/vs/preview/) 
in its current release (Preview 6 as of the time of this writing) and you need 
**.Net 5.0 Preview** (the name is not .Net Core 5.0). 
And finally, in Visual Studio you need need to go to 
**Options -> Environment -> Preview Features** 
and there enable the option **Use previews of the .NET Core SDK**.

With all requirements in place, start with **TerraFX.Interop.Windows.sln** 
in the root directory of the repository. 
It will run a few minimalistic examples of using the **TerraFX windows interop API**, 
such as rendering a triangle into a DirectX 11 or 12 window. 
More examples are being added over time.  
**TerraFX.Interop.Windows.Samples.sln** is the second project you might want to try. 
It also has minimalistic examples but instead of a full screen window, 
the DirectX rendering is embedded into a GUI with buttons and a panel for the rendering.

Those examples should get you started with using DirectX via C# in your own projects.

### Contributing

If you are looking to contribute you should read our
[Contributing](CONTRIBUTING.md) documentation.


