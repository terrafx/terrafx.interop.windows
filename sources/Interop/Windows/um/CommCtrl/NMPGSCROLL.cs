// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct NMPGSCROLL
    {
        public NMHDR hdr;

        [NativeTypeName("WORD")]
        public ushort fwKeys;

        public RECT rcParent;

        public int iDir;

        public int iXpos;

        public int iYpos;

        public int iScroll;
    }
}
