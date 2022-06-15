// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

[Guid("15E65EC0-3B9C-11D2-B92F-00609797EA5B")]
public partial struct IDirectDraw7
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IDirectDraw7;
}
