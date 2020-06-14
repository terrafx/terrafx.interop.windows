// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DISPID_SpeechAudioStatus
    {
        DISPID_SASFreeBufferSpace = 1,
        DISPID_SASNonBlockingIO = (DISPID_SASFreeBufferSpace + 1),
        DISPID_SASState = (DISPID_SASNonBlockingIO + 1),
        DISPID_SASCurrentSeekPosition = (DISPID_SASState + 1),
        DISPID_SASCurrentDevicePosition = (DISPID_SASCurrentSeekPosition + 1),
    }
}
