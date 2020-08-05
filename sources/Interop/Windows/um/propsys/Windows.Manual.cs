// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid LIBID_PropSysObjects = new Guid(0x2CDA3294, 0x6C4F, 0x4020, 0xB1, 0x61, 0x27, 0xC5, 0x30, 0xC8, 0x1F, 0xA6);
    }
}
