// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaCapturePauseBehavior.xml' path='doc/member[@name="MediaCapturePauseBehavior"]/*' />
public enum MediaCapturePauseBehavior
{
    /// <include file='MediaCapturePauseBehavior.xml' path='doc/member[@name="MediaCapturePauseBehavior.MediaCapturePauseBehavior_RetainHardwareResources"]/*' />
    MediaCapturePauseBehavior_RetainHardwareResources = 0,

    /// <include file='MediaCapturePauseBehavior.xml' path='doc/member[@name="MediaCapturePauseBehavior.MediaCapturePauseBehavior_ReleaseHardwareResources"]/*' />
    MediaCapturePauseBehavior_ReleaseHardwareResources = 1,
}
