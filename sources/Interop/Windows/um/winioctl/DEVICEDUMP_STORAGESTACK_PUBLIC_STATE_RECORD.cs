// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD
    {
        [NativeTypeName("BYTE [16]")]
        public fixed byte Cdb[16];

        [NativeTypeName("BYTE [16]")]
        public fixed byte Command[16];

        [NativeTypeName("DWORDLONG")]
        public ulong StartTime;

        [NativeTypeName("DWORDLONG")]
        public ulong EndTime;

        [NativeTypeName("DWORD")]
        public uint OperationStatus;

        [NativeTypeName("DWORD")]
        public uint OperationError;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:5954:9)")]
        public _StackSpecific_e__Union StackSpecific;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _StackSpecific_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:5955:10)")]
            public _ExternalStack_e__Struct ExternalStack;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:5959:10)")]
            public _AtaPort_e__Struct AtaPort;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:5963:10)")]
            public _StorPort_e__Struct StorPort;

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            public partial struct _ExternalStack_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwReserved;
            }

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            public partial struct _AtaPort_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwAtaPortSpecific;
            }

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            public partial struct _StorPort_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint SrbTag;
            }
        }
    }
}
