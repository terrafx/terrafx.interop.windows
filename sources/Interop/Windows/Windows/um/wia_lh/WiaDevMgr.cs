// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='WiaDevMgr.xml' path='doc/member[@name="WiaDevMgr"]/*' />
[Guid("A1F4E726-8CF1-11D1-BF92-0060081ED811")]
public unsafe partial struct WiaDevMgr : INativeGuid
{
    /// <include file='WiaDevMgr.xml' path='doc/member[@name="WiaDevMgr.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in CLSID_WiaDevMgr);
}
