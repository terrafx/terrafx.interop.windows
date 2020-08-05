// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IAdvancedMediaCaptureInitializationSettings = new Guid(0x3DE21209, 0x8BA6, 0x4F2A, 0xA5, 0x77, 0x28, 0x19, 0xB5, 0x6F, 0xF1, 0x4D);

        public static readonly Guid IID_IAdvancedMediaCaptureSettings = new Guid(0x24E0485F, 0xA33E, 0x4AA1, 0xB5, 0x64, 0x60, 0x19, 0xB1, 0xD1, 0x4F, 0x65);

        public static readonly Guid IID_IAdvancedMediaCapture = new Guid(0xD0751585, 0xD216, 0x4344, 0xB5, 0xBF, 0x46, 0x3B, 0x68, 0xF9, 0x77, 0xBB);
    }
}
