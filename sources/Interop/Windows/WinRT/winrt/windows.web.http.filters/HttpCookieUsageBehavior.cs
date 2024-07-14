// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HttpCookieUsageBehavior.xml' path='doc/member[@name="HttpCookieUsageBehavior"]/*' />
public enum HttpCookieUsageBehavior
{
    /// <include file='HttpCookieUsageBehavior.xml' path='doc/member[@name="HttpCookieUsageBehavior.HttpCookieUsageBehavior_Default"]/*' />
    HttpCookieUsageBehavior_Default = 0,

    /// <include file='HttpCookieUsageBehavior.xml' path='doc/member[@name="HttpCookieUsageBehavior.HttpCookieUsageBehavior_NoCookies"]/*' />
    HttpCookieUsageBehavior_NoCookies = 1,
}
