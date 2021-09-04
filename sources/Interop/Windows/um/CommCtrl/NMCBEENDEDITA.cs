// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NMCBEENDEDITA
    {
        public NMHDR hdr;

        [NativeTypeName("BOOL")]
        public int fChanged;

        public int iNewSelection;

        [NativeTypeName("char [260]")]
        public fixed sbyte szText[260];

        public int iWhy;
    }
}
