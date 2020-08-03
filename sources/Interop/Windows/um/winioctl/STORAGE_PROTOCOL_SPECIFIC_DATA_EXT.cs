// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_PROTOCOL_SPECIFIC_DATA_EXT
    {
        public STORAGE_PROTOCOL_TYPE ProtocolType;

        [NativeTypeName("DWORD")]
        public uint DataType;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataValue;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataSubValue;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataOffset;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataLength;

        [NativeTypeName("DWORD")]
        public uint FixedProtocolReturnData;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataSubValue2;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataSubValue3;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataSubValue4;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataSubValue5;

        [NativeTypeName("DWORD [5]")]
        public fixed uint Reserved[5];
    }
}
