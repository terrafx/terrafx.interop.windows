// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

public static partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneCallBlockedTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneCallBlockedTriggerDetails = "Windows.ApplicationModel.Calls.Background.IPhoneCallBlockedTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneCallOriginDataRequestTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[84]")]
    public const string InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneCallOriginDataRequestTriggerDetails = "Windows.ApplicationModel.Calls.Background.IPhoneCallOriginDataRequestTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneIncomingCallDismissedTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[84]")]
    public const string InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneIncomingCallDismissedTriggerDetails = "Windows.ApplicationModel.Calls.Background.IPhoneIncomingCallDismissedTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneIncomingCallNotificationTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[87]")]
    public const string InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneIncomingCallNotificationTriggerDetails = "Windows.ApplicationModel.Calls.Background.IPhoneIncomingCallNotificationTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneLineChangedTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneLineChangedTriggerDetails = "Windows.ApplicationModel.Calls.Background.IPhoneLineChangedTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneNewVoicemailMessageTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[82]")]
    public const string InterfaceName_Windows_ApplicationModel_Calls_Background_IPhoneNewVoicemailMessageTriggerDetails = "Windows.ApplicationModel.Calls.Background.IPhoneNewVoicemailMessageTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneCallBlockedTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[73]")]
    public const string RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneCallBlockedTriggerDetails = "Windows.ApplicationModel.Calls.Background.PhoneCallBlockedTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneCallOriginDataRequestTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[83]")]
    [Obsolete("PhoneCallOriginDataRequestTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public const string RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneCallOriginDataRequestTriggerDetails = "Windows.ApplicationModel.Calls.Background.PhoneCallOriginDataRequestTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneIncomingCallDismissedTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[83]")]
    [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public const string RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneIncomingCallDismissedTriggerDetails = "Windows.ApplicationModel.Calls.Background.PhoneIncomingCallDismissedTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneIncomingCallNotificationTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[86]")]
    public const string RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneIncomingCallNotificationTriggerDetails = "Windows.ApplicationModel.Calls.Background.PhoneIncomingCallNotificationTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneLineChangedTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[73]")]
    public const string RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneLineChangedTriggerDetails = "Windows.ApplicationModel.Calls.Background.PhoneLineChangedTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneNewVoicemailMessageTriggerDetails"]/*' />
    [NativeTypeName("const WCHAR[81]")]
    public const string RuntimeClass_Windows_ApplicationModel_Calls_Background_PhoneNewVoicemailMessageTriggerDetails = "Windows.ApplicationModel.Calls.Background.PhoneNewVoicemailMessageTriggerDetails";

    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.WINDOWS_APPLICATIONMODEL_CALLS_BACKGROUND_CALLSBACKGROUNDCONTRACT_VERSION"]/*' />
    [NativeTypeName("#define WINDOWS_APPLICATIONMODEL_CALLS_BACKGROUND_CALLSBACKGROUNDCONTRACT_VERSION 0x40000")]
    public const int WINDOWS_APPLICATIONMODEL_CALLS_BACKGROUND_CALLSBACKGROUNDCONTRACT_VERSION = 0x40000;
}
