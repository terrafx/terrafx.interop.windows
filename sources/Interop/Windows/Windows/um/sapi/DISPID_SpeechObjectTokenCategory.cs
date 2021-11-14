// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum DISPID_SpeechObjectTokenCategory
    {
        DISPID_SOTCId = 1,
        DISPID_SOTCDefault = (DISPID_SOTCId + 1),
        DISPID_SOTCSetId = (DISPID_SOTCDefault + 1),
        DISPID_SOTCGetDataKey = (DISPID_SOTCSetId + 1),
        DISPID_SOTCEnumerateTokens = (DISPID_SOTCGetDataKey + 1),
    }
}
