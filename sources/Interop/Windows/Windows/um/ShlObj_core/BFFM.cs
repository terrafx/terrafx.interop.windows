// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class BFFM
{
    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_INITIALIZED"]/*' />
    [NativeTypeName("#define BFFM_INITIALIZED 1")]
    public const int BFFM_INITIALIZED = 1;

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_SELCHANGED"]/*' />
    [NativeTypeName("#define BFFM_SELCHANGED 2")]
    public const int BFFM_SELCHANGED = 2;

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_VALIDATEFAILEDA"]/*' />
    [NativeTypeName("#define BFFM_VALIDATEFAILEDA 3")]
    public const int BFFM_VALIDATEFAILEDA = 3;

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_VALIDATEFAILEDW"]/*' />
    [NativeTypeName("#define BFFM_VALIDATEFAILEDW 4")]
    public const int BFFM_VALIDATEFAILEDW = 4;

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_IUNKNOWN"]/*' />
    [NativeTypeName("#define BFFM_IUNKNOWN 5")]
    public const int BFFM_IUNKNOWN = 5;

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_SETSTATUSTEXTA"]/*' />
    [NativeTypeName("#define BFFM_SETSTATUSTEXTA (WM_USER + 100)")]
    public const int BFFM_SETSTATUSTEXTA = (0x0400 + 100);

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_ENABLEOK"]/*' />
    [NativeTypeName("#define BFFM_ENABLEOK (WM_USER + 101)")]
    public const int BFFM_ENABLEOK = (0x0400 + 101);

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_SETSELECTIONA"]/*' />
    [NativeTypeName("#define BFFM_SETSELECTIONA (WM_USER + 102)")]
    public const int BFFM_SETSELECTIONA = (0x0400 + 102);

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_SETSELECTIONW"]/*' />
    [NativeTypeName("#define BFFM_SETSELECTIONW (WM_USER + 103)")]
    public const int BFFM_SETSELECTIONW = (0x0400 + 103);

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_SETSTATUSTEXTW"]/*' />
    [NativeTypeName("#define BFFM_SETSTATUSTEXTW (WM_USER + 104)")]
    public const int BFFM_SETSTATUSTEXTW = (0x0400 + 104);

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_SETOKTEXT"]/*' />
    [NativeTypeName("#define BFFM_SETOKTEXT (WM_USER + 105)")]
    public const int BFFM_SETOKTEXT = (0x0400 + 105);

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_SETEXPANDED"]/*' />
    [NativeTypeName("#define BFFM_SETEXPANDED (WM_USER + 106)")]
    public const int BFFM_SETEXPANDED = (0x0400 + 106);

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_SETSTATUSTEXT"]/*' />
    [NativeTypeName("#define BFFM_SETSTATUSTEXT BFFM_SETSTATUSTEXTW")]
    public const int BFFM_SETSTATUSTEXT = (0x0400 + 104);

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_SETSELECTION"]/*' />
    [NativeTypeName("#define BFFM_SETSELECTION BFFM_SETSELECTIONW")]
    public const int BFFM_SETSELECTION = (0x0400 + 103);

    /// <include file='BFFM.xml' path='doc/member[@name="BFFM.BFFM_VALIDATEFAILED"]/*' />
    [NativeTypeName("#define BFFM_VALIDATEFAILED BFFM_VALIDATEFAILEDW")]
    public const int BFFM_VALIDATEFAILED = 4;
}
