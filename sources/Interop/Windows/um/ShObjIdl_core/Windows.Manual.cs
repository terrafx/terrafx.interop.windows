// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid CLSID_ShellLibrary = new Guid(0xD9B3211D, 0xE57F, 0x4426, 0xAA, 0xEF, 0x30, 0xA8, 0x06, 0xAD, 0xD3, 0x97);
    }
}
