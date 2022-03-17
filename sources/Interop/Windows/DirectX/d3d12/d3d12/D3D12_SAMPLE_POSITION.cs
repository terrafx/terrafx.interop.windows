// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SAMPLE_POSITION.xml' path='doc/member[@name="D3D12_SAMPLE_POSITION"]/*' />
public partial struct D3D12_SAMPLE_POSITION
{
    /// <include file='D3D12_SAMPLE_POSITION.xml' path='doc/member[@name="D3D12_SAMPLE_POSITION.X"]/*' />
    [NativeTypeName("INT8")]
    public sbyte X;

    /// <include file='D3D12_SAMPLE_POSITION.xml' path='doc/member[@name="D3D12_SAMPLE_POSITION.Y"]/*' />
    [NativeTypeName("INT8")]
    public sbyte Y;
}
