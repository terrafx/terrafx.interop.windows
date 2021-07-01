// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dragdropinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IDragDropManagerInterop = new Guid(0x5AD8CBA7, 0x4C01, 0x4DAC, 0x90, 0x74, 0x82, 0x78, 0x94, 0x29, 0x2D, 0x63);
    }
}
