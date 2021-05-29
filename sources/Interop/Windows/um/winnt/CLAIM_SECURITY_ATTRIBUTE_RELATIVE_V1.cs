// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1
    {
        [NativeTypeName("DWORD")]
        public uint Name;

        [NativeTypeName("WORD")]
        public ushort ValueType;

        [NativeTypeName("WORD")]
        public ushort Reserved;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint ValueCount;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:12220:5)")]
        public _Values_e__Union Values;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Values_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint pInt64[1];

            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint pUint64[1];

            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint ppString[1];

            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint pFqbn[1];

            [FieldOffset(0)]
            [NativeTypeName("DWORD [1]")]
            public fixed uint pOctetString[1];
        }
    }
}
