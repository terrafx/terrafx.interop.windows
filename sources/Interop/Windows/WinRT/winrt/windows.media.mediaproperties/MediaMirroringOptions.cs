// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaMirroringOptions.xml' path='doc/member[@name="MediaMirroringOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum MediaMirroringOptions : uint
{
    /// <include file='MediaMirroringOptions.xml' path='doc/member[@name="MediaMirroringOptions.MediaMirroringOptions_None"]/*' />
    MediaMirroringOptions_None = 0,

    /// <include file='MediaMirroringOptions.xml' path='doc/member[@name="MediaMirroringOptions.MediaMirroringOptions_Horizontal"]/*' />
    MediaMirroringOptions_Horizontal = 0x1,

    /// <include file='MediaMirroringOptions.xml' path='doc/member[@name="MediaMirroringOptions.MediaMirroringOptions_Vertical"]/*' />
    MediaMirroringOptions_Vertical = 0x2,
}
