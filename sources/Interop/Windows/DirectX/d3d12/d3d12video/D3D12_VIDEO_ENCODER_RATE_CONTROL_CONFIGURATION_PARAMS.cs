// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12video_L6919_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_CQP"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP* pConfiguration_CQP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pConfiguration_CQP;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_CBR"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR* pConfiguration_CBR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pConfiguration_CBR;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_VBR"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR* pConfiguration_VBR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pConfiguration_VBR;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_QVBR"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR* pConfiguration_QVBR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pConfiguration_QVBR;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_CQP1"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1* pConfiguration_CQP1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pConfiguration_CQP1;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_CBR1"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR1* pConfiguration_CBR1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pConfiguration_CBR1;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_VBR1"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR1* pConfiguration_VBR1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pConfiguration_VBR1;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_QVBR1"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1* pConfiguration_QVBR1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pConfiguration_QVBR1;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_AbsoluteQPMap"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP* pConfiguration_AbsoluteQPMap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pConfiguration_AbsoluteQPMap;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_CQP"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP *")]
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP* pConfiguration_CQP;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_CBR"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR *")]
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR* pConfiguration_CBR;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_VBR"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR *")]
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR* pConfiguration_VBR;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_QVBR"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR *")]
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR* pConfiguration_QVBR;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_CQP1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1 *")]
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1* pConfiguration_CQP1;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_CBR1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR1 *")]
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR1* pConfiguration_CBR1;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_VBR1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR1 *")]
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_VBR1* pConfiguration_VBR1;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_QVBR1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1 *")]
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1* pConfiguration_QVBR1;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pConfiguration_AbsoluteQPMap"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP *")]
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP* pConfiguration_AbsoluteQPMap;
    }
}
