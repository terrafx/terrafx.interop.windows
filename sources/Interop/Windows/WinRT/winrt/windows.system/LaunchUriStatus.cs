// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='LaunchUriStatus.xml' path='doc/member[@name="LaunchUriStatus"]/*' />
public enum LaunchUriStatus
{
    /// <include file='LaunchUriStatus.xml' path='doc/member[@name="LaunchUriStatus.LaunchUriStatus_Success"]/*' />
    LaunchUriStatus_Success = 0,

    /// <include file='LaunchUriStatus.xml' path='doc/member[@name="LaunchUriStatus.LaunchUriStatus_AppUnavailable"]/*' />
    LaunchUriStatus_AppUnavailable = 1,

    /// <include file='LaunchUriStatus.xml' path='doc/member[@name="LaunchUriStatus.LaunchUriStatus_ProtocolUnavailable"]/*' />
    LaunchUriStatus_ProtocolUnavailable = 2,

    /// <include file='LaunchUriStatus.xml' path='doc/member[@name="LaunchUriStatus.LaunchUriStatus_Unknown"]/*' />
    LaunchUriStatus_Unknown = 3,
}
