// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct EXCEPTION_RECORD
    {
        [NativeTypeName("DWORD")]
        public uint ExceptionCode;

        [NativeTypeName("DWORD")]
        public uint ExceptionFlags;

        [NativeTypeName("struct _EXCEPTION_RECORD *")]
        public EXCEPTION_RECORD* ExceptionRecord;

        [NativeTypeName("PVOID")]
        public void* ExceptionAddress;

        [NativeTypeName("DWORD")]
        public uint NumberParameters;

        [NativeTypeName("ULONG_PTR [15]")]
        public _ExceptionInformation_e__FixedBuffer ExceptionInformation;

        public partial struct _ExceptionInformation_e__FixedBuffer
        {
            public nuint e0;
            public nuint e1;
            public nuint e2;
            public nuint e3;
            public nuint e4;
            public nuint e5;
            public nuint e6;
            public nuint e7;
            public nuint e8;
            public nuint e9;
            public nuint e10;
            public nuint e11;
            public nuint e12;
            public nuint e13;
            public nuint e14;

            public ref nuint this[int index] => ref AsSpan()[index];

            public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 15);
        }
    }
}
