// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TF
{
    /// <include file='TF.xml' path='doc/member[@name="TF.TF_E_NOCONVERSION"]/*' />
    [NativeTypeName("#define TF_E_NOCONVERSION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0600)")]
    public const int TF_E_NOCONVERSION = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0600))));

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_DICTATION_ON"]/*' />
    [NativeTypeName("#define TF_DICTATION_ON 0x00000001")]
    public const int TF_DICTATION_ON = 0x00000001;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_DICTATION_ENABLED"]/*' />
    [NativeTypeName("#define TF_DICTATION_ENABLED 0x00000002")]
    public const int TF_DICTATION_ENABLED = 0x00000002;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_COMMANDING_ENABLED"]/*' />
    [NativeTypeName("#define TF_COMMANDING_ENABLED 0x00000004")]
    public const int TF_COMMANDING_ENABLED = 0x00000004;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_COMMANDING_ON"]/*' />
    [NativeTypeName("#define TF_COMMANDING_ON 0x00000008")]
    public const int TF_COMMANDING_ON = 0x00000008;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SPEECHUI_SHOWN"]/*' />
    [NativeTypeName("#define TF_SPEECHUI_SHOWN 0x00000010")]
    public const int TF_SPEECHUI_SHOWN = 0x00000010;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_SHOW_BALLOON"]/*' />
    [NativeTypeName("#define TF_SHOW_BALLOON 0x00000001")]
    public const int TF_SHOW_BALLOON = 0x00000001;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_DISABLE_BALLOON"]/*' />
    [NativeTypeName("#define TF_DISABLE_BALLOON 0x00000002")]
    public const int TF_DISABLE_BALLOON = 0x00000002;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_MENUREADY"]/*' />
    [NativeTypeName("#define TF_MENUREADY 0x00000001")]
    public const int TF_MENUREADY = 0x00000001;

    /// <include file='TF.xml' path='doc/member[@name="TF.TF_PROPUI_STATUS_SAVETOFILE"]/*' />
    [NativeTypeName("#define TF_PROPUI_STATUS_SAVETOFILE 0x00000001")]
    public const int TF_PROPUI_STATUS_SAVETOFILE = 0x00000001;
}
