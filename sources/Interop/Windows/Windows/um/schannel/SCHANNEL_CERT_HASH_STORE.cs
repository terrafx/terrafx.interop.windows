// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE"]/*' />
public partial struct SCHANNEL_CERT_HASH_STORE
{
    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.dwLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLength;

    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.hProv"]/*' />
    public HCRYPTPROV hProv;

    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.ShaHash"]/*' />
    [NativeTypeName("BYTE[20]")]
    public _ShaHash_e__FixedBuffer ShaHash;

    /// <include file='SCHANNEL_CERT_HASH_STORE.xml' path='doc/member[@name="SCHANNEL_CERT_HASH_STORE.pwszStoreName"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _pwszStoreName_e__FixedBuffer pwszStoreName;

    /// <include file='_ShaHash_e__FixedBuffer.xml' path='doc/member[@name="_ShaHash_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _ShaHash_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_pwszStoreName_e__FixedBuffer.xml' path='doc/member[@name="_pwszStoreName_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _pwszStoreName_e__FixedBuffer
    {
        public char e0;
    }
}
