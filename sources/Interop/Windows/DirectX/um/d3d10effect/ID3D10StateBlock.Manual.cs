// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

[Guid("0803425A-57F5-4dd6-9465-A87570834A08")]
public partial struct ID3D10StateBlock
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ID3D10StateBlock;
}
