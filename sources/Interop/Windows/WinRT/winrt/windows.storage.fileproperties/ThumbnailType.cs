// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ThumbnailType.xml' path='doc/member[@name="ThumbnailType"]/*' />
public enum ThumbnailType
{
    /// <include file='ThumbnailType.xml' path='doc/member[@name="ThumbnailType.ThumbnailType_Image"]/*' />
    ThumbnailType_Image = 0,

    /// <include file='ThumbnailType.xml' path='doc/member[@name="ThumbnailType.ThumbnailType_Icon"]/*' />
    ThumbnailType_Icon = 1,
}
