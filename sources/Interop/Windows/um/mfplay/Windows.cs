// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mfplay", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MFPCreateMediaPlayer([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("BOOL")] int fStartPlayback, [NativeTypeName("MFP_CREATION_OPTIONS")] uint creationOptions, IMFPMediaPlayerCallback* pCallback, [NativeTypeName("HWND")] IntPtr hWnd, IMFPMediaPlayer** ppMediaPlayer);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFP_POSITIONTYPE_100NS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFP_PKEY_StreamIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x97, 0xCF, 0xA7,
                    0xD9, 0xE8,
                    0x87, 0x4A,
                    0xBD,
                    0x8E,
                    0x29,
                    0x67,
                    0x00,
                    0x1F,
                    0xD3,
                    0xAD,
                    0x00, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const PROPERTYKEY")]
        public static ref readonly PROPERTYKEY MFP_PKEY_StreamRenderingResults
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x97, 0xCF, 0xA7,
                    0xD9, 0xE8,
                    0x87, 0x4A,
                    0xBD,
                    0x8E,
                    0x29,
                    0x67,
                    0x00,
                    0x1F,
                    0xD3,
                    0xAD,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
                return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPMediaPlayer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0x59, 0x14, 0xA7,
                    0xAF, 0x58,
                    0x0A, 0x43,
                    0x85,
                    0xBF,
                    0x44,
                    0xF5,
                    0xEC,
                    0x83,
                    0x8D,
                    0x85
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPMediaItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6B, 0x3E, 0xEB, 0x90,
                    0xBF, 0xEC,
                    0xCC, 0x45,
                    0xB1,
                    0xDA,
                    0xC6,
                    0xFE,
                    0x3E,
                    0xA7,
                    0x0D,
                    0x57
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMFPMediaPlayerCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0x8F, 0x6C, 0x76,
                    0xDB, 0x5F,
                    0xEA, 0x4F,
                    0xA2,
                    0x8D,
                    0xB9,
                    0x12,
                    0x99,
                    0x6F,
                    0x51,
                    0xBD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
