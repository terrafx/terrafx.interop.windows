// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define ENDPOINT_HARDWARE_SUPPORT_VOLUME 0x00000001")]
        public const int ENDPOINT_HARDWARE_SUPPORT_VOLUME = 0x00000001;

        [NativeTypeName("#define ENDPOINT_HARDWARE_SUPPORT_MUTE 0x00000002")]
        public const int ENDPOINT_HARDWARE_SUPPORT_MUTE = 0x00000002;

        [NativeTypeName("#define ENDPOINT_HARDWARE_SUPPORT_METER 0x00000004")]
        public const int ENDPOINT_HARDWARE_SUPPORT_METER = 0x00000004;

        public static readonly Guid IID_IAudioEndpointVolumeCallback = new Guid(0x657804FA, 0xD6AD, 0x4496, 0x8A, 0x60, 0x35, 0x27, 0x52, 0xAF, 0x4F, 0x89);

        public static readonly Guid IID_IAudioEndpointVolume = new Guid(0x5CDF2C82, 0x841E, 0x4546, 0x97, 0x22, 0x0C, 0xF7, 0x40, 0x78, 0x22, 0x9A);

        public static readonly Guid IID_IAudioEndpointVolumeEx = new Guid(0x66E11784, 0xF695, 0x4F28, 0xA5, 0x05, 0xA7, 0x08, 0x00, 0x81, 0xA7, 0x8F);

        public static readonly Guid IID_IAudioMeterInformation = new Guid(0xC02216F6, 0x8C67, 0x4B5B, 0x9D, 0x00, 0xD0, 0x08, 0xE7, 0x3E, 0x00, 0x64);
    }
}
