// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoDisplayDimension.xml' path='doc/member[@name="CODECAPI_AVEncVideoDisplayDimension"]/*' />
[Guid("DE053668-F4EC-47A9-86D0-836770F0C1D5")]
public partial struct CODECAPI_AVEncVideoDisplayDimension : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoDisplayDimension;
}
