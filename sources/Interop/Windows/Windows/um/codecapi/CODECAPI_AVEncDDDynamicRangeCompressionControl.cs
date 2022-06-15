// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncDDDynamicRangeCompressionControl.xml' path='doc/member[@name="CODECAPI_AVEncDDDynamicRangeCompressionControl"]/*' />
[Guid("CFC2FF6D-79B8-4B8D-A8AA-A0C9BD1C2940")]
public partial struct CODECAPI_AVEncDDDynamicRangeCompressionControl : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncDDDynamicRangeCompressionControl;
}
