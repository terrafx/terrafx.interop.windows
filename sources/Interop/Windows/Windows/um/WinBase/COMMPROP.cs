// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct COMMPROP
    {
        [NativeTypeName("WORD")]
        public ushort wPacketLength;

        [NativeTypeName("WORD")]
        public ushort wPacketVersion;

        [NativeTypeName("DWORD")]
        public uint dwServiceMask;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("DWORD")]
        public uint dwMaxTxQueue;

        [NativeTypeName("DWORD")]
        public uint dwMaxRxQueue;

        [NativeTypeName("DWORD")]
        public uint dwMaxBaud;

        [NativeTypeName("DWORD")]
        public uint dwProvSubType;

        [NativeTypeName("DWORD")]
        public uint dwProvCapabilities;

        [NativeTypeName("DWORD")]
        public uint dwSettableParams;

        [NativeTypeName("DWORD")]
        public uint dwSettableBaud;

        [NativeTypeName("WORD")]
        public ushort wSettableData;

        [NativeTypeName("WORD")]
        public ushort wSettableStopParity;

        [NativeTypeName("DWORD")]
        public uint dwCurrentTxQueue;

        [NativeTypeName("DWORD")]
        public uint dwCurrentRxQueue;

        [NativeTypeName("DWORD")]
        public uint dwProvSpec1;

        [NativeTypeName("DWORD")]
        public uint dwProvSpec2;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort wcProvChar[1];
    }
}
