// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct NMTBRESTORE64
    {
        public NMHDR hdr;

        [NativeTypeName("DWORD *")]
        public uint* pData;

        [NativeTypeName("DWORD *")]
        public uint* pCurrent;

        [NativeTypeName("UINT")]
        public uint cbData;

        public int iItem;

        public int cButtons;

        public int cbBytesPerRecord;

        public TBBUTTON64 tbButton;
    }
}
