// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct STORAGE_COUNTER
    {
        public STORAGE_COUNTER_TYPE Type;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:6438:5)")]
        public _Value_e__Union Value;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Value_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winioctl.h:6440:9)")]
            public _ManufactureDate_e__Struct ManufactureDate;

            [FieldOffset(0)]
            [NativeTypeName("DWORDLONG")]
            public ulong AsUlonglong;

            public partial struct _ManufactureDate_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint Week;

                [NativeTypeName("DWORD")]
                public uint Year;
            }
        }
    }
}
