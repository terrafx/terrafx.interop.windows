// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR"]/*' />
public unsafe partial struct STORAGE_MINIPORT_DESCRIPTOR
{
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Portdriver"]/*' />
    public STORAGE_PORT_CODE_SET Portdriver;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.LUNResetSupported"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte LUNResetSupported;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.TargetResetSupported"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte TargetResetSupported;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.IoTimeoutValue"]/*' />
    [NativeTypeName("WORD")]
    public ushort IoTimeoutValue;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.ExtraIoInfoSupported"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ExtraIoInfoSupported;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Reserved0"]/*' />
    [NativeTypeName("BYTE [3]")]
    public fixed byte Reserved0[3];

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Reserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved1;
}
