// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERCEIVEDFLAG_UNDEFINED"]/*' />
    [NativeTypeName("#define PERCEIVEDFLAG_UNDEFINED 0x0000")]
    public const int PERCEIVEDFLAG_UNDEFINED = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERCEIVEDFLAG_SOFTCODED"]/*' />
    [NativeTypeName("#define PERCEIVEDFLAG_SOFTCODED 0x0001")]
    public const int PERCEIVEDFLAG_SOFTCODED = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERCEIVEDFLAG_HARDCODED"]/*' />
    [NativeTypeName("#define PERCEIVEDFLAG_HARDCODED 0x0002")]
    public const int PERCEIVEDFLAG_HARDCODED = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERCEIVEDFLAG_NATIVESUPPORT"]/*' />
    [NativeTypeName("#define PERCEIVEDFLAG_NATIVESUPPORT 0x0004")]
    public const int PERCEIVEDFLAG_NATIVESUPPORT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERCEIVEDFLAG_GDIPLUS"]/*' />
    [NativeTypeName("#define PERCEIVEDFLAG_GDIPLUS 0x0010")]
    public const int PERCEIVEDFLAG_GDIPLUS = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERCEIVEDFLAG_WMSDK"]/*' />
    [NativeTypeName("#define PERCEIVEDFLAG_WMSDK 0x0020")]
    public const int PERCEIVEDFLAG_WMSDK = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PERCEIVEDFLAG_ZIPFOLDER"]/*' />
    [NativeTypeName("#define PERCEIVEDFLAG_ZIPFOLDER 0x0040")]
    public const int PERCEIVEDFLAG_ZIPFOLDER = 0x0040;
}
