// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct REASON_CONTEXT
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/minwinbase.h:266:5)")]
        public _Anonymous_e__Union1 Reason;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union1
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/minwinbase.h:267:9)")]
            public _Anonymous_e__Union2 Detailed;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* SimpleReasonString;

            public unsafe partial struct _Anonymous_e__Union2
            {
                [NativeTypeName("HMODULE")]
                public IntPtr LocalizedReasonModule;

                [NativeTypeName("ULONG")]
                public uint LocalizedReasonId;

                [NativeTypeName("ULONG")]
                public uint ReasonStringCount;

                [NativeTypeName("LPWSTR *")]
                public ushort** ReasonStrings;
            }
        }
    }
}
