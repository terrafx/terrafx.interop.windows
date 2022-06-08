// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecVideoH264ErrorConcealment.xml' path='doc/member[@name="CODECAPI_AVDecVideoH264ErrorConcealment"]/*' />
[Guid("ECECACE8-3436-462C-9294-CD7BACD758A9")]
public partial struct CODECAPI_AVDecVideoH264ErrorConcealment : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVDecVideoH264ErrorConcealment;
}
