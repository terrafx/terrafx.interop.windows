// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MOUSEKEYS
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint iMaxSpeed;

        [NativeTypeName("DWORD")]
        public uint iTimeToMaxSpeed;

        [NativeTypeName("DWORD")]
        public uint iCtrlSpeed;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("DWORD")]
        public uint dwReserved2;
    }
}
