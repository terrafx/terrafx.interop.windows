// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct IMAGE_ENCLAVE_CONFIG64
{
    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.MinimumRequiredConfigSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint MinimumRequiredConfigSize;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.PolicyFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint PolicyFlags;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.NumberOfImports"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfImports;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.ImportList"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImportList;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.ImportEntrySize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImportEntrySize;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.FamilyID"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _FamilyID_e__FixedBuffer FamilyID;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.ImageID"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _ImageID_e__FixedBuffer ImageID;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.ImageVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint ImageVersion;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.SecurityVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint SecurityVersion;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.EnclaveSize"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong EnclaveSize;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.NumberOfThreads"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfThreads;

    /// <include file='IMAGE_ENCLAVE_CONFIG64.xml' path='doc/member[@name="IMAGE_ENCLAVE_CONFIG64.EnclaveFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint EnclaveFlags;

    /// <include file='_FamilyID_e__FixedBuffer.xml' path='doc/member[@name="_FamilyID_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    [InlineArray(16)]
    public partial struct _FamilyID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_ImageID_e__FixedBuffer.xml' path='doc/member[@name="_ImageID_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    [InlineArray(16)]
    public partial struct _ImageID_e__FixedBuffer
    {
        public byte e0;
    }
}
