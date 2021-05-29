// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DISPID_SpeechPhraseReplacement
    {
        DISPID_SPRDisplayAttributes = 1,
        DISPID_SPRText = (DISPID_SPRDisplayAttributes + 1),
        DISPID_SPRFirstElement = (DISPID_SPRText + 1),
        DISPID_SPRNumberOfElements = (DISPID_SPRFirstElement + 1),
    }
}
