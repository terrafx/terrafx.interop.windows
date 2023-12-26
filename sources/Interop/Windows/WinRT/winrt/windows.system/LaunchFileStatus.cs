// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='LaunchFileStatus.xml' path='doc/member[@name="LaunchFileStatus"]/*' />
public enum LaunchFileStatus
{
    /// <include file='LaunchFileStatus.xml' path='doc/member[@name="LaunchFileStatus.LaunchFileStatus_Success"]/*' />
    LaunchFileStatus_Success = 0,

    /// <include file='LaunchFileStatus.xml' path='doc/member[@name="LaunchFileStatus.LaunchFileStatus_AppUnavailable"]/*' />
    LaunchFileStatus_AppUnavailable = 1,

    /// <include file='LaunchFileStatus.xml' path='doc/member[@name="LaunchFileStatus.LaunchFileStatus_DeniedByPolicy"]/*' />
    LaunchFileStatus_DeniedByPolicy = 2,

    /// <include file='LaunchFileStatus.xml' path='doc/member[@name="LaunchFileStatus.LaunchFileStatus_FileTypeNotSupported"]/*' />
    LaunchFileStatus_FileTypeNotSupported = 3,

    /// <include file='LaunchFileStatus.xml' path='doc/member[@name="LaunchFileStatus.LaunchFileStatus_Unknown"]/*' />
    LaunchFileStatus_Unknown = 4,
}
