// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct EXTRASEARCH
    {
        public Guid guidSearch;

        [NativeTypeName("WCHAR [80]")]
        public fixed ushort wszFriendlyName[80];

        [NativeTypeName("WCHAR [2084]")]
        public fixed ushort wszUrl[2084];
    }
}
