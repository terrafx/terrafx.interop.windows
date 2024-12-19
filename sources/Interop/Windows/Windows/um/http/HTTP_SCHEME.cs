// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SCHEME.xml' path='doc/member[@name="HTTP_SCHEME"]/*' />
public enum HTTP_SCHEME
{
    /// <include file='HTTP_SCHEME.xml' path='doc/member[@name="HTTP_SCHEME.HttpSchemeHttp"]/*' />
    HttpSchemeHttp,

    /// <include file='HTTP_SCHEME.xml' path='doc/member[@name="HTTP_SCHEME.HttpSchemeHttps"]/*' />
    HttpSchemeHttps,

    /// <include file='HTTP_SCHEME.xml' path='doc/member[@name="HTTP_SCHEME.HttpSchemeMaximum"]/*' />
    HttpSchemeMaximum,
}
