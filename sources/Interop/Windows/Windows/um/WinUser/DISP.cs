// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DISP
{
    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_CHANGE_SUCCESSFUL"]/*' />
    [NativeTypeName("#define DISP_CHANGE_SUCCESSFUL 0")]
    public const int DISP_CHANGE_SUCCESSFUL = 0;

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_CHANGE_RESTART"]/*' />
    [NativeTypeName("#define DISP_CHANGE_RESTART 1")]
    public const int DISP_CHANGE_RESTART = 1;

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_CHANGE_FAILED"]/*' />
    [NativeTypeName("#define DISP_CHANGE_FAILED -1")]
    public const int DISP_CHANGE_FAILED = -1;

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_CHANGE_BADMODE"]/*' />
    [NativeTypeName("#define DISP_CHANGE_BADMODE -2")]
    public const int DISP_CHANGE_BADMODE = -2;

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_CHANGE_NOTUPDATED"]/*' />
    [NativeTypeName("#define DISP_CHANGE_NOTUPDATED -3")]
    public const int DISP_CHANGE_NOTUPDATED = -3;

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_CHANGE_BADFLAGS"]/*' />
    [NativeTypeName("#define DISP_CHANGE_BADFLAGS -4")]
    public const int DISP_CHANGE_BADFLAGS = -4;

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_CHANGE_BADPARAM"]/*' />
    [NativeTypeName("#define DISP_CHANGE_BADPARAM -5")]
    public const int DISP_CHANGE_BADPARAM = -5;

    /// <include file='DISP.xml' path='doc/member[@name="DISP.DISP_CHANGE_BADDUALVIEW"]/*' />
    [NativeTypeName("#define DISP_CHANGE_BADDUALVIEW -6")]
    public const int DISP_CHANGE_BADDUALVIEW = -6;
}
