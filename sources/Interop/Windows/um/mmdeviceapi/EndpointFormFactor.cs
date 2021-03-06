// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum EndpointFormFactor
    {
        RemoteNetworkDevice = 0,
        Speakers = (RemoteNetworkDevice + 1),
        LineLevel = (Speakers + 1),
        Headphones = (LineLevel + 1),
        Microphone = (Headphones + 1),
        Headset = (Microphone + 1),
        Handset = (Headset + 1),
        UnknownDigitalPassthrough = (Handset + 1),
        SPDIF = (UnknownDigitalPassthrough + 1),
        DigitalAudioDisplayDevice = (SPDIF + 1),
        UnknownFormFactor = (DigitalAudioDisplayDevice + 1),
        EndpointFormFactor_enum_count = (UnknownFormFactor + 1),
    }
}
