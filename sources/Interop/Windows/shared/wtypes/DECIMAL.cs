// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DECIMAL
    {
        [NativeTypeName("USHORT")]
        public ushort wReserved;

        [NativeTypeName("tagDEC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/wtypes.h:697:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public unsafe ref byte scale
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous.scale, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous))->scale;
#endif
            }
        }

        public unsafe ref byte sign
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous.sign, 1));
#else
                return ref ((_Anonymous1_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous1.Anonymous))->sign;
#endif
            }
        }

        public unsafe ref ushort signscale
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.signscale, 1));
#else
                return ref ((_Anonymous1_e__Union*)Unsafe.AsPointer(ref Anonymous1))->signscale;
#endif
            }
        }

        [NativeTypeName("ULONG")]
        public uint Hi32;

        [NativeTypeName("tagDEC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/wtypes.h:705:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public unsafe ref uint Lo32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Anonymous.Lo32, 1));
#else
                return ref ((_Anonymous2_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous2.Anonymous))->Lo32;
#endif
            }
        }

        public unsafe ref uint Mid32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Anonymous.Mid32, 1));
#else
                return ref ((_Anonymous2_e__Union._Anonymous_e__Struct*)Unsafe.AsPointer(ref Anonymous2.Anonymous))->Mid32;
#endif
            }
        }

        public unsafe ref ulong Lo64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Lo64, 1));
#else
                return ref ((_Anonymous2_e__Union*)Unsafe.AsPointer(ref Anonymous2))->Lo64;
#endif
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("tagDEC::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/wtypes.h:698:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("USHORT")]
            public ushort signscale;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("BYTE")]
                public byte scale;

                [NativeTypeName("BYTE")]
                public byte sign;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("tagDEC::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared/wtypes.h:706:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Lo64;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Lo32;

                [NativeTypeName("ULONG")]
                public uint Mid32;
            }
        }
    }
}
