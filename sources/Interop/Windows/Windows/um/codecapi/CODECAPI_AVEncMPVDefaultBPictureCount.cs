// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMPVDefaultBPictureCount.xml' path='doc/member[@name="CODECAPI_AVEncMPVDefaultBPictureCount"]/*' />
[Guid("8D390AAC-DC5C-4200-B57F-814D04BABAB2")]
public partial struct CODECAPI_AVEncMPVDefaultBPictureCount : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMPVDefaultBPictureCount;
}
