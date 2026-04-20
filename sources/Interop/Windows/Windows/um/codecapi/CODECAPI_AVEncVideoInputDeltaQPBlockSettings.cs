// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoInputDeltaQPBlockSettings.xml' path='doc/member[@name="CODECAPI_AVEncVideoInputDeltaQPBlockSettings"]/*' />
[Guid("5A4787DC-0648-47AA-B945-552BFAD2A6D8")]
public unsafe partial struct CODECAPI_AVEncVideoInputDeltaQPBlockSettings : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncVideoInputDeltaQPBlockSettings);
}
