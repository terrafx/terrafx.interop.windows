// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IMEMENUITEMINFOA
    {
        public uint cbSize;

        public uint fType;

        public uint fState;

        public uint wID;

        public HBITMAP hbmpChecked;

        public HBITMAP hbmpUnchecked;

        [NativeTypeName("DWORD")]
        public uint dwItemData;

        [NativeTypeName("CHAR [80]")]
        public fixed sbyte szString[80];

        public HBITMAP hbmpItem;
    }
}
