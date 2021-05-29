// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CACHE_RELATIONSHIP
    {
        [NativeTypeName("BYTE")]
        public byte Level;

        [NativeTypeName("BYTE")]
        public byte Associativity;

        [NativeTypeName("WORD")]
        public ushort LineSize;

        [NativeTypeName("DWORD")]
        public uint CacheSize;

        public PROCESSOR_CACHE_TYPE Type;

        [NativeTypeName("BYTE [18]")]
        public fixed byte Reserved[18];

        [NativeTypeName("WORD")]
        public ushort GroupCount;

        [NativeTypeName("_CACHE_RELATIONSHIP::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:13621:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref GROUP_AFFINITY GroupMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.GroupMask, 1));
            }
        }

        public Span<GROUP_AFFINITY> GroupMasks
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.GroupMasks.AsSpan();
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public GROUP_AFFINITY GroupMask;

            [FieldOffset(0)]
            [NativeTypeName("GROUP_AFFINITY [1]")]
            public _GroupMasks_e__FixedBuffer GroupMasks;

            public partial struct _GroupMasks_e__FixedBuffer
            {
                public GROUP_AFFINITY e0;

                public ref GROUP_AFFINITY this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return ref AsSpan(int.MaxValue)[index];
                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public Span<GROUP_AFFINITY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
            }
        }
    }
}
