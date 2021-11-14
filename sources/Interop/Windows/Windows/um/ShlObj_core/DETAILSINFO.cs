// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct DETAILSINFO
    {
        [NativeTypeName("LPCITEMIDLIST")]
        public ITEMIDLIST* pidl;

        public int fmt;

        public int cxChar;

        public STRRET str;

        public int iImage;
    }
}
