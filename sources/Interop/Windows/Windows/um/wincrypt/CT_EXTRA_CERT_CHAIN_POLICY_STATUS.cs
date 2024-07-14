// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CT_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CT_EXTRA_CERT_CHAIN_POLICY_STATUS"]/*' />
public partial struct CT_EXTRA_CERT_CHAIN_POLICY_STATUS
{
    /// <include file='CT_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CT_EXTRA_CERT_CHAIN_POLICY_STATUS.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CT_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CT_EXTRA_CERT_CHAIN_POLICY_STATUS.lErrorStatus"]/*' />
    [NativeTypeName("LONG")]
    public int lErrorStatus;

    /// <include file='CT_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CT_EXTRA_CERT_CHAIN_POLICY_STATUS.lErrorSubStatus"]/*' />
    [NativeTypeName("LONG")]
    public int lErrorSubStatus;

    /// <include file='CT_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CT_EXTRA_CERT_CHAIN_POLICY_STATUS.cEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint cEntries;

    /// <include file='CT_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CT_EXTRA_CERT_CHAIN_POLICY_STATUS.cValidated"]/*' />
    [NativeTypeName("DWORD")]
    public uint cValidated;
}
