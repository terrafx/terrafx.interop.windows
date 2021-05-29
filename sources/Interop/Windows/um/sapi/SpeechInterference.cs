// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.SPINTERFERENCE;

namespace TerraFX.Interop
{
    public enum SpeechInterference
    {
        SINone = SPINTERFERENCE_NONE,
        SINoise = SPINTERFERENCE_NOISE,
        SINoSignal = SPINTERFERENCE_NOSIGNAL,
        SITooLoud = SPINTERFERENCE_TOOLOUD,
        SITooQuiet = SPINTERFERENCE_TOOQUIET,
        SITooFast = SPINTERFERENCE_TOOFAST,
        SITooSlow = SPINTERFERENCE_TOOSLOW,
    }
}
