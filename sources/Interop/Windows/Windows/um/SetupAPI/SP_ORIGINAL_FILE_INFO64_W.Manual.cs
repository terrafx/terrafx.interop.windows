// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SP_ORIGINAL_FILE_INFO64_W
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort OriginalInfName[260];

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort OriginalCatalogName[260];
    }
}
