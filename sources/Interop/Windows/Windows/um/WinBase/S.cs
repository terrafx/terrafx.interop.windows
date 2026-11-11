// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class S
{
    /// <include file='S.xml' path='doc/member[@name="S.S_QUEUEEMPTY"]/*' />
    [NativeTypeName("#define S_QUEUEEMPTY 0")]
    public const int S_QUEUEEMPTY = 0;

    /// <include file='S.xml' path='doc/member[@name="S.S_THRESHOLD"]/*' />
    [NativeTypeName("#define S_THRESHOLD 1")]
    public const int S_THRESHOLD = 1;

    /// <include file='S.xml' path='doc/member[@name="S.S_ALLTHRESHOLD"]/*' />
    [NativeTypeName("#define S_ALLTHRESHOLD 2")]
    public const int S_ALLTHRESHOLD = 2;

    /// <include file='S.xml' path='doc/member[@name="S.S_NORMAL"]/*' />
    [NativeTypeName("#define S_NORMAL 0")]
    public const int S_NORMAL = 0;

    /// <include file='S.xml' path='doc/member[@name="S.S_LEGATO"]/*' />
    [NativeTypeName("#define S_LEGATO 1")]
    public const int S_LEGATO = 1;

    /// <include file='S.xml' path='doc/member[@name="S.S_STACCATO"]/*' />
    [NativeTypeName("#define S_STACCATO 2")]
    public const int S_STACCATO = 2;

    /// <include file='S.xml' path='doc/member[@name="S.S_PERIOD512"]/*' />
    [NativeTypeName("#define S_PERIOD512 0")]
    public const int S_PERIOD512 = 0;

    /// <include file='S.xml' path='doc/member[@name="S.S_PERIOD1024"]/*' />
    [NativeTypeName("#define S_PERIOD1024 1")]
    public const int S_PERIOD1024 = 1;

    /// <include file='S.xml' path='doc/member[@name="S.S_PERIOD2048"]/*' />
    [NativeTypeName("#define S_PERIOD2048 2")]
    public const int S_PERIOD2048 = 2;

    /// <include file='S.xml' path='doc/member[@name="S.S_PERIODVOICE"]/*' />
    [NativeTypeName("#define S_PERIODVOICE 3")]
    public const int S_PERIODVOICE = 3;

    /// <include file='S.xml' path='doc/member[@name="S.S_WHITE512"]/*' />
    [NativeTypeName("#define S_WHITE512 4")]
    public const int S_WHITE512 = 4;

    /// <include file='S.xml' path='doc/member[@name="S.S_WHITE1024"]/*' />
    [NativeTypeName("#define S_WHITE1024 5")]
    public const int S_WHITE1024 = 5;

    /// <include file='S.xml' path='doc/member[@name="S.S_WHITE2048"]/*' />
    [NativeTypeName("#define S_WHITE2048 6")]
    public const int S_WHITE2048 = 6;

    /// <include file='S.xml' path='doc/member[@name="S.S_WHITEVOICE"]/*' />
    [NativeTypeName("#define S_WHITEVOICE 7")]
    public const int S_WHITEVOICE = 7;

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDVNA"]/*' />
    [NativeTypeName("#define S_SERDVNA (-1)")]
    public const int S_SERDVNA = (-1);

    /// <include file='S.xml' path='doc/member[@name="S.S_SEROFM"]/*' />
    [NativeTypeName("#define S_SEROFM (-2)")]
    public const int S_SEROFM = (-2);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERMACT"]/*' />
    [NativeTypeName("#define S_SERMACT (-3)")]
    public const int S_SERMACT = (-3);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERQFUL"]/*' />
    [NativeTypeName("#define S_SERQFUL (-4)")]
    public const int S_SERQFUL = (-4);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERBDNT"]/*' />
    [NativeTypeName("#define S_SERBDNT (-5)")]
    public const int S_SERBDNT = (-5);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDLN"]/*' />
    [NativeTypeName("#define S_SERDLN (-6)")]
    public const int S_SERDLN = (-6);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDCC"]/*' />
    [NativeTypeName("#define S_SERDCC (-7)")]
    public const int S_SERDCC = (-7);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDTP"]/*' />
    [NativeTypeName("#define S_SERDTP (-8)")]
    public const int S_SERDTP = (-8);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDVL"]/*' />
    [NativeTypeName("#define S_SERDVL (-9)")]
    public const int S_SERDVL = (-9);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDMD"]/*' />
    [NativeTypeName("#define S_SERDMD (-10)")]
    public const int S_SERDMD = (-10);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDSH"]/*' />
    [NativeTypeName("#define S_SERDSH (-11)")]
    public const int S_SERDSH = (-11);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDPT"]/*' />
    [NativeTypeName("#define S_SERDPT (-12)")]
    public const int S_SERDPT = (-12);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDFQ"]/*' />
    [NativeTypeName("#define S_SERDFQ (-13)")]
    public const int S_SERDFQ = (-13);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDDR"]/*' />
    [NativeTypeName("#define S_SERDDR (-14)")]
    public const int S_SERDDR = (-14);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDSR"]/*' />
    [NativeTypeName("#define S_SERDSR (-15)")]
    public const int S_SERDSR = (-15);

    /// <include file='S.xml' path='doc/member[@name="S.S_SERDST"]/*' />
    [NativeTypeName("#define S_SERDST (-16)")]
    public const int S_SERDST = (-16);
}
