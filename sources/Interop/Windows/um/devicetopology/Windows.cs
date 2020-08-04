// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid EVENTCONTEXT_VOLUMESLIDER = new Guid(0xE2C2E9DE, 0x09B1, 0x4B04, 0x84, 0xE5, 0x07, 0x93, 0x12, 0x25, 0xEE, 0x04);

        [NativeTypeName("#define DEVTOPO_HARDWARE_INITIATED_EVENTCONTEXT \'draH\'")]
        public const int DEVTOPO_HARDWARE_INITIATED_EVENTCONTEXT = 0x64726148;
    }
}
