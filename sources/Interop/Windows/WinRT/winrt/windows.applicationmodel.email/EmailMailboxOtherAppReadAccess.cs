// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMailboxOtherAppReadAccess.xml' path='doc/member[@name="EmailMailboxOtherAppReadAccess"]/*' />
public enum EmailMailboxOtherAppReadAccess
{
    /// <include file='EmailMailboxOtherAppReadAccess.xml' path='doc/member[@name="EmailMailboxOtherAppReadAccess.EmailMailboxOtherAppReadAccess_SystemOnly"]/*' />
    EmailMailboxOtherAppReadAccess_SystemOnly = 0,

    /// <include file='EmailMailboxOtherAppReadAccess.xml' path='doc/member[@name="EmailMailboxOtherAppReadAccess.EmailMailboxOtherAppReadAccess_Full"]/*' />
    EmailMailboxOtherAppReadAccess_Full = 1,

    /// <include file='EmailMailboxOtherAppReadAccess.xml' path='doc/member[@name="EmailMailboxOtherAppReadAccess.EmailMailboxOtherAppReadAccess_None"]/*' />
    EmailMailboxOtherAppReadAccess_None = 2,
}
