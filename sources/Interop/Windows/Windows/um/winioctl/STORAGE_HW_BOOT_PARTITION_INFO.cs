// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_HW_BOOT_PARTITION_INFO.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_INFO"]/*' />
public partial struct STORAGE_HW_BOOT_PARTITION_INFO
{
    /// <include file='STORAGE_HW_BOOT_PARTITION_INFO.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_INFO.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_HW_BOOT_PARTITION_INFO.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_INFO.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_HW_BOOT_PARTITION_INFO.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_INFO.BPSZ"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong BPSZ;

    /// <include file='STORAGE_HW_BOOT_PARTITION_INFO.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_INFO.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='STORAGE_HW_BOOT_PARTITION_INFO.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_INFO.ImagePayloadAlignment"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImagePayloadAlignment;

    /// <include file='STORAGE_HW_BOOT_PARTITION_INFO.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_INFO.ImagePayloadMaxSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImagePayloadMaxSize;

    /// <include file='STORAGE_HW_BOOT_PARTITION_INFO.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_INFO.SlotCount"]/*' />
    public byte SlotCount;

    /// <include file='STORAGE_HW_BOOT_PARTITION_INFO.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_INFO.ABPID"]/*' />
    public byte ABPID;
}
