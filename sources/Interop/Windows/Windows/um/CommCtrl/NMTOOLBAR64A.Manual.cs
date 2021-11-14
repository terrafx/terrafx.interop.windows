// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct NMTOOLBAR64A
    {
        public NMHDR hdr;

        public int iItem;

        public TBBUTTON64 tbButton;

        public int cchText;

        [NativeTypeName("LPSTR")]
        public sbyte* pszText;

        public RECT rcButton;
    }
}
