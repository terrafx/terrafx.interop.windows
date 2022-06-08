// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoCBRMotionTradeoff.xml' path='doc/member[@name="CODECAPI_AVEncVideoCBRMotionTradeoff"]/*' />
[Guid("0D49451E-18D5-4367-A4EF-3240DF1693C4")]
public partial struct CODECAPI_AVEncVideoCBRMotionTradeoff : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoCBRMotionTradeoff;
}
