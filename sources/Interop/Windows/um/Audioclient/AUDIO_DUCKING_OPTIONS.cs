// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum AUDIO_DUCKING_OPTIONS
    {
        AUDIO_DUCKING_OPTIONS_DEFAULT = 0,
        AUDIO_DUCKING_OPTIONS_DO_NOT_DUCK_OTHER_STREAMS = 0x1,
    }
}
