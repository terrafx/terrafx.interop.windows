// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_MEDIA_ENGINE_READY
    {
        MF_MEDIA_ENGINE_READY_HAVE_NOTHING = 0,
        MF_MEDIA_ENGINE_READY_HAVE_METADATA = 1,
        MF_MEDIA_ENGINE_READY_HAVE_CURRENT_DATA = 2,
        MF_MEDIA_ENGINE_READY_HAVE_FUTURE_DATA = 3,
        MF_MEDIA_ENGINE_READY_HAVE_ENOUGH_DATA = 4,
    }
}
