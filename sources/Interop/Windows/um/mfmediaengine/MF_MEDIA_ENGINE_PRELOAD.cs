// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public enum MF_MEDIA_ENGINE_PRELOAD
    {
        MF_MEDIA_ENGINE_PRELOAD_MISSING = 0,
        MF_MEDIA_ENGINE_PRELOAD_EMPTY = 1,
        MF_MEDIA_ENGINE_PRELOAD_NONE = 2,
        MF_MEDIA_ENGINE_PRELOAD_METADATA = 3,
        MF_MEDIA_ENGINE_PRELOAD_AUTOMATIC = 4,
    }
}
