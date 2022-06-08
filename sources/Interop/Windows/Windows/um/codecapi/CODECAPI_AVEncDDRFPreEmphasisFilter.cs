// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncDDRFPreEmphasisFilter.xml' path='doc/member[@name="CODECAPI_AVEncDDRFPreEmphasisFilter"]/*' />
[Guid("21AF44C0-244E-4F3D-A2CC-3D3068B2E73F")]
public partial struct CODECAPI_AVEncDDRFPreEmphasisFilter : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncDDRFPreEmphasisFilter;
}
