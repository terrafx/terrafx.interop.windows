// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncDDDCHighPassFilter.xml' path='doc/member[@name="CODECAPI_AVEncDDDCHighPassFilter"]/*' />
[Guid("9565239F-861C-4AC8-BFDA-E00CB4DB8548")]
public partial struct CODECAPI_AVEncDDDCHighPassFilter : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncDDDCHighPassFilter;
}
