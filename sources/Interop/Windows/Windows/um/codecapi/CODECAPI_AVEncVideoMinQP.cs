// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoMinQP.xml' path='doc/member[@name="CODECAPI_AVEncVideoMinQP"]/*' />
[Guid("0EE22C6A-A37C-4568-B5F1-9D4C2B3AB886")]
public partial struct CODECAPI_AVEncVideoMinQP : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoMinQP;
}
