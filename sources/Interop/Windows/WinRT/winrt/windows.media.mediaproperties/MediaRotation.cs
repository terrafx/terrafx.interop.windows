// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaRotation.xml' path='doc/member[@name="MediaRotation"]/*' />
public enum MediaRotation
{
    /// <include file='MediaRotation.xml' path='doc/member[@name="MediaRotation.MediaRotation_None"]/*' />
    MediaRotation_None = 0,

    /// <include file='MediaRotation.xml' path='doc/member[@name="MediaRotation.MediaRotation_Clockwise90Degrees"]/*' />
    MediaRotation_Clockwise90Degrees = 1,

    /// <include file='MediaRotation.xml' path='doc/member[@name="MediaRotation.MediaRotation_Clockwise180Degrees"]/*' />
    MediaRotation_Clockwise180Degrees = 2,

    /// <include file='MediaRotation.xml' path='doc/member[@name="MediaRotation.MediaRotation_Clockwise270Degrees"]/*' />
    MediaRotation_Clockwise270Degrees = 3,
}
