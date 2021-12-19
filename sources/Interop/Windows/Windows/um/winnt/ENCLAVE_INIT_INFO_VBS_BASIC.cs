// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC"]/*' />
public unsafe partial struct ENCLAVE_INIT_INFO_VBS_BASIC
{
    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.FamilyId"]/*' />
    [NativeTypeName("BYTE [16]")]
    public fixed byte FamilyId[16];

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.ImageId"]/*' />
    [NativeTypeName("BYTE [16]")]
    public fixed byte ImageId[16];

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.EnclaveSize"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong EnclaveSize;

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.EnclaveSvn"]/*' />
    [NativeTypeName("DWORD")]
    public uint EnclaveSvn;

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='ENCLAVE_INIT_INFO_VBS_BASIC.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_VBS_BASIC.Anonymous"]/*' />
    [NativeTypeName("_ENCLAVE_INIT_INFO_VBS_BASIC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winnt.h:14295:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SignatureInfoHandle"]/*' />
    public ref HANDLE SignatureInfoHandle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.SignatureInfoHandle;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Unused"]/*' />
    public ref ulong Unused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Unused, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SignatureInfoHandle"]/*' />
        [FieldOffset(0)]
        public HANDLE SignatureInfoHandle;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Unused"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong Unused;
    }
}
