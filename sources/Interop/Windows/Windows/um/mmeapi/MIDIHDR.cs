// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct MIDIHDR
    {
        [NativeTypeName("LPSTR")]
        public sbyte* lpData;

        [NativeTypeName("DWORD")]
        public uint dwBufferLength;

        [NativeTypeName("DWORD")]
        public uint dwBytesRecorded;

        [NativeTypeName("DWORD_PTR")]
        public nuint dwUser;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("struct midihdr_tag *")]
        public MIDIHDR* lpNext;

        [NativeTypeName("DWORD_PTR")]
        public nuint reserved;

        [NativeTypeName("DWORD")]
        public uint dwOffset;

        [NativeTypeName("DWORD_PTR [8]")]
        public _dwReserved_e__FixedBuffer dwReserved;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _dwReserved_e__FixedBuffer
        {
            public nuint e0;
            public nuint e1;
            public nuint e2;
            public nuint e3;
            public nuint e4;
            public nuint e5;
            public nuint e6;
            public nuint e7;

            public ref nuint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}
