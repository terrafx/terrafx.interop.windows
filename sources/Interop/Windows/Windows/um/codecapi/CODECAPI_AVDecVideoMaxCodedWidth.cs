// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecVideoMaxCodedWidth.xml' path='doc/member[@name="CODECAPI_AVDecVideoMaxCodedWidth"]/*' />
[Guid("5AE557B8-77AF-41F5-9FA6-4DB2FE1D4BCA")]
public unsafe partial struct CODECAPI_AVDecVideoMaxCodedWidth : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVDecVideoMaxCodedWidth));
}
