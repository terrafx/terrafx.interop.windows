// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PERSIST_FOLDER_TARGET_INFO
    {
        [NativeTypeName("LPITEMIDLIST")]
        public ITEMIDLIST* pidlTargetFolder;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szTargetParsingName[260];

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szNetworkProvider[260];

        [NativeTypeName("DWORD")]
        public uint dwAttributes;

        public int csidl;
    }
}
