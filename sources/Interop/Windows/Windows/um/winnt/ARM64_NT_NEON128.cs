// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct ARM64_NT_NEON128
{
    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L6771_C5")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.D"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("double[2]")]
    public _D_e__FixedBuffer D;

    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.S"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("float[4]")]
    public _S_e__FixedBuffer S;

    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.H"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("WORD[8]")]
    public _H_e__FixedBuffer H;

    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.B"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("BYTE[16]")]
    public _B_e__FixedBuffer B;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Low"]/*' />
    [UnscopedRef]
    public ref ulong Low
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Low;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.High"]/*' />
    [UnscopedRef]
    public ref long High
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.High;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Low"]/*' />
        [NativeTypeName("ULONGLONG")]
        public ulong Low;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.High"]/*' />
        [NativeTypeName("LONGLONG")]
        public long High;
    }

    /// <include file='_D_e__FixedBuffer.xml' path='doc/member[@name="_D_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _D_e__FixedBuffer
    {
        public double e0;
    }

    /// <include file='_S_e__FixedBuffer.xml' path='doc/member[@name="_S_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _S_e__FixedBuffer
    {
        public float e0;
    }

    /// <include file='_H_e__FixedBuffer.xml' path='doc/member[@name="_H_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _H_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_B_e__FixedBuffer.xml' path='doc/member[@name="_B_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _B_e__FixedBuffer
    {
        public byte e0;
    }
}
