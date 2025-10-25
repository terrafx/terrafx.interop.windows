// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_BASICPROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASICPROCESS_INFORMATION"]/*' />
public partial struct SYSTEM_BASICPROCESS_INFORMATION
{
    /// <include file='SYSTEM_BASICPROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASICPROCESS_INFORMATION.NextEntryOffset"]/*' />
    [NativeTypeName("ULONG")]
    public uint NextEntryOffset;

    /// <include file='SYSTEM_BASICPROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASICPROCESS_INFORMATION.UniqueProcessId"]/*' />
    public HANDLE UniqueProcessId;

    /// <include file='SYSTEM_BASICPROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASICPROCESS_INFORMATION.InheritedFromUniqueProcessId"]/*' />
    public HANDLE InheritedFromUniqueProcessId;

    /// <include file='SYSTEM_BASICPROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASICPROCESS_INFORMATION.SequenceNumber"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SequenceNumber;

    /// <include file='SYSTEM_BASICPROCESS_INFORMATION.xml' path='doc/member[@name="SYSTEM_BASICPROCESS_INFORMATION.ImageName"]/*' />
    public UNICODE_STRING ImageName;
}
