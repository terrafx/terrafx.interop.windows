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
            internal UIntPtr e0;
            internal UIntPtr e1;
            internal UIntPtr e2;
            internal UIntPtr e3;
            internal UIntPtr e4;
            internal UIntPtr e5;
            internal UIntPtr e6;
            internal UIntPtr e7;
            internal UIntPtr e8;
            internal UIntPtr e9;
            internal UIntPtr e10;
            internal UIntPtr e11;
            internal UIntPtr e12;
            internal UIntPtr e13;
            internal UIntPtr e14;

            public ref UIntPtr this[int index] => ref AsSpan()[index];

            public Span<UIntPtr> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 15);
        }
    }
}
