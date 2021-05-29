// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_MEDIA_ENGINE_OPM_STATUS
    {
        MF_MEDIA_ENGINE_OPM_NOT_REQUESTED = 0,
        MF_MEDIA_ENGINE_OPM_ESTABLISHED = 1,
        MF_MEDIA_ENGINE_OPM_FAILED_VM = 2,
        MF_MEDIA_ENGINE_OPM_FAILED_BDA = 3,
        MF_MEDIA_ENGINE_OPM_FAILED_UNSIGNED_DRIVER = 4,
        MF_MEDIA_ENGINE_OPM_FAILED = 5,
    }
}
