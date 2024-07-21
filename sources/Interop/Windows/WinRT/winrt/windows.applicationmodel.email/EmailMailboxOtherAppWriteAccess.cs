// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMailboxOtherAppWriteAccess.xml' path='doc/member[@name="EmailMailboxOtherAppWriteAccess"]/*' />
public enum EmailMailboxOtherAppWriteAccess
{
    /// <include file='EmailMailboxOtherAppWriteAccess.xml' path='doc/member[@name="EmailMailboxOtherAppWriteAccess.EmailMailboxOtherAppWriteAccess_None"]/*' />
    EmailMailboxOtherAppWriteAccess_None = 0,

    /// <include file='EmailMailboxOtherAppWriteAccess.xml' path='doc/member[@name="EmailMailboxOtherAppWriteAccess.EmailMailboxOtherAppWriteAccess_Limited"]/*' />
    EmailMailboxOtherAppWriteAccess_Limited = 1,
}
