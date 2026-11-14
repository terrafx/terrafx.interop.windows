// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Cpl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CPL
{
    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_DYNAMIC_RES"]/*' />
    [NativeTypeName("#define CPL_DYNAMIC_RES 0")]
    public const int CPL_DYNAMIC_RES = 0;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_INIT"]/*' />
    [NativeTypeName("#define CPL_INIT 1")]
    public const int CPL_INIT = 1;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_GETCOUNT"]/*' />
    [NativeTypeName("#define CPL_GETCOUNT 2")]
    public const int CPL_GETCOUNT = 2;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_INQUIRE"]/*' />
    [NativeTypeName("#define CPL_INQUIRE 3")]
    public const int CPL_INQUIRE = 3;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_SELECT"]/*' />
    [NativeTypeName("#define CPL_SELECT 4")]
    public const int CPL_SELECT = 4;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_DBLCLK"]/*' />
    [NativeTypeName("#define CPL_DBLCLK 5")]
    public const int CPL_DBLCLK = 5;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_STOP"]/*' />
    [NativeTypeName("#define CPL_STOP 6")]
    public const int CPL_STOP = 6;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_EXIT"]/*' />
    [NativeTypeName("#define CPL_EXIT 7")]
    public const int CPL_EXIT = 7;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_NEWINQUIRE"]/*' />
    [NativeTypeName("#define CPL_NEWINQUIRE 8")]
    public const int CPL_NEWINQUIRE = 8;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_STARTWPARMSA"]/*' />
    [NativeTypeName("#define CPL_STARTWPARMSA 9")]
    public const int CPL_STARTWPARMSA = 9;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_STARTWPARMSW"]/*' />
    [NativeTypeName("#define CPL_STARTWPARMSW 10")]
    public const int CPL_STARTWPARMSW = 10;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_STARTWPARMS"]/*' />
    [NativeTypeName("#define CPL_STARTWPARMS CPL_STARTWPARMSW")]
    public const int CPL_STARTWPARMS = 10;

    /// <include file='CPL.xml' path='doc/member[@name="CPL.CPL_SETUP"]/*' />
    [NativeTypeName("#define CPL_SETUP 200")]
    public const int CPL_SETUP = 200;
}
