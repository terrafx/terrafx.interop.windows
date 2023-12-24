// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW"]/*' />
public unsafe partial struct CREDENTIAL_TARGET_INFORMATIONW
{
    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.TargetName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* TargetName;

    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.NetbiosServerName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* NetbiosServerName;

    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.DnsServerName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* DnsServerName;

    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.NetbiosDomainName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* NetbiosDomainName;

    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.DnsDomainName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* DnsDomainName;

    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.DnsTreeName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* DnsTreeName;

    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.PackageName"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* PackageName;

    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.CredTypeCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint CredTypeCount;

    /// <include file='CREDENTIAL_TARGET_INFORMATIONW.xml' path='doc/member[@name="CREDENTIAL_TARGET_INFORMATIONW.CredTypes"]/*' />
    [NativeTypeName("LPDWORD")]
    public uint* CredTypes;
}
