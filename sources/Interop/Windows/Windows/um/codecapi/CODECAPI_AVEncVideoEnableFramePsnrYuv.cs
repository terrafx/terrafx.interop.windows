// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoEnableFramePsnrYuv.xml' path='doc/member[@name="CODECAPI_AVEncVideoEnableFramePsnrYuv"]/*' />
[Guid("2BBCDD1D-BC47-430E-B2E8-64801B47F5F0")]
public unsafe partial struct CODECAPI_AVEncVideoEnableFramePsnrYuv : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncVideoEnableFramePsnrYuv);
}
