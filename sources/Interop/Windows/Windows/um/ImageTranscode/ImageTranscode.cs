// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ImageTranscode.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='ImageTranscode.xml' path='doc/member[@name="ImageTranscode"]/*' />
[Guid("17B75166-928F-417D-9685-64AA135565C1")]
public unsafe partial struct ImageTranscode : INativeGuid
{
    /// <include file='ImageTranscode.xml' path='doc/member[@name="ImageTranscode.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in CLSID_ImageTranscode);
}
