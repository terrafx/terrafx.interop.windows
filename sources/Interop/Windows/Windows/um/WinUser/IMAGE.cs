// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IMAGE
{
    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_BITMAP"]/*' />
    [NativeTypeName("#define IMAGE_BITMAP 0")]
    public const int IMAGE_BITMAP = 0;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_ICON"]/*' />
    [NativeTypeName("#define IMAGE_ICON 1")]
    public const int IMAGE_ICON = 1;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_CURSOR"]/*' />
    [NativeTypeName("#define IMAGE_CURSOR 2")]
    public const int IMAGE_CURSOR = 2;

    /// <include file='IMAGE.xml' path='doc/member[@name="IMAGE.IMAGE_ENHMETAFILE"]/*' />
    [NativeTypeName("#define IMAGE_ENHMETAFILE 3")]
    public const int IMAGE_ENHMETAFILE = 3;
}
