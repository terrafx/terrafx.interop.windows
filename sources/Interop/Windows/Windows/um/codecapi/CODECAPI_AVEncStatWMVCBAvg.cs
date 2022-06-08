// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncStatWMVCBAvg.xml' path='doc/member[@name="CODECAPI_AVEncStatWMVCBAvg"]/*' />
[Guid("6AA6229F-D602-4B9D-B68C-C1AD78884BEF")]
public partial struct CODECAPI_AVEncStatWMVCBAvg : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncStatWMVCBAvg;
}
