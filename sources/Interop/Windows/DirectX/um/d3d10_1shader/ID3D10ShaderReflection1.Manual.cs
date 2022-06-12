// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

[Guid("C3457783-A846-47CE-9520-CEA6F66E7447")]
public partial struct ID3D10ShaderReflection1
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ID3D10ShaderReflection1;
}
