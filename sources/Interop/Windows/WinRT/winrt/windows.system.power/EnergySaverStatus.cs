// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EnergySaverStatus.xml' path='doc/member[@name="EnergySaverStatus"]/*' />
public enum EnergySaverStatus
{
    /// <include file='EnergySaverStatus.xml' path='doc/member[@name="EnergySaverStatus.EnergySaverStatus_Disabled"]/*' />
    EnergySaverStatus_Disabled = 0,

    /// <include file='EnergySaverStatus.xml' path='doc/member[@name="EnergySaverStatus.EnergySaverStatus_Off"]/*' />
    EnergySaverStatus_Off = 1,

    /// <include file='EnergySaverStatus.xml' path='doc/member[@name="EnergySaverStatus.EnergySaverStatus_On"]/*' />
    EnergySaverStatus_On = 2,
}
