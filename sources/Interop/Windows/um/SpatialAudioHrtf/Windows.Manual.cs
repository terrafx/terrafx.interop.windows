// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IID_ISpatialAudioObjectForHrtf = new Guid(0xD7436ADE, 0x1978, 0x4E14, 0xAB, 0xA0, 0x55, 0x5B, 0xD8, 0xEB, 0x83, 0xB4);

        public static readonly Guid IID_ISpatialAudioObjectRenderStreamForHrtf = new Guid(0xE08DEEF9, 0x5363, 0x406E, 0x9F, 0xDC, 0x08, 0x0E, 0xE2, 0x47, 0xBB, 0xE0);
    }
}
