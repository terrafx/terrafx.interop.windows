// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define SPATIAL_AUDIO_STANDARD_COMMANDS_START 200")]
        public const int SPATIAL_AUDIO_STANDARD_COMMANDS_START = 200;

        [NativeTypeName("#define SPATIAL_AUDIO_POSITION (SPATIAL_AUDIO_STANDARD_COMMANDS_START)")]
        public const int SPATIAL_AUDIO_POSITION = (200);

        [NativeTypeName("#define SPATIAL_AUDIO_POSITION_BYTE_COUNT (sizeof(float) * 3)")]
        public const uint SPATIAL_AUDIO_POSITION_BYTE_COUNT = (4 * 3);

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_COMMAND_NOT_FOUND AUDCLNT_ERR(0x0200)")]
        public const int SPTLAUD_MD_CLNT_E_COMMAND_NOT_FOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0200))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_OBJECT_NOT_INITIALIZED AUDCLNT_ERR(0x0201)")]
        public const int SPTLAUD_MD_CLNT_E_OBJECT_NOT_INITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0201))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_INVALID_ARGS AUDCLNT_ERR(0x0202)")]
        public const int SPTLAUD_MD_CLNT_E_INVALID_ARGS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0202))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_METADATA_FORMAT_NOT_FOUND AUDCLNT_ERR(0x0203)")]
        public const int SPTLAUD_MD_CLNT_E_METADATA_FORMAT_NOT_FOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0203))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_VALUE_BUFFER_INCORRECT_SIZE AUDCLNT_ERR(0x0204)")]
        public const int SPTLAUD_MD_CLNT_E_VALUE_BUFFER_INCORRECT_SIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0204))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_MEMORY_BOUNDS AUDCLNT_ERR(0x0205)")]
        public const int SPTLAUD_MD_CLNT_E_MEMORY_BOUNDS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0205))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_MORE_COMMANDS AUDCLNT_ERR(0x0206)")]
        public const int SPTLAUD_MD_CLNT_E_NO_MORE_COMMANDS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0206))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_BUFFER_ALREADY_ATTACHED AUDCLNT_ERR(0x0207)")]
        public const int SPTLAUD_MD_CLNT_E_BUFFER_ALREADY_ATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0207))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_BUFFER_NOT_ATTACHED AUDCLNT_ERR(0x0208)")]
        public const int SPTLAUD_MD_CLNT_E_BUFFER_NOT_ATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0208))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_FRAMECOUNT_OUT_OF_RANGE AUDCLNT_ERR(0x0209)")]
        public const int SPTLAUD_MD_CLNT_E_FRAMECOUNT_OUT_OF_RANGE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0209))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_ITEMS_FOUND AUDCLNT_ERR(0x0210)")]
        public const int SPTLAUD_MD_CLNT_E_NO_ITEMS_FOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0210))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ITEM_COPY_OVERFLOW AUDCLNT_ERR(0x0211)")]
        public const int SPTLAUD_MD_CLNT_E_ITEM_COPY_OVERFLOW = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0211))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_ITEMS_OPEN AUDCLNT_ERR(0x0212)")]
        public const int SPTLAUD_MD_CLNT_E_NO_ITEMS_OPEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0212))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ITEMS_ALREADY_OPEN AUDCLNT_ERR(0x0213)")]
        public const int SPTLAUD_MD_CLNT_E_ITEMS_ALREADY_OPEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0213))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ATTACH_FAILED_INTERNAL_BUFFER AUDCLNT_ERR(0x0214)")]
        public const int SPTLAUD_MD_CLNT_E_ATTACH_FAILED_INTERNAL_BUFFER = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0214))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_DETACH_FAILED_INTERNAL_BUFFER AUDCLNT_ERR(0x0215)")]
        public const int SPTLAUD_MD_CLNT_E_DETACH_FAILED_INTERNAL_BUFFER = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0215))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_BUFFER_ATTACHED AUDCLNT_ERR(0x0216)")]
        public const int SPTLAUD_MD_CLNT_E_NO_BUFFER_ATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0216))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_MORE_ITEMS AUDCLNT_ERR(0x0217)")]
        public const int SPTLAUD_MD_CLNT_E_NO_MORE_ITEMS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0217))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_FRAMEOFFSET_OUT_OF_RANGE AUDCLNT_ERR(0x0218)")]
        public const int SPTLAUD_MD_CLNT_E_FRAMEOFFSET_OUT_OF_RANGE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0218))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ITEM_MUST_HAVE_COMMANDS AUDCLNT_ERR(0x0219)")]
        public const int SPTLAUD_MD_CLNT_E_ITEM_MUST_HAVE_COMMANDS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0219))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_ITEMOFFSET_WRITTEN AUDCLNT_ERR(0x0220)")]
        public const int SPTLAUD_MD_CLNT_E_NO_ITEMOFFSET_WRITTEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0220))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_NO_ITEMS_WRITTEN AUDCLNT_ERR(0x0221)")]
        public const int SPTLAUD_MD_CLNT_E_NO_ITEMS_WRITTEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0221))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_COMMAND_ALREADY_WRITTEN AUDCLNT_ERR(0x0222)")]
        public const int SPTLAUD_MD_CLNT_E_COMMAND_ALREADY_WRITTEN = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0222))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_FORMAT_MISMATCH AUDCLNT_ERR(0x0223)")]
        public const int SPTLAUD_MD_CLNT_E_FORMAT_MISMATCH = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0223))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_BUFFER_STILL_ATTACHED AUDCLNT_ERR(0x0224)")]
        public const int SPTLAUD_MD_CLNT_E_BUFFER_STILL_ATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0224))));

        [NativeTypeName("#define SPTLAUD_MD_CLNT_E_ITEMS_LOCKED_FOR_WRITING AUDCLNT_ERR(0x0225)")]
        public const int SPTLAUD_MD_CLNT_E_ITEMS_LOCKED_FOR_WRITING = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0225))));

        public static ref readonly Guid IID_ISpatialAudioMetadataItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8F, 0xC7, 0xD7, 0xBC,
                    0x98, 0x30,
                    0x22, 0x4F,
                    0xB5,
                    0x47,
                    0xA2,
                    0xF2,
                    0x5A,
                    0x38,
                    0x12,
                    0x69
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpatialAudioMetadataWriter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0xCA, 0x17, 0x1B,
                    0x55, 0x29,
                    0x4D, 0x44,
                    0xA4,
                    0x30,
                    0x53,
                    0x7D,
                    0xC5,
                    0x89,
                    0xA8,
                    0x44
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpatialAudioMetadataReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x86, 0x8E, 0xB7,
                    0xD9, 0x31,
                    0x32, 0x4C,
                    0x94,
                    0xD2,
                    0x7D,
                    0xF4,
                    0x0F,
                    0xC7,
                    0xEB,
                    0xEC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpatialAudioMetadataCopier
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0xB2, 0x24, 0xD2,
                    0x51, 0xE2,
                    0xD0, 0x4F,
                    0x9C,
                    0xA2,
                    0xD5,
                    0xEC,
                    0xF9,
                    0xA6,
                    0x84,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpatialAudioMetadataItemsBuffer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x0A, 0x64, 0x42,
                    0xBD, 0xE1,
                    0xD9, 0x42,
                    0x9F,
                    0xF6,
                    0x03,
                    0x1A,
                    0xB7,
                    0x1A,
                    0x2D,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpatialAudioMetadataClient
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0x4A, 0x7D, 0x77,
                    0xFF, 0xF6,
                    0x26, 0x4A,
                    0x85,
                    0xDC,
                    0x68,
                    0xD7,
                    0xCD,
                    0xED,
                    0xA1,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpatialAudioObjectForMetadataCommands
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4B, 0xC9, 0xF2, 0x0D,
                    0xF9, 0xF5,
                    0x2D, 0x47,
                    0xAF,
                    0x6B,
                    0xC4,
                    0x6E,
                    0x0A,
                    0xC9,
                    0xCD,
                    0x05
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpatialAudioObjectForMetadataItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFF, 0x49, 0xEA, 0xDD,
                    0xC0, 0x3B,
                    0x77, 0x43,
                    0x8A,
                    0xAD,
                    0x9F,
                    0xBC,
                    0xFD,
                    0x80,
                    0x85,
                    0x66
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISpatialAudioObjectRenderStreamForMetadata
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0xC9, 0xC9, 0xBB,
                    0xD5, 0x48,
                    0x2E, 0x4A,
                    0xA0,
                    0xC7,
                    0xF7,
                    0xF0,
                    0xD6,
                    0x7C,
                    0x1F,
                    0xB1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
