// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncCommonMultipassMode.xml' path='doc/member[@name="CODECAPI_AVEncCommonMultipassMode"]/*' />
[Guid("22533D4C-47E1-41B5-9352-A2B7780E7AC4")]
public partial struct CODECAPI_AVEncCommonMultipassMode : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncCommonMultipassMode;
}
