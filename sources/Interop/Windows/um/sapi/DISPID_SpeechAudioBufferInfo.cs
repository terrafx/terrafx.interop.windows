// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DISPID_SpeechAudioBufferInfo
    {
        DISPID_SABIMinNotification = 1,
        DISPID_SABIBufferSize = (DISPID_SABIMinNotification + 1),
        DISPID_SABIEventBias = (DISPID_SABIBufferSize + 1),
    }
}
