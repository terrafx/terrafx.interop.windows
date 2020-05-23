// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct XINPUT_KEYSTROKE
    {
        [NativeTypeName("WORD")]
        public ushort VirtualKey;

        [NativeTypeName("WCHAR")]
        public ushort Unicode;

        [NativeTypeName("WORD")]
        public ushort Flags;

        [NativeTypeName("BYTE")]
        public byte UserIndex;

        [NativeTypeName("BYTE")]
        public byte HidCode;
    }
}
