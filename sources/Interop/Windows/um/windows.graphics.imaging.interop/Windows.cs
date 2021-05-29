// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_SoftwareBitmapNativeFactory = new Guid(0x84e65691, 0x8602, 0x4a84, 0xbe, 0x46, 0x70, 0x8b, 0xe9, 0xcd, 0x4b, 0x74);

        public static readonly Guid IID_ISoftwareBitmapNative = new Guid(0x94BC8415, 0x04EA, 0x4B2E, 0xAF, 0x13, 0x4D, 0xE9, 0x5A, 0xA8, 0x98, 0xEB);

        public static readonly Guid IID_ISoftwareBitmapNativeFactory = new Guid(0xC3C181EC, 0x2914, 0x4791, 0xAF, 0x02, 0x02, 0xD2, 0x24, 0xA1, 0x0B, 0x43);
    }
}
