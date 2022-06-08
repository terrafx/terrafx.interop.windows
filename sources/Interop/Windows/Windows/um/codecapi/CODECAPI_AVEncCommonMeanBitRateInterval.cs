// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncCommonMeanBitRateInterval.xml' path='doc/member[@name="CODECAPI_AVEncCommonMeanBitRateInterval"]/*' />
[Guid("BFAA2F0C-CB82-4BC0-8474-F06A8A0D0258")]
public partial struct CODECAPI_AVEncCommonMeanBitRateInterval : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncCommonMeanBitRateInterval;
}
