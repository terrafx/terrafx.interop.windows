// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatUnknown
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0x59, 0x5E, 0xA4,
                    0x78, 0x90,
                    0x7C, 0x4A,
                    0xAD,
                    0xB5,
                    0x4E,
                    0xDC,
                    0x4F,
                    0xD6,
                    0x1B,
                    0x1F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatIfd
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0x96, 0x73, 0x53,
                    0x8A, 0x2D,
                    0xB6, 0x4B,
                    0x9B,
                    0xF8,
                    0x2F,
                    0x0A,
                    0x8E,
                    0x2A,
                    0x3A,
                    0xDF
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatSubIfd
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0xE1, 0xA2, 0x58,
                    0xB9, 0x2D,
                    0x57, 0x4E,
                    0xBB,
                    0x14,
                    0x51,
                    0x77,
                    0x89,
                    0x1E,
                    0xD3,
                    0x31
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatExif
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0x4F, 0x3C, 0x1C,
                    0x4A, 0xB8,
                    0x7D, 0x46,
                    0x94,
                    0x93,
                    0x36,
                    0xCF,
                    0xBD,
                    0x59,
                    0xEA,
                    0x57
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatGps
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0xAB, 0x34, 0x71,
                    0x51, 0x93,
                    0xAD, 0x44,
                    0xAF,
                    0x62,
                    0x44,
                    0x8D,
                    0xB6,
                    0xB5,
                    0x02,
                    0xEC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatInterop
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0x6F, 0x68, 0xED,
                    0x1F, 0x68,
                    0x8B, 0x4C,
                    0xBD,
                    0x41,
                    0xA8,
                    0xAD,
                    0xDB,
                    0xF6,
                    0xB3,
                    0xFC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatApp0
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x70, 0x00, 0x79,
                    0x8D, 0x26,
                    0xD6, 0x45,
                    0xA3,
                    0xC2,
                    0x35,
                    0x4E,
                    0x6A,
                    0x50,
                    0x4B,
                    0xC9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatApp1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0xDF, 0xD3, 0x8F,
                    0x51, 0xF9,
                    0x2B, 0x49,
                    0x81,
                    0x7F,
                    0x69,
                    0xC2,
                    0xE6,
                    0xD9,
                    0xA5,
                    0xB0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatApp13
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x56, 0x65, 0x32,
                    0x02, 0xF5,
                    0x54, 0x43,
                    0x9C,
                    0xC0,
                    0x8E,
                    0x3F,
                    0x48,
                    0xEA,
                    0xF6,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatIPTC
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x14, 0x09, 0xAB, 0x4F,
                    0x29, 0xE1,
                    0x87, 0x40,
                    0xA1,
                    0xD1,
                    0xBC,
                    0x81,
                    0x2D,
                    0x45,
                    0xA7,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatIRB
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x0D, 0x10, 0x16,
                    0x70, 0x85,
                    0xB9, 0x4B,
                    0xB9,
                    0x2D,
                    0xFD,
                    0xA4,
                    0xB2,
                    0x3E,
                    0xCE,
                    0x67
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormat8BIMIPTC
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x56, 0x10, 0x00,
                    0x52, 0x08,
                    0x6A, 0x4E,
                    0xB1,
                    0x91,
                    0x5C,
                    0x33,
                    0xAC,
                    0x5B,
                    0x04,
                    0x30
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormat8BIMResolutionInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x30, 0x9F, 0x73,
                    0xDB, 0x81,
                    0xCB, 0x43,
                    0xAC,
                    0x5E,
                    0x55,
                    0x01,
                    0x3E,
                    0xF9,
                    0xF0,
                    0x03
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormat8BIMIPTCDigest
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0x22, 0xA3, 0x1C,
                    0xCD, 0x9C,
                    0x86, 0x47,
                    0x8B,
                    0xD8,
                    0x79,
                    0x53,
                    0x9D,
                    0xB6,
                    0xA0,
                    0x06
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatXMP
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x38, 0xCC, 0x5A, 0xBB,
                    0x16, 0xF2,
                    0xEC, 0x4C,
                    0xA6,
                    0xC5,
                    0x5F,
                    0x6E,
                    0x73,
                    0x97,
                    0x63,
                    0xA9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatThumbnail
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0xCE, 0x3D, 0x24,
                    0x03, 0x87,
                    0xEE, 0x40,
                    0x8E,
                    0xF0,
                    0x22,
                    0xA6,
                    0x00,
                    0xB8,
                    0x05,
                    0x8C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatChunktEXt
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0x89, 0x8D, 0x56,
                    0xA9, 0xC0,
                    0x23, 0x49,
                    0x90,
                    0x5D,
                    0xDF,
                    0x2B,
                    0x38,
                    0x23,
                    0x8F,
                    0xBC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatXMPStruct
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x3C, 0x38, 0x22,
                    0x17, 0xED,
                    0x2E, 0x4E,
                    0xAF,
                    0x17,
                    0xD8,
                    0x5B,
                    0x8F,
                    0x6B,
                    0x30,
                    0xD0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatXMPBag
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5F, 0xCA, 0x3C, 0x83,
                    0xB7, 0xDC,
                    0x16, 0x45,
                    0x80,
                    0x6F,
                    0x65,
                    0x96,
                    0xAB,
                    0x26,
                    0xDC,
                    0xE4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatXMPSeq
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xDF, 0xE8, 0x63,
                    0x6C, 0xEB,
                    0x6C, 0x45,
                    0xA2,
                    0x24,
                    0xB2,
                    0x5E,
                    0x79,
                    0x4F,
                    0xD6,
                    0x48
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatXMPAlt
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0xA6, 0x08, 0x7B,
                    0xAA, 0x91,
                    0x1B, 0x48,
                    0xA7,
                    0x98,
                    0x4D,
                    0xA9,
                    0x49,
                    0x08,
                    0x61,
                    0x3B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatLSD
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1E, 0x03, 0x56, 0xE2,
                    0x99, 0x62,
                    0x29, 0x49,
                    0xB9,
                    0x8D,
                    0x5A,
                    0xC8,
                    0x84,
                    0xAF,
                    0xBA,
                    0x92
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatIMD
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0xB0, 0x2B, 0xBD,
                    0x52, 0x4D,
                    0xDD, 0x48,
                    0x96,
                    0x77,
                    0xDB,
                    0x48,
                    0x3E,
                    0x85,
                    0xAE,
                    0x8F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatGCE
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0xCA, 0x25, 0x2A,
                    0xEB, 0xDE,
                    0x69, 0x4C,
                    0xA7,
                    0x88,
                    0x0E,
                    0xC2,
                    0x26,
                    0x6D,
                    0xCA,
                    0xFD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatAPE
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC2, 0x3D, 0x04, 0x2E,
                    0x67, 0xC9,
                    0x05, 0x4E,
                    0x87,
                    0x5E,
                    0x61,
                    0x8B,
                    0xF6,
                    0x7E,
                    0x85,
                    0xC3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatJpegChrominance
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0x0D, 0x3D, 0xF7,
                    0xC6, 0xCE,
                    0x85, 0x4F,
                    0x9B,
                    0x0E,
                    0x1C,
                    0x39,
                    0x56,
                    0xB1,
                    0xBE,
                    0xF7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatJpegLuminance
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0x80, 0x90, 0x86,
                    0xFC, 0xED,
                    0x60, 0x48,
                    0x8D,
                    0x4B,
                    0x4E,
                    0xE6,
                    0xE8,
                    0x3E,
                    0x60,
                    0x58
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatJpegComment
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x5F, 0x0E, 0x22,
                    0xD3, 0xAF,
                    0x4E, 0x47,
                    0x9D,
                    0x31,
                    0x7D,
                    0x4F,
                    0xE7,
                    0x30,
                    0xF5,
                    0x57
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatGifComment
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xE0, 0xB6, 0xC4,
                    0xB4, 0xCF,
                    0xD3, 0x4A,
                    0xAB,
                    0x33,
                    0x9A,
                    0xAD,
                    0x23,
                    0x55,
                    0xA3,
                    0x4A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatChunkgAMA
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0x35, 0x09, 0xF0,
                    0x5D, 0x1D,
                    0xD1, 0x4C,
                    0x81,
                    0xB2,
                    0x93,
                    0x24,
                    0xD7,
                    0xEC,
                    0xA7,
                    0x81
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatChunkbKGD
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x71, 0x35, 0x4D, 0xE1,
                    0x47, 0x6B,
                    0xEA, 0x4D,
                    0xB6,
                    0x0A,
                    0x87,
                    0xCE,
                    0x0A,
                    0x78,
                    0xDF,
                    0xB7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatChunkiTXt
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0xC7, 0xBE, 0xC2,
                    0x68, 0x0B,
                    0x77, 0x4B,
                    0xAA,
                    0x0E,
                    0x62,
                    0x95,
                    0xA6,
                    0xAC,
                    0x18,
                    0x14
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatChunkcHRM
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5B, 0x65, 0xB3, 0x9D,
                    0x42, 0x28,
                    0xB3, 0x44,
                    0x80,
                    0x67,
                    0x12,
                    0xE9,
                    0xB3,
                    0x75,
                    0x55,
                    0x6A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatChunkhIST
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDA, 0x82, 0x9A, 0xC5,
                    0x74, 0xDB,
                    0xA4, 0x48,
                    0xBD,
                    0x6A,
                    0xB6,
                    0x9C,
                    0x49,
                    0x31,
                    0xEF,
                    0x95
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatChunkiCCP
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAB, 0x49, 0x43, 0xEB,
                    0x85, 0xB6,
                    0x0F, 0x45,
                    0x91,
                    0xB5,
                    0xE8,
                    0x02,
                    0xE8,
                    0x92,
                    0x53,
                    0x6C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatChunksRGB
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0xFD, 0x15, 0xC1,
                    0x6F, 0xCC,
                    0x3F, 0x4E,
                    0x83,
                    0x63,
                    0x52,
                    0x4B,
                    0x87,
                    0xC6,
                    0xB0,
                    0xD9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatChunktIME
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0xAE, 0x00, 0x6B,
                    0x4B, 0xE2,
                    0x0A, 0x46,
                    0x98,
                    0xB6,
                    0x87,
                    0x8B,
                    0xD0,
                    0x30,
                    0x72,
                    0xFD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatDds
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x46, 0x06, 0x4A,
                    0x33, 0x8C,
                    0x60, 0x4E,
                    0x9C,
                    0x29,
                    0x13,
                    0x62,
                    0x31,
                    0x70,
                    0x2D,
                    0x08
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatHeif
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0xF3, 0x7E, 0x81,
                    0x88, 0x12,
                    0xF4, 0x45,
                    0xA8,
                    0x52,
                    0x26,
                    0x0D,
                    0x9E,
                    0x7C,
                    0xCE,
                    0x83
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatHeifHDR
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0x8D, 0x8B, 0x56,
                    0x65, 0x1E,
                    0x8C, 0x43,
                    0x89,
                    0x68,
                    0xD6,
                    0x0E,
                    0x10,
                    0x12,
                    0xBE,
                    0xB9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatWebpANIM
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0xFD, 0xC4, 0x6D,
                    0xE6, 0x78,
                    0x02, 0x41,
                    0xAE,
                    0x35,
                    0xBC,
                    0xFA,
                    0x1E,
                    0xDC,
                    0xC7,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MetadataFormatWebpANMF
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x05, 0xC1, 0x43,
                    0x3B, 0xB9,
                    0xBB, 0x4A,
                    0xB0,
                    0x03,
                    0xA0,
                    0x8C,
                    0x0D,
                    0x87,
                    0x04,
                    0x71
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICUnknownMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC2, 0x45, 0x97, 0x69,
                    0x66, 0x50,
                    0x82, 0x4B,
                    0xA8,
                    0xE3,
                    0xD4,
                    0x04,
                    0x78,
                    0xDB,
                    0xEC,
                    0x8C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICUnknownMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0xCA, 0x9C, 0xA0,
                    0xBA, 0x27,
                    0x39, 0x4F,
                    0x90,
                    0x53,
                    0x12,
                    0x1F,
                    0xA4,
                    0xDC,
                    0x08,
                    0xFC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICApp0MetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x33, 0xC6, 0xF3,
                    0xC8, 0x46,
                    0x8E, 0x49,
                    0x8F,
                    0xBB,
                    0xCC,
                    0x6F,
                    0x72,
                    0x1B,
                    0xBC,
                    0xDE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICApp0MetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x4B, 0x32, 0x43,
                    0x8F, 0xA7,
                    0x0F, 0x48,
                    0x91,
                    0x11,
                    0x96,
                    0x38,
                    0xAA,
                    0xCC,
                    0xC8,
                    0x32
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICApp1MetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x69, 0x60, 0x36, 0xEE,
                    0x32, 0x18,
                    0x0F, 0x42,
                    0xB3,
                    0x81,
                    0x04,
                    0x79,
                    0xAD,
                    0x06,
                    0x6F,
                    0x19
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICApp1MetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x13, 0x35, 0xE3, 0xDD,
                    0x4E, 0x77,
                    0xCD, 0x4B,
                    0xAE,
                    0x79,
                    0x02,
                    0xF4,
                    0xAD,
                    0xFE,
                    0x62,
                    0xFC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICApp13MetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0xA9, 0x19, 0x7B,
                    0xD6, 0xA9,
                    0xE5, 0x49,
                    0xBD,
                    0x45,
                    0x02,
                    0xC3,
                    0x4E,
                    0x4E,
                    0x4C,
                    0xD5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICApp13MetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x3C, 0x7E, 0xAA,
                    0x4C, 0x86,
                    0x04, 0x46,
                    0xBC,
                    0x04,
                    0x8B,
                    0x0B,
                    0x76,
                    0xE6,
                    0x37,
                    0xF6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICIfdMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0x46, 0x91, 0x8F,
                    0x0A, 0x9D,
                    0xB2, 0x4E,
                    0x90,
                    0x19,
                    0x0B,
                    0xF9,
                    0x6D,
                    0x8A,
                    0x9E,
                    0xE6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICIfdMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0xFC, 0xEB, 0xB1,
                    0xBD, 0xC9,
                    0xA2, 0x47,
                    0x8D,
                    0x33,
                    0xB9,
                    0x48,
                    0x76,
                    0x97,
                    0x77,
                    0xA7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICSubIfdMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x2F, 0xD4, 0x50,
                    0xD1, 0xEC,
                    0x41, 0x4B,
                    0xB6,
                    0x5D,
                    0xDA,
                    0x1F,
                    0xDA,
                    0xA7,
                    0x56,
                    0x63
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICSubIfdMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0x53, 0xDE, 0x8A,
                    0x9B, 0x8E,
                    0x4C, 0x4F,
                    0xAC,
                    0xF2,
                    0xF0,
                    0x00,
                    0x87,
                    0x06,
                    0xB2,
                    0x38
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICExifMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x38, 0x40, 0xD9,
                    0x7F, 0x29,
                    0x49, 0x4A,
                    0xBF,
                    0x9B,
                    0x77,
                    0x89,
                    0x81,
                    0x50,
                    0xA4,
                    0x42
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICExifMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDA, 0x4C, 0xA1, 0xC9,
                    0x39, 0xC3,
                    0x0B, 0x46,
                    0x90,
                    0x78,
                    0xD4,
                    0xDE,
                    0xBC,
                    0xFA,
                    0xBE,
                    0x91
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICGpsMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0x79, 0x97, 0x36,
                    0x3B, 0x22,
                    0x4E, 0x48,
                    0x99,
                    0x25,
                    0xC4,
                    0x86,
                    0x92,
                    0x18,
                    0xF1,
                    0x7A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICGpsMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0x13, 0x8C, 0xCB,
                    0xB5, 0x62,
                    0x96, 0x4C,
                    0xA4,
                    0x8B,
                    0x6B,
                    0xA6,
                    0xAC,
                    0xE3,
                    0x9C,
                    0x76
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICInteropMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x98, 0xB8, 0xC8, 0xB5,
                    0x74, 0x00,
                    0x9F, 0x45,
                    0xB7,
                    0x00,
                    0x86,
                    0x0D,
                    0x46,
                    0x51,
                    0xEA,
                    0x14
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICInteropMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0xC6, 0x2E, 0x12,
                    0x7E, 0xCD,
                    0xD8, 0x44,
                    0xB1,
                    0x86,
                    0x2C,
                    0x8C,
                    0x20,
                    0xC3,
                    0xB5,
                    0x0F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICThumbnailMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x29, 0x01, 0xFB,
                    0xF6, 0xF4,
                    0xD7, 0x44,
                    0x9D,
                    0x09,
                    0xDA,
                    0xA0,
                    0x87,
                    0xA9,
                    0xDB,
                    0x57
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICThumbnailMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0xB2, 0x49, 0xD0,
                    0xD0, 0x5D,
                    0xFE, 0x44,
                    0xB0,
                    0xB3,
                    0x8F,
                    0x92,
                    0xC8,
                    0xE6,
                    0xD0,
                    0x80
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICIPTCMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x29, 0x01, 0x03,
                    0xF6, 0xF4,
                    0xD7, 0x44,
                    0x9D,
                    0x09,
                    0xDA,
                    0xA0,
                    0x87,
                    0xA9,
                    0xDB,
                    0x57
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICIPTCMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0xB2, 0x49, 0x12,
                    0xD0, 0x5D,
                    0xFE, 0x44,
                    0xB0,
                    0xB3,
                    0x8F,
                    0x92,
                    0xC8,
                    0xE6,
                    0xD0,
                    0x80
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICIRBMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD7, 0xD3, 0xDC, 0xD4,
                    0xC2, 0xB4,
                    0xD9, 0x47,
                    0xA6,
                    0xBF,
                    0xB8,
                    0x9B,
                    0xA3,
                    0x96,
                    0xA4,
                    0xA3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICIRBMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x35, 0x19, 0x5C, 0x5C,
                    0x35, 0x02,
                    0x34, 0x44,
                    0x80,
                    0xBC,
                    0x25,
                    0x1B,
                    0xC1,
                    0xEC,
                    0x39,
                    0xC6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WIC8BIMIPTCMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x66, 0x10, 0x00,
                    0x01, 0x08,
                    0xA6, 0x4D,
                    0xA4,
                    0xA4,
                    0x82,
                    0x65,
                    0x22,
                    0xB6,
                    0xD2,
                    0x8F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WIC8BIMIPTCMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x82, 0x10, 0x00,
                    0x41, 0xEE,
                    0xA2, 0x44,
                    0x9E,
                    0x9C,
                    0x4B,
                    0xE4,
                    0xD5,
                    0xB1,
                    0xD2,
                    0xCD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WIC8BIMResolutionInfoMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x13, 0x05, 0x58,
                    0x48, 0xE3,
                    0x7C, 0x4F,
                    0xB3,
                    0xCC,
                    0x6D,
                    0xB9,
                    0x96,
                    0x5A,
                    0x05,
                    0x99
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WIC8BIMResolutionInfoMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0xFE, 0xF2, 0x4F,
                    0x4A, 0xE7,
                    0x71, 0x4B,
                    0x98,
                    0xC4,
                    0xAB,
                    0x7D,
                    0xC1,
                    0x67,
                    0x07,
                    0xBA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WIC8BIMIPTCDigestMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1E, 0x5F, 0x80, 0x02,
                    0xAA, 0xD5,
                    0x5B, 0x41,
                    0x82,
                    0xC5,
                    0x61,
                    0xC0,
                    0x33,
                    0xA9,
                    0x88,
                    0xA6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WIC8BIMIPTCDigestMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0xE6, 0xB5, 0x2D,
                    0x67, 0x0D,
                    0x5F, 0x49,
                    0x8F,
                    0x9D,
                    0xC2,
                    0xF0,
                    0x18,
                    0x86,
                    0x47,
                    0xAC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngTextMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCC, 0xAF, 0x59, 0x4B,
                    0xC3, 0xB8,
                    0x8A, 0x40,
                    0xB6,
                    0x70,
                    0x89,
                    0xE5,
                    0xFA,
                    0xB6,
                    0xFD,
                    0xA7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngTextMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB9, 0xAF, 0xEB, 0xB5,
                    0x3E, 0x25,
                    0x72, 0x4A,
                    0xA7,
                    0x44,
                    0x07,
                    0x62,
                    0xD2,
                    0x68,
                    0x56,
                    0x83
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0x24, 0xB6, 0x72,
                    0x11, 0xAE,
                    0x48, 0x49,
                    0xA6,
                    0x5C,
                    0x35,
                    0x1E,
                    0xB0,
                    0x82,
                    0x94,
                    0x19
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0xE1, 0x65, 0x17,
                    0xD4, 0x1B,
                    0x2E, 0x46,
                    0xB6,
                    0xB1,
                    0x59,
                    0x0B,
                    0xF1,
                    0x26,
                    0x2A,
                    0xC6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPStructMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0x0D, 0xB9, 0x01,
                    0x09, 0x82,
                    0xF7, 0x47,
                    0x9C,
                    0x52,
                    0xE1,
                    0x24,
                    0x4B,
                    0xF5,
                    0x0C,
                    0xED
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPStructMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0x1F, 0xC2, 0x22,
                    0xDB, 0x7D,
                    0x1C, 0x41,
                    0x9B,
                    0x17,
                    0xC5,
                    0xB7,
                    0xBD,
                    0x06,
                    0x4A,
                    0xBC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPBagMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x9A, 0xE7, 0xE7,
                    0x2C, 0x4F,
                    0xAB, 0x4F,
                    0x8D,
                    0x00,
                    0x39,
                    0x4F,
                    0x2D,
                    0x6B,
                    0xBE,
                    0xBE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPBagMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x2C, 0x82, 0xED,
                    0xBE, 0xD6,
                    0x01, 0x43,
                    0xA6,
                    0x31,
                    0x0E,
                    0x14,
                    0x16,
                    0xBA,
                    0xD2,
                    0x8F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPSeqMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0xE7, 0x12, 0x7F,
                    0x71, 0xFC,
                    0xD7, 0x43,
                    0xA5,
                    0x1D,
                    0x92,
                    0xF3,
                    0x59,
                    0x77,
                    0xAB,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPSeqMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDE, 0xD1, 0x68, 0x6D,
                    0x32, 0xD4,
                    0x0F, 0x4B,
                    0x92,
                    0x3A,
                    0x09,
                    0x11,
                    0x83,
                    0xA9,
                    0xBD,
                    0xA7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPAltMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC2, 0xDC, 0x94, 0xAA,
                    0xB0, 0xB8,
                    0x98, 0x48,
                    0xB8,
                    0x35,
                    0x00,
                    0x0A,
                    0xAB,
                    0xD7,
                    0x43,
                    0x93
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICXMPAltMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6C, 0x2A, 0x6C, 0x07,
                    0x8F, 0xF7,
                    0x46, 0x4C,
                    0xA7,
                    0x23,
                    0x35,
                    0x83,
                    0xE7,
                    0x08,
                    0x76,
                    0xEA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICLSDMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0x07, 0x07, 0x41,
                    0xE4, 0x59,
                    0x9A, 0x47,
                    0xA1,
                    0xF7,
                    0x95,
                    0x4A,
                    0xDC,
                    0x2E,
                    0xF5,
                    0xFC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICLSDMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0x37, 0xC0, 0x73,
                    0xD9, 0xE5,
                    0x54, 0x49,
                    0x87,
                    0x6A,
                    0x6D,
                    0xA8,
                    0x1D,
                    0x6E,
                    0x57,
                    0x68
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICGCEMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5D, 0x34, 0x2E, 0xB9,
                    0x2D, 0xF5,
                    0xF3, 0x41,
                    0xB5,
                    0x62,
                    0x08,
                    0x1B,
                    0xC7,
                    0x72,
                    0xE3,
                    0xB9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICGCEMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0xDC, 0x95, 0xAF,
                    0xB2, 0x16,
                    0xF4, 0x47,
                    0xB3,
                    0xEA,
                    0x3C,
                    0x31,
                    0x79,
                    0x66,
                    0x93,
                    0xE7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICIMDMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x67, 0xA2, 0x47, 0x74,
                    0x15, 0x00,
                    0xC8, 0x42,
                    0xA8,
                    0xF1,
                    0xFB,
                    0x3B,
                    0x94,
                    0xC6,
                    0x83,
                    0x61
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICIMDMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1F, 0x07, 0x89, 0x8C,
                    0x2E, 0x45,
                    0x95, 0x4E,
                    0x96,
                    0x82,
                    0x9D,
                    0x10,
                    0x24,
                    0x62,
                    0x71,
                    0x72
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICAPEMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0xB9, 0x67, 0x17,
                    0x21, 0xB0,
                    0xEA, 0x44,
                    0x92,
                    0x0F,
                    0x86,
                    0x3C,
                    0x11,
                    0xF4,
                    0xF7,
                    0x68
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICAPEMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0xDF, 0x6E, 0xBD,
                    0x90, 0x28,
                    0x2F, 0x48,
                    0xB2,
                    0x33,
                    0x8D,
                    0x73,
                    0x39,
                    0xA1,
                    0xCF,
                    0x8D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICJpegChrominanceMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4B, 0x90, 0xB1, 0x50,
                    0x8F, 0xF2,
                    0x74, 0x45,
                    0x93,
                    0xF4,
                    0x0B,
                    0xAD,
                    0xE8,
                    0x2C,
                    0x69,
                    0xE9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICJpegChrominanceMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0x66, 0xF5, 0x3F,
                    0x6B, 0x6E,
                    0xD4, 0x49,
                    0x96,
                    0xE6,
                    0xB7,
                    0x88,
                    0x86,
                    0x69,
                    0x2C,
                    0x62
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICJpegLuminanceMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x2F, 0x6F, 0x35,
                    0xA6, 0x05,
                    0x28, 0x47,
                    0xB9,
                    0xA4,
                    0x1B,
                    0xFB,
                    0xCE,
                    0x04,
                    0xD8,
                    0x38
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICJpegLuminanceMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0x3A, 0x58, 0x1D,
                    0x0E, 0x8A,
                    0x57, 0x46,
                    0x99,
                    0x82,
                    0xA3,
                    0x80,
                    0xCA,
                    0x58,
                    0xFB,
                    0x4B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICJpegCommentMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x34, 0x66, 0x9F,
                    0xC4, 0x60,
                    0x4D, 0x4C,
                    0xAB,
                    0x58,
                    0xD2,
                    0x35,
                    0x86,
                    0x85,
                    0xF6,
                    0x07
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICJpegCommentMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6F, 0x23, 0x73, 0xE5,
                    0xB1, 0x55,
                    0xDA, 0x4E,
                    0x81,
                    0xEA,
                    0x9F,
                    0x65,
                    0xDB,
                    0x02,
                    0x90,
                    0xD3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICGifCommentMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0x7D, 0x55, 0x32,
                    0xDC, 0x69,
                    0x95, 0x4F,
                    0x83,
                    0x6E,
                    0xF5,
                    0x97,
                    0x2B,
                    0x2F,
                    0x61,
                    0x59
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICGifCommentMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0x97, 0x27, 0xA0,
                    0xAE, 0xC4,
                    0x8C, 0x41,
                    0xAF,
                    0x95,
                    0xE6,
                    0x37,
                    0xC7,
                    0xEA,
                    0xD2,
                    0xA1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngGamaMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0xCA, 0x92, 0x36,
                    0x82, 0xE0,
                    0x50, 0x43,
                    0x9E,
                    0x1F,
                    0x37,
                    0x04,
                    0xCB,
                    0x08,
                    0x3C,
                    0xD5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngGamaMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x13, 0x6D, 0x03, 0xFF,
                    0x4B, 0x5D,
                    0xDD, 0x46,
                    0xB1,
                    0x0F,
                    0x10,
                    0x66,
                    0x93,
                    0xD9,
                    0xFE,
                    0x4F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngBkgdMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0xA4, 0xE7, 0x0C,
                    0xE8, 0x03,
                    0x60, 0x4A,
                    0x9D,
                    0x15,
                    0x28,
                    0x2E,
                    0xF3,
                    0x2E,
                    0xE7,
                    0xDA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngBkgdMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0xF2, 0xE3, 0x68,
                    0xAE, 0x31,
                    0x41, 0x44,
                    0xBB,
                    0x6A,
                    0xFD,
                    0x70,
                    0x47,
                    0x52,
                    0x5F,
                    0x90
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngItxtMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFA, 0xB2, 0xBF, 0xAA,
                    0x1E, 0x3E,
                    0x8F, 0x4A,
                    0x89,
                    0x77,
                    0x55,
                    0x56,
                    0xFB,
                    0x94,
                    0xEA,
                    0x23
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngItxtMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0x97, 0x87, 0x31,
                    0x51, 0xE7,
                    0xF8, 0x4D,
                    0x98,
                    0x1D,
                    0x68,
                    0xDF,
                    0xF6,
                    0x77,
                    0x04,
                    0xED
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngChrmMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0x5F, 0x0B, 0xF9,
                    0x7B, 0x36,
                    0x2A, 0x40,
                    0x9D,
                    0xD1,
                    0xBC,
                    0x0F,
                    0xD5,
                    0x9D,
                    0x8F,
                    0x62
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngChrmMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0xE3, 0x3C, 0xE2,
                    0x08, 0x56,
                    0x83, 0x4E,
                    0xBC,
                    0xEF,
                    0x27,
                    0xB1,
                    0x98,
                    0x7E,
                    0x51,
                    0xD7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngHistMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x0B, 0x7A, 0x87,
                    0x13, 0xA3,
                    0x91, 0x44,
                    0x87,
                    0xB5,
                    0x2E,
                    0x6D,
                    0x05,
                    0x94,
                    0xF5,
                    0x20
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngHistMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0xE7, 0x03, 0x8A,
                    0x2E, 0x67,
                    0x6E, 0x44,
                    0xBF,
                    0x1F,
                    0x2C,
                    0x11,
                    0xD2,
                    0x33,
                    0xB6,
                    0xFF
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngIccpMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0xE6, 0xD3, 0xF5,
                    0x0F, 0xCB,
                    0x28, 0x46,
                    0xA4,
                    0x78,
                    0x6D,
                    0x82,
                    0x44,
                    0xBE,
                    0x36,
                    0xB1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngIccpMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5F, 0x1E, 0x67, 0x16,
                    0xE6, 0x0C,
                    0xC4, 0x4C,
                    0x97,
                    0x68,
                    0xE8,
                    0x9F,
                    0xE5,
                    0x01,
                    0x8A,
                    0xDE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngSrgbMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0x36, 0x40, 0xFB,
                    0x7E, 0x54,
                    0x56, 0x49,
                    0xA3,
                    0xB9,
                    0xD4,
                    0x41,
                    0x88,
                    0x59,
                    0xBA,
                    0x66
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngSrgbMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0x35, 0xEE, 0xA6,
                    0xEC, 0x87,
                    0xDF, 0x47,
                    0x9F,
                    0x22,
                    0x1D,
                    0x5A,
                    0xAD,
                    0x84,
                    0x0C,
                    0x82
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngTimeMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xDF, 0x4E, 0xD9,
                    0xE5, 0xEF,
                    0x0D, 0x4F,
                    0x85,
                    0xC8,
                    0xF5,
                    0xA6,
                    0x8B,
                    0x30,
                    0x00,
                    0xB1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICPngTimeMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x84, 0xB7, 0x1A,
                    0xA3, 0xB5,
                    0x91, 0x4D,
                    0x8A,
                    0xCE,
                    0x33,
                    0xFC,
                    0xD1,
                    0x49,
                    0x9B,
                    0xE6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICDdsMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x88, 0x6C, 0x27,
                    0x33, 0x75,
                    0x86, 0x4A,
                    0xB6,
                    0x76,
                    0x66,
                    0xB3,
                    0x60,
                    0x80,
                    0xD4,
                    0x84
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICDdsMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBD, 0x8B, 0x68, 0xFD,
                    0xED, 0x31,
                    0xB7, 0x4D,
                    0xA7,
                    0x23,
                    0x93,
                    0x49,
                    0x27,
                    0xD3,
                    0x83,
                    0x67
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICHeifMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0xFC, 0xDD, 0xAC,
                    0xEC, 0x85,
                    0xBC, 0x41,
                    0xBD,
                    0xEF,
                    0x1B,
                    0xC2,
                    0x62,
                    0xE4,
                    0xDB,
                    0x05
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICHeifMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x79, 0x5E, 0xE4, 0x3A,
                    0xBC, 0x40,
                    0x01, 0x44,
                    0xAC,
                    0xE5,
                    0xDD,
                    0x3C,
                    0xB1,
                    0x6E,
                    0x6A,
                    0xFE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICHeifHDRMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0xDE, 0x38, 0x24,
                    0xD9, 0x94,
                    0xE8, 0x4B,
                    0x84,
                    0xA8,
                    0x4D,
                    0xE9,
                    0x5A,
                    0x57,
                    0x5E,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICWebpAnimMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0x99, 0x6F, 0x07,
                    0x48, 0xA3,
                    0x5C, 0x46,
                    0xA8,
                    0x07,
                    0xA2,
                    0x52,
                    0xF3,
                    0xF2,
                    0xD3,
                    0xDE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WICWebpAnmfMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x0B, 0xA1, 0x85,
                    0xF6, 0xC9,
                    0x9F, 0x43,
                    0xBE,
                    0x5E,
                    0xC0,
                    0xFB,
                    0xEF,
                    0x67,
                    0x80,
                    0x7C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("WindowsCodecs", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICMatchMetadataContent([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IStream* pIStream, [NativeTypeName("GUID *")] Guid* pguidMetadataFormat);

        [DllImport("WindowsCodecs", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICSerializeMetadataContent([NativeTypeName("const GUID &")] Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, [NativeTypeName("DWORD")] uint dwPersistOptions, IStream* pIStream);

        [DllImport("WindowsCodecs", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WICGetMetadataContentSize([NativeTypeName("const GUID &")] Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, ULARGE_INTEGER* pcbSize);

        public static ref readonly Guid IID_IWICMetadataBlockReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8D, 0x2A, 0xAA, 0xFE,
                    0xF3, 0xB3,
                    0xE4, 0x43,
                    0xB2,
                    0x5C,
                    0xD1,
                    0xDE,
                    0x99,
                    0x0A,
                    0x1A,
                    0xE1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataBlockWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0x96, 0xFB, 0x08,
                    0x44, 0xB4,
                    0xE8, 0x41,
                    0x8D,
                    0xBE,
                    0x6A,
                    0x53,
                    0xA5,
                    0x42,
                    0xBF,
                    0xF1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0xFE, 0x04, 0x92,
                    0xFC, 0xD8,
                    0xD5, 0x4F,
                    0xA0,
                    0x01,
                    0x95,
                    0x36,
                    0xB0,
                    0x67,
                    0xA8,
                    0x99
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x6E, 0x83, 0xF7,
                    0xE0, 0x3B,
                    0x0B, 0x47,
                    0x86,
                    0xBB,
                    0x16,
                    0x0D,
                    0x0A,
                    0xEC,
                    0xD7,
                    0xDE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICStreamProvider
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0x94, 0x94, 0x44,
                    0x68, 0xB4,
                    0x27, 0x49,
                    0x96,
                    0xD7,
                    0xBA,
                    0x90,
                    0xD3,
                    0x1A,
                    0xB5,
                    0x05
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICPersistStream
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x50, 0x67, 0x00,
                    0x08, 0x69,
                    0xF8, 0x45,
                    0x86,
                    0xA3,
                    0x49,
                    0xC7,
                    0xDF,
                    0xD6,
                    0xD9,
                    0xAD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataHandlerInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBF, 0x58, 0xA9, 0xAB,
                    0x72, 0xC6,
                    0xD1, 0x44,
                    0x8D,
                    0x61,
                    0xCE,
                    0x6D,
                    0xF2,
                    0xE6,
                    0x82,
                    0xC2
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataReaderInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5B, 0x1F, 0xBF, 0xEE,
                    0xC1, 0x07,
                    0x47, 0x44,
                    0xA3,
                    0xAB,
                    0x22,
                    0xAC,
                    0xAF,
                    0x78,
                    0xA8,
                    0x04
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICMetadataWriterInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBA, 0x3F, 0x2E, 0xB2,
                    0x25, 0x39,
                    0x23, 0x43,
                    0xB5,
                    0xC1,
                    0x9E,
                    0xBF,
                    0xC4,
                    0x30,
                    0xF2,
                    0x36
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWICComponentFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x0C, 0x2D, 0x41,
                    0x50, 0x96,
                    0xFA, 0x44,
                    0xAF,
                    0x5B,
                    0xDD,
                    0x2A,
                    0x06,
                    0xC8,
                    0xE8,
                    0xFB
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
