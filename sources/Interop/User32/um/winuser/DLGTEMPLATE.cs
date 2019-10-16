// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DLGTEMPLATE
    {
        [NativeTypeName("DWORD")]
        public uint style;

        [NativeTypeName("DWORD")]
        public uint dwExtendedStyle;

        [NativeTypeName("WORD")]
        public ushort cdit;

        public short x;

        public short y;

        public short cx;

        public short cy;
    }
}
