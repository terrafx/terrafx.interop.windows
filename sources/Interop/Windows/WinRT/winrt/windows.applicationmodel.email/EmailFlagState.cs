// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailFlagState.xml' path='doc/member[@name="EmailFlagState"]/*' />
public enum EmailFlagState
{
    /// <include file='EmailFlagState.xml' path='doc/member[@name="EmailFlagState.EmailFlagState_Unflagged"]/*' />
    EmailFlagState_Unflagged = 0,

    /// <include file='EmailFlagState.xml' path='doc/member[@name="EmailFlagState.EmailFlagState_Flagged"]/*' />
    EmailFlagState_Flagged = 1,

    /// <include file='EmailFlagState.xml' path='doc/member[@name="EmailFlagState.EmailFlagState_Completed"]/*' />
    EmailFlagState_Completed = 2,

    /// <include file='EmailFlagState.xml' path='doc/member[@name="EmailFlagState.EmailFlagState_Cleared"]/*' />
    EmailFlagState_Cleared = 3,
}
