// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NetworkTypes.xml' path='doc/member[@name="NetworkTypes"]/*' />
[NativeTypeName("unsigned int")]
public enum NetworkTypes : uint
{
    /// <include file='NetworkTypes.xml' path='doc/member[@name="NetworkTypes.NetworkTypes_None"]/*' />
    NetworkTypes_None = 0,

    /// <include file='NetworkTypes.xml' path='doc/member[@name="NetworkTypes.NetworkTypes_Internet"]/*' />
    NetworkTypes_Internet = 0x1,

    /// <include file='NetworkTypes.xml' path='doc/member[@name="NetworkTypes.NetworkTypes_PrivateNetwork"]/*' />
    NetworkTypes_PrivateNetwork = 0x2,
}
