// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SPGRAMMARWORDTYPE;

namespace TerraFX.Interop.Windows;

public enum SpeechGrammarWordType
{
    SGDisplay = SPWT_DISPLAY,
    SGLexical = SPWT_LEXICAL,
    SGPronounciation = SPWT_PRONUNCIATION,
    SGLexicalNoSpecialChars = SPWT_LEXICAL_NO_SPECIAL_CHARS,
}
