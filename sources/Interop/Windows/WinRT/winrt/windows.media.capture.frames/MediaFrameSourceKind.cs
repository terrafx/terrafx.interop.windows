// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaFrameSourceKind.xml' path='doc/member[@name="MediaFrameSourceKind"]/*' />
public enum MediaFrameSourceKind
{
    /// <include file='MediaFrameSourceKind.xml' path='doc/member[@name="MediaFrameSourceKind.MediaFrameSourceKind_Custom"]/*' />
    MediaFrameSourceKind_Custom = 0,

    /// <include file='MediaFrameSourceKind.xml' path='doc/member[@name="MediaFrameSourceKind.MediaFrameSourceKind_Color"]/*' />
    MediaFrameSourceKind_Color = 1,

    /// <include file='MediaFrameSourceKind.xml' path='doc/member[@name="MediaFrameSourceKind.MediaFrameSourceKind_Infrared"]/*' />
    MediaFrameSourceKind_Infrared = 2,

    /// <include file='MediaFrameSourceKind.xml' path='doc/member[@name="MediaFrameSourceKind.MediaFrameSourceKind_Depth"]/*' />
    MediaFrameSourceKind_Depth = 3,

    /// <include file='MediaFrameSourceKind.xml' path='doc/member[@name="MediaFrameSourceKind.MediaFrameSourceKind_Audio"]/*' />
    MediaFrameSourceKind_Audio = 4,

    /// <include file='MediaFrameSourceKind.xml' path='doc/member[@name="MediaFrameSourceKind.MediaFrameSourceKind_Image"]/*' />
    MediaFrameSourceKind_Image = 5,

    /// <include file='MediaFrameSourceKind.xml' path='doc/member[@name="MediaFrameSourceKind.MediaFrameSourceKind_Metadata"]/*' />
    MediaFrameSourceKind_Metadata = 6,
}
