// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DEVICE_MEDIA_INFO
    {
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:948:5)")]
        public _DeviceSpecific_e__Union DeviceSpecific;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _DeviceSpecific_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:949:9)")]
            public _DiskInfo_e__Struct DiskInfo;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:959:9)")]
            public _RemovableDiskInfo_e__Struct RemovableDiskInfo;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:969:9)")]
            public _TapeInfo_e__Struct TapeInfo;

            public partial struct _DiskInfo_e__Struct
            {
                public LARGE_INTEGER Cylinders;

                public STORAGE_MEDIA_TYPE MediaType;

                [NativeTypeName("DWORD")]
                public uint TracksPerCylinder;

                [NativeTypeName("DWORD")]
                public uint SectorsPerTrack;

                [NativeTypeName("DWORD")]
                public uint BytesPerSector;

                [NativeTypeName("DWORD")]
                public uint NumberMediaSides;

                [NativeTypeName("DWORD")]
                public uint MediaCharacteristics;
            }

            public partial struct _RemovableDiskInfo_e__Struct
            {
                public LARGE_INTEGER Cylinders;

                public STORAGE_MEDIA_TYPE MediaType;

                [NativeTypeName("DWORD")]
                public uint TracksPerCylinder;

                [NativeTypeName("DWORD")]
                public uint SectorsPerTrack;

                [NativeTypeName("DWORD")]
                public uint BytesPerSector;

                [NativeTypeName("DWORD")]
                public uint NumberMediaSides;

                [NativeTypeName("DWORD")]
                public uint MediaCharacteristics;
            }

            public partial struct _TapeInfo_e__Struct
            {
                public STORAGE_MEDIA_TYPE MediaType;

                [NativeTypeName("DWORD")]
                public uint MediaCharacteristics;

                [NativeTypeName("DWORD")]
                public uint CurrentBlockSize;

                public STORAGE_BUS_TYPE BusType;

                [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:979:13)")]
                public _BusSpecificData_e__Union BusSpecificData;

                [StructLayout(LayoutKind.Explicit)]
                public partial struct _BusSpecificData_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winioctl.h:980:17)")]
                    public _ScsiInformation_e__Struct ScsiInformation;

                    public partial struct _ScsiInformation_e__Struct
                    {
                        [NativeTypeName("BYTE")]
                        public byte MediumType;

                        [NativeTypeName("BYTE")]
                        public byte DensityCode;
                    }
                }
            }
        }
    }
}
