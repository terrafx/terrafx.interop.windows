// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='InputActivationState.xml' path='doc/member[@name="InputActivationState"]/*' />
public enum InputActivationState
{
    /// <include file='InputActivationState.xml' path='doc/member[@name="InputActivationState.InputActivationState_None"]/*' />
    InputActivationState_None = 0,

    /// <include file='InputActivationState.xml' path='doc/member[@name="InputActivationState.InputActivationState_Deactivated"]/*' />
    InputActivationState_Deactivated = 1,

    /// <include file='InputActivationState.xml' path='doc/member[@name="InputActivationState.InputActivationState_ActivatedNotForeground"]/*' />
    InputActivationState_ActivatedNotForeground = 2,

    /// <include file='InputActivationState.xml' path='doc/member[@name="InputActivationState.InputActivationState_ActivatedInForeground"]/*' />
    InputActivationState_ActivatedInForeground = 3,
}
