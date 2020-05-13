// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct NT_TIB
    {
        [NativeTypeName("struct _EXCEPTION_REGISTRATION_RECORD *")]
        public EXCEPTION_REGISTRATION_RECORD* ExceptionList;

        [NativeTypeName("PVOID")]
        public void* StackBase;

        [NativeTypeName("PVOID")]
        public void* StackLimit;

        [NativeTypeName("PVOID")]
        public void* SubSystemTib;

        [NativeTypeName("_NT_TIB::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:11444:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("PVOID")]
        public void* ArbitraryUserPointer;

        [NativeTypeName("struct _NT_TIB *")]
        public NT_TIB* Self;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PVOID")]
            public void* FiberData;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Version;
        }
    }
}
