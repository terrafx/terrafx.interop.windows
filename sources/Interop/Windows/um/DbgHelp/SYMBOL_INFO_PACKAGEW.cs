// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SYMBOL_INFO_PACKAGEW
    {
        public SYMBOL_INFOW si;

        [NativeTypeName("WCHAR [2001]")]
        public fixed ushort name[2001];
    }
}
