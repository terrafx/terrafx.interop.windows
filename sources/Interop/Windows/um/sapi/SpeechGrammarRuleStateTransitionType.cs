// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SpeechGrammarRuleStateTransitionType
    {
        SGRSTTEpsilon = 0,
        SGRSTTWord = (SGRSTTEpsilon + 1),
        SGRSTTRule = (SGRSTTWord + 1),
        SGRSTTDictation = (SGRSTTRule + 1),
        SGRSTTWildcard = (SGRSTTDictation + 1),
        SGRSTTTextBuffer = (SGRSTTWildcard + 1),
    }
}
