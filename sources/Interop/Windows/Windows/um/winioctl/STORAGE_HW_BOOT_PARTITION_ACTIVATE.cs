// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_HW_BOOT_PARTITION_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_ACTIVATE"]/*' />
public partial struct STORAGE_HW_BOOT_PARTITION_ACTIVATE
{
    /// <include file='STORAGE_HW_BOOT_PARTITION_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_ACTIVATE.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_HW_BOOT_PARTITION_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_ACTIVATE.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_HW_BOOT_PARTITION_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_ACTIVATE.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='STORAGE_HW_BOOT_PARTITION_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_ACTIVATE.BPID"]/*' />
    public byte BPID;

    /// <include file='STORAGE_HW_BOOT_PARTITION_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_BOOT_PARTITION_ACTIVATE.Reserved"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
