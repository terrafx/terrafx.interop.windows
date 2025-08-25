// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoOutputBitsUsedMapBlockSize.xml' path='doc/member[@name="CODECAPI_AVEncVideoOutputBitsUsedMapBlockSize"]/*' />
[Guid("6C2CD11A-CA3B-44BD-9A9E-93B03634C36E")]
public unsafe partial struct CODECAPI_AVEncVideoOutputBitsUsedMapBlockSize : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncVideoOutputBitsUsedMapBlockSize);
}
