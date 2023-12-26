// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StereoscopicVideoRenderMode.xml' path='doc/member[@name="StereoscopicVideoRenderMode"]/*' />
public enum StereoscopicVideoRenderMode
{
    /// <include file='StereoscopicVideoRenderMode.xml' path='doc/member[@name="StereoscopicVideoRenderMode.StereoscopicVideoRenderMode_Mono"]/*' />
    StereoscopicVideoRenderMode_Mono = 0,

    /// <include file='StereoscopicVideoRenderMode.xml' path='doc/member[@name="StereoscopicVideoRenderMode.StereoscopicVideoRenderMode_Stereo"]/*' />
    StereoscopicVideoRenderMode_Stereo = 1,
}
