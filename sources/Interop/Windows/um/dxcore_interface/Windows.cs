// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDXCoreAdapterFactory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0x59, 0xEE, 0x78,
                    0x6E, 0xC3,
                    0x13, 0x4B,
                    0xA6,
                    0x69,
                    0x00,
                    0x5D,
                    0xD1,
                    0x1C,
                    0x0F,
                    0x06
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDXCoreAdapterList
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0x77, 0x6C, 0x52,
                    0xE9, 0x40,
                    0x9B, 0x45,
                    0xB7,
                    0x11,
                    0xF3,
                    0x2A,
                    0xD7,
                    0x6D,
                    0xFC,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDXCoreAdapter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x4C, 0xDB, 0xF0,
                    0x5A, 0xFE,
                    0xA2, 0x42,
                    0xBD,
                    0x62,
                    0xF2,
                    0xA6,
                    0xCF,
                    0x6F,
                    0xC8,
                    0x3E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6B, 0x86, 0x47, 0x8C,
                    0x83, 0x75,
                    0x0D, 0x45,
                    0xF0,
                    0xF0,
                    0x6B,
                    0xAD,
                    0xA8,
                    0x95,
                    0xAF,
                    0x4B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0xCE, 0x9E, 0x0C,
                    0x6E, 0x2F,
                    0x01, 0x4F,
                    0x8C,
                    0x96,
                    0xE8,
                    0x9E,
                    0x33,
                    0x1B,
                    0x47,
                    0xB1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x28, 0x8E, 0x24,
                    0x93, 0xA7,
                    0x24, 0x47,
                    0xAB,
                    0xAA,
                    0x23,
                    0xA6,
                    0xDE,
                    0x1B,
                    0xE0,
                    0x90
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define _FACDXCORE 0x880")]
        public const int _FACDXCORE = 0x880;
    }
}
