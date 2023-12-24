// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='ENCLAVE_INIT_INFO_SGX.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_SGX"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct ENCLAVE_INIT_INFO_SGX
{
    /// <include file='ENCLAVE_INIT_INFO_SGX.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_SGX.SigStruct"]/*' />
    [NativeTypeName("BYTE[1808]")]
    public _SigStruct_e__FixedBuffer SigStruct;

    /// <include file='ENCLAVE_INIT_INFO_SGX.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_SGX.Reserved1"]/*' />
    [NativeTypeName("BYTE[240]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    /// <include file='ENCLAVE_INIT_INFO_SGX.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_SGX.EInitToken"]/*' />
    [NativeTypeName("BYTE[304]")]
    public _EInitToken_e__FixedBuffer EInitToken;

    /// <include file='ENCLAVE_INIT_INFO_SGX.xml' path='doc/member[@name="ENCLAVE_INIT_INFO_SGX.Reserved2"]/*' />
    [NativeTypeName("BYTE[1744]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    /// <include file='_SigStruct_e__FixedBuffer.xml' path='doc/member[@name="_SigStruct_e__FixedBuffer"]/*' />
    [InlineArray(1808)]
    public partial struct _SigStruct_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*' />
    [InlineArray(240)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_EInitToken_e__FixedBuffer.xml' path='doc/member[@name="_EInitToken_e__FixedBuffer"]/*' />
    [InlineArray(304)]
    public partial struct _EInitToken_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
    [InlineArray(1744)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public byte e0;
    }
}
