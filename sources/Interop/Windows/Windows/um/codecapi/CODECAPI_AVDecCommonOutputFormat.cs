// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecCommonOutputFormat.xml' path='doc/member[@name="CODECAPI_AVDecCommonOutputFormat"]/*' />
[Guid("3C790028-C0CE-4256-B1A2-1B0FC8B1DCDC")]
public partial struct CODECAPI_AVDecCommonOutputFormat : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVDecCommonOutputFormat;
}
