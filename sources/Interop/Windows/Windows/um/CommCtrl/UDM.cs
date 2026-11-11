// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class UDM
{
    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_SETRANGE"]/*' />
    [NativeTypeName("#define UDM_SETRANGE (WM_USER+101)")]
    public const int UDM_SETRANGE = (0x0400 + 101);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_GETRANGE"]/*' />
    [NativeTypeName("#define UDM_GETRANGE (WM_USER+102)")]
    public const int UDM_GETRANGE = (0x0400 + 102);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_SETPOS"]/*' />
    [NativeTypeName("#define UDM_SETPOS (WM_USER+103)")]
    public const int UDM_SETPOS = (0x0400 + 103);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_GETPOS"]/*' />
    [NativeTypeName("#define UDM_GETPOS (WM_USER+104)")]
    public const int UDM_GETPOS = (0x0400 + 104);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_SETBUDDY"]/*' />
    [NativeTypeName("#define UDM_SETBUDDY (WM_USER+105)")]
    public const int UDM_SETBUDDY = (0x0400 + 105);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_GETBUDDY"]/*' />
    [NativeTypeName("#define UDM_GETBUDDY (WM_USER+106)")]
    public const int UDM_GETBUDDY = (0x0400 + 106);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_SETACCEL"]/*' />
    [NativeTypeName("#define UDM_SETACCEL (WM_USER+107)")]
    public const int UDM_SETACCEL = (0x0400 + 107);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_GETACCEL"]/*' />
    [NativeTypeName("#define UDM_GETACCEL (WM_USER+108)")]
    public const int UDM_GETACCEL = (0x0400 + 108);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_SETBASE"]/*' />
    [NativeTypeName("#define UDM_SETBASE (WM_USER+109)")]
    public const int UDM_SETBASE = (0x0400 + 109);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_GETBASE"]/*' />
    [NativeTypeName("#define UDM_GETBASE (WM_USER+110)")]
    public const int UDM_GETBASE = (0x0400 + 110);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_SETRANGE32"]/*' />
    [NativeTypeName("#define UDM_SETRANGE32 (WM_USER+111)")]
    public const int UDM_SETRANGE32 = (0x0400 + 111);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_GETRANGE32"]/*' />
    [NativeTypeName("#define UDM_GETRANGE32 (WM_USER+112)")]
    public const int UDM_GETRANGE32 = (0x0400 + 112);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_SETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define UDM_SETUNICODEFORMAT CCM_SETUNICODEFORMAT")]
    public const int UDM_SETUNICODEFORMAT = (0x2000 + 5);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_GETUNICODEFORMAT"]/*' />
    [NativeTypeName("#define UDM_GETUNICODEFORMAT CCM_GETUNICODEFORMAT")]
    public const int UDM_GETUNICODEFORMAT = (0x2000 + 6);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_SETPOS32"]/*' />
    [NativeTypeName("#define UDM_SETPOS32 (WM_USER+113)")]
    public const int UDM_SETPOS32 = (0x0400 + 113);

    /// <include file='UDM.xml' path='doc/member[@name="UDM.UDM_GETPOS32"]/*' />
    [NativeTypeName("#define UDM_GETPOS32 (WM_USER+114)")]
    public const int UDM_GETPOS32 = (0x0400 + 114);
}
