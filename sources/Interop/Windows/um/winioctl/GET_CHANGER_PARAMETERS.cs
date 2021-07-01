// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct GET_CHANGER_PARAMETERS
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("WORD")]
        public ushort NumberTransportElements;

        [NativeTypeName("WORD")]
        public ushort NumberStorageElements;

        [NativeTypeName("WORD")]
        public ushort NumberCleanerSlots;

        [NativeTypeName("WORD")]
        public ushort NumberIEElements;

        [NativeTypeName("WORD")]
        public ushort NumberDataTransferElements;

        [NativeTypeName("WORD")]
        public ushort NumberOfDoors;

        [NativeTypeName("WORD")]
        public ushort FirstSlotNumber;

        [NativeTypeName("WORD")]
        public ushort FirstDriveNumber;

        [NativeTypeName("WORD")]
        public ushort FirstTransportNumber;

        [NativeTypeName("WORD")]
        public ushort FirstIEPortNumber;

        [NativeTypeName("WORD")]
        public ushort FirstCleanerSlotAddress;

        [NativeTypeName("WORD")]
        public ushort MagazineSize;

        [NativeTypeName("DWORD")]
        public uint DriveCleanTimeout;

        [NativeTypeName("DWORD")]
        public uint Features0;

        [NativeTypeName("DWORD")]
        public uint Features1;

        [NativeTypeName("BYTE")]
        public byte MoveFromTransport;

        [NativeTypeName("BYTE")]
        public byte MoveFromSlot;

        [NativeTypeName("BYTE")]
        public byte MoveFromIePort;

        [NativeTypeName("BYTE")]
        public byte MoveFromDrive;

        [NativeTypeName("BYTE")]
        public byte ExchangeFromTransport;

        [NativeTypeName("BYTE")]
        public byte ExchangeFromSlot;

        [NativeTypeName("BYTE")]
        public byte ExchangeFromIePort;

        [NativeTypeName("BYTE")]
        public byte ExchangeFromDrive;

        [NativeTypeName("BYTE")]
        public byte LockUnlockCapabilities;

        [NativeTypeName("BYTE")]
        public byte PositionCapabilities;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved1[2];

        [NativeTypeName("DWORD [2]")]
        public fixed uint Reserved2[2];
    }
}
