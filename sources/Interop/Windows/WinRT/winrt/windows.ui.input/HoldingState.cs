// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HoldingState.xml' path='doc/member[@name="HoldingState"]/*' />
public enum HoldingState
{
    /// <include file='HoldingState.xml' path='doc/member[@name="HoldingState.HoldingState_Started"]/*' />
    HoldingState_Started = 0,

    /// <include file='HoldingState.xml' path='doc/member[@name="HoldingState.HoldingState_Completed"]/*' />
    HoldingState_Completed = 1,

    /// <include file='HoldingState.xml' path='doc/member[@name="HoldingState.HoldingState_Canceled"]/*' />
    HoldingState_Canceled = 2,
}
