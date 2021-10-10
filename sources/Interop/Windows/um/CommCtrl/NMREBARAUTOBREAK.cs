// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct NMREBARAUTOBREAK
    {
        public NMHDR hdr;

        [NativeTypeName("UINT")]
        public uint uBand;

        [NativeTypeName("UINT")]
        public uint wID;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("UINT")]
        public uint uMsg;

        [NativeTypeName("UINT")]
        public uint fStyleCurrent;

        [NativeTypeName("BOOL")]
        public int fAutoBreak;
    }
}
