// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HostNameSortOptions.xml' path='doc/member[@name="HostNameSortOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum HostNameSortOptions : uint
{
    /// <include file='HostNameSortOptions.xml' path='doc/member[@name="HostNameSortOptions.HostNameSortOptions_None"]/*' />
    HostNameSortOptions_None = 0,

    /// <include file='HostNameSortOptions.xml' path='doc/member[@name="HostNameSortOptions.HostNameSortOptions_OptimizeForLongConnections"]/*' />
    HostNameSortOptions_OptimizeForLongConnections = 0x2,
}
