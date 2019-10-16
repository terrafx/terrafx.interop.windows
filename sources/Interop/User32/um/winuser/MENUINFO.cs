// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

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

        [NativeTypeName("UINT")]
        public uint cyMax;

        [NativeTypeName("HBRUSH")]
        public IntPtr hbrBack;

        [NativeTypeName("DWORD")]
        public uint dwContextHelpID;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr dwMenuData;
    }
}
