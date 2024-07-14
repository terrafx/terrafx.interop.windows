// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DraggingState.xml' path='doc/member[@name="DraggingState"]/*' />
public enum DraggingState
{
    /// <include file='DraggingState.xml' path='doc/member[@name="DraggingState.DraggingState_Started"]/*' />
    DraggingState_Started = 0,

    /// <include file='DraggingState.xml' path='doc/member[@name="DraggingState.DraggingState_Continuing"]/*' />
    DraggingState_Continuing = 1,

    /// <include file='DraggingState.xml' path='doc/member[@name="DraggingState.DraggingState_Completed"]/*' />
    DraggingState_Completed = 2,
}
