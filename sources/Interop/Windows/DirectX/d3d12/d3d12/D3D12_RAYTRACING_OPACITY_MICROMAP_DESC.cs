// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_DESC"]/*' />
public partial struct D3D12_RAYTRACING_OPACITY_MICROMAP_DESC
{
    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_DESC.ByteOffset"]/*' />
    public uint ByteOffset;

    public uint _bitfield;

    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_DESC.SubdivisionLevel"]/*' />
    [NativeTypeName("uint : 16")]
    public uint SubdivisionLevel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return _bitfield & 0xFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
        }
    }

    /// <include file='D3D12_RAYTRACING_OPACITY_MICROMAP_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_OPACITY_MICROMAP_DESC.Format"]/*' />
    [NativeTypeName("D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT : 16")]
    public D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT Format
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT)((_bitfield << 0) >> 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFFFu << 16)) | (((uint)(value) & 0xFFFF) << 16);
        }
    }
}
