// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define SPATIAL_AUDIO_STANDARD_COMMANDS_START 200")]
        public const int SPATIAL_AUDIO_STANDARD_COMMANDS_START = 200;

        [NativeTypeName("#define SPATIAL_AUDIO_POSITION (SPATIAL_AUDIO_STANDARD_COMMANDS_START)")]
        public const int SPATIAL_AUDIO_POSITION = (200);

        [NativeTypeName("#define SPATIAL_AUDIO_POSITION_BYTE_COUNT (sizeof(float) * 3)")]
        public const uint SPATIAL_AUDIO_POSITION_BYTE_COUNT = unchecked(4 * 3);

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

        public static readonly Guid IID_ISpatialAudioMetadataItems = new Guid(0xBCD7C78F, 0x3098, 0x4F22, 0xB5, 0x47, 0xA2, 0xF2, 0x5A, 0x38, 0x12, 0x69);

        public static readonly Guid IID_ISpatialAudioMetadataWriter = new Guid(0x1B17CA01, 0x2955, 0x444D, 0xA4, 0x30, 0x53, 0x7D, 0xC5, 0x89, 0xA8, 0x44);

        public static readonly Guid IID_ISpatialAudioMetadataReader = new Guid(0xB78E86A2, 0x31D9, 0x4C32, 0x94, 0xD2, 0x7D, 0xF4, 0x0F, 0xC7, 0xEB, 0xEC);

        public static readonly Guid IID_ISpatialAudioMetadataCopier = new Guid(0xD224B233, 0xE251, 0x4FD0, 0x9C, 0xA2, 0xD5, 0xEC, 0xF9, 0xA6, 0x84, 0x04);

        public static readonly Guid IID_ISpatialAudioMetadataItemsBuffer = new Guid(0x42640A16, 0xE1BD, 0x42D9, 0x9F, 0xF6, 0x03, 0x1A, 0xB7, 0x1A, 0x2D, 0xBA);

        public static readonly Guid IID_ISpatialAudioMetadataClient = new Guid(0x777D4A3B, 0xF6FF, 0x4A26, 0x85, 0xDC, 0x68, 0xD7, 0xCD, 0xED, 0xA1, 0xD4);

        public static readonly Guid IID_ISpatialAudioObjectForMetadataCommands = new Guid(0x0DF2C94B, 0xF5F9, 0x472D, 0xAF, 0x6B, 0xC4, 0x6E, 0x0A, 0xC9, 0xCD, 0x05);

        public static readonly Guid IID_ISpatialAudioObjectForMetadataItems = new Guid(0xDDEA49FF, 0x3BC0, 0x4377, 0x8A, 0xAD, 0x9F, 0xBC, 0xFD, 0x80, 0x85, 0x66);

        public static readonly Guid IID_ISpatialAudioObjectRenderStreamForMetadata = new Guid(0xBBC9C907, 0x48D5, 0x4A2E, 0xA0, 0xC7, 0xF7, 0xF0, 0xD6, 0x7C, 0x1F, 0xB1);
    }
}
