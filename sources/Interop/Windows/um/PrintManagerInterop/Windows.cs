// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PrintManagerInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IPrintManagerInterop = new Guid(0xC5435A42, 0x8D43, 0x4E7B, 0xA6, 0x8A, 0xEF, 0x31, 0x1E, 0x39, 0x20, 0x87);
    }
}
