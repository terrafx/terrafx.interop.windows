// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_MEDIA_ENGINE_CREATEFLAGS
    {
        MF_MEDIA_ENGINE_AUDIOONLY = 0x1,
        MF_MEDIA_ENGINE_WAITFORSTABLE_STATE = 0x2,
        MF_MEDIA_ENGINE_FORCEMUTE = 0x4,
        MF_MEDIA_ENGINE_REAL_TIME_MODE = 0x8,
        MF_MEDIA_ENGINE_DISABLE_LOCAL_PLUGINS = 0x10,
        MF_MEDIA_ENGINE_CREATEFLAGS_MASK = 0x1f,
    }
}
