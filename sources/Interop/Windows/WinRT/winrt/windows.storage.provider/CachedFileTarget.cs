// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CachedFileTarget.xml' path='doc/member[@name="CachedFileTarget"]/*' />
public enum CachedFileTarget
{
    /// <include file='CachedFileTarget.xml' path='doc/member[@name="CachedFileTarget.CachedFileTarget_Local"]/*' />
    CachedFileTarget_Local = 0,

    /// <include file='CachedFileTarget.xml' path='doc/member[@name="CachedFileTarget.CachedFileTarget_Remote"]/*' />
    CachedFileTarget_Remote = 1,
}
