// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecDisableVideoPostProcessing.xml' path='doc/member[@name="CODECAPI_AVDecDisableVideoPostProcessing"]/*' />
[Guid("F8749193-667A-4F2C-A9E8-5D4AF924F08F")]
public partial struct CODECAPI_AVDecDisableVideoPostProcessing : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVDecDisableVideoPostProcessing;
}
