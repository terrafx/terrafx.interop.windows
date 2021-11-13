// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX
{
    public static partial class DirectX
    {
        [NativeTypeName("#define FACILITY_XAPO 0x897")]
        public const int FACILITY_XAPO = 0x897;

        [NativeTypeName("#define XAPO_E_FORMAT_UNSUPPORTED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_XAPO, 0x01)")]
        public const int XAPO_E_FORMAT_UNSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x897) << 16) | ((uint)(0x01))));

        [NativeTypeName("#define XAPO_MIN_CHANNELS 1")]
        public const int XAPO_MIN_CHANNELS = 1;

        [NativeTypeName("#define XAPO_MAX_CHANNELS 64")]
        public const int XAPO_MAX_CHANNELS = 64;

        [NativeTypeName("#define XAPO_MIN_FRAMERATE 1000")]
        public const int XAPO_MIN_FRAMERATE = 1000;

        [NativeTypeName("#define XAPO_MAX_FRAMERATE 200000")]
        public const int XAPO_MAX_FRAMERATE = 200000;

        [NativeTypeName("#define XAPO_REGISTRATION_STRING_LENGTH 256")]
        public const int XAPO_REGISTRATION_STRING_LENGTH = 256;

        [NativeTypeName("#define XAPO_FLAG_CHANNELS_MUST_MATCH 0x00000001")]
        public const int XAPO_FLAG_CHANNELS_MUST_MATCH = 0x00000001;

        [NativeTypeName("#define XAPO_FLAG_FRAMERATE_MUST_MATCH 0x00000002")]
        public const int XAPO_FLAG_FRAMERATE_MUST_MATCH = 0x00000002;

        [NativeTypeName("#define XAPO_FLAG_BITSPERSAMPLE_MUST_MATCH 0x00000004")]
        public const int XAPO_FLAG_BITSPERSAMPLE_MUST_MATCH = 0x00000004;

        [NativeTypeName("#define XAPO_FLAG_BUFFERCOUNT_MUST_MATCH 0x00000008")]
        public const int XAPO_FLAG_BUFFERCOUNT_MUST_MATCH = 0x00000008;

        [NativeTypeName("#define XAPO_FLAG_INPLACE_REQUIRED 0x00000020")]
        public const int XAPO_FLAG_INPLACE_REQUIRED = 0x00000020;

        [NativeTypeName("#define XAPO_FLAG_INPLACE_SUPPORTED 0x00000010")]
        public const int XAPO_FLAG_INPLACE_SUPPORTED = 0x00000010;

        public static ref readonly Guid IID_IXAPO
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0xB9, 0x10, 0xA4,
                    0x39, 0x98,
                    0x19, 0x48,
                    0xA0,
                    0xBE,
                    0x28,
                    0x56,
                    0xAE,
                    0x6B,
                    0x3A,
                    0xDB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IXAPOParameters
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x5C, 0xD9, 0x26,
                    0xF2, 0x80,
                    0x9A, 0x49,
                    0xAD,
                    0x54,
                    0x5A,
                    0xE7,
                    0xF0,
                    0x1C,
                    0x6D,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
