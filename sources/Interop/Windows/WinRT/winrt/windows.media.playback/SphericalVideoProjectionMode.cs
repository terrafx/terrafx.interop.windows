// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SphericalVideoProjectionMode.xml' path='doc/member[@name="SphericalVideoProjectionMode"]/*' />
public enum SphericalVideoProjectionMode
{
    /// <include file='SphericalVideoProjectionMode.xml' path='doc/member[@name="SphericalVideoProjectionMode.SphericalVideoProjectionMode_Spherical"]/*' />
    SphericalVideoProjectionMode_Spherical = 0,

    /// <include file='SphericalVideoProjectionMode.xml' path='doc/member[@name="SphericalVideoProjectionMode.SphericalVideoProjectionMode_Flat"]/*' />
    SphericalVideoProjectionMode_Flat = 1,
}
