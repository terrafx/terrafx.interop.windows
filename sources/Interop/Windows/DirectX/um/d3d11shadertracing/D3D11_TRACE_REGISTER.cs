// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_TRACE_REGISTER.xml' path='doc/member[@name="D3D11_TRACE_REGISTER"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_TRACE_REGISTER
{
    /// <include file='D3D11_TRACE_REGISTER.xml' path='doc/member[@name="D3D11_TRACE_REGISTER.RegType"]/*' />
    public D3D11_TRACE_REGISTER_TYPE RegType;

    /// <include file='D3D11_TRACE_REGISTER.xml' path='doc/member[@name="D3D11_TRACE_REGISTER.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d11shadertracing_L234_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='D3D11_TRACE_REGISTER.xml' path='doc/member[@name="D3D11_TRACE_REGISTER.OperandIndex"]/*' />
    [NativeTypeName("UINT8")]
    public byte OperandIndex;

    /// <include file='D3D11_TRACE_REGISTER.xml' path='doc/member[@name="D3D11_TRACE_REGISTER.Flags"]/*' />
    [NativeTypeName("UINT8")]
    public byte Flags;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Index1D"]/*' />
    [UnscopedRef]
    public ref ushort Index1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Index1D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Index2D"]/*' />
    [UnscopedRef]
    public Span<ushort> Index2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Index2D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Index1D"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT16")]
        public ushort Index1D;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Index2D"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT16[2]")]
        public _Index2D_e__FixedBuffer Index2D;

        /// <include file='_Index2D_e__FixedBuffer.xml' path='doc/member[@name="_Index2D_e__FixedBuffer"]/*' />
        [InlineArray(2)]
        public partial struct _Index2D_e__FixedBuffer
        {
            public ushort e0;
        }
    }
}
