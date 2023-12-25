// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AlarmAccessStatus.xml' path='doc/member[@name="AlarmAccessStatus"]/*' />
public enum AlarmAccessStatus
{
    /// <include file='AlarmAccessStatus.xml' path='doc/member[@name="AlarmAccessStatus.AlarmAccessStatus_Unspecified"]/*' />
    AlarmAccessStatus_Unspecified = 0,

    /// <include file='AlarmAccessStatus.xml' path='doc/member[@name="AlarmAccessStatus.AlarmAccessStatus_AllowedWithWakeupCapability"]/*' />
    AlarmAccessStatus_AllowedWithWakeupCapability = 1,

    /// <include file='AlarmAccessStatus.xml' path='doc/member[@name="AlarmAccessStatus.AlarmAccessStatus_AllowedWithoutWakeupCapability"]/*' />
    AlarmAccessStatus_AllowedWithoutWakeupCapability = 2,

    /// <include file='AlarmAccessStatus.xml' path='doc/member[@name="AlarmAccessStatus.AlarmAccessStatus_Denied"]/*' />
    AlarmAccessStatus_Denied = 3,
}
