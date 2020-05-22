// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
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
            internal nuint e0;
            internal nuint e1;
            internal nuint e2;
            internal nuint e3;
            internal nuint e4;
            internal nuint e5;
            internal nuint e6;
            internal nuint e7;
            internal nuint e8;
            internal nuint e9;
            internal nuint e10;
            internal nuint e11;
            internal nuint e12;
            internal nuint e13;
            internal nuint e14;

            public ref nuint this[int index] => ref AsSpan()[index];

            public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 15);
        }
    }
}
