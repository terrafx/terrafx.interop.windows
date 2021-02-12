// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DISPID_SpeechAudioFormat
    {
        DISPID_SAFType = 1,
        DISPID_SAFGuid = (DISPID_SAFType + 1),
        DISPID_SAFGetWaveFormatEx = (DISPID_SAFGuid + 1),
        DISPID_SAFSetWaveFormatEx = (DISPID_SAFGetWaveFormatEx + 1),
    }
}
