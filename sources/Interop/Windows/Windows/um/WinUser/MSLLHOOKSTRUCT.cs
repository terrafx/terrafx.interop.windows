// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct MSLLHOOKSTRUCT
    {
        public POINT pt;

        [NativeTypeName("DWORD")]
        public uint mouseData;

        [NativeTypeName("DWORD")]
        public uint flags;

        [NativeTypeName("DWORD")]
        public uint time;

        [NativeTypeName("ULONG_PTR")]
        public nuint dwExtraInfo;
    }
}
