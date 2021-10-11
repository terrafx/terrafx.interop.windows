// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static ref readonly Guid LIBID_RendezvousSessionLib
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x56, 0xD8, 0xEF,
                    0x85, 0x5A,
                    0x1B, 0x4A,
                    0xAD,
                    0xD5,
                    0x2E,
                    0xAD,
                    0xAC,
                    0xE6,
                    0xF6,
                    0xA2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid IID_IRendezvousSession
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0xB1, 0xA4, 0x9B,
                    0x0C, 0x8B,
                    0xB7, 0x48,
                    0x9E,
                    0x7C,
                    0x2F,
                    0x25,
                    0x85,
                    0x7C,
                    0x8D,
                    0xF5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid DIID_DRendezvousSessionEvents
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF8, 0x9C, 0xA1, 0x3F,
                    0xC4, 0x64,
                    0x53, 0x4F,
                    0xAE,
                    0x60,
                    0x63,
                    0x5B,
                    0x38,
                    0x06,
                    0xEC,
                    0xA6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid IID_IRendezvousApplication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0B, 0x07, 0x4D, 0x4F,
                    0x75, 0xA2,
                    0xFB, 0x49,
                    0xB1,
                    0x0D,
                    0x8E,
                    0xC2,
                    0x63,
                    0x87,
                    0xB5,
                    0x0D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const CLSID")]
        public static ref readonly Guid CLSID_RendezvousApplication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0x01, 0x7E, 0x0B,
                    0xDE, 0xB5,
                    0xFA, 0x47,
                    0x89,
                    0x66,
                    0x90,
                    0x82,
                    0xF8,
                    0x2F,
                    0xB1,
                    0x92
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define DISPID_EVENT_ON_STATE_CHANGED ( 5 )")]
        public const int DISPID_EVENT_ON_STATE_CHANGED = (5);

        [NativeTypeName("#define DISPID_EVENT_ON_TERMINATION ( 6 )")]
        public const int DISPID_EVENT_ON_TERMINATION = (6);

        [NativeTypeName("#define DISPID_EVENT_ON_CONTEXT_DATA ( 7 )")]
        public const int DISPID_EVENT_ON_CONTEXT_DATA = (7);

        [NativeTypeName("#define DISPID_EVENT_ON_SEND_ERROR ( 8 )")]
        public const int DISPID_EVENT_ON_SEND_ERROR = (8);
    }
}
