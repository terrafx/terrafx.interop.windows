// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsFilterActionType.xml' path='doc/member[@name="SmsFilterActionType"]/*' />
public enum SmsFilterActionType
{
    /// <include file='SmsFilterActionType.xml' path='doc/member[@name="SmsFilterActionType.SmsFilterActionType_AcceptImmediately"]/*' />
    SmsFilterActionType_AcceptImmediately = 0,

    /// <include file='SmsFilterActionType.xml' path='doc/member[@name="SmsFilterActionType.SmsFilterActionType_Drop"]/*' />
    SmsFilterActionType_Drop = 1,

    /// <include file='SmsFilterActionType.xml' path='doc/member[@name="SmsFilterActionType.SmsFilterActionType_Peek"]/*' />
    SmsFilterActionType_Peek = 2,

    /// <include file='SmsFilterActionType.xml' path='doc/member[@name="SmsFilterActionType.SmsFilterActionType_Accept"]/*' />
    SmsFilterActionType_Accept = 3,
}
