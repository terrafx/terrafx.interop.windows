// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMP12PktzPacketSize.xml' path='doc/member[@name="CODECAPI_AVEncMP12PktzPacketSize"]/*' />
[Guid("AB71347A-1332-4DDE-A0E5-CCF7DA8A0F22")]
public unsafe partial struct CODECAPI_AVEncMP12PktzPacketSize : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMP12PktzPacketSize));
}
