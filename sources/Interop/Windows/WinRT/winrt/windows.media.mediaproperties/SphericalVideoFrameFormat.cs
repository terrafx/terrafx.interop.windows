// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SphericalVideoFrameFormat.xml' path='doc/member[@name="SphericalVideoFrameFormat"]/*' />
public enum SphericalVideoFrameFormat
{
    /// <include file='SphericalVideoFrameFormat.xml' path='doc/member[@name="SphericalVideoFrameFormat.SphericalVideoFrameFormat_None"]/*' />
    SphericalVideoFrameFormat_None = 0,

    /// <include file='SphericalVideoFrameFormat.xml' path='doc/member[@name="SphericalVideoFrameFormat.SphericalVideoFrameFormat_Unsupported"]/*' />
    SphericalVideoFrameFormat_Unsupported = 1,

    /// <include file='SphericalVideoFrameFormat.xml' path='doc/member[@name="SphericalVideoFrameFormat.SphericalVideoFrameFormat_Equirectangular"]/*' />
    SphericalVideoFrameFormat_Equirectangular = 2,
}
