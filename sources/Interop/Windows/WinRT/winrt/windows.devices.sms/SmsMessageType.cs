// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsMessageType.xml' path='doc/member[@name="SmsMessageType"]/*' />
public enum SmsMessageType
{
    /// <include file='SmsMessageType.xml' path='doc/member[@name="SmsMessageType.SmsMessageType_Binary"]/*' />
    SmsMessageType_Binary = 0,

    /// <include file='SmsMessageType.xml' path='doc/member[@name="SmsMessageType.SmsMessageType_Text"]/*' />
    SmsMessageType_Text = 1,

    /// <include file='SmsMessageType.xml' path='doc/member[@name="SmsMessageType.SmsMessageType_Wap"]/*' />
    SmsMessageType_Wap = 2,

    /// <include file='SmsMessageType.xml' path='doc/member[@name="SmsMessageType.SmsMessageType_App"]/*' />
    SmsMessageType_App = 3,

    /// <include file='SmsMessageType.xml' path='doc/member[@name="SmsMessageType.SmsMessageType_Broadcast"]/*' />
    SmsMessageType_Broadcast = 4,

    /// <include file='SmsMessageType.xml' path='doc/member[@name="SmsMessageType.SmsMessageType_Voicemail"]/*' />
    SmsMessageType_Voicemail = 5,

    /// <include file='SmsMessageType.xml' path='doc/member[@name="SmsMessageType.SmsMessageType_Status"]/*' />
    SmsMessageType_Status = 6,
}
