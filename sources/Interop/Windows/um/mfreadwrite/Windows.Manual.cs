// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int MF_SOURCE_READER_INVALID_STREAM_INDEX = unchecked((int)0xFFFFFFFF);

        public const int MF_SOURCE_READER_ALL_STREAMS = unchecked((int)0xFFFFFFFE);

        public const int MF_SOURCE_READER_ANY_STREAM = unchecked((int)0xFFFFFFFE);

        public const int MF_SOURCE_READER_FIRST_AUDIO_STREAM = unchecked((int)0xFFFFFFFD);

        public const int MF_SOURCE_READER_FIRST_VIDEO_STREAM = unchecked((int)0xFFFFFFFC);

        public const int MF_SOURCE_READER_MEDIASOURCE = unchecked((int)0xFFFFFFFF);

        public const int MF_SOURCE_READER_CURRENT_TYPE_INDEX = unchecked((int)0xFFFFFFFF);

        public const int MF_SINK_WRITER_INVALID_STREAM_INDEX = unchecked((int)0xFFFFFFFF);

        public const int MF_SINK_WRITER_ALL_STREAMS = unchecked((int)0xFFFFFFFE);

        public const int MF_SINK_WRITER_MEDIASINK = unchecked((int)0xFFFFFFFF);

        public static readonly Guid IID_IMFReadWriteClassFactory = new Guid(0xE7FE2E12, 0x661C, 0x40DA, 0x92, 0xF9, 0x4F, 0x00, 0x2A, 0xB6, 0x76, 0x27);

        public static readonly Guid IID_IMFSourceReader = new Guid(0x70AE66F2, 0xC809, 0x4E4F, 0x89, 0x15, 0xBD, 0xCB, 0x40, 0x6B, 0x79, 0x93);

        public static readonly Guid IID_IMFSourceReaderEx = new Guid(0x7B981CF0, 0x560E, 0x4116, 0x98, 0x75, 0xB0, 0x99, 0x89, 0x5F, 0x23, 0xD7);

        public static readonly Guid IID_IMFSourceReaderCallback = new Guid(0xDEEC8D99, 0xFA1D, 0x4D82, 0x84, 0xC2, 0x2C, 0x89, 0x69, 0x94, 0x48, 0x67);

        public static readonly Guid IID_IMFSourceReaderCallback2 = new Guid(0xCF839FE6, 0x8C2A, 0x4DD2, 0xB6, 0xEA, 0xC2, 0x2D, 0x69, 0x61, 0xAF, 0x05);

        public static readonly Guid IID_IMFSinkWriter = new Guid(0x3137F1CD, 0xFE5E, 0x4805, 0xA5, 0xD8, 0xFB, 0x47, 0x74, 0x48, 0xCB, 0x3D);

        public static readonly Guid IID_IMFSinkWriterEx = new Guid(0x588D72AB, 0x5BC1, 0x496A, 0x87, 0x14, 0xB7, 0x06, 0x17, 0x14, 0x1B, 0x25);

        public static readonly Guid IID_IMFSinkWriterEncoderConfig = new Guid(0x17C3779E, 0x3CDE, 0x4EDE, 0x8C, 0x60, 0x38, 0x99, 0xF5, 0xF5, 0x3A, 0xD6);

        public static readonly Guid IID_IMFSinkWriterCallback = new Guid(0x666F76DE, 0x33D2, 0x41B9, 0xA4, 0x58, 0x29, 0xED, 0x0A, 0x97, 0x2C, 0x58);

        public static readonly Guid IID_IMFSinkWriterCallback2 = new Guid(0x2456BD58, 0xC067, 0x4513, 0x84, 0xFE, 0x8D, 0x0C, 0x88, 0xFF, 0xDC, 0x61);
    }
}
