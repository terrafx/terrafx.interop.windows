// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncAV1EncoderOperatingMode.xml' path='doc/member[@name="CODECAPI_AVEncAV1EncoderOperatingMode"]/*' />
[Guid("8F2E1F91-5B4C-4E1A-9C3D-2F6A8B1D4E7C")]
public unsafe partial struct CODECAPI_AVEncAV1EncoderOperatingMode : INativeGuid
{
    /// <include file='CODECAPI_AVEncAV1EncoderOperatingMode.xml' path='doc/member[@name="CODECAPI_AVEncAV1EncoderOperatingMode.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncAV1EncoderOperatingMode);
}
