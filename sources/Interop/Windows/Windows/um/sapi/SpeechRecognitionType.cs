// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SPRECOEVENTFLAGS;

namespace TerraFX.Interop.Windows
{
    public enum SpeechRecognitionType
    {
        SRTStandard = 0,
        SRTAutopause = SPREF_AutoPause,
        SRTEmulated = SPREF_Emulated,
        SRTSMLTimeout = SPREF_SMLTimeout,
        SRTExtendableParse = SPREF_ExtendableParse,
        SRTReSent = SPREF_ReSent,
    }
}
