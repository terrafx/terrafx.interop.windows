// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_CERT_CONFIG_ENTRY.xml' path='doc/member[@name="HTTP_CERT_CONFIG_ENTRY"]/*' />
public partial struct HTTP_CERT_CONFIG_ENTRY
{
    /// <include file='HTTP_CERT_CONFIG_ENTRY.xml' path='doc/member[@name="HTTP_CERT_CONFIG_ENTRY.CertHash"]/*' />
    [NativeTypeName("BYTE[20]")]
    public _CertHash_e__FixedBuffer CertHash;

    /// <include file='HTTP_CERT_CONFIG_ENTRY.xml' path='doc/member[@name="HTTP_CERT_CONFIG_ENTRY.CertStoreName"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _CertStoreName_e__FixedBuffer CertStoreName;

    /// <include file='_CertHash_e__FixedBuffer.xml' path='doc/member[@name="_CertHash_e__FixedBuffer"]/*' />
    [InlineArray(20)]
    public partial struct _CertHash_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_CertStoreName_e__FixedBuffer.xml' path='doc/member[@name="_CertStoreName_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _CertStoreName_e__FixedBuffer
    {
        public char e0;
    }
}
