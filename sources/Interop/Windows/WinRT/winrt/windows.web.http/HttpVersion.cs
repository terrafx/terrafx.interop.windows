// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HttpVersion.xml' path='doc/member[@name="HttpVersion"]/*' />
public enum HttpVersion
{
    /// <include file='HttpVersion.xml' path='doc/member[@name="HttpVersion.HttpVersion_None"]/*' />
    HttpVersion_None = 0,

    /// <include file='HttpVersion.xml' path='doc/member[@name="HttpVersion.HttpVersion_Http10"]/*' />
    HttpVersion_Http10 = 1,

    /// <include file='HttpVersion.xml' path='doc/member[@name="HttpVersion.HttpVersion_Http11"]/*' />
    HttpVersion_Http11 = 2,

    /// <include file='HttpVersion.xml' path='doc/member[@name="HttpVersion.HttpVersion_Http20"]/*' />
    HttpVersion_Http20 = 3,
}
