// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public partial struct STORAGE_PROTOCOL_SPECIFIC_DATA
    {
        public STORAGE_PROTOCOL_TYPE ProtocolType;

        [NativeTypeName("DWORD")]
        public uint DataType;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataRequestValue;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataRequestSubValue;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataOffset;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataLength;

        [NativeTypeName("DWORD")]
        public uint FixedProtocolReturnData;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataRequestSubValue2;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataRequestSubValue3;

        [NativeTypeName("DWORD")]
        public uint ProtocolDataRequestSubValue4;
    }
}
