// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTPAPI_VERSION.xml' path='doc/member[@name="HTTPAPI_VERSION"]/*' />
public partial struct HTTPAPI_VERSION
{
    /// <include file='HTTPAPI_VERSION.xml' path='doc/member[@name="HTTPAPI_VERSION.HttpApiMajorVersion"]/*' />
    public ushort HttpApiMajorVersion;

    /// <include file='HTTPAPI_VERSION.xml' path='doc/member[@name="HTTPAPI_VERSION.HttpApiMinorVersion"]/*' />
    public ushort HttpApiMinorVersion;
}
