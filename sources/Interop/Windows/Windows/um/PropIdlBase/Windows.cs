// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROPSETFLAG_DEFAULT"]/*' />
    [NativeTypeName("#define PROPSETFLAG_DEFAULT ( 0 )")]
    public const int PROPSETFLAG_DEFAULT = (0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROPSETFLAG_NONSIMPLE"]/*' />
    [NativeTypeName("#define PROPSETFLAG_NONSIMPLE ( 1 )")]
    public const int PROPSETFLAG_NONSIMPLE = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROPSETFLAG_ANSI"]/*' />
    [NativeTypeName("#define PROPSETFLAG_ANSI ( 2 )")]
    public const int PROPSETFLAG_ANSI = (2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROPSETFLAG_UNBUFFERED"]/*' />
    [NativeTypeName("#define PROPSETFLAG_UNBUFFERED ( 4 )")]
    public const int PROPSETFLAG_UNBUFFERED = (4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROPSETFLAG_CASE_SENSITIVE"]/*' />
    [NativeTypeName("#define PROPSETFLAG_CASE_SENSITIVE ( 8 )")]
    public const int PROPSETFLAG_CASE_SENSITIVE = (8);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROPSET_BEHAVIOR_CASE_SENSITIVE"]/*' />
    [NativeTypeName("#define PROPSET_BEHAVIOR_CASE_SENSITIVE ( 1 )")]
    public const int PROPSET_BEHAVIOR_CASE_SENSITIVE = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRSPEC_INVALID"]/*' />
    [NativeTypeName("#define PRSPEC_INVALID ( 0xffffffff )")]
    public const uint PRSPEC_INVALID = (0xffffffff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRSPEC_LPWSTR"]/*' />
    [NativeTypeName("#define PRSPEC_LPWSTR ( 0 )")]
    public const int PRSPEC_LPWSTR = (0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRSPEC_PROPID"]/*' />
    [NativeTypeName("#define PRSPEC_PROPID ( 1 )")]
    public const int PRSPEC_PROPID = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROPSETHDR_OSVERSION_UNKNOWN"]/*' />
    [NativeTypeName("#define PROPSETHDR_OSVERSION_UNKNOWN 0xFFFFFFFF")]
    public const uint PROPSETHDR_OSVERSION_UNKNOWN = 0xFFFFFFFF;
}
