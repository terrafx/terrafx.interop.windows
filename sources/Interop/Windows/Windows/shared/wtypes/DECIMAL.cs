// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL"]/*' />
public partial struct DECIMAL
{
    /// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL.wReserved"]/*' />
    public ushort wReserved;

    /// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL.Anonymous1"]/*' />
    [NativeTypeName("tagDEC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/wtypes.h:705:5)")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL.Hi32"]/*' />
    [NativeTypeName("ULONG")]
    public uint Hi32;

    /// <include file='DECIMAL.xml' path='doc/member[@name="DECIMAL.Anonymous2"]/*' />
    [NativeTypeName("tagDEC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/wtypes.h:713:5)")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.scale"]/*' />
    public ref byte scale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous.scale, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.sign"]/*' />
    public ref byte sign
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous.sign, 1));
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.signscale"]/*' />
    public ref ushort signscale
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.signscale, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Lo32"]/*' />
    public ref uint Lo32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Anonymous.Lo32, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Mid32"]/*' />
    public ref uint Mid32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Anonymous.Mid32, 1));
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Lo64"]/*' />
    public ref ulong Lo64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Lo64, 1));
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("tagDEC::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/wtypes.h:706:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.signscale"]/*' />
        [FieldOffset(0)]
        public ushort signscale;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.scale"]/*' />
            public byte scale;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.sign"]/*' />
            public byte sign;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("tagDEC::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/wtypes.h:714:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Lo64"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Lo64;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Lo32"]/*' />
            [NativeTypeName("ULONG")]
            public uint Lo32;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Mid32"]/*' />
            [NativeTypeName("ULONG")]
            public uint Mid32;
        }
    }
}
