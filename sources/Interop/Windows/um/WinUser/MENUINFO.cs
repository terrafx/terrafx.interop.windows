// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MENUINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint fMask;

        [NativeTypeName("DWORD")]
        public uint dwStyle;

        public uint cyMax;

        public HBRUSH hbrBack;

        [NativeTypeName("DWORD")]
        public uint dwContextHelpID;

        [NativeTypeName("ULONG_PTR")]
        public nuint dwMenuData;
    }
}
