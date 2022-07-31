// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128"]/*' />
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct ARM64_NT_NEON128
{
    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("_ARM64_NT_NEON128::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:6644:5)")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.D"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("double[2]")]
    public fixed double D[2];

    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.S"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("float[4]")]
    public fixed float S[4];

    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.H"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("WORD[8]")]
    public fixed ushort H[8];

    /// <include file='ARM64_NT_NEON128.xml' path='doc/member[@name="ARM64_NT_NEON128.B"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("BYTE[16]")]
    public fixed byte B[16];

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Low"]/*' />
    public ref ulong Low
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Low, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.High"]/*' />
    public ref long High
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.High, 1));
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
}
