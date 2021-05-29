// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DVD_AUDIO_FORMAT
    {
        DVD_AudioFormat_AC3 = 0,
        DVD_AudioFormat_MPEG1 = 1,
        DVD_AudioFormat_MPEG1_DRC = 2,
        DVD_AudioFormat_MPEG2 = 3,
        DVD_AudioFormat_MPEG2_DRC = 4,
        DVD_AudioFormat_LPCM = 5,
        DVD_AudioFormat_DTS = 6,
        DVD_AudioFormat_SDDS = 7,
        DVD_AudioFormat_Other = 8,
    }
}
