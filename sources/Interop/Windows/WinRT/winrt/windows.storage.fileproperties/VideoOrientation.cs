// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VideoOrientation.xml' path='doc/member[@name="VideoOrientation"]/*' />
public enum VideoOrientation
{
    /// <include file='VideoOrientation.xml' path='doc/member[@name="VideoOrientation.VideoOrientation_Normal"]/*' />
    VideoOrientation_Normal = 0,

    /// <include file='VideoOrientation.xml' path='doc/member[@name="VideoOrientation.VideoOrientation_Rotate90"]/*' />
    VideoOrientation_Rotate90 = 90,

    /// <include file='VideoOrientation.xml' path='doc/member[@name="VideoOrientation.VideoOrientation_Rotate180"]/*' />
    VideoOrientation_Rotate180 = 180,

    /// <include file='VideoOrientation.xml' path='doc/member[@name="VideoOrientation.VideoOrientation_Rotate270"]/*' />
    VideoOrientation_Rotate270 = 270,
}
