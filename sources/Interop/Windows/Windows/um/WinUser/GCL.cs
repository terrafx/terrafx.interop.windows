// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GCL
{
    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_MENUNAME"]/*' />
    [NativeTypeName("#define GCL_MENUNAME (-8)")]
    public const int GCL_MENUNAME = (-8);

    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_HBRBACKGROUND"]/*' />
    [NativeTypeName("#define GCL_HBRBACKGROUND (-10)")]
    public const int GCL_HBRBACKGROUND = (-10);

    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_HCURSOR"]/*' />
    [NativeTypeName("#define GCL_HCURSOR (-12)")]
    public const int GCL_HCURSOR = (-12);

    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_HICON"]/*' />
    [NativeTypeName("#define GCL_HICON (-14)")]
    public const int GCL_HICON = (-14);

    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_HMODULE"]/*' />
    [NativeTypeName("#define GCL_HMODULE (-16)")]
    public const int GCL_HMODULE = (-16);

    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_CBWNDEXTRA"]/*' />
    [NativeTypeName("#define GCL_CBWNDEXTRA (-18)")]
    public const int GCL_CBWNDEXTRA = (-18);

    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_CBCLSEXTRA"]/*' />
    [NativeTypeName("#define GCL_CBCLSEXTRA (-20)")]
    public const int GCL_CBCLSEXTRA = (-20);

    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_WNDPROC"]/*' />
    [NativeTypeName("#define GCL_WNDPROC (-24)")]
    public const int GCL_WNDPROC = (-24);

    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_STYLE"]/*' />
    [NativeTypeName("#define GCL_STYLE (-26)")]
    public const int GCL_STYLE = (-26);

    /// <include file='GCL.xml' path='doc/member[@name="GCL.GCL_HICONSM"]/*' />
    [NativeTypeName("#define GCL_HICONSM (-34)")]
    public const int GCL_HICONSM = (-34);
}
