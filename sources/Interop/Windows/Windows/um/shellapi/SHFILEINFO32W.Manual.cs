// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SHFILEINFO32W
    {
        public HICON hIcon;

        public int iIcon;

        [NativeTypeName("DWORD")]
        public uint dwAttributes;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szDisplayName[260];

        [NativeTypeName("WCHAR [80]")]
        public fixed ushort szTypeName[80];
    }
}
