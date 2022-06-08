// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoOutputFrameRate.xml' path='doc/member[@name="CODECAPI_AVEncVideoOutputFrameRate"]/*' />
[Guid("EA85E7C3-9567-4D99-87C4-02C1C278CA7C")]
public partial struct CODECAPI_AVEncVideoOutputFrameRate : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoOutputFrameRate;
}
