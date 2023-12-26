// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HttpCacheReadBehavior.xml' path='doc/member[@name="HttpCacheReadBehavior"]/*' />
public enum HttpCacheReadBehavior
{
    /// <include file='HttpCacheReadBehavior.xml' path='doc/member[@name="HttpCacheReadBehavior.HttpCacheReadBehavior_Default"]/*' />
    HttpCacheReadBehavior_Default = 0,

    /// <include file='HttpCacheReadBehavior.xml' path='doc/member[@name="HttpCacheReadBehavior.HttpCacheReadBehavior_MostRecent"]/*' />
    HttpCacheReadBehavior_MostRecent = 1,

    /// <include file='HttpCacheReadBehavior.xml' path='doc/member[@name="HttpCacheReadBehavior.HttpCacheReadBehavior_OnlyFromCache"]/*' />
    HttpCacheReadBehavior_OnlyFromCache = 2,

    /// <include file='HttpCacheReadBehavior.xml' path='doc/member[@name="HttpCacheReadBehavior.HttpCacheReadBehavior_NoCache"]/*' />
    HttpCacheReadBehavior_NoCache = 3,
}
