// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserInteractionMode.xml' path='doc/member[@name="UserInteractionMode"]/*' />
public enum UserInteractionMode
{
    /// <include file='UserInteractionMode.xml' path='doc/member[@name="UserInteractionMode.UserInteractionMode_Mouse"]/*' />
    UserInteractionMode_Mouse = 0,

    /// <include file='UserInteractionMode.xml' path='doc/member[@name="UserInteractionMode.UserInteractionMode_Touch"]/*' />
    UserInteractionMode_Touch = 1,
}
