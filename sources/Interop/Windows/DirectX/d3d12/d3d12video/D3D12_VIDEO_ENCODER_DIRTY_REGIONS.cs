// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_REGIONS"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_DIRTY_REGIONS
{
    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_REGIONS.MapSource"]/*' />
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE MapSource;

    /// <include file='D3D12_VIDEO_ENCODER_DIRTY_REGIONS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DIRTY_REGIONS.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12video_L10067_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pOpaqueLayoutBuffer"]/*' />
    [UnscopedRef]
    public ref ID3D12Resource* pOpaqueLayoutBuffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pOpaqueLayoutBuffer;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCPUBuffer"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO* pCPUBuffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pCPUBuffer;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pOpaqueLayoutBuffer"]/*' />
        [FieldOffset(0)]
        public ID3D12Resource* pOpaqueLayoutBuffer;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCPUBuffer"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO* pCPUBuffer;
    }
}
