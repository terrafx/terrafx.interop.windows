// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct RAWKEYBOARD
    {
        [NativeTypeName("USHORT")]
        public ushort MakeCode;

        [NativeTypeName("USHORT")]
        public ushort Flags;

        [NativeTypeName("USHORT")]
        public ushort Reserved;

        [NativeTypeName("USHORT")]
        public ushort VKey;

        [NativeTypeName("UINT")]
        public uint Message;

        [NativeTypeName("ULONG")]
        public uint ExtraInformation;
    }
}
