// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailQuerySearchFields.xml' path='doc/member[@name="EmailQuerySearchFields"]/*' />
[NativeTypeName("unsigned int")]
public enum EmailQuerySearchFields : uint
{
    /// <include file='EmailQuerySearchFields.xml' path='doc/member[@name="EmailQuerySearchFields.EmailQuerySearchFields_None"]/*' />
    EmailQuerySearchFields_None = 0,

    /// <include file='EmailQuerySearchFields.xml' path='doc/member[@name="EmailQuerySearchFields.EmailQuerySearchFields_Subject"]/*' />
    EmailQuerySearchFields_Subject = 0x1,

    /// <include file='EmailQuerySearchFields.xml' path='doc/member[@name="EmailQuerySearchFields.EmailQuerySearchFields_Sender"]/*' />
    EmailQuerySearchFields_Sender = 0x2,

    /// <include file='EmailQuerySearchFields.xml' path='doc/member[@name="EmailQuerySearchFields.EmailQuerySearchFields_Preview"]/*' />
    EmailQuerySearchFields_Preview = 0x4,

    /// <include file='EmailQuerySearchFields.xml' path='doc/member[@name="EmailQuerySearchFields.EmailQuerySearchFields_Recipients"]/*' />
    EmailQuerySearchFields_Recipients = 0x8,

    /// <include file='EmailQuerySearchFields.xml' path='doc/member[@name="EmailQuerySearchFields.EmailQuerySearchFields_All"]/*' />
    EmailQuerySearchFields_All = 0xffffffff,
}
