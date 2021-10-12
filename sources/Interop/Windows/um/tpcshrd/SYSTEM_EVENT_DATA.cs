// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SYSTEM_EVENT_DATA
    {
        [NativeTypeName("BYTE")]
        public byte bModifier;

        [NativeTypeName("WCHAR")]
        public ushort wKey;

        [NativeTypeName("LONG")]
        public int xPos;

        [NativeTypeName("LONG")]
        public int yPos;

        [NativeTypeName("BYTE")]
        public byte bCursorMode;

        [NativeTypeName("DWORD")]
        public uint dwButtonState;
    }
}
