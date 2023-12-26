// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CachedFileOptions.xml' path='doc/member[@name="CachedFileOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum CachedFileOptions : uint
{
    /// <include file='CachedFileOptions.xml' path='doc/member[@name="CachedFileOptions.CachedFileOptions_None"]/*' />
    CachedFileOptions_None = 0,

    /// <include file='CachedFileOptions.xml' path='doc/member[@name="CachedFileOptions.CachedFileOptions_RequireUpdateOnAccess"]/*' />
    CachedFileOptions_RequireUpdateOnAccess = 0x1,

    /// <include file='CachedFileOptions.xml' path='doc/member[@name="CachedFileOptions.CachedFileOptions_UseCachedFileWhenOffline"]/*' />
    CachedFileOptions_UseCachedFileWhenOffline = 0x2,

    /// <include file='CachedFileOptions.xml' path='doc/member[@name="CachedFileOptions.CachedFileOptions_DenyAccessWhenOffline"]/*' />
    CachedFileOptions_DenyAccessWhenOffline = 0x4,
}
