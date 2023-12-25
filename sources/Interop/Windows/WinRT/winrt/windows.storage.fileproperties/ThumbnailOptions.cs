// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ThumbnailOptions.xml' path='doc/member[@name="ThumbnailOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum ThumbnailOptions : uint
{
    /// <include file='ThumbnailOptions.xml' path='doc/member[@name="ThumbnailOptions.ThumbnailOptions_None"]/*' />
    ThumbnailOptions_None = 0,

    /// <include file='ThumbnailOptions.xml' path='doc/member[@name="ThumbnailOptions.ThumbnailOptions_ReturnOnlyIfCached"]/*' />
    ThumbnailOptions_ReturnOnlyIfCached = 0x1,

    /// <include file='ThumbnailOptions.xml' path='doc/member[@name="ThumbnailOptions.ThumbnailOptions_ResizeThumbnail"]/*' />
    ThumbnailOptions_ResizeThumbnail = 0x2,

    /// <include file='ThumbnailOptions.xml' path='doc/member[@name="ThumbnailOptions.ThumbnailOptions_UseCurrentScale"]/*' />
    ThumbnailOptions_UseCurrentScale = 0x4,
}
