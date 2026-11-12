// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_DUMP_FILE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_DUMP_FILE"]/*' />
public partial struct D3D12_FEATURE_DATA_DUMP_FILE
{
    /// <include file='D3D12_FEATURE_DATA_DUMP_FILE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_DUMP_FILE.SupportedByOS"]/*' />
    public BOOL SupportedByOS;

    /// <include file='D3D12_FEATURE_DATA_DUMP_FILE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_DUMP_FILE.DumpFileDriverTier"]/*' />
    public D3D12_DUMP_FILE_DRIVER_TIER DumpFileDriverTier;

    /// <include file='D3D12_FEATURE_DATA_DUMP_FILE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_DUMP_FILE.DumpFileDriverOptionsMask"]/*' />
    public uint DumpFileDriverOptionsMask;
}
