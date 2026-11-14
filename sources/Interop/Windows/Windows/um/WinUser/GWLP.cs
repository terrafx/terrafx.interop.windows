// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GWLP
{
    /// <include file='GWLP.xml' path='doc/member[@name="GWLP.GWLP_WNDPROC"]/*' />
    [NativeTypeName("#define GWLP_WNDPROC (-4)")]
    public const int GWLP_WNDPROC = (-4);

    /// <include file='GWLP.xml' path='doc/member[@name="GWLP.GWLP_HINSTANCE"]/*' />
    [NativeTypeName("#define GWLP_HINSTANCE (-6)")]
    public const int GWLP_HINSTANCE = (-6);

    /// <include file='GWLP.xml' path='doc/member[@name="GWLP.GWLP_HWNDPARENT"]/*' />
    [NativeTypeName("#define GWLP_HWNDPARENT (-8)")]
    public const int GWLP_HWNDPARENT = (-8);

    /// <include file='GWLP.xml' path='doc/member[@name="GWLP.GWLP_USERDATA"]/*' />
    [NativeTypeName("#define GWLP_USERDATA (-21)")]
    public const int GWLP_USERDATA = (-21);

    /// <include file='GWLP.xml' path='doc/member[@name="GWLP.GWLP_ID"]/*' />
    [NativeTypeName("#define GWLP_ID (-12)")]
    public const int GWLP_ID = (-12);
}
