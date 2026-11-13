// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='WiaLog.xml' path='doc/member[@name="WiaLog"]/*' />
[Guid("A1E75357-881A-419E-83E2-BB16DB197C68")]
public unsafe partial struct WiaLog : INativeGuid
{
    /// <include file='WiaLog.xml' path='doc/member[@name="WiaLog.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in CLSID_WiaLog);
}
