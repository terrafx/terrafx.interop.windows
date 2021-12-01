// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA"]/*' />
public unsafe partial struct IMAGE_POLICY_METADATA
{
    /// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA.Version"]/*' />
    public byte Version;

    /// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA.Reserved0"]/*' />
    [NativeTypeName("BYTE [7]")]
    public fixed byte Reserved0[7];

    /// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA.ApplicationId"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ApplicationId;

    /// <include file='IMAGE_POLICY_METADATA.xml' path='doc/member[@name="IMAGE_POLICY_METADATA.Policies"]/*' />
    [NativeTypeName("IMAGE_POLICY_ENTRY []")]
    public IMAGE_POLICY_ENTRY Policies;
}
