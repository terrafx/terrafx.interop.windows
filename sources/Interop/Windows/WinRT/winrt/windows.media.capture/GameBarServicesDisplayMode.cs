// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GameBarServicesDisplayMode.xml' path='doc/member[@name="GameBarServicesDisplayMode"]/*' />
public enum GameBarServicesDisplayMode
{
    /// <include file='GameBarServicesDisplayMode.xml' path='doc/member[@name="GameBarServicesDisplayMode.GameBarServicesDisplayMode_Windowed"]/*' />
    GameBarServicesDisplayMode_Windowed = 0,

    /// <include file='GameBarServicesDisplayMode.xml' path='doc/member[@name="GameBarServicesDisplayMode.GameBarServicesDisplayMode_FullScreenExclusive"]/*' />
    GameBarServicesDisplayMode_FullScreenExclusive = 1,
}
