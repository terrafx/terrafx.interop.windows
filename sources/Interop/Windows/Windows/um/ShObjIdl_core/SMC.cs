// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SMC
{
    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_INITMENU"]/*' />
    [NativeTypeName("#define SMC_INITMENU 0x00000001")]
    public const int SMC_INITMENU = 0x00000001;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_CREATE"]/*' />
    [NativeTypeName("#define SMC_CREATE 0x00000002")]
    public const int SMC_CREATE = 0x00000002;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_EXITMENU"]/*' />
    [NativeTypeName("#define SMC_EXITMENU 0x00000003")]
    public const int SMC_EXITMENU = 0x00000003;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_GETINFO"]/*' />
    [NativeTypeName("#define SMC_GETINFO 0x00000005")]
    public const int SMC_GETINFO = 0x00000005;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_GETSFINFO"]/*' />
    [NativeTypeName("#define SMC_GETSFINFO 0x00000006")]
    public const int SMC_GETSFINFO = 0x00000006;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_GETOBJECT"]/*' />
    [NativeTypeName("#define SMC_GETOBJECT 0x00000007")]
    public const int SMC_GETOBJECT = 0x00000007;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_GETSFOBJECT"]/*' />
    [NativeTypeName("#define SMC_GETSFOBJECT 0x00000008")]
    public const int SMC_GETSFOBJECT = 0x00000008;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_SFEXEC"]/*' />
    [NativeTypeName("#define SMC_SFEXEC 0x00000009")]
    public const int SMC_SFEXEC = 0x00000009;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_SFSELECTITEM"]/*' />
    [NativeTypeName("#define SMC_SFSELECTITEM 0x0000000A")]
    public const int SMC_SFSELECTITEM = 0x0000000A;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_REFRESH"]/*' />
    [NativeTypeName("#define SMC_REFRESH 0x00000010")]
    public const int SMC_REFRESH = 0x00000010;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_DEMOTE"]/*' />
    [NativeTypeName("#define SMC_DEMOTE 0x00000011")]
    public const int SMC_DEMOTE = 0x00000011;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_PROMOTE"]/*' />
    [NativeTypeName("#define SMC_PROMOTE 0x00000012")]
    public const int SMC_PROMOTE = 0x00000012;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_DEFAULTICON"]/*' />
    [NativeTypeName("#define SMC_DEFAULTICON 0x00000016")]
    public const int SMC_DEFAULTICON = 0x00000016;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_NEWITEM"]/*' />
    [NativeTypeName("#define SMC_NEWITEM 0x00000017")]
    public const int SMC_NEWITEM = 0x00000017;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_CHEVRONEXPAND"]/*' />
    [NativeTypeName("#define SMC_CHEVRONEXPAND 0x00000019")]
    public const int SMC_CHEVRONEXPAND = 0x00000019;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_DISPLAYCHEVRONTIP"]/*' />
    [NativeTypeName("#define SMC_DISPLAYCHEVRONTIP 0x0000002A")]
    public const int SMC_DISPLAYCHEVRONTIP = 0x0000002A;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_SETSFOBJECT"]/*' />
    [NativeTypeName("#define SMC_SETSFOBJECT 0x0000002D")]
    public const int SMC_SETSFOBJECT = 0x0000002D;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_SHCHANGENOTIFY"]/*' />
    [NativeTypeName("#define SMC_SHCHANGENOTIFY 0x0000002E")]
    public const int SMC_SHCHANGENOTIFY = 0x0000002E;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_CHEVRONGETTIP"]/*' />
    [NativeTypeName("#define SMC_CHEVRONGETTIP 0x0000002F")]
    public const int SMC_CHEVRONGETTIP = 0x0000002F;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_SFDDRESTRICTED"]/*' />
    [NativeTypeName("#define SMC_SFDDRESTRICTED 0x00000030")]
    public const int SMC_SFDDRESTRICTED = 0x00000030;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_SFEXEC_MIDDLE"]/*' />
    [NativeTypeName("#define SMC_SFEXEC_MIDDLE 0x00000031")]
    public const int SMC_SFEXEC_MIDDLE = 0x00000031;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_GETAUTOEXPANDSTATE"]/*' />
    [NativeTypeName("#define SMC_GETAUTOEXPANDSTATE 0x00000041")]
    public const int SMC_GETAUTOEXPANDSTATE = 0x00000041;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_AUTOEXPANDCHANGE"]/*' />
    [NativeTypeName("#define SMC_AUTOEXPANDCHANGE 0x00000042")]
    public const int SMC_AUTOEXPANDCHANGE = 0x00000042;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_GETCONTEXTMENUMODIFIER"]/*' />
    [NativeTypeName("#define SMC_GETCONTEXTMENUMODIFIER 0x00000043")]
    public const int SMC_GETCONTEXTMENUMODIFIER = 0x00000043;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_GETBKCONTEXTMENU"]/*' />
    [NativeTypeName("#define SMC_GETBKCONTEXTMENU 0x00000044")]
    public const int SMC_GETBKCONTEXTMENU = 0x00000044;

    /// <include file='SMC.xml' path='doc/member[@name="SMC.SMC_OPEN"]/*' />
    [NativeTypeName("#define SMC_OPEN 0x00000045")]
    public const int SMC_OPEN = 0x00000045;
}
