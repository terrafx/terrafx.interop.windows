// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FrameFlashMode.xml' path='doc/member[@name="FrameFlashMode"]/*' />
public enum FrameFlashMode
{
    /// <include file='FrameFlashMode.xml' path='doc/member[@name="FrameFlashMode.FrameFlashMode_Disable"]/*' />
    FrameFlashMode_Disable = 0,

    /// <include file='FrameFlashMode.xml' path='doc/member[@name="FrameFlashMode.FrameFlashMode_Enable"]/*' />
    FrameFlashMode_Enable = 1,

    /// <include file='FrameFlashMode.xml' path='doc/member[@name="FrameFlashMode.FrameFlashMode_Global"]/*' />
    FrameFlashMode_Global = 2,
}
