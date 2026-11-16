// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SCHEME
{
    /// <include file='SCHEME.xml' path='doc/member[@name="SCHEME.SCHEME_DISPLAY"]/*' />
    [NativeTypeName("#define SCHEME_DISPLAY 0x0001")]
    public const int SCHEME_DISPLAY = 0x0001;

    /// <include file='SCHEME.xml' path='doc/member[@name="SCHEME.SCHEME_EDIT"]/*' />
    [NativeTypeName("#define SCHEME_EDIT 0x0002")]
    public const int SCHEME_EDIT = 0x0002;

    /// <include file='SCHEME.xml' path='doc/member[@name="SCHEME.SCHEME_LOCAL"]/*' />
    [NativeTypeName("#define SCHEME_LOCAL 0x0004")]
    public const int SCHEME_LOCAL = 0x0004;

    /// <include file='SCHEME.xml' path='doc/member[@name="SCHEME.SCHEME_GLOBAL"]/*' />
    [NativeTypeName("#define SCHEME_GLOBAL 0x0008")]
    public const int SCHEME_GLOBAL = 0x0008;

    /// <include file='SCHEME.xml' path='doc/member[@name="SCHEME.SCHEME_REFRESH"]/*' />
    [NativeTypeName("#define SCHEME_REFRESH 0x0010")]
    public const int SCHEME_REFRESH = 0x0010;

    /// <include file='SCHEME.xml' path='doc/member[@name="SCHEME.SCHEME_UPDATE"]/*' />
    [NativeTypeName("#define SCHEME_UPDATE 0x0020")]
    public const int SCHEME_UPDATE = 0x0020;

    /// <include file='SCHEME.xml' path='doc/member[@name="SCHEME.SCHEME_DONOTUSE"]/*' />
    [NativeTypeName("#define SCHEME_DONOTUSE 0x0040")]
    public const int SCHEME_DONOTUSE = 0x0040;

    /// <include file='SCHEME.xml' path='doc/member[@name="SCHEME.SCHEME_CREATE"]/*' />
    [NativeTypeName("#define SCHEME_CREATE 0x0080")]
    public const int SCHEME_CREATE = 0x0080;
}
