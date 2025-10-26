// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA"]/*' />
public partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_DATA
{
    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA.MapType"]/*' />
    public D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE MapType;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_DATA.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_DATA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12video_L10281_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Quantization"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX Quantization
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Quantization;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DirtyRegions"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS DirtyRegions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.DirtyRegions;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.MotionVectors"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS MotionVectors
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.MotionVectors;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Quantization"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX Quantization;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DirtyRegions"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS DirtyRegions;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.MotionVectors"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS MotionVectors;
    }
}
