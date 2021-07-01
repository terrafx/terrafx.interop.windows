// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct FILE_REMOTE_PROTOCOL_INFO
    {
        [NativeTypeName("USHORT")]
        public ushort StructureVersion;

        [NativeTypeName("USHORT")]
        public ushort StructureSize;

        [NativeTypeName("ULONG")]
        public uint Protocol;

        [NativeTypeName("USHORT")]
        public ushort ProtocolMajorVersion;

        [NativeTypeName("USHORT")]
        public ushort ProtocolMinorVersion;

        [NativeTypeName("USHORT")]
        public ushort ProtocolRevision;

        [NativeTypeName("USHORT")]
        public ushort Reserved;

        [NativeTypeName("ULONG")]
        public uint Flags;

        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:9102:5)")]
        public _GenericReserved_e__Struct GenericReserved;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:9115:5)")]
        public _ProtocolSpecific_e__Union ProtocolSpecific;

        public unsafe partial struct _GenericReserved_e__Struct
        {
            [NativeTypeName("ULONG [8]")]
            public fixed uint Reserved[8];
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _ProtocolSpecific_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:9117:9)")]
            public _Smb2_e__Struct Smb2;

            [FieldOffset(0)]
            [NativeTypeName("ULONG [16]")]
            public fixed uint Reserved[16];

            public partial struct _Smb2_e__Struct
            {
                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:9119:13)")]
                public _Server_e__Struct Server;

                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WinBase.h:9123:13)")]
                public _Share_e__Struct Share;

                public partial struct _Server_e__Struct
                {
                    [NativeTypeName("ULONG")]
                    public uint Capabilities;
                }

                public partial struct _Share_e__Struct
                {
                    [NativeTypeName("ULONG")]
                    public uint Capabilities;

                    [NativeTypeName("ULONG")]
                    public uint CachingFlags;
                }
            }
        }
    }
}
