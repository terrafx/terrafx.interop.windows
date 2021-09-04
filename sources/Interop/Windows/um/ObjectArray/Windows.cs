// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjectArray.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IObjectArray = new Guid(0x92CA9DCD, 0x5622, 0x4BBA, 0xA8, 0x05, 0x5E, 0x9F, 0x54, 0x1B, 0xD8, 0xC9);

        public static readonly Guid IID_IObjectCollection = new Guid(0x5632B1A4, 0xE38A, 0x400A, 0x92, 0x8A, 0xD4, 0xCD, 0x63, 0x23, 0x02, 0x95);
    }
}
