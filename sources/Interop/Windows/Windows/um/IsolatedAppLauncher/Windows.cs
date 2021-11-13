// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("shcore", ExactSpelling = true)]
        public static extern HRESULT IsProcessInWDAGContainer([NativeTypeName("PVOID")] void* Reserved, BOOL* isProcessInWDAGContainer);

        [DllImport("shcore", ExactSpelling = true)]
        public static extern HRESULT IsProcessInIsolatedContainer(BOOL* isProcessInIsolatedContainer);

        public static ref readonly Guid IID_IIsolatedAppLauncher
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0x87, 0x86, 0xF6,
                    0x42, 0x7B,
                    0xC4, 0x4C,
                    0x96,
                    0xFB,
                    0xF4,
                    0xF3,
                    0xB6,
                    0xE3,
                    0xD2,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_IsolatedAppLauncher
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x24, 0x81, 0xBC,
                    0x5E, 0xE7,
                    0xD1, 0x4F,
                    0x96,
                    0x41,
                    0x1F,
                    0x9F,
                    0x1E,
                    0x2D,
                    0x9A,
                    0x1F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
