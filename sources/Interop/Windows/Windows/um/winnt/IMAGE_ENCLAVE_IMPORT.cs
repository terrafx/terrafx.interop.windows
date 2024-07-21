// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT"]/*' />
[SupportedOSPlatform("windows10.0.16299.0")]
public partial struct IMAGE_ENCLAVE_IMPORT
{
    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.MatchType"]/*' />
    [NativeTypeName("DWORD")]
    public uint MatchType;

    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.MinimumSecurityVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint MinimumSecurityVersion;

    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.UniqueOrAuthorID"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _UniqueOrAuthorID_e__FixedBuffer UniqueOrAuthorID;

    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.FamilyID"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _FamilyID_e__FixedBuffer FamilyID;

    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.ImageID"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _ImageID_e__FixedBuffer ImageID;

    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.ImportName"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImportName;

    /// <include file='IMAGE_ENCLAVE_IMPORT.xml' path='doc/member[@name="IMAGE_ENCLAVE_IMPORT.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='_UniqueOrAuthorID_e__FixedBuffer.xml' path='doc/member[@name="_UniqueOrAuthorID_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _UniqueOrAuthorID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_FamilyID_e__FixedBuffer.xml' path='doc/member[@name="_FamilyID_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _FamilyID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_ImageID_e__FixedBuffer.xml' path='doc/member[@name="_ImageID_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _ImageID_e__FixedBuffer
    {
        public byte e0;
    }
}
