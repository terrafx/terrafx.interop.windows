// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
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
            internal nuint e0;
            internal nuint e1;
            internal nuint e2;
            internal nuint e3;
            internal nuint e4;
            internal nuint e5;
            internal nuint e6;
            internal nuint e7;

            public ref nuint this[int index] => ref AsSpan()[index];

            public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}
