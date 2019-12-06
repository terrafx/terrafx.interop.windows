// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct DEVMODEW
    {
        [NativeTypeName("WCHAR [32]")]
        public fixed ushort dmDeviceName[32];

        [NativeTypeName("WORD")]
        public ushort dmSpecVersion;

        [NativeTypeName("WORD")]
        public ushort dmDriverVersion;

        [NativeTypeName("WORD")]
        public ushort dmSize;

        [NativeTypeName("WORD")]
        public ushort dmDriverExtra;

        [NativeTypeName("DWORD")]
        public uint dmFields;

        [NativeTypeName("_devicemodeW::(anonymous union at um/wingdi.h:2256:5)")]
        public _Anonymous1_e__Union Anonymous1;

        public short dmColor;

        public short dmDuplex;

        public short dmYResolution;

        public short dmTTOption;

        public short dmCollate;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort dmFormName[32];

        [NativeTypeName("WORD")]
        public ushort dmLogPixels;

        [NativeTypeName("DWORD")]
        public uint dmBitsPerPel;

        [NativeTypeName("DWORD")]
        public uint dmPelsWidth;

        [NativeTypeName("DWORD")]
        public uint dmPelsHeight;

        [NativeTypeName("_devicemodeW::(anonymous union at um/wingdi.h:2285:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("DWORD")]
        public uint dmDisplayFrequency;

        [NativeTypeName("DWORD")]
        public uint dmICMMethod;

        [NativeTypeName("DWORD")]
        public uint dmICMIntent;

        [NativeTypeName("DWORD")]
        public uint dmMediaType;

        [NativeTypeName("DWORD")]
        public uint dmDitherType;

        [NativeTypeName("DWORD")]
        public uint dmReserved1;

        [NativeTypeName("DWORD")]
        public uint dmReserved2;

        [NativeTypeName("DWORD")]
        public uint dmPanningWidth;

        [NativeTypeName("DWORD")]
        public uint dmPanningHeight;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_devicemodeW::(anonymous struct at um/wingdi.h:2258:7)")]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("_devicemodeW::(anonymous struct at um/wingdi.h:2269:7)")]
            public _Anonymous2_e__Struct Anonymous2;

            public partial struct _Anonymous1_e__Struct
            {
                public short dmOrientation;

                public short dmPaperSize;

                public short dmPaperLength;

                public short dmPaperWidth;

                public short dmScale;

                public short dmCopies;

                public short dmDefaultSource;

                public short dmPrintQuality;
            }

            public partial struct _Anonymous2_e__Struct
            {
                public POINTL dmPosition;

                [NativeTypeName("DWORD")]
                public uint dmDisplayOrientation;

                [NativeTypeName("DWORD")]
                public uint dmDisplayFixedOutput;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmDisplayFlags;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dmNup;
        }
    }
}
