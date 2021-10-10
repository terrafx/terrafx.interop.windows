// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [25]")]
        public const string CastingSourceInfo_Property_PreferredSourceUriScheme = "PreferredSourceUriScheme";

        [NativeTypeName("const WCHAR [13]")]
        public const string CastingSourceInfo_Property_CastingTypes = "CastingTypes";

        [NativeTypeName("const WCHAR [15]")]
        public const string CastingSourceInfo_Property_ProtectedMedia = "ProtectedMedia";

        public static ref readonly Guid IID_ICastingEventHandler
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x6C, 0x9A, 0xC7,
                    0xBD, 0xBE,
                    0xA6, 0x47,
                    0xA2,
                    0xAD,
                    0x4D,
                    0x45,
                    0xAD,
                    0x79,
                    0xC7,
                    0xBC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICastingController
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x64, 0xA5, 0xF0,
                    0x64, 0xA6,
                    0xBD, 0x4F,
                    0x8B,
                    0x43,
                    0x40,
                    0x9A,
                    0x45,
                    0xE8,
                    0xD9,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICastingSourceInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x1A, 0x10, 0x45,
                    0x3A, 0x7C,
                    0xCE, 0x4B,
                    0x95,
                    0x00,
                    0x12,
                    0xC0,
                    0x90,
                    0x24,
                    0xB2,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
