// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_GUID_AVEncDolbyDigitalPro.xml' path='doc/member[@name="CODECAPI_GUID_AVEncDolbyDigitalPro"]/*' />
[Guid("F5BE76CC-0FF8-40EB-9CB1-BBA94004D44F")]
public partial struct CODECAPI_GUID_AVEncDolbyDigitalPro : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_GUID_AVEncDolbyDigitalPro;
}
