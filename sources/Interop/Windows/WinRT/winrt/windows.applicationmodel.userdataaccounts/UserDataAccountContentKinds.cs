// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataAccountContentKinds.xml' path='doc/member[@name="UserDataAccountContentKinds"]/*' />
[NativeTypeName("unsigned int")]
public enum UserDataAccountContentKinds : uint
{
    /// <include file='UserDataAccountContentKinds.xml' path='doc/member[@name="UserDataAccountContentKinds.UserDataAccountContentKinds_Email"]/*' />
    UserDataAccountContentKinds_Email = 0x1,

    /// <include file='UserDataAccountContentKinds.xml' path='doc/member[@name="UserDataAccountContentKinds.UserDataAccountContentKinds_Contact"]/*' />
    UserDataAccountContentKinds_Contact = 0x2,

    /// <include file='UserDataAccountContentKinds.xml' path='doc/member[@name="UserDataAccountContentKinds.UserDataAccountContentKinds_Appointment"]/*' />
    UserDataAccountContentKinds_Appointment = 0x4,
}
