// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid ID_DOCUMENTPACKAGETARGET_MSXPS
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x40, 0xAE, 0x9C,
                    0xD1, 0xDE,
                    0xC9, 0x41,
                    0xA9,
                    0xFD,
                    0xD7,
                    0x35,
                    0xEF,
                    0x33,
                    0xAE,
                    0xDA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid ID_DOCUMENTPACKAGETARGET_OPENXPS
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0xBB, 0x56, 0x00,
                    0x9C, 0x8C,
                    0x12, 0x46,
                    0xBD,
                    0x0F,
                    0x93,
                    0x01,
                    0x2A,
                    0x87,
                    0x09,
                    0x9D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid ID_DOCUMENTPACKAGETARGET_OPENXPS_WITH_3D
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xD7, 0xDB, 0x63,
                    0x14, 0x8B,
                    0x77, 0x45,
                    0xB0,
                    0x74,
                    0x7B,
                    0xB1,
                    0x1B,
                    0x59,
                    0x6D,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPrintDocumentPackageTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0xFE, 0x8E, 0x1B,
                    0x19, 0x30,
                    0x27, 0x4C,
                    0x96,
                    0x4E,
                    0x36,
                    0x72,
                    0x02,
                    0x15,
                    0x69,
                    0x06
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPrintDocumentPackageStatusEvent
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAD, 0xC8, 0x90, 0xED,
                    0x34, 0x5C,
                    0x05, 0x4D,
                    0xA1,
                    0xEC,
                    0x0E,
                    0x8A,
                    0x9B,
                    0x3A,
                    0xD7,
                    0xAF
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPrintDocumentPackageTargetFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF7, 0x9B, 0x95, 0xD2,
                    0x1B, 0xB3,
                    0x3D, 0x4A,
                    0x96,
                    0x00,
                    0x71,
                    0x2E,
                    0xB1,
                    0x33,
                    0x5B,
                    0xA4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_PrintDocumentPackageTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0x66, 0x42, 0x48,
                    0x47, 0x99,
                    0xEA, 0x46,
                    0x8B,
                    0xA2,
                    0xD8,
                    0xCC,
                    0xE4,
                    0x32,
                    0xC2,
                    0xCA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_PrintDocumentPackageTargetFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0xF1, 0x8E, 0x34,
                    0x81, 0x6C,
                    0x82, 0x49,
                    0x92,
                    0xB4,
                    0xEE,
                    0x18,
                    0x8A,
                    0x43,
                    0x86,
                    0x7A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
