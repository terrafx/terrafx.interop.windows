// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_RESOLVER_CACHE_CONFIG.xml' path='doc/member[@name="WINHTTP_RESOLVER_CACHE_CONFIG"]/*' />
public partial struct WINHTTP_RESOLVER_CACHE_CONFIG
{
    /// <include file='WINHTTP_RESOLVER_CACHE_CONFIG.xml' path='doc/member[@name="WINHTTP_RESOLVER_CACHE_CONFIG.ulMaxResolverCacheEntries"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulMaxResolverCacheEntries;

    /// <include file='WINHTTP_RESOLVER_CACHE_CONFIG.xml' path='doc/member[@name="WINHTTP_RESOLVER_CACHE_CONFIG.ulMaxCacheEntryAge"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulMaxCacheEntryAge;

    /// <include file='WINHTTP_RESOLVER_CACHE_CONFIG.xml' path='doc/member[@name="WINHTTP_RESOLVER_CACHE_CONFIG.ulMinCacheEntryTtl"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulMinCacheEntryTtl;

    /// <include file='WINHTTP_RESOLVER_CACHE_CONFIG.xml' path='doc/member[@name="WINHTTP_RESOLVER_CACHE_CONFIG.SecureDnsSetting"]/*' />
    public WINHTTP_SECURE_DNS_SETTING SecureDnsSetting;

    /// <include file='WINHTTP_RESOLVER_CACHE_CONFIG.xml' path='doc/member[@name="WINHTTP_RESOLVER_CACHE_CONFIG.ullConnResolutionWaitTime"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullConnResolutionWaitTime;

    /// <include file='WINHTTP_RESOLVER_CACHE_CONFIG.xml' path='doc/member[@name="WINHTTP_RESOLVER_CACHE_CONFIG.ullFlags"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;
}
