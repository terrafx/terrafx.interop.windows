// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_CERT_CONFIG_PARAM.xml' path='doc/member[@name="HTTP_CERT_CONFIG_PARAM"]/*' />
public unsafe partial struct HTTP_CERT_CONFIG_PARAM
{
    /// <include file='HTTP_CERT_CONFIG_PARAM.xml' path='doc/member[@name="HTTP_CERT_CONFIG_PARAM.CertConfigCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint CertConfigCount;

    /// <include file='HTTP_CERT_CONFIG_PARAM.xml' path='doc/member[@name="HTTP_CERT_CONFIG_PARAM.CertConfigs"]/*' />
    [NativeTypeName("PHTTP_CERT_CONFIG_ENTRY")]
    public HTTP_CERT_CONFIG_ENTRY* CertConfigs;
}
