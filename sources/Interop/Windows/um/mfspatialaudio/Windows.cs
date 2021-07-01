// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfspatialaudio.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IMFSpatialAudioObjectBuffer = new Guid(0xD396EC8C, 0x605E, 0x4249, 0x97, 0x8D, 0x72, 0xAD, 0x1C, 0x31, 0x28, 0x72);

        public static readonly Guid IID_IMFSpatialAudioSample = new Guid(0xABF28A9B, 0x3393, 0x4290, 0xBA, 0x79, 0x5F, 0xFC, 0x46, 0xD9, 0x86, 0xB2);
    }
}
