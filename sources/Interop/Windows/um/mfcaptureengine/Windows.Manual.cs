// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int MF_CAPTURE_ENGINE_PREFERRED_SOURCE_STREAM_FOR_VIDEO_PREVIEW = unchecked((int)0xFFFFFFFA);

        public const int MF_CAPTURE_ENGINE_PREFERRED_SOURCE_STREAM_FOR_VIDEO_RECORD = unchecked((int)0xFFFFFFF9);

        public const int MF_CAPTURE_ENGINE_PREFERRED_SOURCE_STREAM_FOR_PHOTO = unchecked((int)0xFFFFFFF8);

        public const int MF_CAPTURE_ENGINE_PREFERRED_SOURCE_STREAM_FOR_AUDIO = unchecked((int)0xFFFFFFF7);

        public const int MF_CAPTURE_ENGINE_MEDIASOURCE = unchecked((int)0xFFFFFFFF);

        public static readonly Guid IID_IMFCaptureEngineOnEventCallback = new Guid(0xAEDA51C0, 0x9025, 0x4983, 0x90, 0x12, 0xDE, 0x59, 0x7B, 0x88, 0xB0, 0x89);

        public static readonly Guid IID_IMFCaptureEngineOnSampleCallback = new Guid(0x52150B82, 0xAB39, 0x4467, 0x98, 0x0F, 0xE4, 0x8B, 0xF0, 0x82, 0x2E, 0xCD);

        public static readonly Guid IID_IMFCaptureSink = new Guid(0x72D6135B, 0x35E9, 0x412C, 0xB9, 0x26, 0xFD, 0x52, 0x65, 0xF2, 0xA8, 0x85);

        public static readonly Guid IID_IMFCaptureRecordSink = new Guid(0x3323B55A, 0xF92A, 0x4FE2, 0x8E, 0xDC, 0xE9, 0xBF, 0xC0, 0x63, 0x4D, 0x77);

        public static readonly Guid IID_IMFCapturePreviewSink = new Guid(0x77346CFD, 0x5B49, 0x4D73, 0xAC, 0xE0, 0x5B, 0x52, 0xA8, 0x59, 0xF2, 0xE0);

        public static readonly Guid IID_IMFCapturePhotoSink = new Guid(0xD2D43CC8, 0x48BB, 0x4AA7, 0x95, 0xDB, 0x10, 0xC0, 0x69, 0x77, 0xE7, 0x77);

        public static readonly Guid IID_IMFCaptureSource = new Guid(0x439A42A8, 0x0D2C, 0x4505, 0xBE, 0x83, 0xF7, 0x9B, 0x2A, 0x05, 0xD5, 0xC4);

        public static readonly Guid IID_IMFCaptureEngine = new Guid(0xA6BBA433, 0x176B, 0x48B2, 0xB3, 0x75, 0x53, 0xAA, 0x03, 0x47, 0x32, 0x07);

        public static readonly Guid IID_IMFCaptureEngineClassFactory = new Guid(0x8F02D140, 0x56FC, 0x4302, 0xA7, 0x05, 0x3A, 0x97, 0xC7, 0x8B, 0xE7, 0x79);

        public static readonly Guid IID_IMFCaptureEngineOnSampleCallback2 = new Guid(0xE37CEED7, 0x340F, 0x4514, 0x9F, 0x4D, 0x9C, 0x2A, 0xE0, 0x26, 0x10, 0x0B);

        public static readonly Guid IID_IMFCaptureSink2 = new Guid(0xF9E4219E, 0x6197, 0x4B5E, 0xB8, 0x88, 0xBE, 0xE3, 0x10, 0xAB, 0x2C, 0x59);
    }
}
