// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static ref readonly Guid IID_IInkD2DRenderer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDE, 0xB1, 0x7F, 0x40,
                    0x5A, 0xF8,
                    0x50, 0x41,
                    0x97,
                    0xCF,
                    0xB7,
                    0xFB,
                    0x27,
                    0x4F,
                    0xB4,
                    0xF8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid IID_IInkD2DRenderer2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD9, 0xDC, 0x95, 0x0A,
                    0x78, 0x45,
                    0x71, 0x4B,
                    0xB2,
                    0x0B,
                    0xBF,
                    0x66,
                    0x4D,
                    0x4B,
                    0xFE,
                    0xEE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid LIBID_InkD2DRendererLib
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x0A, 0x0D, 0x39,
                    0xE2, 0x19,
                    0xBB, 0x46,
                    0x86,
                    0x2E,
                    0xB0,
                    0x9F,
                    0x3C,
                    0xDC,
                    0xF8,
                    0xB9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const CLSID")]
        public static ref readonly Guid CLSID_InkD2DRenderer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0C, 0xE6, 0x44, 0x40,
                    0x01, 0x7B,
                    0x71, 0x46,
                    0xA9,
                    0x7C,
                    0x04,
                    0xE0,
                    0x21,
                    0x0A,
                    0x07,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
