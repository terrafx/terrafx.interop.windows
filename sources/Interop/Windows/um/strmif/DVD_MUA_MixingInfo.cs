// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DVD_MUA_MixingInfo
    {
        [NativeTypeName("BOOL")]
        public int fMixTo0;

        [NativeTypeName("BOOL")]
        public int fMixTo1;

        [NativeTypeName("BOOL")]
        public int fMix0InPhase;

        [NativeTypeName("BOOL")]
        public int fMix1InPhase;

        [NativeTypeName("DWORD")]
        public uint dwSpeakerPosition;
    }
}
