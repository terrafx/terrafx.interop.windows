// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GazeInputAccessStatus.xml' path='doc/member[@name="GazeInputAccessStatus"]/*' />
public enum GazeInputAccessStatus
{
    /// <include file='GazeInputAccessStatus.xml' path='doc/member[@name="GazeInputAccessStatus.GazeInputAccessStatus_Unspecified"]/*' />
    GazeInputAccessStatus_Unspecified = 0,

    /// <include file='GazeInputAccessStatus.xml' path='doc/member[@name="GazeInputAccessStatus.GazeInputAccessStatus_Allowed"]/*' />
    GazeInputAccessStatus_Allowed = 1,

    /// <include file='GazeInputAccessStatus.xml' path='doc/member[@name="GazeInputAccessStatus.GazeInputAccessStatus_DeniedByUser"]/*' />
    GazeInputAccessStatus_DeniedByUser = 2,

    /// <include file='GazeInputAccessStatus.xml' path='doc/member[@name="GazeInputAccessStatus.GazeInputAccessStatus_DeniedBySystem"]/*' />
    GazeInputAccessStatus_DeniedBySystem = 3,
}
