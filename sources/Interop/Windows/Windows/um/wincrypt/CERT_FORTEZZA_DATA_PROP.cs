// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CERT_FORTEZZA_DATA_PROP.xml' path='doc/member[@name="CERT_FORTEZZA_DATA_PROP"]/*' />
public partial struct CERT_FORTEZZA_DATA_PROP
{
    /// <include file='CERT_FORTEZZA_DATA_PROP.xml' path='doc/member[@name="CERT_FORTEZZA_DATA_PROP.SerialNumber"]/*' />
    [NativeTypeName("unsigned char[8]")]
    public _SerialNumber_e__FixedBuffer SerialNumber;

    /// <include file='CERT_FORTEZZA_DATA_PROP.xml' path='doc/member[@name="CERT_FORTEZZA_DATA_PROP.CertIndex"]/*' />
    public int CertIndex;

    /// <include file='CERT_FORTEZZA_DATA_PROP.xml' path='doc/member[@name="CERT_FORTEZZA_DATA_PROP.CertLabel"]/*' />
    [NativeTypeName("unsigned char[36]")]
    public _CertLabel_e__FixedBuffer CertLabel;

    /// <include file='_SerialNumber_e__FixedBuffer.xml' path='doc/member[@name="_SerialNumber_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _SerialNumber_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_CertLabel_e__FixedBuffer.xml' path='doc/member[@name="_CertLabel_e__FixedBuffer"]/*' />
    [InlineArray(36)]
    public partial struct _CertLabel_e__FixedBuffer
    {
        public byte e0;
    }
}
