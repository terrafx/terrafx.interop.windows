// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoInputAbsoluteQPBlockSettings.xml' path='doc/member[@name="CODECAPI_AVEncVideoInputAbsoluteQPBlockSettings"]/*' />
[Guid("EF95A145-4F91-4DEA-8173-ACFF11434210")]
public unsafe partial struct CODECAPI_AVEncVideoInputAbsoluteQPBlockSettings : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncVideoInputAbsoluteQPBlockSettings);
}
