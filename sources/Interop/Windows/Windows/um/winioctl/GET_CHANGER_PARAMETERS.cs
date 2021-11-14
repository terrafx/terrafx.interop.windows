// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
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

        public byte MoveFromTransport;

        public byte MoveFromSlot;

        public byte MoveFromIePort;

        public byte MoveFromDrive;

        public byte ExchangeFromTransport;

        public byte ExchangeFromSlot;

        public byte ExchangeFromIePort;

        public byte ExchangeFromDrive;

        public byte LockUnlockCapabilities;

        public byte PositionCapabilities;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved1[2];

        [NativeTypeName("DWORD [2]")]
        public fixed uint Reserved2[2];
    }
}
