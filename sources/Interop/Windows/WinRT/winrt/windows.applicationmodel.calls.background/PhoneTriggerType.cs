// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneTriggerType.xml' path='doc/member[@name="PhoneTriggerType"]/*' />
public enum PhoneTriggerType
{
    /// <include file='PhoneTriggerType.xml' path='doc/member[@name="PhoneTriggerType.PhoneTriggerType_NewVoicemailMessage"]/*' />
    PhoneTriggerType_NewVoicemailMessage = 0,

    /// <include file='PhoneTriggerType.xml' path='doc/member[@name="PhoneTriggerType.PhoneTriggerType_CallHistoryChanged"]/*' />
    PhoneTriggerType_CallHistoryChanged = 1,

    /// <include file='PhoneTriggerType.xml' path='doc/member[@name="PhoneTriggerType.PhoneTriggerType_LineChanged"]/*' />
    PhoneTriggerType_LineChanged = 2,

    /// <include file='PhoneTriggerType.xml' path='doc/member[@name="PhoneTriggerType.PhoneTriggerType_AirplaneModeDisabledForEmergencyCall"]/*' />
    PhoneTriggerType_AirplaneModeDisabledForEmergencyCall = 3,

    /// <include file='PhoneTriggerType.xml' path='doc/member[@name="PhoneTriggerType.PhoneTriggerType_CallOriginDataRequest"]/*' />
    [Obsolete("CallOriginDataRequest is deprecated and might not work for all platforms. For more info, see MSDN.")]
    PhoneTriggerType_CallOriginDataRequest = 4,

    /// <include file='PhoneTriggerType.xml' path='doc/member[@name="PhoneTriggerType.PhoneTriggerType_CallBlocked"]/*' />
    PhoneTriggerType_CallBlocked = 5,

    /// <include file='PhoneTriggerType.xml' path='doc/member[@name="PhoneTriggerType.PhoneTriggerType_IncomingCallDismissed"]/*' />
    [Obsolete("IncomingCallDismissed is deprecated and might not work for all platforms. For more info, see MSDN.")]
    PhoneTriggerType_IncomingCallDismissed = 6,

    /// <include file='PhoneTriggerType.xml' path='doc/member[@name="PhoneTriggerType.PhoneTriggerType_IncomingCallNotification"]/*' />
    PhoneTriggerType_IncomingCallNotification = 7,
}
