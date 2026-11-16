// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DIPROP
{
    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_BUFFERSIZE"]/*' />
    [NativeTypeName("#define DIPROP_BUFFERSIZE MAKEDIPROP(1)")]
    public static Guid* DIPROP_BUFFERSIZE => unchecked((Guid*)(1));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_AXISMODE"]/*' />
    [NativeTypeName("#define DIPROP_AXISMODE MAKEDIPROP(2)")]
    public static Guid* DIPROP_AXISMODE => unchecked((Guid*)(2));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_GRANULARITY"]/*' />
    [NativeTypeName("#define DIPROP_GRANULARITY MAKEDIPROP(3)")]
    public static Guid* DIPROP_GRANULARITY => unchecked((Guid*)(3));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_RANGE"]/*' />
    [NativeTypeName("#define DIPROP_RANGE MAKEDIPROP(4)")]
    public static Guid* DIPROP_RANGE => unchecked((Guid*)(4));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_DEADZONE"]/*' />
    [NativeTypeName("#define DIPROP_DEADZONE MAKEDIPROP(5)")]
    public static Guid* DIPROP_DEADZONE => unchecked((Guid*)(5));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_SATURATION"]/*' />
    [NativeTypeName("#define DIPROP_SATURATION MAKEDIPROP(6)")]
    public static Guid* DIPROP_SATURATION => unchecked((Guid*)(6));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_FFGAIN"]/*' />
    [NativeTypeName("#define DIPROP_FFGAIN MAKEDIPROP(7)")]
    public static Guid* DIPROP_FFGAIN => unchecked((Guid*)(7));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_FFLOAD"]/*' />
    [NativeTypeName("#define DIPROP_FFLOAD MAKEDIPROP(8)")]
    public static Guid* DIPROP_FFLOAD => unchecked((Guid*)(8));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_AUTOCENTER"]/*' />
    [NativeTypeName("#define DIPROP_AUTOCENTER MAKEDIPROP(9)")]
    public static Guid* DIPROP_AUTOCENTER => unchecked((Guid*)(9));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_CALIBRATIONMODE"]/*' />
    [NativeTypeName("#define DIPROP_CALIBRATIONMODE MAKEDIPROP(10)")]
    public static Guid* DIPROP_CALIBRATIONMODE => unchecked((Guid*)(10));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_CALIBRATION"]/*' />
    [NativeTypeName("#define DIPROP_CALIBRATION MAKEDIPROP(11)")]
    public static Guid* DIPROP_CALIBRATION => unchecked((Guid*)(11));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_GUIDANDPATH"]/*' />
    [NativeTypeName("#define DIPROP_GUIDANDPATH MAKEDIPROP(12)")]
    public static Guid* DIPROP_GUIDANDPATH => unchecked((Guid*)(12));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_INSTANCENAME"]/*' />
    [NativeTypeName("#define DIPROP_INSTANCENAME MAKEDIPROP(13)")]
    public static Guid* DIPROP_INSTANCENAME => unchecked((Guid*)(13));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_PRODUCTNAME"]/*' />
    [NativeTypeName("#define DIPROP_PRODUCTNAME MAKEDIPROP(14)")]
    public static Guid* DIPROP_PRODUCTNAME => unchecked((Guid*)(14));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_JOYSTICKID"]/*' />
    [NativeTypeName("#define DIPROP_JOYSTICKID MAKEDIPROP(15)")]
    public static Guid* DIPROP_JOYSTICKID => unchecked((Guid*)(15));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_GETPORTDISPLAYNAME"]/*' />
    [NativeTypeName("#define DIPROP_GETPORTDISPLAYNAME MAKEDIPROP(16)")]
    public static Guid* DIPROP_GETPORTDISPLAYNAME => unchecked((Guid*)(16));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_PHYSICALRANGE"]/*' />
    [NativeTypeName("#define DIPROP_PHYSICALRANGE MAKEDIPROP(18)")]
    public static Guid* DIPROP_PHYSICALRANGE => unchecked((Guid*)(18));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_LOGICALRANGE"]/*' />
    [NativeTypeName("#define DIPROP_LOGICALRANGE MAKEDIPROP(19)")]
    public static Guid* DIPROP_LOGICALRANGE => unchecked((Guid*)(19));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_KEYNAME"]/*' />
    [NativeTypeName("#define DIPROP_KEYNAME MAKEDIPROP(20)")]
    public static Guid* DIPROP_KEYNAME => unchecked((Guid*)(20));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_CPOINTS"]/*' />
    [NativeTypeName("#define DIPROP_CPOINTS MAKEDIPROP(21)")]
    public static Guid* DIPROP_CPOINTS => unchecked((Guid*)(21));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_APPDATA"]/*' />
    [NativeTypeName("#define DIPROP_APPDATA MAKEDIPROP(22)")]
    public static Guid* DIPROP_APPDATA => unchecked((Guid*)(22));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_SCANCODE"]/*' />
    [NativeTypeName("#define DIPROP_SCANCODE MAKEDIPROP(23)")]
    public static Guid* DIPROP_SCANCODE => unchecked((Guid*)(23));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_VIDPID"]/*' />
    [NativeTypeName("#define DIPROP_VIDPID MAKEDIPROP(24)")]
    public static Guid* DIPROP_VIDPID => unchecked((Guid*)(24));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_USERNAME"]/*' />
    [NativeTypeName("#define DIPROP_USERNAME MAKEDIPROP(25)")]
    public static Guid* DIPROP_USERNAME => unchecked((Guid*)(25));

    /// <include file='DIPROP.xml' path='doc/member[@name="DIPROP.DIPROP_TYPENAME"]/*' />
    [NativeTypeName("#define DIPROP_TYPENAME MAKEDIPROP(26)")]
    public static Guid* DIPROP_TYPENAME => unchecked((Guid*)(26));
}
