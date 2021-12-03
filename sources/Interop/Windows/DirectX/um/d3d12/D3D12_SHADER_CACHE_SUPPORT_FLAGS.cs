// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS"]/*' />
[Flags]
public enum D3D12_SHADER_CACHE_SUPPORT_FLAGS
{
    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_NONE"]/*' />
    D3D12_SHADER_CACHE_SUPPORT_NONE = 0,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_SINGLE_PSO"]/*' />
    D3D12_SHADER_CACHE_SUPPORT_SINGLE_PSO = 0x1,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_LIBRARY"]/*' />
    D3D12_SHADER_CACHE_SUPPORT_LIBRARY = 0x2,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE"]/*' />
    D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE = 0x4,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE"]/*' />
    D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE = 0x8,

    /// <include file='D3D12_SHADER_CACHE_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_SUPPORT_FLAGS.D3D12_SHADER_CACHE_SUPPORT_DRIVER_MANAGED_CACHE"]/*' />
    D3D12_SHADER_CACHE_SUPPORT_DRIVER_MANAGED_CACHE = 0x10,
}
