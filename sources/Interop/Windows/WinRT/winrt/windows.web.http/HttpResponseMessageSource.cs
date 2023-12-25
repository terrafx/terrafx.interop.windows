// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HttpResponseMessageSource.xml' path='doc/member[@name="HttpResponseMessageSource"]/*' />
public enum HttpResponseMessageSource
{
    /// <include file='HttpResponseMessageSource.xml' path='doc/member[@name="HttpResponseMessageSource.HttpResponseMessageSource_None"]/*' />
    HttpResponseMessageSource_None = 0,

    /// <include file='HttpResponseMessageSource.xml' path='doc/member[@name="HttpResponseMessageSource.HttpResponseMessageSource_Cache"]/*' />
    HttpResponseMessageSource_Cache = 1,

    /// <include file='HttpResponseMessageSource.xml' path='doc/member[@name="HttpResponseMessageSource.HttpResponseMessageSource_Network"]/*' />
    HttpResponseMessageSource_Network = 2,
}
