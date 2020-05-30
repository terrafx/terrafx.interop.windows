// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AudioSessionTypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AUDIO_STREAM_CATEGORY
    {
        AudioCategory_Other = 0,
        AudioCategory_ForegroundOnlyMedia = 1,
        AudioCategory_Communications = 3,
        AudioCategory_Alerts = 4,
        AudioCategory_SoundEffects = 5,
        AudioCategory_GameEffects = 6,
        AudioCategory_GameMedia = 7,
        AudioCategory_GameChat = 8,
        AudioCategory_Speech = 9,
        AudioCategory_Movie = 10,
        AudioCategory_Media = 11,
    }
}
