// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static readonly Guid IID_IAMFilterGraphCallback = new Guid(0x56a868fd, 0x0ad4, 0x11ce, 0xb0, 0xa3, 0x0, 0x20, 0xaf, 0x0b, 0xa7, 0x70);
    }
}
