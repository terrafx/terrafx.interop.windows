// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastCaptureTargetType.xml' path='doc/member[@name="AppBroadcastCaptureTargetType"]/*' />
public enum AppBroadcastCaptureTargetType
{
    /// <include file='AppBroadcastCaptureTargetType.xml' path='doc/member[@name="AppBroadcastCaptureTargetType.AppBroadcastCaptureTargetType_AppView"]/*' />
    AppBroadcastCaptureTargetType_AppView = 0,

    /// <include file='AppBroadcastCaptureTargetType.xml' path='doc/member[@name="AppBroadcastCaptureTargetType.AppBroadcastCaptureTargetType_EntireDisplay"]/*' />
    AppBroadcastCaptureTargetType_EntireDisplay = 1,
}
