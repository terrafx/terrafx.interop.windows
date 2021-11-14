// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct NMLVCUSTOMDRAW
    {
        public NMCUSTOMDRAW nmcd;

        public COLORREF clrText;

        public COLORREF clrTextBk;

        public int iSubItem;

        [NativeTypeName("DWORD")]
        public uint dwItemType;

        public COLORREF clrFace;

        public int iIconEffect;

        public int iIconPhase;

        public int iPartId;

        public int iStateId;

        public RECT rcText;

        public uint uAlign;
    }
}
