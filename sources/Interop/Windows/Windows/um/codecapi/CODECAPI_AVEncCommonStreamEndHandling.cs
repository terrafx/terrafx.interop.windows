// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncCommonStreamEndHandling.xml' path='doc/member[@name="CODECAPI_AVEncCommonStreamEndHandling"]/*' />
[Guid("6AAD30AF-6BA8-4CCC-8FCA-18D19BEAEB1C")]
public partial struct CODECAPI_AVEncCommonStreamEndHandling : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncCommonStreamEndHandling;
}
