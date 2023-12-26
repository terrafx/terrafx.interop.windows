// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HttpCacheWriteBehavior.xml' path='doc/member[@name="HttpCacheWriteBehavior"]/*' />
public enum HttpCacheWriteBehavior
{
    /// <include file='HttpCacheWriteBehavior.xml' path='doc/member[@name="HttpCacheWriteBehavior.HttpCacheWriteBehavior_Default"]/*' />
    HttpCacheWriteBehavior_Default = 0,

    /// <include file='HttpCacheWriteBehavior.xml' path='doc/member[@name="HttpCacheWriteBehavior.HttpCacheWriteBehavior_NoCache"]/*' />
    HttpCacheWriteBehavior_NoCache = 1,
}
