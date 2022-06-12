// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

[Guid("57805885-6EEC-11CF-9441-A82303C10E27")]
public partial struct IDirectDrawSurface2
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IDirectDrawSurface2;
}
