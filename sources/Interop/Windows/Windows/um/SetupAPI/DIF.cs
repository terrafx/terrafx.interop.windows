// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DIF
{
    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_SELECTDEVICE"]/*' />
    [NativeTypeName("#define DIF_SELECTDEVICE 0x00000001")]
    public const int DIF_SELECTDEVICE = 0x00000001;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_INSTALLDEVICE"]/*' />
    [NativeTypeName("#define DIF_INSTALLDEVICE 0x00000002")]
    public const int DIF_INSTALLDEVICE = 0x00000002;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_ASSIGNRESOURCES"]/*' />
    [NativeTypeName("#define DIF_ASSIGNRESOURCES 0x00000003")]
    public const int DIF_ASSIGNRESOURCES = 0x00000003;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_PROPERTIES"]/*' />
    [NativeTypeName("#define DIF_PROPERTIES 0x00000004")]
    public const int DIF_PROPERTIES = 0x00000004;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_REMOVE"]/*' />
    [NativeTypeName("#define DIF_REMOVE 0x00000005")]
    public const int DIF_REMOVE = 0x00000005;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_FIRSTTIMESETUP"]/*' />
    [NativeTypeName("#define DIF_FIRSTTIMESETUP 0x00000006")]
    public const int DIF_FIRSTTIMESETUP = 0x00000006;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_FOUNDDEVICE"]/*' />
    [NativeTypeName("#define DIF_FOUNDDEVICE 0x00000007")]
    public const int DIF_FOUNDDEVICE = 0x00000007;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_SELECTCLASSDRIVERS"]/*' />
    [NativeTypeName("#define DIF_SELECTCLASSDRIVERS 0x00000008")]
    public const int DIF_SELECTCLASSDRIVERS = 0x00000008;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_VALIDATECLASSDRIVERS"]/*' />
    [NativeTypeName("#define DIF_VALIDATECLASSDRIVERS 0x00000009")]
    public const int DIF_VALIDATECLASSDRIVERS = 0x00000009;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_INSTALLCLASSDRIVERS"]/*' />
    [NativeTypeName("#define DIF_INSTALLCLASSDRIVERS 0x0000000A")]
    public const int DIF_INSTALLCLASSDRIVERS = 0x0000000A;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_CALCDISKSPACE"]/*' />
    [NativeTypeName("#define DIF_CALCDISKSPACE 0x0000000B")]
    public const int DIF_CALCDISKSPACE = 0x0000000B;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_DESTROYPRIVATEDATA"]/*' />
    [NativeTypeName("#define DIF_DESTROYPRIVATEDATA 0x0000000C")]
    public const int DIF_DESTROYPRIVATEDATA = 0x0000000C;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_VALIDATEDRIVER"]/*' />
    [NativeTypeName("#define DIF_VALIDATEDRIVER 0x0000000D")]
    public const int DIF_VALIDATEDRIVER = 0x0000000D;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_DETECT"]/*' />
    [NativeTypeName("#define DIF_DETECT 0x0000000F")]
    public const int DIF_DETECT = 0x0000000F;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_INSTALLWIZARD"]/*' />
    [NativeTypeName("#define DIF_INSTALLWIZARD 0x00000010")]
    public const int DIF_INSTALLWIZARD = 0x00000010;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_DESTROYWIZARDDATA"]/*' />
    [NativeTypeName("#define DIF_DESTROYWIZARDDATA 0x00000011")]
    public const int DIF_DESTROYWIZARDDATA = 0x00000011;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_PROPERTYCHANGE"]/*' />
    [NativeTypeName("#define DIF_PROPERTYCHANGE 0x00000012")]
    public const int DIF_PROPERTYCHANGE = 0x00000012;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_ENABLECLASS"]/*' />
    [NativeTypeName("#define DIF_ENABLECLASS 0x00000013")]
    public const int DIF_ENABLECLASS = 0x00000013;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_DETECTVERIFY"]/*' />
    [NativeTypeName("#define DIF_DETECTVERIFY 0x00000014")]
    public const int DIF_DETECTVERIFY = 0x00000014;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_INSTALLDEVICEFILES"]/*' />
    [NativeTypeName("#define DIF_INSTALLDEVICEFILES 0x00000015")]
    public const int DIF_INSTALLDEVICEFILES = 0x00000015;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_UNREMOVE"]/*' />
    [NativeTypeName("#define DIF_UNREMOVE 0x00000016")]
    public const int DIF_UNREMOVE = 0x00000016;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_SELECTBESTCOMPATDRV"]/*' />
    [NativeTypeName("#define DIF_SELECTBESTCOMPATDRV 0x00000017")]
    public const int DIF_SELECTBESTCOMPATDRV = 0x00000017;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_ALLOW_INSTALL"]/*' />
    [NativeTypeName("#define DIF_ALLOW_INSTALL 0x00000018")]
    public const int DIF_ALLOW_INSTALL = 0x00000018;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_REGISTERDEVICE"]/*' />
    [NativeTypeName("#define DIF_REGISTERDEVICE 0x00000019")]
    public const int DIF_REGISTERDEVICE = 0x00000019;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_NEWDEVICEWIZARD_PRESELECT"]/*' />
    [NativeTypeName("#define DIF_NEWDEVICEWIZARD_PRESELECT 0x0000001A")]
    public const int DIF_NEWDEVICEWIZARD_PRESELECT = 0x0000001A;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_NEWDEVICEWIZARD_SELECT"]/*' />
    [NativeTypeName("#define DIF_NEWDEVICEWIZARD_SELECT 0x0000001B")]
    public const int DIF_NEWDEVICEWIZARD_SELECT = 0x0000001B;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_NEWDEVICEWIZARD_PREANALYZE"]/*' />
    [NativeTypeName("#define DIF_NEWDEVICEWIZARD_PREANALYZE 0x0000001C")]
    public const int DIF_NEWDEVICEWIZARD_PREANALYZE = 0x0000001C;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_NEWDEVICEWIZARD_POSTANALYZE"]/*' />
    [NativeTypeName("#define DIF_NEWDEVICEWIZARD_POSTANALYZE 0x0000001D")]
    public const int DIF_NEWDEVICEWIZARD_POSTANALYZE = 0x0000001D;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_NEWDEVICEWIZARD_FINISHINSTALL"]/*' />
    [NativeTypeName("#define DIF_NEWDEVICEWIZARD_FINISHINSTALL 0x0000001E")]
    public const int DIF_NEWDEVICEWIZARD_FINISHINSTALL = 0x0000001E;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_UNUSED1"]/*' />
    [NativeTypeName("#define DIF_UNUSED1 0x0000001F")]
    public const int DIF_UNUSED1 = 0x0000001F;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_INSTALLINTERFACES"]/*' />
    [NativeTypeName("#define DIF_INSTALLINTERFACES 0x00000020")]
    public const int DIF_INSTALLINTERFACES = 0x00000020;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_DETECTCANCEL"]/*' />
    [NativeTypeName("#define DIF_DETECTCANCEL 0x00000021")]
    public const int DIF_DETECTCANCEL = 0x00000021;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_REGISTER_COINSTALLERS"]/*' />
    [NativeTypeName("#define DIF_REGISTER_COINSTALLERS 0x00000022")]
    public const int DIF_REGISTER_COINSTALLERS = 0x00000022;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_ADDPROPERTYPAGE_ADVANCED"]/*' />
    [NativeTypeName("#define DIF_ADDPROPERTYPAGE_ADVANCED 0x00000023")]
    public const int DIF_ADDPROPERTYPAGE_ADVANCED = 0x00000023;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_ADDPROPERTYPAGE_BASIC"]/*' />
    [NativeTypeName("#define DIF_ADDPROPERTYPAGE_BASIC 0x00000024")]
    public const int DIF_ADDPROPERTYPAGE_BASIC = 0x00000024;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_RESERVED1"]/*' />
    [NativeTypeName("#define DIF_RESERVED1 0x00000025")]
    public const int DIF_RESERVED1 = 0x00000025;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_TROUBLESHOOTER"]/*' />
    [NativeTypeName("#define DIF_TROUBLESHOOTER 0x00000026")]
    public const int DIF_TROUBLESHOOTER = 0x00000026;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_POWERMESSAGEWAKE"]/*' />
    [NativeTypeName("#define DIF_POWERMESSAGEWAKE 0x00000027")]
    public const int DIF_POWERMESSAGEWAKE = 0x00000027;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_ADDREMOTEPROPERTYPAGE_ADVANCED"]/*' />
    [NativeTypeName("#define DIF_ADDREMOTEPROPERTYPAGE_ADVANCED 0x00000028")]
    public const int DIF_ADDREMOTEPROPERTYPAGE_ADVANCED = 0x00000028;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_UPDATEDRIVER_UI"]/*' />
    [NativeTypeName("#define DIF_UPDATEDRIVER_UI 0x00000029")]
    public const int DIF_UPDATEDRIVER_UI = 0x00000029;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_FINISHINSTALL_ACTION"]/*' />
    [NativeTypeName("#define DIF_FINISHINSTALL_ACTION 0x0000002A")]
    public const int DIF_FINISHINSTALL_ACTION = 0x0000002A;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_RESERVED2"]/*' />
    [NativeTypeName("#define DIF_RESERVED2 0x00000030")]
    public const int DIF_RESERVED2 = 0x00000030;

    /// <include file='DIF.xml' path='doc/member[@name="DIF.DIF_MOVEDEVICE"]/*' />
    [NativeTypeName("#define DIF_MOVEDEVICE 0x0000000E")]
    public const int DIF_MOVEDEVICE = 0x0000000E;
}
