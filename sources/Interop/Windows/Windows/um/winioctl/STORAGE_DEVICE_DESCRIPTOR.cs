// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct STORAGE_DEVICE_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public byte DeviceType;

        public byte DeviceTypeModifier;

        [NativeTypeName("BOOLEAN")]
        public byte RemovableMedia;

        [NativeTypeName("BOOLEAN")]
        public byte CommandQueueing;

        [NativeTypeName("DWORD")]
        public uint VendorIdOffset;

        [NativeTypeName("DWORD")]
        public uint ProductIdOffset;

        [NativeTypeName("DWORD")]
        public uint ProductRevisionOffset;

        [NativeTypeName("DWORD")]
        public uint SerialNumberOffset;

        public STORAGE_BUS_TYPE BusType;

        [NativeTypeName("DWORD")]
        public uint RawPropertiesLength;

        [NativeTypeName("BYTE [1]")]
        public fixed byte RawDeviceProperties[1];
    }
}
