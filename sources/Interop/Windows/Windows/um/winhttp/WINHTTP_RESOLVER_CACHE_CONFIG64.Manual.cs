// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct WINHTTP_RESOLVER_CACHE_CONFIG64
{
    [NativeTypeName("ULONG")]
    public uint ulMaxResolverCacheEntries;

    [NativeTypeName("ULONG")]
    public uint ulMaxCacheEntryAge;

    [NativeTypeName("ULONG")]
    public uint ulMinCacheEntryTtl;

    public WINHTTP_SECURE_DNS_SETTING SecureDnsSetting;

    [NativeTypeName("ULONGLONG")]
    public ulong ullConnResolutionWaitTime;

    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;
}
