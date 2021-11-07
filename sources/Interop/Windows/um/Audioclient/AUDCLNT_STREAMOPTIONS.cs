// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [Flags]
    [SupportedOSPlatform("windows8.1")]
    public enum AUDCLNT_STREAMOPTIONS
    {
        AUDCLNT_STREAMOPTIONS_NONE = 0,
        AUDCLNT_STREAMOPTIONS_RAW = 0x1,
        AUDCLNT_STREAMOPTIONS_MATCH_FORMAT = 0x2,
        AUDCLNT_STREAMOPTIONS_AMBISONICS = 0x4,
    }
}
