// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMPVGOPSizeMax.xml' path='doc/member[@name="CODECAPI_AVEncMPVGOPSizeMax"]/*' />
[Guid("FE7DE4C4-1936-4FE2-BDF7-1F18CA1D001F")]
public partial struct CODECAPI_AVEncMPVGOPSizeMax : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMPVGOPSizeMax;
}
