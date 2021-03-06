// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct VIDEO_STREAM_CONFIG_CAPS
    {
        [NativeTypeName("GUID")]
        public Guid guid;

        [NativeTypeName("ULONG")]
        public uint VideoStandard;

        public SIZE InputSize;

        public SIZE MinCroppingSize;

        public SIZE MaxCroppingSize;

        public int CropGranularityX;

        public int CropGranularityY;

        public int CropAlignX;

        public int CropAlignY;

        public SIZE MinOutputSize;

        public SIZE MaxOutputSize;

        public int OutputGranularityX;

        public int OutputGranularityY;

        public int StretchTapsX;

        public int StretchTapsY;

        public int ShrinkTapsX;

        public int ShrinkTapsY;

        [NativeTypeName("LONGLONG")]
        public long MinFrameInterval;

        [NativeTypeName("LONGLONG")]
        public long MaxFrameInterval;

        [NativeTypeName("LONG")]
        public int MinBitsPerSecond;

        [NativeTypeName("LONG")]
        public int MaxBitsPerSecond;
    }
}
