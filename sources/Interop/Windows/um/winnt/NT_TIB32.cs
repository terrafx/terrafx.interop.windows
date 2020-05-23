// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct NT_TIB32
    {
        [NativeTypeName("DWORD")]
        public uint ExceptionList;

        [NativeTypeName("DWORD")]
        public uint StackBase;

        [NativeTypeName("DWORD")]
        public uint StackLimit;

        [NativeTypeName("DWORD")]
        public uint SubSystemTib;

        [NativeTypeName("_NT_TIB32::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11512:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint ArbitraryUserPointer;

        [NativeTypeName("DWORD")]
        public uint Self;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint FiberData;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Version;
        }
    }
}
