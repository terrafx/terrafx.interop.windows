// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_HW_FIRMWARE_ACTIVATE
{
    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Slot"]/*' />
    public byte Slot;

    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Reserved0"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    /// <include file='_Reserved0_e__FixedBuffer.xml' path='doc/member[@name="_Reserved0_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }
}
