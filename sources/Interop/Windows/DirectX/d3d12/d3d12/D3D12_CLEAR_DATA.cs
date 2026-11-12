// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_CLEAR_DATA.xml' path='doc/member[@name="D3D12_CLEAR_DATA"]/*' />
public partial struct D3D12_CLEAR_DATA
{
    /// <include file='D3D12_CLEAR_DATA.xml' path='doc/member[@name="D3D12_CLEAR_DATA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L42815_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Floats"]/*' />
    [UnscopedRef]
    public Span<float> Floats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Floats;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Uints"]/*' />
    [UnscopedRef]
    public Span<uint> Uints
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Uints;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Sints"]/*' />
    [UnscopedRef]
    public Span<int> Sints
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Sints;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Bytes"]/*' />
    [UnscopedRef]
    public Span<byte> Bytes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Bytes;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Floats"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("FLOAT[4]")]
        public _Floats_e__FixedBuffer Floats;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Uints"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT[4]")]
        public _Uints_e__FixedBuffer Uints;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Sints"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("INT[4]")]
        public _Sints_e__FixedBuffer Sints;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Bytes"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BYTE[16]")]
        public _Bytes_e__FixedBuffer Bytes;

        /// <include file='_Floats_e__FixedBuffer.xml' path='doc/member[@name="_Floats_e__FixedBuffer"]/*' />
        [InlineArray(4)]
        public partial struct _Floats_e__FixedBuffer
        {
            public float e0;
        }

        /// <include file='_Uints_e__FixedBuffer.xml' path='doc/member[@name="_Uints_e__FixedBuffer"]/*' />
        [InlineArray(4)]
        public partial struct _Uints_e__FixedBuffer
        {
            public uint e0;
        }

        /// <include file='_Sints_e__FixedBuffer.xml' path='doc/member[@name="_Sints_e__FixedBuffer"]/*' />
        [InlineArray(4)]
        public partial struct _Sints_e__FixedBuffer
        {
            public int e0;
        }

        /// <include file='_Bytes_e__FixedBuffer.xml' path='doc/member[@name="_Bytes_e__FixedBuffer"]/*' />
        [InlineArray(16)]
        public partial struct _Bytes_e__FixedBuffer
        {
            public byte e0;
        }
    }
}
