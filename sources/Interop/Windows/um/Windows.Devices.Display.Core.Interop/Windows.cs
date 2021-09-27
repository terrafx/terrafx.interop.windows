// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [return: NativeTypeName("INT64")]
        public static long Int64FromLuid([NativeTypeName("const LUID &")] LUID* Luid)
        {
            LARGE_INTEGER val = new LARGE_INTEGER();

            val.Anonymous.LowPart = Luid->LowPart;
            val.Anonymous.HighPart = Luid->HighPart;
            return val.QuadPart;
        }

        public static LUID LuidFromInt64([NativeTypeName("INT64")] long Int64)
        {
            LARGE_INTEGER val = new LARGE_INTEGER();

            val.QuadPart = Int64;
            LUID Luid = new LUID();

            Luid.LowPart = val.Anonymous.LowPart;
            Luid.HighPart = val.Anonymous.HighPart;
            return Luid;
        }

        public static ref readonly Guid IID_IDisplayDeviceInterop
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0x83, 0x33, 0x64,
                    0x6A, 0x36,
                    0x1B, 0x47,
                    0xBD,
                    0x56,
                    0xDD,
                    0x8E,
                    0xF4,
                    0x8E,
                    0x43,
                    0x9B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDisplayPathInterop
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x05, 0x42, 0xBA, 0xA6,
                    0x9E, 0xE5,
                    0x71, 0x4E,
                    0xB2,
                    0x5B,
                    0x4E,
                    0x43,
                    0x6D,
                    0x21,
                    0xEE,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
