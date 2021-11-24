// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SPWORDPRONOUNCEABLE;

namespace TerraFX.Interop.Windows;

public enum SpeechWordPronounceable
{
    SWPUnknownWordUnpronounceable = SPWP_UNKNOWN_WORD_UNPRONOUNCEABLE,
    SWPUnknownWordPronounceable = SPWP_UNKNOWN_WORD_PRONOUNCEABLE,
    SWPKnownWordPronounceable = SPWP_KNOWN_WORD_PRONOUNCEABLE,
}
