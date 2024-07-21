// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GameBarCommandOrigin.xml' path='doc/member[@name="GameBarCommandOrigin"]/*' />
public enum GameBarCommandOrigin
{
    /// <include file='GameBarCommandOrigin.xml' path='doc/member[@name="GameBarCommandOrigin.GameBarCommandOrigin_ShortcutKey"]/*' />
    GameBarCommandOrigin_ShortcutKey = 0,

    /// <include file='GameBarCommandOrigin.xml' path='doc/member[@name="GameBarCommandOrigin.GameBarCommandOrigin_Cortana"]/*' />
    GameBarCommandOrigin_Cortana = 1,

    /// <include file='GameBarCommandOrigin.xml' path='doc/member[@name="GameBarCommandOrigin.GameBarCommandOrigin_AppCommand"]/*' />
    GameBarCommandOrigin_AppCommand = 2,
}
