// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DVD_VideoAttributes
    {
        [NativeTypeName("BOOL")]
        public int fPanscanPermitted;

        [NativeTypeName("BOOL")]
        public int fLetterboxPermitted;

        [NativeTypeName("ULONG")]
        public uint ulAspectX;

        [NativeTypeName("ULONG")]
        public uint ulAspectY;

        [NativeTypeName("ULONG")]
        public uint ulFrameRate;

        [NativeTypeName("ULONG")]
        public uint ulFrameHeight;

        public DVD_VIDEO_COMPRESSION Compression;

        [NativeTypeName("BOOL")]
        public int fLine21Field1InGOP;

        [NativeTypeName("BOOL")]
        public int fLine21Field2InGOP;

        [NativeTypeName("ULONG")]
        public uint ulSourceResolutionX;

        [NativeTypeName("ULONG")]
        public uint ulSourceResolutionY;

        [NativeTypeName("BOOL")]
        public int fIsSourceLetterboxed;

        [NativeTypeName("BOOL")]
        public int fIsFilmMode;
    }
}
