// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SCHANNEL_CERT_HASH.xml' path='doc/member[@name="SCHANNEL_CERT_HASH"]/*' />
public partial struct SCHANNEL_CERT_HASH
{
    /// <include file='SCHANNEL_CERT_HASH.xml' path='doc/member[@name="SCHANNEL_CERT_HASH.dwLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLength;

    /// <include file='SCHANNEL_CERT_HASH.xml' path='doc/member[@name="SCHANNEL_CERT_HASH.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='SCHANNEL_CERT_HASH.xml' path='doc/member[@name="SCHANNEL_CERT_HASH.hProv"]/*' />
    public HCRYPTPROV hProv;

    /// <include file='SCHANNEL_CERT_HASH.xml' path='doc/member[@name="SCHANNEL_CERT_HASH.ShaHash"]/*' />
    [NativeTypeName("BYTE[20]")]
    public _ShaHash_e__FixedBuffer ShaHash;

    /// <include file='_ShaHash_e__FixedBuffer.xml' path='doc/member[@name="_ShaHash_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _ShaHash_e__FixedBuffer
    {
        public byte e0;
    }
}
