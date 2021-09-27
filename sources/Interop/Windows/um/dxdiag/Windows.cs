// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DxDiagProvider
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x71, 0x80, 0x5B, 0xA6,
                    0xFE, 0x3B,
                    0x13, 0x42,
                    0x9A,
                    0x5B,
                    0x49,
                    0x1D,
                    0xA4,
                    0x46,
                    0x1C,
                    0xA7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDxDiagProvider
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x4C, 0x6B, 0x9C,
                    0xF8, 0x23,
                    0xCC, 0x49,
                    0xA3,
                    0xED,
                    0x45,
                    0xA5,
                    0x50,
                    0x00,
                    0xA6,
                    0xD2
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDxDiagContainer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0x46, 0x0F, 0x7D,
                    0x64, 0x40,
                    0x62, 0x48,
                    0xBC,
                    0x7F,
                    0x93,
                    0x3E,
                    0x50,
                    0x58,
                    0xC1,
                    0x0F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define DXDIAG_DX9_SDK_VERSION 111")]
        public const int DXDIAG_DX9_SDK_VERSION = 111;

        [NativeTypeName("#define DXDIAG_E_INSUFFICIENT_BUFFER ((HRESULT)0x8007007AL)")]
        public const int DXDIAG_E_INSUFFICIENT_BUFFER = unchecked((int)(0x8007007A));
    }
}
