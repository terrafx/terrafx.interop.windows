// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoDefaultUpperFieldDominant.xml' path='doc/member[@name="CODECAPI_AVEncVideoDefaultUpperFieldDominant"]/*' />
[Guid("810167C4-0BC1-47CA-8FC2-57055A1474A5")]
public partial struct CODECAPI_AVEncVideoDefaultUpperFieldDominant : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoDefaultUpperFieldDominant;
}
