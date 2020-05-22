// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct JOBOBJECT_CPU_RATE_CONTROL_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint ControlFlags;

        [NativeTypeName("_JOBOBJECT_CPU_RATE_CONTROL_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12007:5)")]
        public _Anonymous_e__Union1 Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union1
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint CpuRate;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Weight;

            [FieldOffset(0)]
            [NativeTypeName("_JOBOBJECT_CPU_RATE_CONTROL_INFORMATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12010:9)")]
            public _Anonymous_e__Union2 Anonymous;

            public partial struct _Anonymous_e__Union2
            {
                [NativeTypeName("WORD")]
                public ushort MinRate;

                [NativeTypeName("WORD")]
                public ushort MaxRate;
            }
        }
    }
}
