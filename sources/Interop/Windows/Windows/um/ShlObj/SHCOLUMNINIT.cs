// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SHCOLUMNINIT
    {
        [NativeTypeName("ULONG")]
        public uint dwFlags;

        [NativeTypeName("ULONG")]
        public uint dwReserved;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort wszFolder[260];
    }
}
