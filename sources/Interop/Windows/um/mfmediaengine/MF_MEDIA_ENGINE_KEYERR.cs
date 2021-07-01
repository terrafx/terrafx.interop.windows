// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_MEDIA_ENGINE_KEYERR
    {
        MF_MEDIAENGINE_KEYERR_UNKNOWN = 1,
        MF_MEDIAENGINE_KEYERR_CLIENT = 2,
        MF_MEDIAENGINE_KEYERR_SERVICE = 3,
        MF_MEDIAENGINE_KEYERR_OUTPUT = 4,
        MF_MEDIAENGINE_KEYERR_HARDWARECHANGE = 5,
        MF_MEDIAENGINE_KEYERR_DOMAIN = 6,
    }
}
