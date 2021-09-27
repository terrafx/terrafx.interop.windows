// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define SHIMGKEY_QUALITY L\"Compression\"")]
        public const string SHIMGKEY_QUALITY = "Compression";

        [NativeTypeName("#define SHIMGKEY_RAWFORMAT L\"RawDataFormat\"")]
        public const string SHIMGKEY_RAWFORMAT = "RawDataFormat";

        [NativeTypeName("#define SHIMGDEC_DEFAULT 0x00000000")]
        public const int SHIMGDEC_DEFAULT = 0x00000000;

        [NativeTypeName("#define SHIMGDEC_THUMBNAIL 0x00000001")]
        public const int SHIMGDEC_THUMBNAIL = 0x00000001;

        [NativeTypeName("#define SHIMGDEC_LOADFULL 0x00000002")]
        public const int SHIMGDEC_LOADFULL = 0x00000002;

        [NativeTypeName("#define E_NOTVALIDFORANIMATEDIMAGE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x01)")]
        public const int E_NOTVALIDFORANIMATEDIMAGE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x01))));

        public static ref readonly Guid IID_IShellImageDataFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5C, 0xED, 0xE8, 0x9B,
                    0xAB, 0xED,
                    0x75, 0x4D,
                    0x90,
                    0xF3,
                    0xBD,
                    0x5B,
                    0xDB,
                    0xB2,
                    0x1C,
                    0x82
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IShellImageData
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0xEC, 0xDE, 0xBF,
                    0x40, 0x80,
                    0x03, 0x44,
                    0xA5,
                    0xEA,
                    0x9E,
                    0x07,
                    0xDA,
                    0xFC,
                    0xF5,
                    0x30
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IShellImageDataAbort
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0x8E, 0xFB, 0x53,
                    0xC0, 0x50,
                    0x03, 0x40,
                    0xB4,
                    0xAA,
                    0x0C,
                    0x8D,
                    0xF2,
                    0x8E,
                    0x7F,
                    0x3A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ShellImageDataFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0xE4, 0xE4, 0x66,
                    0x85, 0xF3,
                    0xD0, 0x4D,
                    0x8D,
                    0x74,
                    0xA2,
                    0xEF,
                    0xD1,
                    0xBC,
                    0x61,
                    0x78
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
