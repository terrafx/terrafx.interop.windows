// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaStreamType.xml' path='doc/member[@name="MediaStreamType"]/*' />
public enum MediaStreamType
{
    /// <include file='MediaStreamType.xml' path='doc/member[@name="MediaStreamType.MediaStreamType_VideoPreview"]/*' />
    MediaStreamType_VideoPreview = 0,

    /// <include file='MediaStreamType.xml' path='doc/member[@name="MediaStreamType.MediaStreamType_VideoRecord"]/*' />
    MediaStreamType_VideoRecord = 1,

    /// <include file='MediaStreamType.xml' path='doc/member[@name="MediaStreamType.MediaStreamType_Audio"]/*' />
    MediaStreamType_Audio = 2,

    /// <include file='MediaStreamType.xml' path='doc/member[@name="MediaStreamType.MediaStreamType_Photo"]/*' />
    MediaStreamType_Photo = 3,

    /// <include file='MediaStreamType.xml' path='doc/member[@name="MediaStreamType.MediaStreamType_Metadata"]/*' />
    MediaStreamType_Metadata = 4,
}
