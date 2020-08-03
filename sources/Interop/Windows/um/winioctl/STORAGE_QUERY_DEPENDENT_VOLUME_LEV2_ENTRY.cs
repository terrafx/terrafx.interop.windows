// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint EntryLength;

        [NativeTypeName("DWORD")]
        public uint DependencyTypeFlags;

        [NativeTypeName("DWORD")]
        public uint ProviderSpecificFlags;

        public VIRTUAL_STORAGE_TYPE VirtualStorageType;

        [NativeTypeName("DWORD")]
        public uint AncestorLevel;

        [NativeTypeName("DWORD")]
        public uint HostVolumeNameOffset;

        [NativeTypeName("DWORD")]
        public uint HostVolumeNameSize;

        [NativeTypeName("DWORD")]
        public uint DependentVolumeNameOffset;

        [NativeTypeName("DWORD")]
        public uint DependentVolumeNameSize;

        [NativeTypeName("DWORD")]
        public uint RelativePathOffset;

        [NativeTypeName("DWORD")]
        public uint RelativePathSize;

        [NativeTypeName("DWORD")]
        public uint DependentDeviceNameOffset;

        [NativeTypeName("DWORD")]
        public uint DependentDeviceNameSize;
    }
}
