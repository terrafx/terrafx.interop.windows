// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid DXGI_DEBUG_ALL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0xE2, 0x8A, 0xE4,
                    0x80, 0xDA,
                    0x0B, 0x49,
                    0x87,
                    0xE6,
                    0x43,
                    0xE9,
                    0xA9,
                    0xCF,
                    0xDA,
                    0x08
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DXGI_DEBUG_DX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0xD7, 0xCD, 0x35,
                    0xB2, 0x13,
                    0x1D, 0x42,
                    0xA5,
                    0xD7,
                    0x7E,
                    0x44,
                    0x51,
                    0x28,
                    0x7D,
                    0x64
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DXGI_DEBUG_DXGI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0xDA, 0xCD, 0x25,
                    0xC6, 0xB1,
                    0xE1, 0x47,
                    0xAC,
                    0x3E,
                    0x98,
                    0x87,
                    0x5B,
                    0x5A,
                    0x2E,
                    0x2A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DXGI_DEBUG_APP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x6E, 0xCD, 0x06,
                    0x19, 0x42,
                    0xBD, 0x4E,
                    0x87,
                    0x09,
                    0x27,
                    0xED,
                    0x23,
                    0x36,
                    0x0C,
                    0x62
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("DXGIDebug", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DXGIGetDebugInterface([NativeTypeName("const IID &")] Guid* riid, void** ppDebug);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDXGIInfoQueue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0x41, 0x74, 0xD6,
                    0x2A, 0x67,
                    0x6F, 0x47,
                    0x9E,
                    0x82,
                    0xCD,
                    0x55,
                    0xB4,
                    0x49,
                    0x49,
                    0xCE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDXGIDebug
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x74, 0x9E, 0x11,
                    0x9E, 0xDE,
                    0xFE, 0x40,
                    0x88,
                    0x06,
                    0x88,
                    0xF9,
                    0x0C,
                    0x12,
                    0xB4,
                    0x41
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDXGIDebug1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0x5F, 0xA0, 0xC5,
                    0xF2, 0x16,
                    0xDF, 0x4A,
                    0x9F,
                    0x4D,
                    0xA8,
                    0xC4,
                    0xD5,
                    0x8A,
                    0xC5,
                    0x50
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define DXGI_DEBUG_BINARY_VERSION ( 1 )")]
        public const int DXGI_DEBUG_BINARY_VERSION = (1);

        [NativeTypeName("#define DXGI_INFO_QUEUE_MESSAGE_ID_STRING_FROM_APPLICATION 0")]
        public const int DXGI_INFO_QUEUE_MESSAGE_ID_STRING_FROM_APPLICATION = 0;

        [NativeTypeName("#define DXGI_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
        public const int DXGI_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
    }
}
