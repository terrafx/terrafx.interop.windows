// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

[Guid("B3A6F3E0-2B43-11CF-A2DE-00AA00B93356")]
public partial struct IDirectDraw2
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IDirectDraw2;
}
