// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CERT_CREDENTIAL_INFO.xml' path='doc/member[@name="CERT_CREDENTIAL_INFO"]/*' />
public partial struct CERT_CREDENTIAL_INFO
{
    /// <include file='CERT_CREDENTIAL_INFO.xml' path='doc/member[@name="CERT_CREDENTIAL_INFO.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='CERT_CREDENTIAL_INFO.xml' path='doc/member[@name="CERT_CREDENTIAL_INFO.rgbHashOfCert"]/*' />
    [NativeTypeName("UCHAR[20]")]
    public _rgbHashOfCert_e__FixedBuffer rgbHashOfCert;

    /// <include file='_rgbHashOfCert_e__FixedBuffer.xml' path='doc/member[@name="_rgbHashOfCert_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _rgbHashOfCert_e__FixedBuffer
    {
        public byte e0;
    }
}
