// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaCaptureFocusState.xml' path='doc/member[@name="MediaCaptureFocusState"]/*' />
public enum MediaCaptureFocusState
{
    /// <include file='MediaCaptureFocusState.xml' path='doc/member[@name="MediaCaptureFocusState.MediaCaptureFocusState_Uninitialized"]/*' />
    MediaCaptureFocusState_Uninitialized = 0,

    /// <include file='MediaCaptureFocusState.xml' path='doc/member[@name="MediaCaptureFocusState.MediaCaptureFocusState_Lost"]/*' />
    MediaCaptureFocusState_Lost = 1,

    /// <include file='MediaCaptureFocusState.xml' path='doc/member[@name="MediaCaptureFocusState.MediaCaptureFocusState_Searching"]/*' />
    MediaCaptureFocusState_Searching = 2,

    /// <include file='MediaCaptureFocusState.xml' path='doc/member[@name="MediaCaptureFocusState.MediaCaptureFocusState_Focused"]/*' />
    MediaCaptureFocusState_Focused = 3,

    /// <include file='MediaCaptureFocusState.xml' path='doc/member[@name="MediaCaptureFocusState.MediaCaptureFocusState_Failed"]/*' />
    MediaCaptureFocusState_Failed = 4,
}
