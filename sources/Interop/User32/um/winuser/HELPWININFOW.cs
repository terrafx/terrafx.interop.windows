// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct HELPWININFOW
    {
        public int wStructSize;

        public int x;

        public int y;

        public int dx;

        public int dy;

        public int wMax;

        [NativeTypeName("WCHAR [2]")]
        public fixed ushort rgchMember[2];
    }
}
