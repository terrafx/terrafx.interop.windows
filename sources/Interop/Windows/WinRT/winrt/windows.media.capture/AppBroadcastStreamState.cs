// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastStreamState.xml' path='doc/member[@name="AppBroadcastStreamState"]/*' />
public enum AppBroadcastStreamState
{
    /// <include file='AppBroadcastStreamState.xml' path='doc/member[@name="AppBroadcastStreamState.AppBroadcastStreamState_Initializing"]/*' />
    AppBroadcastStreamState_Initializing = 0,

    /// <include file='AppBroadcastStreamState.xml' path='doc/member[@name="AppBroadcastStreamState.AppBroadcastStreamState_StreamReady"]/*' />
    AppBroadcastStreamState_StreamReady = 1,

    /// <include file='AppBroadcastStreamState.xml' path='doc/member[@name="AppBroadcastStreamState.AppBroadcastStreamState_Started"]/*' />
    AppBroadcastStreamState_Started = 2,

    /// <include file='AppBroadcastStreamState.xml' path='doc/member[@name="AppBroadcastStreamState.AppBroadcastStreamState_Paused"]/*' />
    AppBroadcastStreamState_Paused = 3,

    /// <include file='AppBroadcastStreamState.xml' path='doc/member[@name="AppBroadcastStreamState.AppBroadcastStreamState_Terminated"]/*' />
    AppBroadcastStreamState_Terminated = 4,
}
