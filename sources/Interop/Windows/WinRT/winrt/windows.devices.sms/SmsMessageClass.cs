// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmsMessageClass.xml' path='doc/member[@name="SmsMessageClass"]/*' />
public enum SmsMessageClass
{
    /// <include file='SmsMessageClass.xml' path='doc/member[@name="SmsMessageClass.SmsMessageClass_None"]/*' />
    SmsMessageClass_None = 0,

    /// <include file='SmsMessageClass.xml' path='doc/member[@name="SmsMessageClass.SmsMessageClass_Class0"]/*' />
    SmsMessageClass_Class0 = 1,

    /// <include file='SmsMessageClass.xml' path='doc/member[@name="SmsMessageClass.SmsMessageClass_Class1"]/*' />
    SmsMessageClass_Class1 = 2,

    /// <include file='SmsMessageClass.xml' path='doc/member[@name="SmsMessageClass.SmsMessageClass_Class2"]/*' />
    SmsMessageClass_Class2 = 3,

    /// <include file='SmsMessageClass.xml' path='doc/member[@name="SmsMessageClass.SmsMessageClass_Class3"]/*' />
    SmsMessageClass_Class3 = 4,
}
