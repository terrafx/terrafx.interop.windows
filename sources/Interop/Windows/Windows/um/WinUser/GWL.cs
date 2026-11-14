// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GWL
{
    /// <include file='GWL.xml' path='doc/member[@name="GWL.GWL_WNDPROC"]/*' />
    [NativeTypeName("#define GWL_WNDPROC (-4)")]
    public const int GWL_WNDPROC = (-4);

    /// <include file='GWL.xml' path='doc/member[@name="GWL.GWL_HINSTANCE"]/*' />
    [NativeTypeName("#define GWL_HINSTANCE (-6)")]
    public const int GWL_HINSTANCE = (-6);

    /// <include file='GWL.xml' path='doc/member[@name="GWL.GWL_HWNDPARENT"]/*' />
    [NativeTypeName("#define GWL_HWNDPARENT (-8)")]
    public const int GWL_HWNDPARENT = (-8);

    /// <include file='GWL.xml' path='doc/member[@name="GWL.GWL_STYLE"]/*' />
    [NativeTypeName("#define GWL_STYLE (-16)")]
    public const int GWL_STYLE = (-16);

    /// <include file='GWL.xml' path='doc/member[@name="GWL.GWL_EXSTYLE"]/*' />
    [NativeTypeName("#define GWL_EXSTYLE (-20)")]
    public const int GWL_EXSTYLE = (-20);

    /// <include file='GWL.xml' path='doc/member[@name="GWL.GWL_USERDATA"]/*' />
    [NativeTypeName("#define GWL_USERDATA (-21)")]
    public const int GWL_USERDATA = (-21);

    /// <include file='GWL.xml' path='doc/member[@name="GWL.GWL_ID"]/*' />
    [NativeTypeName("#define GWL_ID (-12)")]
    public const int GWL_ID = (-12);
}
