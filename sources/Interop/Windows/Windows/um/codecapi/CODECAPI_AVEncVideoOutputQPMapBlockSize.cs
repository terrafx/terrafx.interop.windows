// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoOutputQPMapBlockSize.xml' path='doc/member[@name="CODECAPI_AVEncVideoOutputQPMapBlockSize"]/*' />
[Guid("97038743-4AE3-44C3-A0F2-5BD58A4634EF")]
public unsafe partial struct CODECAPI_AVEncVideoOutputQPMapBlockSize : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncVideoOutputQPMapBlockSize);
}
