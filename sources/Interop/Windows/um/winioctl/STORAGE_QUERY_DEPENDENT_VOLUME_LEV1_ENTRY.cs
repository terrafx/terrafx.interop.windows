// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint EntryLength;

        [NativeTypeName("DWORD")]
        public uint DependencyTypeFlags;

        [NativeTypeName("DWORD")]
        public uint ProviderSpecificFlags;

        public VIRTUAL_STORAGE_TYPE VirtualStorageType;
    }
}
