// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ImageTranscode.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_ITranscodeImage = new Guid(0xBAE86DDD, 0xDC11, 0x421C, 0xB7, 0xAB, 0xCC, 0x55, 0xD1, 0xD6, 0x5C, 0x44);

        public static readonly Guid IID_ImageTranscode = new Guid(0x17B75166, 0x928F, 0x417D, 0x96, 0x85, 0x64, 0xAA, 0x13, 0x55, 0x65, 0xC1);
    }
}
