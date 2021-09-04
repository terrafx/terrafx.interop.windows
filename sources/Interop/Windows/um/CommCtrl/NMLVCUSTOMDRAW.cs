// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct NMLVCUSTOMDRAW
    {
        [NativeTypeName("NMCUSTOMDRAW")]
        public NMCUSTOMDRAWINFO nmcd;

        [NativeTypeName("COLORREF")]
        public uint clrText;

        [NativeTypeName("COLORREF")]
        public uint clrTextBk;

        public int iSubItem;

        [NativeTypeName("DWORD")]
        public uint dwItemType;

        [NativeTypeName("COLORREF")]
        public uint clrFace;

        public int iIconEffect;

        public int iIconPhase;

        public int iPartId;

        public int iStateId;

        public RECT rcText;

        [NativeTypeName("UINT")]
        public uint uAlign;
    }
}
