// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ThumbnailMode.xml' path='doc/member[@name="ThumbnailMode"]/*' />
public enum ThumbnailMode
{
    /// <include file='ThumbnailMode.xml' path='doc/member[@name="ThumbnailMode.ThumbnailMode_PicturesView"]/*' />
    ThumbnailMode_PicturesView = 0,

    /// <include file='ThumbnailMode.xml' path='doc/member[@name="ThumbnailMode.ThumbnailMode_VideosView"]/*' />
    ThumbnailMode_VideosView = 1,

    /// <include file='ThumbnailMode.xml' path='doc/member[@name="ThumbnailMode.ThumbnailMode_MusicView"]/*' />
    ThumbnailMode_MusicView = 2,

    /// <include file='ThumbnailMode.xml' path='doc/member[@name="ThumbnailMode.ThumbnailMode_DocumentsView"]/*' />
    ThumbnailMode_DocumentsView = 3,

    /// <include file='ThumbnailMode.xml' path='doc/member[@name="ThumbnailMode.ThumbnailMode_ListView"]/*' />
    ThumbnailMode_ListView = 4,

    /// <include file='ThumbnailMode.xml' path='doc/member[@name="ThumbnailMode.ThumbnailMode_SingleItem"]/*' />
    ThumbnailMode_SingleItem = 5,
}
