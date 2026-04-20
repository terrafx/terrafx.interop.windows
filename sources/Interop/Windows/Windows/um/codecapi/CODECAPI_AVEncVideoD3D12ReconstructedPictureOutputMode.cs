// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoD3D12ReconstructedPictureOutputMode.xml' path='doc/member[@name="CODECAPI_AVEncVideoD3D12ReconstructedPictureOutputMode"]/*' />
[Guid("4A7B2E8F-1D93-4C6A-B548-91E2F8C5A7D3")]
public unsafe partial struct CODECAPI_AVEncVideoD3D12ReconstructedPictureOutputMode : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_CODECAPI_AVEncVideoD3D12ReconstructedPictureOutputMode);
}
