// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CameraOcclusionKind.xml' path='doc/member[@name="CameraOcclusionKind"]/*' />
public enum CameraOcclusionKind
{
    /// <include file='CameraOcclusionKind.xml' path='doc/member[@name="CameraOcclusionKind.CameraOcclusionKind_Lid"]/*' />
    CameraOcclusionKind_Lid = 0,

    /// <include file='CameraOcclusionKind.xml' path='doc/member[@name="CameraOcclusionKind.CameraOcclusionKind_CameraHardware"]/*' />
    CameraOcclusionKind_CameraHardware = 1,
}
