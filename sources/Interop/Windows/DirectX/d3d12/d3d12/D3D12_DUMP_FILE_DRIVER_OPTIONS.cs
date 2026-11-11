// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DUMP_FILE_DRIVER_OPTIONS.xml' path='doc/member[@name="D3D12_DUMP_FILE_DRIVER_OPTIONS"]/*' />
public enum D3D12_DUMP_FILE_DRIVER_OPTIONS
{
    /// <include file='D3D12_DUMP_FILE_DRIVER_OPTIONS.xml' path='doc/member[@name="D3D12_DUMP_FILE_DRIVER_OPTIONS.D3D12_DUMP_FILE_DRIVER_OPTION_NO_OVERHEAD"]/*' />
    D3D12_DUMP_FILE_DRIVER_OPTION_NO_OVERHEAD = 0x1,

    /// <include file='D3D12_DUMP_FILE_DRIVER_OPTIONS.xml' path='doc/member[@name="D3D12_DUMP_FILE_DRIVER_OPTIONS.D3D12_DUMP_FILE_DRIVER_OPTION_MEDIUM_OVERHEAD"]/*' />
    D3D12_DUMP_FILE_DRIVER_OPTION_MEDIUM_OVERHEAD = 0x2,

    /// <include file='D3D12_DUMP_FILE_DRIVER_OPTIONS.xml' path='doc/member[@name="D3D12_DUMP_FILE_DRIVER_OPTIONS.D3D12_DUMP_FILE_DRIVER_OPTION_HIGH_OVERHEAD"]/*' />
    D3D12_DUMP_FILE_DRIVER_OPTION_HIGH_OVERHEAD = 0x4,

    /// <include file='D3D12_DUMP_FILE_DRIVER_OPTIONS.xml' path='doc/member[@name="D3D12_DUMP_FILE_DRIVER_OPTIONS.D3D12_DUMP_FILE_DRIVER_OPTION_NO_DATA"]/*' />
    D3D12_DUMP_FILE_DRIVER_OPTION_NO_DATA = 0x8,

    /// <include file='D3D12_DUMP_FILE_DRIVER_OPTIONS.xml' path='doc/member[@name="D3D12_DUMP_FILE_DRIVER_OPTIONS.D3D12_DUMP_FILE_DRIVER_OPTION_SHADER_REGISTERS"]/*' />
    D3D12_DUMP_FILE_DRIVER_OPTION_SHADER_REGISTERS = 0x10,

    /// <include file='D3D12_DUMP_FILE_DRIVER_OPTIONS.xml' path='doc/member[@name="D3D12_DUMP_FILE_DRIVER_OPTIONS.D3D12_DUMP_FILE_DRIVER_OPTION_RESOURCES"]/*' />
    D3D12_DUMP_FILE_DRIVER_OPTION_RESOURCES = 0x20,

    /// <include file='D3D12_DUMP_FILE_DRIVER_OPTIONS.xml' path='doc/member[@name="D3D12_DUMP_FILE_DRIVER_OPTIONS.D3D12_DUMP_FILE_DRIVER_OPTION_EVENT_MARKERS"]/*' />
    D3D12_DUMP_FILE_DRIVER_OPTION_EVENT_MARKERS = 0x40,
}
