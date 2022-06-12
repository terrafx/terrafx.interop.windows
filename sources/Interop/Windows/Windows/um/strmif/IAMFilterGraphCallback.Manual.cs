// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

[Guid("56A868FD-0AD4-11CE-B0A3-0020AF0BA770")]
public partial struct IAMFilterGraphCallback
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IAMFilterGraphCallback;
}
