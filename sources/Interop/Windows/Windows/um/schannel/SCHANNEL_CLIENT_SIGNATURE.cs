// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE"]/*' />
public partial struct SCHANNEL_CLIENT_SIGNATURE
{
    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.cbLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbLength;

    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.aiHash"]/*' />
    [NativeTypeName("ALG_ID")]
    public uint aiHash;

    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.cbHash"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbHash;

    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.HashValue"]/*' />
    [NativeTypeName("BYTE[36]")]
    public _HashValue_e__FixedBuffer HashValue;

    /// <include file='SCHANNEL_CLIENT_SIGNATURE.xml' path='doc/member[@name="SCHANNEL_CLIENT_SIGNATURE.CertThumbprint"]/*' />
    [NativeTypeName("BYTE[20]")]
    public _CertThumbprint_e__FixedBuffer CertThumbprint;

    /// <include file='_HashValue_e__FixedBuffer.xml' path='doc/member[@name="_HashValue_e__FixedBuffer"]/*' />
    [InlineArray(36)]
    public partial struct _HashValue_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_CertThumbprint_e__FixedBuffer.xml' path='doc/member[@name="_CertThumbprint_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _CertThumbprint_e__FixedBuffer
    {
        public byte e0;
    }
}
