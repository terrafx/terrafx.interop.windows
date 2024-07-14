// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaPixelFormat.xml' path='doc/member[@name="MediaPixelFormat"]/*' />
public enum MediaPixelFormat
{
    /// <include file='MediaPixelFormat.xml' path='doc/member[@name="MediaPixelFormat.MediaPixelFormat_Nv12"]/*' />
    MediaPixelFormat_Nv12 = 0,

    /// <include file='MediaPixelFormat.xml' path='doc/member[@name="MediaPixelFormat.MediaPixelFormat_Bgra8"]/*' />
    MediaPixelFormat_Bgra8 = 1,

    /// <include file='MediaPixelFormat.xml' path='doc/member[@name="MediaPixelFormat.MediaPixelFormat_P010"]/*' />
    MediaPixelFormat_P010 = 2,
}
