// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_GPU_BASED_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_FLAGS"]/*' />
[Flags]
public enum D3D12_GPU_BASED_VALIDATION_FLAGS
{
    /// <include file='D3D12_GPU_BASED_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_FLAGS.D3D12_GPU_BASED_VALIDATION_FLAGS_NONE"]/*' />
    D3D12_GPU_BASED_VALIDATION_FLAGS_NONE = 0,

    /// <include file='D3D12_GPU_BASED_VALIDATION_FLAGS.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_FLAGS.D3D12_GPU_BASED_VALIDATION_FLAGS_DISABLE_STATE_TRACKING"]/*' />
    D3D12_GPU_BASED_VALIDATION_FLAGS_DISABLE_STATE_TRACKING = 0x1,
}
