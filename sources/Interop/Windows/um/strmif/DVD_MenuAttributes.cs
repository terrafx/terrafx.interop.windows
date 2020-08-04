// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DVD_MenuAttributes
    {
        [NativeTypeName("BOOL [8]")]
        public fixed int fCompatibleRegion[8];

        public DVD_VideoAttributes VideoAttributes;

        [NativeTypeName("BOOL")]
        public int fAudioPresent;

        public DVD_AudioAttributes AudioAttributes;

        [NativeTypeName("BOOL")]
        public int fSubpicturePresent;

        public DVD_SubpictureAttributes SubpictureAttributes;
    }
}
