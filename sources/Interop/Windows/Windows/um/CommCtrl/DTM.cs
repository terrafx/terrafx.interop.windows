// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DTM
{
    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_FIRST"]/*' />
    [NativeTypeName("#define DTM_FIRST 0x1000")]
    public const int DTM_FIRST = 0x1000;

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_GETSYSTEMTIME"]/*' />
    [NativeTypeName("#define DTM_GETSYSTEMTIME (DTM_FIRST + 1)")]
    public const int DTM_GETSYSTEMTIME = (0x1000 + 1);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_SETSYSTEMTIME"]/*' />
    [NativeTypeName("#define DTM_SETSYSTEMTIME (DTM_FIRST + 2)")]
    public const int DTM_SETSYSTEMTIME = (0x1000 + 2);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_GETRANGE"]/*' />
    [NativeTypeName("#define DTM_GETRANGE (DTM_FIRST + 3)")]
    public const int DTM_GETRANGE = (0x1000 + 3);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_SETRANGE"]/*' />
    [NativeTypeName("#define DTM_SETRANGE (DTM_FIRST + 4)")]
    public const int DTM_SETRANGE = (0x1000 + 4);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_SETFORMATA"]/*' />
    [NativeTypeName("#define DTM_SETFORMATA (DTM_FIRST + 5)")]
    public const int DTM_SETFORMATA = (0x1000 + 5);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_SETFORMATW"]/*' />
    [NativeTypeName("#define DTM_SETFORMATW (DTM_FIRST + 50)")]
    public const int DTM_SETFORMATW = (0x1000 + 50);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_SETFORMAT"]/*' />
    [NativeTypeName("#define DTM_SETFORMAT DTM_SETFORMATW")]
    public const int DTM_SETFORMAT = (0x1000 + 50);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_SETMCCOLOR"]/*' />
    [NativeTypeName("#define DTM_SETMCCOLOR (DTM_FIRST + 6)")]
    public const int DTM_SETMCCOLOR = (0x1000 + 6);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_GETMCCOLOR"]/*' />
    [NativeTypeName("#define DTM_GETMCCOLOR (DTM_FIRST + 7)")]
    public const int DTM_GETMCCOLOR = (0x1000 + 7);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_GETMONTHCAL"]/*' />
    [NativeTypeName("#define DTM_GETMONTHCAL (DTM_FIRST + 8)")]
    public const int DTM_GETMONTHCAL = (0x1000 + 8);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_SETMCFONT"]/*' />
    [NativeTypeName("#define DTM_SETMCFONT (DTM_FIRST + 9)")]
    public const int DTM_SETMCFONT = (0x1000 + 9);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_GETMCFONT"]/*' />
    [NativeTypeName("#define DTM_GETMCFONT (DTM_FIRST + 10)")]
    public const int DTM_GETMCFONT = (0x1000 + 10);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_SETMCSTYLE"]/*' />
    [NativeTypeName("#define DTM_SETMCSTYLE (DTM_FIRST + 11)")]
    public const int DTM_SETMCSTYLE = (0x1000 + 11);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_GETMCSTYLE"]/*' />
    [NativeTypeName("#define DTM_GETMCSTYLE (DTM_FIRST + 12)")]
    public const int DTM_GETMCSTYLE = (0x1000 + 12);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_CLOSEMONTHCAL"]/*' />
    [NativeTypeName("#define DTM_CLOSEMONTHCAL (DTM_FIRST + 13)")]
    public const int DTM_CLOSEMONTHCAL = (0x1000 + 13);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_GETDATETIMEPICKERINFO"]/*' />
    [NativeTypeName("#define DTM_GETDATETIMEPICKERINFO (DTM_FIRST + 14)")]
    public const int DTM_GETDATETIMEPICKERINFO = (0x1000 + 14);

    /// <include file='DTM.xml' path='doc/member[@name="DTM.DTM_GETIDEALSIZE"]/*' />
    [NativeTypeName("#define DTM_GETIDEALSIZE (DTM_FIRST + 15)")]
    public const int DTM_GETIDEALSIZE = (0x1000 + 15);
}
