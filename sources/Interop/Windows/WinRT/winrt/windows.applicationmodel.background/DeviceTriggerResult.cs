// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DeviceTriggerResult.xml' path='doc/member[@name="DeviceTriggerResult"]/*' />
public enum DeviceTriggerResult
{
    /// <include file='DeviceTriggerResult.xml' path='doc/member[@name="DeviceTriggerResult.DeviceTriggerResult_Allowed"]/*' />
    DeviceTriggerResult_Allowed = 0,

    /// <include file='DeviceTriggerResult.xml' path='doc/member[@name="DeviceTriggerResult.DeviceTriggerResult_DeniedByUser"]/*' />
    DeviceTriggerResult_DeniedByUser = 1,

    /// <include file='DeviceTriggerResult.xml' path='doc/member[@name="DeviceTriggerResult.DeviceTriggerResult_DeniedBySystem"]/*' />
    DeviceTriggerResult_DeniedBySystem = 2,

    /// <include file='DeviceTriggerResult.xml' path='doc/member[@name="DeviceTriggerResult.DeviceTriggerResult_LowBattery"]/*' />
    DeviceTriggerResult_LowBattery = 3,
}
