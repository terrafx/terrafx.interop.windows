// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppBroadcastPreviewState.xml' path='doc/member[@name="AppBroadcastPreviewState"]/*' />
public enum AppBroadcastPreviewState
{
    /// <include file='AppBroadcastPreviewState.xml' path='doc/member[@name="AppBroadcastPreviewState.AppBroadcastPreviewState_Started"]/*' />
    AppBroadcastPreviewState_Started = 0,

    /// <include file='AppBroadcastPreviewState.xml' path='doc/member[@name="AppBroadcastPreviewState.AppBroadcastPreviewState_Stopped"]/*' />
    AppBroadcastPreviewState_Stopped = 1,

    /// <include file='AppBroadcastPreviewState.xml' path='doc/member[@name="AppBroadcastPreviewState.AppBroadcastPreviewState_Failed"]/*' />
    AppBroadcastPreviewState_Failed = 2,
}
