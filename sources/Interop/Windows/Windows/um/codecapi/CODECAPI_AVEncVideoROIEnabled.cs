// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoROIEnabled.xml' path='doc/member[@name="CODECAPI_AVEncVideoROIEnabled"]/*' />
[Guid("D74F7F18-44DD-4B85-ABA3-05D9F42A8280")]
public partial struct CODECAPI_AVEncVideoROIEnabled : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoROIEnabled;
}
