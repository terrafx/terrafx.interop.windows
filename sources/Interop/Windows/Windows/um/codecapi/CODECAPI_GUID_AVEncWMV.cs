// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVEncWMV.xml' path='doc/member[@name="CODECAPI_GUID_AVEncWMV"]/*' />
[Guid("4E0FEF9B-1D43-41BD-B8BD-4D7BF7457A2A")]
public partial struct CODECAPI_GUID_AVEncWMV : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_GUID_AVEncWMV;
}
