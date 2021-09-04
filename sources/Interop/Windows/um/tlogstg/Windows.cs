// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define SID_STravelLogCursor IID_ITravelLogStg")]
        public static readonly Guid SID_STravelLogCursor = IID_ITravelLogStg;

        public static readonly Guid IID_ITravelLogEntry = new Guid(0x7EBFDD87, 0xAD18, 0x11D3, 0xA4, 0xC5, 0x00, 0xC0, 0x4F, 0x72, 0xD6, 0xB8);

        public static readonly Guid IID_ITravelLogClient = new Guid(0x241C033E, 0xE659, 0x43DA, 0xAA, 0x4D, 0x40, 0x86, 0xDB, 0xC4, 0x75, 0x8D);

        public static readonly Guid IID_IEnumTravelLogEntry = new Guid(0x7EBFDD85, 0xAD18, 0x11D3, 0xA4, 0xC5, 0x00, 0xC0, 0x4F, 0x72, 0xD6, 0xB8);

        public static readonly Guid IID_ITravelLogStg = new Guid(0x7EBFDD80, 0xAD18, 0x11D3, 0xA4, 0xC5, 0x00, 0xC0, 0x4F, 0x72, 0xD6, 0xB8);
    }
}
