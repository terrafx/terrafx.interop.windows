// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CameraStreamState.xml' path='doc/member[@name="CameraStreamState"]/*' />
public enum CameraStreamState
{
    /// <include file='CameraStreamState.xml' path='doc/member[@name="CameraStreamState.CameraStreamState_NotStreaming"]/*' />
    CameraStreamState_NotStreaming = 0,

    /// <include file='CameraStreamState.xml' path='doc/member[@name="CameraStreamState.CameraStreamState_Streaming"]/*' />
    CameraStreamState_Streaming = 1,

    /// <include file='CameraStreamState.xml' path='doc/member[@name="CameraStreamState.CameraStreamState_BlockedForPrivacy"]/*' />
    CameraStreamState_BlockedForPrivacy = 2,

    /// <include file='CameraStreamState.xml' path='doc/member[@name="CameraStreamState.CameraStreamState_Shutdown"]/*' />
    CameraStreamState_Shutdown = 3,
}
