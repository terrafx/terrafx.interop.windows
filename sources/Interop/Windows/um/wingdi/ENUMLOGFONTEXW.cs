// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ENUMLOGFONTEXW
    {
        public LOGFONTW elfLogFont;

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort elfFullName[64];

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort elfStyle[32];

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort elfScript[32];
    }
}
