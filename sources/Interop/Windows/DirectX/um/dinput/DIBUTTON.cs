// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIBUTTON
{
    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_SHIFTUP"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_SHIFTUP 0x01000C01")]
    public const int DIBUTTON_DRIVINGR_SHIFTUP = 0x01000C01;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_SHIFTDOWN"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_SHIFTDOWN 0x01000C02")]
    public const int DIBUTTON_DRIVINGR_SHIFTDOWN = 0x01000C02;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_VIEW"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_VIEW 0x01001C03")]
    public const int DIBUTTON_DRIVINGR_VIEW = 0x01001C03;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_MENU 0x010004FD")]
    public const int DIBUTTON_DRIVINGR_MENU = 0x010004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_BRAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_BRAKE 0x01004C04")]
    public const int DIBUTTON_DRIVINGR_BRAKE = 0x01004C04;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_DASHBOARD"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_DASHBOARD 0x01004405")]
    public const int DIBUTTON_DRIVINGR_DASHBOARD = 0x01004405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_AIDS"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_AIDS 0x01004406")]
    public const int DIBUTTON_DRIVINGR_AIDS = 0x01004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_MAP"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_MAP 0x01004407")]
    public const int DIBUTTON_DRIVINGR_MAP = 0x01004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_BOOST"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_BOOST 0x01004408")]
    public const int DIBUTTON_DRIVINGR_BOOST = 0x01004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_PIT"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_PIT 0x01004409")]
    public const int DIBUTTON_DRIVINGR_PIT = 0x01004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_ACCELERATE_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_ACCELERATE_LINK 0x0103D4E0")]
    public const int DIBUTTON_DRIVINGR_ACCELERATE_LINK = 0x0103D4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_STEER_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_STEER_LEFT_LINK 0x0100CCE4")]
    public const int DIBUTTON_DRIVINGR_STEER_LEFT_LINK = 0x0100CCE4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_STEER_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_STEER_RIGHT_LINK 0x0100CCEC")]
    public const int DIBUTTON_DRIVINGR_STEER_RIGHT_LINK = 0x0100CCEC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_GLANCE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_GLANCE_LEFT_LINK 0x0107C4E4")]
    public const int DIBUTTON_DRIVINGR_GLANCE_LEFT_LINK = 0x0107C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_GLANCE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_GLANCE_RIGHT_LINK 0x0107C4EC")]
    public const int DIBUTTON_DRIVINGR_GLANCE_RIGHT_LINK = 0x0107C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_DEVICE 0x010044FE")]
    public const int DIBUTTON_DRIVINGR_DEVICE = 0x010044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGR_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGR_PAUSE 0x010044FC")]
    public const int DIBUTTON_DRIVINGR_PAUSE = 0x010044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_FIRE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_FIRE 0x02000C01")]
    public const int DIBUTTON_DRIVINGC_FIRE = 0x02000C01;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_WEAPONS"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_WEAPONS 0x02000C02")]
    public const int DIBUTTON_DRIVINGC_WEAPONS = 0x02000C02;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_TARGET"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_TARGET 0x02000C03")]
    public const int DIBUTTON_DRIVINGC_TARGET = 0x02000C03;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_MENU 0x020004FD")]
    public const int DIBUTTON_DRIVINGC_MENU = 0x020004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_SHIFTUP"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_SHIFTUP 0x02004C04")]
    public const int DIBUTTON_DRIVINGC_SHIFTUP = 0x02004C04;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_SHIFTDOWN"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_SHIFTDOWN 0x02004C05")]
    public const int DIBUTTON_DRIVINGC_SHIFTDOWN = 0x02004C05;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_DASHBOARD"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_DASHBOARD 0x02004406")]
    public const int DIBUTTON_DRIVINGC_DASHBOARD = 0x02004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_AIDS"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_AIDS 0x02004407")]
    public const int DIBUTTON_DRIVINGC_AIDS = 0x02004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_BRAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_BRAKE 0x02004C08")]
    public const int DIBUTTON_DRIVINGC_BRAKE = 0x02004C08;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_FIRESECONDARY"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_FIRESECONDARY 0x02004C09")]
    public const int DIBUTTON_DRIVINGC_FIRESECONDARY = 0x02004C09;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_ACCELERATE_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_ACCELERATE_LINK 0x0203D4E0")]
    public const int DIBUTTON_DRIVINGC_ACCELERATE_LINK = 0x0203D4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_STEER_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_STEER_LEFT_LINK 0x0200CCE4")]
    public const int DIBUTTON_DRIVINGC_STEER_LEFT_LINK = 0x0200CCE4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_STEER_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_STEER_RIGHT_LINK 0x0200CCEC")]
    public const int DIBUTTON_DRIVINGC_STEER_RIGHT_LINK = 0x0200CCEC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_GLANCE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_GLANCE_LEFT_LINK 0x0207C4E4")]
    public const int DIBUTTON_DRIVINGC_GLANCE_LEFT_LINK = 0x0207C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_GLANCE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_GLANCE_RIGHT_LINK 0x0207C4EC")]
    public const int DIBUTTON_DRIVINGC_GLANCE_RIGHT_LINK = 0x0207C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_DEVICE 0x020044FE")]
    public const int DIBUTTON_DRIVINGC_DEVICE = 0x020044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGC_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGC_PAUSE 0x020044FC")]
    public const int DIBUTTON_DRIVINGC_PAUSE = 0x020044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_FIRE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_FIRE 0x03000C01")]
    public const int DIBUTTON_DRIVINGT_FIRE = 0x03000C01;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_WEAPONS"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_WEAPONS 0x03000C02")]
    public const int DIBUTTON_DRIVINGT_WEAPONS = 0x03000C02;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_TARGET"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_TARGET 0x03000C03")]
    public const int DIBUTTON_DRIVINGT_TARGET = 0x03000C03;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_MENU 0x030004FD")]
    public const int DIBUTTON_DRIVINGT_MENU = 0x030004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_VIEW"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_VIEW 0x03005C04")]
    public const int DIBUTTON_DRIVINGT_VIEW = 0x03005C04;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_DASHBOARD"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_DASHBOARD 0x03005C05")]
    public const int DIBUTTON_DRIVINGT_DASHBOARD = 0x03005C05;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_BRAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_BRAKE 0x03004C06")]
    public const int DIBUTTON_DRIVINGT_BRAKE = 0x03004C06;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_FIRESECONDARY"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_FIRESECONDARY 0x03004C07")]
    public const int DIBUTTON_DRIVINGT_FIRESECONDARY = 0x03004C07;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_ACCELERATE_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_ACCELERATE_LINK 0x0303D4E0")]
    public const int DIBUTTON_DRIVINGT_ACCELERATE_LINK = 0x0303D4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_STEER_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_STEER_LEFT_LINK 0x0300CCE4")]
    public const int DIBUTTON_DRIVINGT_STEER_LEFT_LINK = 0x0300CCE4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_STEER_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_STEER_RIGHT_LINK 0x0300CCEC")]
    public const int DIBUTTON_DRIVINGT_STEER_RIGHT_LINK = 0x0300CCEC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_BARREL_UP_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_BARREL_UP_LINK 0x030144E0")]
    public const int DIBUTTON_DRIVINGT_BARREL_UP_LINK = 0x030144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_BARREL_DOWN_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_BARREL_DOWN_LINK 0x030144E8")]
    public const int DIBUTTON_DRIVINGT_BARREL_DOWN_LINK = 0x030144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_ROTATE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_ROTATE_LEFT_LINK 0x030244E4")]
    public const int DIBUTTON_DRIVINGT_ROTATE_LEFT_LINK = 0x030244E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_ROTATE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_ROTATE_RIGHT_LINK 0x030244EC")]
    public const int DIBUTTON_DRIVINGT_ROTATE_RIGHT_LINK = 0x030244EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_GLANCE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_GLANCE_LEFT_LINK 0x0307C4E4")]
    public const int DIBUTTON_DRIVINGT_GLANCE_LEFT_LINK = 0x0307C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_GLANCE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_GLANCE_RIGHT_LINK 0x0307C4EC")]
    public const int DIBUTTON_DRIVINGT_GLANCE_RIGHT_LINK = 0x0307C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_DEVICE 0x030044FE")]
    public const int DIBUTTON_DRIVINGT_DEVICE = 0x030044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_DRIVINGT_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_DRIVINGT_PAUSE 0x030044FC")]
    public const int DIBUTTON_DRIVINGT_PAUSE = 0x030044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_VIEW"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_VIEW 0x04002401")]
    public const int DIBUTTON_FLYINGC_VIEW = 0x04002401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_DISPLAY 0x04002402")]
    public const int DIBUTTON_FLYINGC_DISPLAY = 0x04002402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_GEAR"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_GEAR 0x04002C03")]
    public const int DIBUTTON_FLYINGC_GEAR = 0x04002C03;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_MENU 0x040004FD")]
    public const int DIBUTTON_FLYINGC_MENU = 0x040004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_FLAPSUP"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_FLAPSUP 0x04006404")]
    public const int DIBUTTON_FLYINGC_FLAPSUP = 0x04006404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_FLAPSDOWN"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_FLAPSDOWN 0x04006405")]
    public const int DIBUTTON_FLYINGC_FLAPSDOWN = 0x04006405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_BRAKE_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_BRAKE_LINK 0x04046CE0")]
    public const int DIBUTTON_FLYINGC_BRAKE_LINK = 0x04046CE0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_FASTER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_FASTER_LINK 0x0403D4E0")]
    public const int DIBUTTON_FLYINGC_FASTER_LINK = 0x0403D4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_SLOWER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_SLOWER_LINK 0x0403D4E8")]
    public const int DIBUTTON_FLYINGC_SLOWER_LINK = 0x0403D4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_GLANCE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_GLANCE_LEFT_LINK 0x0407C4E4")]
    public const int DIBUTTON_FLYINGC_GLANCE_LEFT_LINK = 0x0407C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_GLANCE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_GLANCE_RIGHT_LINK 0x0407C4EC")]
    public const int DIBUTTON_FLYINGC_GLANCE_RIGHT_LINK = 0x0407C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_GLANCE_UP_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_GLANCE_UP_LINK 0x0407C4E0")]
    public const int DIBUTTON_FLYINGC_GLANCE_UP_LINK = 0x0407C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_GLANCE_DOWN_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_GLANCE_DOWN_LINK 0x0407C4E8")]
    public const int DIBUTTON_FLYINGC_GLANCE_DOWN_LINK = 0x0407C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_DEVICE 0x040044FE")]
    public const int DIBUTTON_FLYINGC_DEVICE = 0x040044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGC_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGC_PAUSE 0x040044FC")]
    public const int DIBUTTON_FLYINGC_PAUSE = 0x040044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_FIRE"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_FIRE 0x05000C01")]
    public const int DIBUTTON_FLYINGM_FIRE = 0x05000C01;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_WEAPONS"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_WEAPONS 0x05000C02")]
    public const int DIBUTTON_FLYINGM_WEAPONS = 0x05000C02;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_TARGET"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_TARGET 0x05000C03")]
    public const int DIBUTTON_FLYINGM_TARGET = 0x05000C03;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_MENU 0x050004FD")]
    public const int DIBUTTON_FLYINGM_MENU = 0x050004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_COUNTER"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_COUNTER 0x05005C04")]
    public const int DIBUTTON_FLYINGM_COUNTER = 0x05005C04;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_VIEW"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_VIEW 0x05006405")]
    public const int DIBUTTON_FLYINGM_VIEW = 0x05006405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_DISPLAY 0x05006406")]
    public const int DIBUTTON_FLYINGM_DISPLAY = 0x05006406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_FLAPSUP"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_FLAPSUP 0x05005407")]
    public const int DIBUTTON_FLYINGM_FLAPSUP = 0x05005407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_FLAPSDOWN"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_FLAPSDOWN 0x05005408")]
    public const int DIBUTTON_FLYINGM_FLAPSDOWN = 0x05005408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_FIRESECONDARY"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_FIRESECONDARY 0x05004C09")]
    public const int DIBUTTON_FLYINGM_FIRESECONDARY = 0x05004C09;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_GEAR"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_GEAR 0x0500640A")]
    public const int DIBUTTON_FLYINGM_GEAR = 0x0500640A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_BRAKE_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_BRAKE_LINK 0x050464E0")]
    public const int DIBUTTON_FLYINGM_BRAKE_LINK = 0x050464E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_FASTER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_FASTER_LINK 0x0503D4E0")]
    public const int DIBUTTON_FLYINGM_FASTER_LINK = 0x0503D4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_SLOWER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_SLOWER_LINK 0x0503D4E8")]
    public const int DIBUTTON_FLYINGM_SLOWER_LINK = 0x0503D4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_GLANCE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_GLANCE_LEFT_LINK 0x0507C4E4")]
    public const int DIBUTTON_FLYINGM_GLANCE_LEFT_LINK = 0x0507C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_GLANCE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_GLANCE_RIGHT_LINK 0x0507C4EC")]
    public const int DIBUTTON_FLYINGM_GLANCE_RIGHT_LINK = 0x0507C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_GLANCE_UP_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_GLANCE_UP_LINK 0x0507C4E0")]
    public const int DIBUTTON_FLYINGM_GLANCE_UP_LINK = 0x0507C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_GLANCE_DOWN_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_GLANCE_DOWN_LINK 0x0507C4E8")]
    public const int DIBUTTON_FLYINGM_GLANCE_DOWN_LINK = 0x0507C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_DEVICE 0x050044FE")]
    public const int DIBUTTON_FLYINGM_DEVICE = 0x050044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGM_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGM_PAUSE 0x050044FC")]
    public const int DIBUTTON_FLYINGM_PAUSE = 0x050044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_FIRE"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_FIRE 0x06001401")]
    public const int DIBUTTON_FLYINGH_FIRE = 0x06001401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_WEAPONS"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_WEAPONS 0x06001402")]
    public const int DIBUTTON_FLYINGH_WEAPONS = 0x06001402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_TARGET"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_TARGET 0x06001403")]
    public const int DIBUTTON_FLYINGH_TARGET = 0x06001403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_MENU 0x060004FD")]
    public const int DIBUTTON_FLYINGH_MENU = 0x060004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_COUNTER"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_COUNTER 0x06005404")]
    public const int DIBUTTON_FLYINGH_COUNTER = 0x06005404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_VIEW"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_VIEW 0x06006405")]
    public const int DIBUTTON_FLYINGH_VIEW = 0x06006405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_GEAR"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_GEAR 0x06006406")]
    public const int DIBUTTON_FLYINGH_GEAR = 0x06006406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_FIRESECONDARY"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_FIRESECONDARY 0x06004C07")]
    public const int DIBUTTON_FLYINGH_FIRESECONDARY = 0x06004C07;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_FASTER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_FASTER_LINK 0x0603DCE0")]
    public const int DIBUTTON_FLYINGH_FASTER_LINK = 0x0603DCE0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_SLOWER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_SLOWER_LINK 0x0603DCE8")]
    public const int DIBUTTON_FLYINGH_SLOWER_LINK = 0x0603DCE8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_GLANCE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_GLANCE_LEFT_LINK 0x0607C4E4")]
    public const int DIBUTTON_FLYINGH_GLANCE_LEFT_LINK = 0x0607C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_GLANCE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_GLANCE_RIGHT_LINK 0x0607C4EC")]
    public const int DIBUTTON_FLYINGH_GLANCE_RIGHT_LINK = 0x0607C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_GLANCE_UP_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_GLANCE_UP_LINK 0x0607C4E0")]
    public const int DIBUTTON_FLYINGH_GLANCE_UP_LINK = 0x0607C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_GLANCE_DOWN_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_GLANCE_DOWN_LINK 0x0607C4E8")]
    public const int DIBUTTON_FLYINGH_GLANCE_DOWN_LINK = 0x0607C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_DEVICE 0x060044FE")]
    public const int DIBUTTON_FLYINGH_DEVICE = 0x060044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FLYINGH_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FLYINGH_PAUSE 0x060044FC")]
    public const int DIBUTTON_FLYINGH_PAUSE = 0x060044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_FIRE"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_FIRE 0x07000401")]
    public const int DIBUTTON_SPACESIM_FIRE = 0x07000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_WEAPONS"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_WEAPONS 0x07000402")]
    public const int DIBUTTON_SPACESIM_WEAPONS = 0x07000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_TARGET"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_TARGET 0x07000403")]
    public const int DIBUTTON_SPACESIM_TARGET = 0x07000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_MENU 0x070004FD")]
    public const int DIBUTTON_SPACESIM_MENU = 0x070004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_VIEW"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_VIEW 0x07004404")]
    public const int DIBUTTON_SPACESIM_VIEW = 0x07004404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_DISPLAY 0x07004405")]
    public const int DIBUTTON_SPACESIM_DISPLAY = 0x07004405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_RAISE"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_RAISE 0x07004406")]
    public const int DIBUTTON_SPACESIM_RAISE = 0x07004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_LOWER"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_LOWER 0x07004407")]
    public const int DIBUTTON_SPACESIM_LOWER = 0x07004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_GEAR"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_GEAR 0x07004408")]
    public const int DIBUTTON_SPACESIM_GEAR = 0x07004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_FIRESECONDARY"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_FIRESECONDARY 0x07004409")]
    public const int DIBUTTON_SPACESIM_FIRESECONDARY = 0x07004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_LEFT_LINK 0x0700C4E4")]
    public const int DIBUTTON_SPACESIM_LEFT_LINK = 0x0700C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_RIGHT_LINK 0x0700C4EC")]
    public const int DIBUTTON_SPACESIM_RIGHT_LINK = 0x0700C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_FORWARD_LINK 0x070144E0")]
    public const int DIBUTTON_SPACESIM_FORWARD_LINK = 0x070144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_BACKWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_BACKWARD_LINK 0x070144E8")]
    public const int DIBUTTON_SPACESIM_BACKWARD_LINK = 0x070144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_FASTER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_FASTER_LINK 0x0703C4E0")]
    public const int DIBUTTON_SPACESIM_FASTER_LINK = 0x0703C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_SLOWER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_SLOWER_LINK 0x0703C4E8")]
    public const int DIBUTTON_SPACESIM_SLOWER_LINK = 0x0703C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_TURN_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_TURN_LEFT_LINK 0x070244E4")]
    public const int DIBUTTON_SPACESIM_TURN_LEFT_LINK = 0x070244E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_TURN_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_TURN_RIGHT_LINK 0x070244EC")]
    public const int DIBUTTON_SPACESIM_TURN_RIGHT_LINK = 0x070244EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_GLANCE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_GLANCE_LEFT_LINK 0x0707C4E4")]
    public const int DIBUTTON_SPACESIM_GLANCE_LEFT_LINK = 0x0707C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_GLANCE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_GLANCE_RIGHT_LINK 0x0707C4EC")]
    public const int DIBUTTON_SPACESIM_GLANCE_RIGHT_LINK = 0x0707C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_GLANCE_UP_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_GLANCE_UP_LINK 0x0707C4E0")]
    public const int DIBUTTON_SPACESIM_GLANCE_UP_LINK = 0x0707C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_GLANCE_DOWN_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_GLANCE_DOWN_LINK 0x0707C4E8")]
    public const int DIBUTTON_SPACESIM_GLANCE_DOWN_LINK = 0x0707C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_DEVICE 0x070044FE")]
    public const int DIBUTTON_SPACESIM_DEVICE = 0x070044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SPACESIM_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_SPACESIM_PAUSE 0x070044FC")]
    public const int DIBUTTON_SPACESIM_PAUSE = 0x070044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_PUNCH"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_PUNCH 0x08000401")]
    public const int DIBUTTON_FIGHTINGH_PUNCH = 0x08000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_KICK"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_KICK 0x08000402")]
    public const int DIBUTTON_FIGHTINGH_KICK = 0x08000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_BLOCK"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_BLOCK 0x08000403")]
    public const int DIBUTTON_FIGHTINGH_BLOCK = 0x08000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_CROUCH"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_CROUCH 0x08000404")]
    public const int DIBUTTON_FIGHTINGH_CROUCH = 0x08000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_JUMP 0x08000405")]
    public const int DIBUTTON_FIGHTINGH_JUMP = 0x08000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_SPECIAL1"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_SPECIAL1 0x08000406")]
    public const int DIBUTTON_FIGHTINGH_SPECIAL1 = 0x08000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_SPECIAL2"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_SPECIAL2 0x08000407")]
    public const int DIBUTTON_FIGHTINGH_SPECIAL2 = 0x08000407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_MENU 0x080004FD")]
    public const int DIBUTTON_FIGHTINGH_MENU = 0x080004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_SELECT 0x08004408")]
    public const int DIBUTTON_FIGHTINGH_SELECT = 0x08004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_DISPLAY 0x08004409")]
    public const int DIBUTTON_FIGHTINGH_DISPLAY = 0x08004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_DODGE"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_DODGE 0x0800440A")]
    public const int DIBUTTON_FIGHTINGH_DODGE = 0x0800440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_LEFT_LINK 0x0800C4E4")]
    public const int DIBUTTON_FIGHTINGH_LEFT_LINK = 0x0800C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_RIGHT_LINK 0x0800C4EC")]
    public const int DIBUTTON_FIGHTINGH_RIGHT_LINK = 0x0800C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_FORWARD_LINK 0x080144E0")]
    public const int DIBUTTON_FIGHTINGH_FORWARD_LINK = 0x080144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_BACKWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_BACKWARD_LINK 0x080144E8")]
    public const int DIBUTTON_FIGHTINGH_BACKWARD_LINK = 0x080144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_DEVICE 0x080044FE")]
    public const int DIBUTTON_FIGHTINGH_DEVICE = 0x080044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FIGHTINGH_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FIGHTINGH_PAUSE 0x080044FC")]
    public const int DIBUTTON_FIGHTINGH_PAUSE = 0x080044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_FIRE"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_FIRE 0x09000401")]
    public const int DIBUTTON_FPS_FIRE = 0x09000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_WEAPONS"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_WEAPONS 0x09000402")]
    public const int DIBUTTON_FPS_WEAPONS = 0x09000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_APPLY"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_APPLY 0x09000403")]
    public const int DIBUTTON_FPS_APPLY = 0x09000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_SELECT 0x09000404")]
    public const int DIBUTTON_FPS_SELECT = 0x09000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_CROUCH"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_CROUCH 0x09000405")]
    public const int DIBUTTON_FPS_CROUCH = 0x09000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_JUMP 0x09000406")]
    public const int DIBUTTON_FPS_JUMP = 0x09000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_STRAFE"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_STRAFE 0x09000407")]
    public const int DIBUTTON_FPS_STRAFE = 0x09000407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_MENU 0x090004FD")]
    public const int DIBUTTON_FPS_MENU = 0x090004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_DISPLAY 0x09004408")]
    public const int DIBUTTON_FPS_DISPLAY = 0x09004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_DODGE"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_DODGE 0x09004409")]
    public const int DIBUTTON_FPS_DODGE = 0x09004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_GLANCEL"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_GLANCEL 0x0900440A")]
    public const int DIBUTTON_FPS_GLANCEL = 0x0900440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_GLANCER"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_GLANCER 0x0900440B")]
    public const int DIBUTTON_FPS_GLANCER = 0x0900440B;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_FIRESECONDARY"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_FIRESECONDARY 0x0900440C")]
    public const int DIBUTTON_FPS_FIRESECONDARY = 0x0900440C;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_ROTATE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_ROTATE_LEFT_LINK 0x0900C4E4")]
    public const int DIBUTTON_FPS_ROTATE_LEFT_LINK = 0x0900C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_ROTATE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_ROTATE_RIGHT_LINK 0x0900C4EC")]
    public const int DIBUTTON_FPS_ROTATE_RIGHT_LINK = 0x0900C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_FORWARD_LINK 0x090144E0")]
    public const int DIBUTTON_FPS_FORWARD_LINK = 0x090144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_BACKWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_BACKWARD_LINK 0x090144E8")]
    public const int DIBUTTON_FPS_BACKWARD_LINK = 0x090144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_GLANCE_UP_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_GLANCE_UP_LINK 0x0901C4E0")]
    public const int DIBUTTON_FPS_GLANCE_UP_LINK = 0x0901C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_GLANCE_DOWN_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_GLANCE_DOWN_LINK 0x0901C4E8")]
    public const int DIBUTTON_FPS_GLANCE_DOWN_LINK = 0x0901C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_STEP_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_STEP_LEFT_LINK 0x090244E4")]
    public const int DIBUTTON_FPS_STEP_LEFT_LINK = 0x090244E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_STEP_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_STEP_RIGHT_LINK 0x090244EC")]
    public const int DIBUTTON_FPS_STEP_RIGHT_LINK = 0x090244EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_DEVICE 0x090044FE")]
    public const int DIBUTTON_FPS_DEVICE = 0x090044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FPS_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FPS_PAUSE 0x090044FC")]
    public const int DIBUTTON_FPS_PAUSE = 0x090044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_RUN"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_RUN 0x0A000401")]
    public const int DIBUTTON_TPS_RUN = 0x0A000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_ACTION"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_ACTION 0x0A000402")]
    public const int DIBUTTON_TPS_ACTION = 0x0A000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_SELECT 0x0A000403")]
    public const int DIBUTTON_TPS_SELECT = 0x0A000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_USE"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_USE 0x0A000404")]
    public const int DIBUTTON_TPS_USE = 0x0A000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_JUMP 0x0A000405")]
    public const int DIBUTTON_TPS_JUMP = 0x0A000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_MENU 0x0A0004FD")]
    public const int DIBUTTON_TPS_MENU = 0x0A0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_VIEW"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_VIEW 0x0A004406")]
    public const int DIBUTTON_TPS_VIEW = 0x0A004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_STEPLEFT"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_STEPLEFT 0x0A004407")]
    public const int DIBUTTON_TPS_STEPLEFT = 0x0A004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_STEPRIGHT"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_STEPRIGHT 0x0A004408")]
    public const int DIBUTTON_TPS_STEPRIGHT = 0x0A004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_DODGE"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_DODGE 0x0A004409")]
    public const int DIBUTTON_TPS_DODGE = 0x0A004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_INVENTORY"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_INVENTORY 0x0A00440A")]
    public const int DIBUTTON_TPS_INVENTORY = 0x0A00440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_TURN_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_TURN_LEFT_LINK 0x0A0244E4")]
    public const int DIBUTTON_TPS_TURN_LEFT_LINK = 0x0A0244E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_TURN_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_TURN_RIGHT_LINK 0x0A0244EC")]
    public const int DIBUTTON_TPS_TURN_RIGHT_LINK = 0x0A0244EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_FORWARD_LINK 0x0A0144E0")]
    public const int DIBUTTON_TPS_FORWARD_LINK = 0x0A0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_BACKWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_BACKWARD_LINK 0x0A0144E8")]
    public const int DIBUTTON_TPS_BACKWARD_LINK = 0x0A0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_GLANCE_UP_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_GLANCE_UP_LINK 0x0A07C4E0")]
    public const int DIBUTTON_TPS_GLANCE_UP_LINK = 0x0A07C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_GLANCE_DOWN_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_GLANCE_DOWN_LINK 0x0A07C4E8")]
    public const int DIBUTTON_TPS_GLANCE_DOWN_LINK = 0x0A07C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_GLANCE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_GLANCE_LEFT_LINK 0x0A07C4E4")]
    public const int DIBUTTON_TPS_GLANCE_LEFT_LINK = 0x0A07C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_GLANCE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_GLANCE_RIGHT_LINK 0x0A07C4EC")]
    public const int DIBUTTON_TPS_GLANCE_RIGHT_LINK = 0x0A07C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_DEVICE 0x0A0044FE")]
    public const int DIBUTTON_TPS_DEVICE = 0x0A0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_TPS_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_TPS_PAUSE 0x0A0044FC")]
    public const int DIBUTTON_TPS_PAUSE = 0x0A0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_GET"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_GET 0x0B000401")]
    public const int DIBUTTON_STRATEGYR_GET = 0x0B000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_APPLY"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_APPLY 0x0B000402")]
    public const int DIBUTTON_STRATEGYR_APPLY = 0x0B000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_SELECT 0x0B000403")]
    public const int DIBUTTON_STRATEGYR_SELECT = 0x0B000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_ATTACK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_ATTACK 0x0B000404")]
    public const int DIBUTTON_STRATEGYR_ATTACK = 0x0B000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_CAST"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_CAST 0x0B000405")]
    public const int DIBUTTON_STRATEGYR_CAST = 0x0B000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_CROUCH"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_CROUCH 0x0B000406")]
    public const int DIBUTTON_STRATEGYR_CROUCH = 0x0B000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_JUMP 0x0B000407")]
    public const int DIBUTTON_STRATEGYR_JUMP = 0x0B000407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_MENU 0x0B0004FD")]
    public const int DIBUTTON_STRATEGYR_MENU = 0x0B0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_MAP"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_MAP 0x0B004408")]
    public const int DIBUTTON_STRATEGYR_MAP = 0x0B004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_DISPLAY 0x0B004409")]
    public const int DIBUTTON_STRATEGYR_DISPLAY = 0x0B004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_LEFT_LINK 0x0B00C4E4")]
    public const int DIBUTTON_STRATEGYR_LEFT_LINK = 0x0B00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_RIGHT_LINK 0x0B00C4EC")]
    public const int DIBUTTON_STRATEGYR_RIGHT_LINK = 0x0B00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_FORWARD_LINK 0x0B0144E0")]
    public const int DIBUTTON_STRATEGYR_FORWARD_LINK = 0x0B0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_BACK_LINK 0x0B0144E8")]
    public const int DIBUTTON_STRATEGYR_BACK_LINK = 0x0B0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_ROTATE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_ROTATE_LEFT_LINK 0x0B0244E4")]
    public const int DIBUTTON_STRATEGYR_ROTATE_LEFT_LINK = 0x0B0244E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_ROTATE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_ROTATE_RIGHT_LINK 0x0B0244EC")]
    public const int DIBUTTON_STRATEGYR_ROTATE_RIGHT_LINK = 0x0B0244EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_DEVICE 0x0B0044FE")]
    public const int DIBUTTON_STRATEGYR_DEVICE = 0x0B0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYR_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYR_PAUSE 0x0B0044FC")]
    public const int DIBUTTON_STRATEGYR_PAUSE = 0x0B0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_SELECT 0x0C000401")]
    public const int DIBUTTON_STRATEGYT_SELECT = 0x0C000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_INSTRUCT"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_INSTRUCT 0x0C000402")]
    public const int DIBUTTON_STRATEGYT_INSTRUCT = 0x0C000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_APPLY"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_APPLY 0x0C000403")]
    public const int DIBUTTON_STRATEGYT_APPLY = 0x0C000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_TEAM"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_TEAM 0x0C000404")]
    public const int DIBUTTON_STRATEGYT_TEAM = 0x0C000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_TURN"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_TURN 0x0C000405")]
    public const int DIBUTTON_STRATEGYT_TURN = 0x0C000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_MENU 0x0C0004FD")]
    public const int DIBUTTON_STRATEGYT_MENU = 0x0C0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_ZOOM 0x0C004406")]
    public const int DIBUTTON_STRATEGYT_ZOOM = 0x0C004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_MAP"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_MAP 0x0C004407")]
    public const int DIBUTTON_STRATEGYT_MAP = 0x0C004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_DISPLAY 0x0C004408")]
    public const int DIBUTTON_STRATEGYT_DISPLAY = 0x0C004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_LEFT_LINK 0x0C00C4E4")]
    public const int DIBUTTON_STRATEGYT_LEFT_LINK = 0x0C00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_RIGHT_LINK 0x0C00C4EC")]
    public const int DIBUTTON_STRATEGYT_RIGHT_LINK = 0x0C00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_FORWARD_LINK 0x0C0144E0")]
    public const int DIBUTTON_STRATEGYT_FORWARD_LINK = 0x0C0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_BACK_LINK 0x0C0144E8")]
    public const int DIBUTTON_STRATEGYT_BACK_LINK = 0x0C0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_DEVICE 0x0C0044FE")]
    public const int DIBUTTON_STRATEGYT_DEVICE = 0x0C0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_STRATEGYT_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_STRATEGYT_PAUSE 0x0C0044FC")]
    public const int DIBUTTON_STRATEGYT_PAUSE = 0x0C0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_FIRE"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_FIRE 0x0D000401")]
    public const int DIBUTTON_HUNTING_FIRE = 0x0D000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_AIM"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_AIM 0x0D000402")]
    public const int DIBUTTON_HUNTING_AIM = 0x0D000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_WEAPON"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_WEAPON 0x0D000403")]
    public const int DIBUTTON_HUNTING_WEAPON = 0x0D000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_BINOCULAR"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_BINOCULAR 0x0D000404")]
    public const int DIBUTTON_HUNTING_BINOCULAR = 0x0D000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_CALL"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_CALL 0x0D000405")]
    public const int DIBUTTON_HUNTING_CALL = 0x0D000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_MAP"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_MAP 0x0D000406")]
    public const int DIBUTTON_HUNTING_MAP = 0x0D000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_SPECIAL 0x0D000407")]
    public const int DIBUTTON_HUNTING_SPECIAL = 0x0D000407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_MENU 0x0D0004FD")]
    public const int DIBUTTON_HUNTING_MENU = 0x0D0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_DISPLAY 0x0D004408")]
    public const int DIBUTTON_HUNTING_DISPLAY = 0x0D004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_CROUCH"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_CROUCH 0x0D004409")]
    public const int DIBUTTON_HUNTING_CROUCH = 0x0D004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_JUMP 0x0D00440A")]
    public const int DIBUTTON_HUNTING_JUMP = 0x0D00440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_FIRESECONDARY"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_FIRESECONDARY 0x0D00440B")]
    public const int DIBUTTON_HUNTING_FIRESECONDARY = 0x0D00440B;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_LEFT_LINK 0x0D00C4E4")]
    public const int DIBUTTON_HUNTING_LEFT_LINK = 0x0D00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_RIGHT_LINK 0x0D00C4EC")]
    public const int DIBUTTON_HUNTING_RIGHT_LINK = 0x0D00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_FORWARD_LINK 0x0D0144E0")]
    public const int DIBUTTON_HUNTING_FORWARD_LINK = 0x0D0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_BACK_LINK 0x0D0144E8")]
    public const int DIBUTTON_HUNTING_BACK_LINK = 0x0D0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_ROTATE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_ROTATE_LEFT_LINK 0x0D0244E4")]
    public const int DIBUTTON_HUNTING_ROTATE_LEFT_LINK = 0x0D0244E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_ROTATE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_ROTATE_RIGHT_LINK 0x0D0244EC")]
    public const int DIBUTTON_HUNTING_ROTATE_RIGHT_LINK = 0x0D0244EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_DEVICE 0x0D0044FE")]
    public const int DIBUTTON_HUNTING_DEVICE = 0x0D0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HUNTING_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_HUNTING_PAUSE 0x0D0044FC")]
    public const int DIBUTTON_HUNTING_PAUSE = 0x0D0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_CAST"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_CAST 0x0E000401")]
    public const int DIBUTTON_FISHING_CAST = 0x0E000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_TYPE"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_TYPE 0x0E000402")]
    public const int DIBUTTON_FISHING_TYPE = 0x0E000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_BINOCULAR"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_BINOCULAR 0x0E000403")]
    public const int DIBUTTON_FISHING_BINOCULAR = 0x0E000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_BAIT"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_BAIT 0x0E000404")]
    public const int DIBUTTON_FISHING_BAIT = 0x0E000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_MAP"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_MAP 0x0E000405")]
    public const int DIBUTTON_FISHING_MAP = 0x0E000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_MENU 0x0E0004FD")]
    public const int DIBUTTON_FISHING_MENU = 0x0E0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_DISPLAY 0x0E004406")]
    public const int DIBUTTON_FISHING_DISPLAY = 0x0E004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_CROUCH"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_CROUCH 0x0E004407")]
    public const int DIBUTTON_FISHING_CROUCH = 0x0E004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_JUMP 0x0E004408")]
    public const int DIBUTTON_FISHING_JUMP = 0x0E004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_LEFT_LINK 0x0E00C4E4")]
    public const int DIBUTTON_FISHING_LEFT_LINK = 0x0E00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_RIGHT_LINK 0x0E00C4EC")]
    public const int DIBUTTON_FISHING_RIGHT_LINK = 0x0E00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_FORWARD_LINK 0x0E0144E0")]
    public const int DIBUTTON_FISHING_FORWARD_LINK = 0x0E0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_BACK_LINK 0x0E0144E8")]
    public const int DIBUTTON_FISHING_BACK_LINK = 0x0E0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_ROTATE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_ROTATE_LEFT_LINK 0x0E0244E4")]
    public const int DIBUTTON_FISHING_ROTATE_LEFT_LINK = 0x0E0244E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_ROTATE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_ROTATE_RIGHT_LINK 0x0E0244EC")]
    public const int DIBUTTON_FISHING_ROTATE_RIGHT_LINK = 0x0E0244EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_DEVICE 0x0E0044FE")]
    public const int DIBUTTON_FISHING_DEVICE = 0x0E0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FISHING_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FISHING_PAUSE 0x0E0044FC")]
    public const int DIBUTTON_FISHING_PAUSE = 0x0E0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_SELECT 0x0F000401")]
    public const int DIBUTTON_BASEBALLB_SELECT = 0x0F000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_NORMAL"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_NORMAL 0x0F000402")]
    public const int DIBUTTON_BASEBALLB_NORMAL = 0x0F000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_POWER"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_POWER 0x0F000403")]
    public const int DIBUTTON_BASEBALLB_POWER = 0x0F000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_BUNT"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_BUNT 0x0F000404")]
    public const int DIBUTTON_BASEBALLB_BUNT = 0x0F000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_STEAL"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_STEAL 0x0F000405")]
    public const int DIBUTTON_BASEBALLB_STEAL = 0x0F000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_BURST"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_BURST 0x0F000406")]
    public const int DIBUTTON_BASEBALLB_BURST = 0x0F000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_SLIDE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_SLIDE 0x0F000407")]
    public const int DIBUTTON_BASEBALLB_SLIDE = 0x0F000407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_CONTACT"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_CONTACT 0x0F000408")]
    public const int DIBUTTON_BASEBALLB_CONTACT = 0x0F000408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_MENU 0x0F0004FD")]
    public const int DIBUTTON_BASEBALLB_MENU = 0x0F0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_NOSTEAL"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_NOSTEAL 0x0F004409")]
    public const int DIBUTTON_BASEBALLB_NOSTEAL = 0x0F004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_BOX"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_BOX 0x0F00440A")]
    public const int DIBUTTON_BASEBALLB_BOX = 0x0F00440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_LEFT_LINK 0x0F00C4E4")]
    public const int DIBUTTON_BASEBALLB_LEFT_LINK = 0x0F00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_RIGHT_LINK 0x0F00C4EC")]
    public const int DIBUTTON_BASEBALLB_RIGHT_LINK = 0x0F00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_FORWARD_LINK 0x0F0144E0")]
    public const int DIBUTTON_BASEBALLB_FORWARD_LINK = 0x0F0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_BACK_LINK 0x0F0144E8")]
    public const int DIBUTTON_BASEBALLB_BACK_LINK = 0x0F0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_DEVICE 0x0F0044FE")]
    public const int DIBUTTON_BASEBALLB_DEVICE = 0x0F0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLB_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLB_PAUSE 0x0F0044FC")]
    public const int DIBUTTON_BASEBALLB_PAUSE = 0x0F0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_SELECT 0x10000401")]
    public const int DIBUTTON_BASEBALLP_SELECT = 0x10000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_PITCH"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_PITCH 0x10000402")]
    public const int DIBUTTON_BASEBALLP_PITCH = 0x10000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_BASE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_BASE 0x10000403")]
    public const int DIBUTTON_BASEBALLP_BASE = 0x10000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_THROW"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_THROW 0x10000404")]
    public const int DIBUTTON_BASEBALLP_THROW = 0x10000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_FAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_FAKE 0x10000405")]
    public const int DIBUTTON_BASEBALLP_FAKE = 0x10000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_MENU 0x100004FD")]
    public const int DIBUTTON_BASEBALLP_MENU = 0x100004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_WALK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_WALK 0x10004406")]
    public const int DIBUTTON_BASEBALLP_WALK = 0x10004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_LOOK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_LOOK 0x10004407")]
    public const int DIBUTTON_BASEBALLP_LOOK = 0x10004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_LEFT_LINK 0x1000C4E4")]
    public const int DIBUTTON_BASEBALLP_LEFT_LINK = 0x1000C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_RIGHT_LINK 0x1000C4EC")]
    public const int DIBUTTON_BASEBALLP_RIGHT_LINK = 0x1000C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_FORWARD_LINK 0x100144E0")]
    public const int DIBUTTON_BASEBALLP_FORWARD_LINK = 0x100144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_BACK_LINK 0x100144E8")]
    public const int DIBUTTON_BASEBALLP_BACK_LINK = 0x100144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_DEVICE 0x100044FE")]
    public const int DIBUTTON_BASEBALLP_DEVICE = 0x100044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLP_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLP_PAUSE 0x100044FC")]
    public const int DIBUTTON_BASEBALLP_PAUSE = 0x100044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_NEAREST"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_NEAREST 0x11000401")]
    public const int DIBUTTON_BASEBALLF_NEAREST = 0x11000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_THROW1"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_THROW1 0x11000402")]
    public const int DIBUTTON_BASEBALLF_THROW1 = 0x11000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_THROW2"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_THROW2 0x11000403")]
    public const int DIBUTTON_BASEBALLF_THROW2 = 0x11000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_BURST"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_BURST 0x11000404")]
    public const int DIBUTTON_BASEBALLF_BURST = 0x11000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_JUMP 0x11000405")]
    public const int DIBUTTON_BASEBALLF_JUMP = 0x11000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_DIVE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_DIVE 0x11000406")]
    public const int DIBUTTON_BASEBALLF_DIVE = 0x11000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_MENU 0x110004FD")]
    public const int DIBUTTON_BASEBALLF_MENU = 0x110004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_SHIFTIN"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_SHIFTIN 0x11004407")]
    public const int DIBUTTON_BASEBALLF_SHIFTIN = 0x11004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_SHIFTOUT"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_SHIFTOUT 0x11004408")]
    public const int DIBUTTON_BASEBALLF_SHIFTOUT = 0x11004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_AIM_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_AIM_LEFT_LINK 0x1100C4E4")]
    public const int DIBUTTON_BASEBALLF_AIM_LEFT_LINK = 0x1100C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_AIM_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_AIM_RIGHT_LINK 0x1100C4EC")]
    public const int DIBUTTON_BASEBALLF_AIM_RIGHT_LINK = 0x1100C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_FORWARD_LINK 0x110144E0")]
    public const int DIBUTTON_BASEBALLF_FORWARD_LINK = 0x110144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_BACK_LINK 0x110144E8")]
    public const int DIBUTTON_BASEBALLF_BACK_LINK = 0x110144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_DEVICE 0x110044FE")]
    public const int DIBUTTON_BASEBALLF_DEVICE = 0x110044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BASEBALLF_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_BASEBALLF_PAUSE 0x110044FC")]
    public const int DIBUTTON_BASEBALLF_PAUSE = 0x110044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_SHOOT"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_SHOOT 0x12000401")]
    public const int DIBUTTON_BBALLO_SHOOT = 0x12000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_DUNK"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_DUNK 0x12000402")]
    public const int DIBUTTON_BBALLO_DUNK = 0x12000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_PASS"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_PASS 0x12000403")]
    public const int DIBUTTON_BBALLO_PASS = 0x12000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_FAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_FAKE 0x12000404")]
    public const int DIBUTTON_BBALLO_FAKE = 0x12000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_SPECIAL 0x12000405")]
    public const int DIBUTTON_BBALLO_SPECIAL = 0x12000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_PLAYER"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_PLAYER 0x12000406")]
    public const int DIBUTTON_BBALLO_PLAYER = 0x12000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_BURST"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_BURST 0x12000407")]
    public const int DIBUTTON_BBALLO_BURST = 0x12000407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_CALL"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_CALL 0x12000408")]
    public const int DIBUTTON_BBALLO_CALL = 0x12000408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_MENU 0x120004FD")]
    public const int DIBUTTON_BBALLO_MENU = 0x120004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_SCREEN"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_SCREEN 0x12004409")]
    public const int DIBUTTON_BBALLO_SCREEN = 0x12004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_PLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_PLAY 0x1200440A")]
    public const int DIBUTTON_BBALLO_PLAY = 0x1200440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_JAB"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_JAB 0x1200440B")]
    public const int DIBUTTON_BBALLO_JAB = 0x1200440B;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_POST"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_POST 0x1200440C")]
    public const int DIBUTTON_BBALLO_POST = 0x1200440C;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_TIMEOUT"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_TIMEOUT 0x1200440D")]
    public const int DIBUTTON_BBALLO_TIMEOUT = 0x1200440D;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_SUBSTITUTE 0x1200440E")]
    public const int DIBUTTON_BBALLO_SUBSTITUTE = 0x1200440E;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_LEFT_LINK 0x1200C4E4")]
    public const int DIBUTTON_BBALLO_LEFT_LINK = 0x1200C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_RIGHT_LINK 0x1200C4EC")]
    public const int DIBUTTON_BBALLO_RIGHT_LINK = 0x1200C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_FORWARD_LINK 0x120144E0")]
    public const int DIBUTTON_BBALLO_FORWARD_LINK = 0x120144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_BACK_LINK 0x120144E8")]
    public const int DIBUTTON_BBALLO_BACK_LINK = 0x120144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_DEVICE 0x120044FE")]
    public const int DIBUTTON_BBALLO_DEVICE = 0x120044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLO_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLO_PAUSE 0x120044FC")]
    public const int DIBUTTON_BBALLO_PAUSE = 0x120044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_JUMP 0x13000401")]
    public const int DIBUTTON_BBALLD_JUMP = 0x13000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_STEAL"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_STEAL 0x13000402")]
    public const int DIBUTTON_BBALLD_STEAL = 0x13000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_FAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_FAKE 0x13000403")]
    public const int DIBUTTON_BBALLD_FAKE = 0x13000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_SPECIAL 0x13000404")]
    public const int DIBUTTON_BBALLD_SPECIAL = 0x13000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_PLAYER"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_PLAYER 0x13000405")]
    public const int DIBUTTON_BBALLD_PLAYER = 0x13000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_BURST"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_BURST 0x13000406")]
    public const int DIBUTTON_BBALLD_BURST = 0x13000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_PLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_PLAY 0x13000407")]
    public const int DIBUTTON_BBALLD_PLAY = 0x13000407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_MENU 0x130004FD")]
    public const int DIBUTTON_BBALLD_MENU = 0x130004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_TIMEOUT"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_TIMEOUT 0x13004408")]
    public const int DIBUTTON_BBALLD_TIMEOUT = 0x13004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_SUBSTITUTE 0x13004409")]
    public const int DIBUTTON_BBALLD_SUBSTITUTE = 0x13004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_LEFT_LINK 0x1300C4E4")]
    public const int DIBUTTON_BBALLD_LEFT_LINK = 0x1300C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_RIGHT_LINK 0x1300C4EC")]
    public const int DIBUTTON_BBALLD_RIGHT_LINK = 0x1300C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_FORWARD_LINK 0x130144E0")]
    public const int DIBUTTON_BBALLD_FORWARD_LINK = 0x130144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_BACK_LINK 0x130144E8")]
    public const int DIBUTTON_BBALLD_BACK_LINK = 0x130144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_DEVICE 0x130044FE")]
    public const int DIBUTTON_BBALLD_DEVICE = 0x130044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BBALLD_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_BBALLD_PAUSE 0x130044FC")]
    public const int DIBUTTON_BBALLD_PAUSE = 0x130044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLP_PLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLP_PLAY 0x14000401")]
    public const int DIBUTTON_FOOTBALLP_PLAY = 0x14000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLP_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLP_SELECT 0x14000402")]
    public const int DIBUTTON_FOOTBALLP_SELECT = 0x14000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLP_HELP"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLP_HELP 0x14000403")]
    public const int DIBUTTON_FOOTBALLP_HELP = 0x14000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLP_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLP_MENU 0x140004FD")]
    public const int DIBUTTON_FOOTBALLP_MENU = 0x140004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLP_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLP_DEVICE 0x140044FE")]
    public const int DIBUTTON_FOOTBALLP_DEVICE = 0x140044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLP_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLP_PAUSE 0x140044FC")]
    public const int DIBUTTON_FOOTBALLP_PAUSE = 0x140044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_SELECT 0x15000401")]
    public const int DIBUTTON_FOOTBALLQ_SELECT = 0x15000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_SNAP"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_SNAP 0x15000402")]
    public const int DIBUTTON_FOOTBALLQ_SNAP = 0x15000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_JUMP 0x15000403")]
    public const int DIBUTTON_FOOTBALLQ_JUMP = 0x15000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_SLIDE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_SLIDE 0x15000404")]
    public const int DIBUTTON_FOOTBALLQ_SLIDE = 0x15000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_PASS"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_PASS 0x15000405")]
    public const int DIBUTTON_FOOTBALLQ_PASS = 0x15000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_FAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_FAKE 0x15000406")]
    public const int DIBUTTON_FOOTBALLQ_FAKE = 0x15000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_MENU 0x150004FD")]
    public const int DIBUTTON_FOOTBALLQ_MENU = 0x150004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_FAKESNAP"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_FAKESNAP 0x15004407")]
    public const int DIBUTTON_FOOTBALLQ_FAKESNAP = 0x15004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_MOTION"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_MOTION 0x15004408")]
    public const int DIBUTTON_FOOTBALLQ_MOTION = 0x15004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_AUDIBLE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_AUDIBLE 0x15004409")]
    public const int DIBUTTON_FOOTBALLQ_AUDIBLE = 0x15004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_LEFT_LINK 0x1500C4E4")]
    public const int DIBUTTON_FOOTBALLQ_LEFT_LINK = 0x1500C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_RIGHT_LINK 0x1500C4EC")]
    public const int DIBUTTON_FOOTBALLQ_RIGHT_LINK = 0x1500C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_FORWARD_LINK 0x150144E0")]
    public const int DIBUTTON_FOOTBALLQ_FORWARD_LINK = 0x150144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_BACK_LINK 0x150144E8")]
    public const int DIBUTTON_FOOTBALLQ_BACK_LINK = 0x150144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_DEVICE 0x150044FE")]
    public const int DIBUTTON_FOOTBALLQ_DEVICE = 0x150044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLQ_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_PAUSE 0x150044FC")]
    public const int DIBUTTON_FOOTBALLQ_PAUSE = 0x150044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_JUMP 0x16000401")]
    public const int DIBUTTON_FOOTBALLO_JUMP = 0x16000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_LEFTARM"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_LEFTARM 0x16000402")]
    public const int DIBUTTON_FOOTBALLO_LEFTARM = 0x16000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_RIGHTARM"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_RIGHTARM 0x16000403")]
    public const int DIBUTTON_FOOTBALLO_RIGHTARM = 0x16000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_THROW"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_THROW 0x16000404")]
    public const int DIBUTTON_FOOTBALLO_THROW = 0x16000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_SPIN"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_SPIN 0x16000405")]
    public const int DIBUTTON_FOOTBALLO_SPIN = 0x16000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_MENU 0x160004FD")]
    public const int DIBUTTON_FOOTBALLO_MENU = 0x160004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_JUKE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_JUKE 0x16004406")]
    public const int DIBUTTON_FOOTBALLO_JUKE = 0x16004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_SHOULDER"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_SHOULDER 0x16004407")]
    public const int DIBUTTON_FOOTBALLO_SHOULDER = 0x16004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_TURBO"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_TURBO 0x16004408")]
    public const int DIBUTTON_FOOTBALLO_TURBO = 0x16004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_DIVE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_DIVE 0x16004409")]
    public const int DIBUTTON_FOOTBALLO_DIVE = 0x16004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_ZOOM 0x1600440A")]
    public const int DIBUTTON_FOOTBALLO_ZOOM = 0x1600440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_SUBSTITUTE 0x1600440B")]
    public const int DIBUTTON_FOOTBALLO_SUBSTITUTE = 0x1600440B;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_LEFT_LINK 0x1600C4E4")]
    public const int DIBUTTON_FOOTBALLO_LEFT_LINK = 0x1600C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_RIGHT_LINK 0x1600C4EC")]
    public const int DIBUTTON_FOOTBALLO_RIGHT_LINK = 0x1600C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_FORWARD_LINK 0x160144E0")]
    public const int DIBUTTON_FOOTBALLO_FORWARD_LINK = 0x160144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_BACK_LINK 0x160144E8")]
    public const int DIBUTTON_FOOTBALLO_BACK_LINK = 0x160144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_DEVICE 0x160044FE")]
    public const int DIBUTTON_FOOTBALLO_DEVICE = 0x160044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLO_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLO_PAUSE 0x160044FC")]
    public const int DIBUTTON_FOOTBALLO_PAUSE = 0x160044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_PLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_PLAY 0x17000401")]
    public const int DIBUTTON_FOOTBALLD_PLAY = 0x17000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SELECT 0x17000402")]
    public const int DIBUTTON_FOOTBALLD_SELECT = 0x17000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_JUMP 0x17000403")]
    public const int DIBUTTON_FOOTBALLD_JUMP = 0x17000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_TACKLE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_TACKLE 0x17000404")]
    public const int DIBUTTON_FOOTBALLD_TACKLE = 0x17000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_FAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_FAKE 0x17000405")]
    public const int DIBUTTON_FOOTBALLD_FAKE = 0x17000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_SUPERTACKLE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SUPERTACKLE 0x17000406")]
    public const int DIBUTTON_FOOTBALLD_SUPERTACKLE = 0x17000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_MENU 0x170004FD")]
    public const int DIBUTTON_FOOTBALLD_MENU = 0x170004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_SPIN"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SPIN 0x17004407")]
    public const int DIBUTTON_FOOTBALLD_SPIN = 0x17004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_SWIM"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SWIM 0x17004408")]
    public const int DIBUTTON_FOOTBALLD_SWIM = 0x17004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_BULLRUSH"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_BULLRUSH 0x17004409")]
    public const int DIBUTTON_FOOTBALLD_BULLRUSH = 0x17004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_RIP"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_RIP 0x1700440A")]
    public const int DIBUTTON_FOOTBALLD_RIP = 0x1700440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_AUDIBLE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_AUDIBLE 0x1700440B")]
    public const int DIBUTTON_FOOTBALLD_AUDIBLE = 0x1700440B;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_ZOOM 0x1700440C")]
    public const int DIBUTTON_FOOTBALLD_ZOOM = 0x1700440C;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SUBSTITUTE 0x1700440D")]
    public const int DIBUTTON_FOOTBALLD_SUBSTITUTE = 0x1700440D;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_LEFT_LINK 0x1700C4E4")]
    public const int DIBUTTON_FOOTBALLD_LEFT_LINK = 0x1700C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_RIGHT_LINK 0x1700C4EC")]
    public const int DIBUTTON_FOOTBALLD_RIGHT_LINK = 0x1700C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_FORWARD_LINK 0x170144E0")]
    public const int DIBUTTON_FOOTBALLD_FORWARD_LINK = 0x170144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_BACK_LINK 0x170144E8")]
    public const int DIBUTTON_FOOTBALLD_BACK_LINK = 0x170144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_DEVICE 0x170044FE")]
    public const int DIBUTTON_FOOTBALLD_DEVICE = 0x170044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_FOOTBALLD_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_FOOTBALLD_PAUSE 0x170044FC")]
    public const int DIBUTTON_FOOTBALLD_PAUSE = 0x170044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_SWING"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_SWING 0x18000401")]
    public const int DIBUTTON_GOLF_SWING = 0x18000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_SELECT 0x18000402")]
    public const int DIBUTTON_GOLF_SELECT = 0x18000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_UP"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_UP 0x18000403")]
    public const int DIBUTTON_GOLF_UP = 0x18000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_DOWN"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_DOWN 0x18000404")]
    public const int DIBUTTON_GOLF_DOWN = 0x18000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_TERRAIN"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_TERRAIN 0x18000405")]
    public const int DIBUTTON_GOLF_TERRAIN = 0x18000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_FLYBY"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_FLYBY 0x18000406")]
    public const int DIBUTTON_GOLF_FLYBY = 0x18000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_MENU 0x180004FD")]
    public const int DIBUTTON_GOLF_MENU = 0x180004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_ZOOM 0x18004407")]
    public const int DIBUTTON_GOLF_ZOOM = 0x18004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_TIMEOUT"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_TIMEOUT 0x18004408")]
    public const int DIBUTTON_GOLF_TIMEOUT = 0x18004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_SUBSTITUTE 0x18004409")]
    public const int DIBUTTON_GOLF_SUBSTITUTE = 0x18004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_LEFT_LINK 0x1800C4E4")]
    public const int DIBUTTON_GOLF_LEFT_LINK = 0x1800C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_RIGHT_LINK 0x1800C4EC")]
    public const int DIBUTTON_GOLF_RIGHT_LINK = 0x1800C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_FORWARD_LINK 0x180144E0")]
    public const int DIBUTTON_GOLF_FORWARD_LINK = 0x180144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_BACK_LINK 0x180144E8")]
    public const int DIBUTTON_GOLF_BACK_LINK = 0x180144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_DEVICE 0x180044FE")]
    public const int DIBUTTON_GOLF_DEVICE = 0x180044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_GOLF_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_GOLF_PAUSE 0x180044FC")]
    public const int DIBUTTON_GOLF_PAUSE = 0x180044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_SHOOT"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_SHOOT 0x19000401")]
    public const int DIBUTTON_HOCKEYO_SHOOT = 0x19000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_PASS"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_PASS 0x19000402")]
    public const int DIBUTTON_HOCKEYO_PASS = 0x19000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_BURST"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_BURST 0x19000403")]
    public const int DIBUTTON_HOCKEYO_BURST = 0x19000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_SPECIAL 0x19000404")]
    public const int DIBUTTON_HOCKEYO_SPECIAL = 0x19000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_FAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_FAKE 0x19000405")]
    public const int DIBUTTON_HOCKEYO_FAKE = 0x19000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_MENU 0x190004FD")]
    public const int DIBUTTON_HOCKEYO_MENU = 0x190004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_ZOOM 0x19004406")]
    public const int DIBUTTON_HOCKEYO_ZOOM = 0x19004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_STRATEGY"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_STRATEGY 0x19004407")]
    public const int DIBUTTON_HOCKEYO_STRATEGY = 0x19004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_TIMEOUT"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_TIMEOUT 0x19004408")]
    public const int DIBUTTON_HOCKEYO_TIMEOUT = 0x19004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_SUBSTITUTE 0x19004409")]
    public const int DIBUTTON_HOCKEYO_SUBSTITUTE = 0x19004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_LEFT_LINK 0x1900C4E4")]
    public const int DIBUTTON_HOCKEYO_LEFT_LINK = 0x1900C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_RIGHT_LINK 0x1900C4EC")]
    public const int DIBUTTON_HOCKEYO_RIGHT_LINK = 0x1900C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_FORWARD_LINK 0x190144E0")]
    public const int DIBUTTON_HOCKEYO_FORWARD_LINK = 0x190144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_BACK_LINK 0x190144E8")]
    public const int DIBUTTON_HOCKEYO_BACK_LINK = 0x190144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_DEVICE 0x190044FE")]
    public const int DIBUTTON_HOCKEYO_DEVICE = 0x190044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYO_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYO_PAUSE 0x190044FC")]
    public const int DIBUTTON_HOCKEYO_PAUSE = 0x190044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_PLAYER"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_PLAYER 0x1A000401")]
    public const int DIBUTTON_HOCKEYD_PLAYER = 0x1A000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_STEAL"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_STEAL 0x1A000402")]
    public const int DIBUTTON_HOCKEYD_STEAL = 0x1A000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_BURST"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_BURST 0x1A000403")]
    public const int DIBUTTON_HOCKEYD_BURST = 0x1A000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_BLOCK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_BLOCK 0x1A000404")]
    public const int DIBUTTON_HOCKEYD_BLOCK = 0x1A000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_FAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_FAKE 0x1A000405")]
    public const int DIBUTTON_HOCKEYD_FAKE = 0x1A000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_MENU 0x1A0004FD")]
    public const int DIBUTTON_HOCKEYD_MENU = 0x1A0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_ZOOM 0x1A004406")]
    public const int DIBUTTON_HOCKEYD_ZOOM = 0x1A004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_STRATEGY"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_STRATEGY 0x1A004407")]
    public const int DIBUTTON_HOCKEYD_STRATEGY = 0x1A004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_TIMEOUT"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_TIMEOUT 0x1A004408")]
    public const int DIBUTTON_HOCKEYD_TIMEOUT = 0x1A004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_SUBSTITUTE 0x1A004409")]
    public const int DIBUTTON_HOCKEYD_SUBSTITUTE = 0x1A004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_LEFT_LINK 0x1A00C4E4")]
    public const int DIBUTTON_HOCKEYD_LEFT_LINK = 0x1A00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_RIGHT_LINK 0x1A00C4EC")]
    public const int DIBUTTON_HOCKEYD_RIGHT_LINK = 0x1A00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_FORWARD_LINK 0x1A0144E0")]
    public const int DIBUTTON_HOCKEYD_FORWARD_LINK = 0x1A0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_BACK_LINK 0x1A0144E8")]
    public const int DIBUTTON_HOCKEYD_BACK_LINK = 0x1A0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_DEVICE 0x1A0044FE")]
    public const int DIBUTTON_HOCKEYD_DEVICE = 0x1A0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYD_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYD_PAUSE 0x1A0044FC")]
    public const int DIBUTTON_HOCKEYD_PAUSE = 0x1A0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_PASS"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_PASS 0x1B000401")]
    public const int DIBUTTON_HOCKEYG_PASS = 0x1B000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_POKE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_POKE 0x1B000402")]
    public const int DIBUTTON_HOCKEYG_POKE = 0x1B000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_STEAL"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_STEAL 0x1B000403")]
    public const int DIBUTTON_HOCKEYG_STEAL = 0x1B000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_BLOCK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_BLOCK 0x1B000404")]
    public const int DIBUTTON_HOCKEYG_BLOCK = 0x1B000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_MENU 0x1B0004FD")]
    public const int DIBUTTON_HOCKEYG_MENU = 0x1B0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_ZOOM 0x1B004405")]
    public const int DIBUTTON_HOCKEYG_ZOOM = 0x1B004405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_STRATEGY"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_STRATEGY 0x1B004406")]
    public const int DIBUTTON_HOCKEYG_STRATEGY = 0x1B004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_TIMEOUT"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_TIMEOUT 0x1B004407")]
    public const int DIBUTTON_HOCKEYG_TIMEOUT = 0x1B004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_SUBSTITUTE 0x1B004408")]
    public const int DIBUTTON_HOCKEYG_SUBSTITUTE = 0x1B004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_LEFT_LINK 0x1B00C4E4")]
    public const int DIBUTTON_HOCKEYG_LEFT_LINK = 0x1B00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_RIGHT_LINK 0x1B00C4EC")]
    public const int DIBUTTON_HOCKEYG_RIGHT_LINK = 0x1B00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_FORWARD_LINK 0x1B0144E0")]
    public const int DIBUTTON_HOCKEYG_FORWARD_LINK = 0x1B0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_BACK_LINK 0x1B0144E8")]
    public const int DIBUTTON_HOCKEYG_BACK_LINK = 0x1B0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_DEVICE 0x1B0044FE")]
    public const int DIBUTTON_HOCKEYG_DEVICE = 0x1B0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_HOCKEYG_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_HOCKEYG_PAUSE 0x1B0044FC")]
    public const int DIBUTTON_HOCKEYG_PAUSE = 0x1B0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_JUMP 0x1C000401")]
    public const int DIBUTTON_BIKINGM_JUMP = 0x1C000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_CAMERA"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_CAMERA 0x1C000402")]
    public const int DIBUTTON_BIKINGM_CAMERA = 0x1C000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_SPECIAL1"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_SPECIAL1 0x1C000403")]
    public const int DIBUTTON_BIKINGM_SPECIAL1 = 0x1C000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_SELECT 0x1C000404")]
    public const int DIBUTTON_BIKINGM_SELECT = 0x1C000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_SPECIAL2"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_SPECIAL2 0x1C000405")]
    public const int DIBUTTON_BIKINGM_SPECIAL2 = 0x1C000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_MENU 0x1C0004FD")]
    public const int DIBUTTON_BIKINGM_MENU = 0x1C0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_ZOOM 0x1C004406")]
    public const int DIBUTTON_BIKINGM_ZOOM = 0x1C004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_LEFT_LINK 0x1C00C4E4")]
    public const int DIBUTTON_BIKINGM_LEFT_LINK = 0x1C00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_RIGHT_LINK 0x1C00C4EC")]
    public const int DIBUTTON_BIKINGM_RIGHT_LINK = 0x1C00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_FASTER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_FASTER_LINK 0x1C0144E0")]
    public const int DIBUTTON_BIKINGM_FASTER_LINK = 0x1C0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_SLOWER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_SLOWER_LINK 0x1C0144E8")]
    public const int DIBUTTON_BIKINGM_SLOWER_LINK = 0x1C0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_BRAKE_BUTTON_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_BRAKE_BUTTON_LINK 0x1C0444E8")]
    public const int DIBUTTON_BIKINGM_BRAKE_BUTTON_LINK = 0x1C0444E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_DEVICE 0x1C0044FE")]
    public const int DIBUTTON_BIKINGM_DEVICE = 0x1C0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BIKINGM_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_BIKINGM_PAUSE 0x1C0044FC")]
    public const int DIBUTTON_BIKINGM_PAUSE = 0x1C0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_JUMP 0x1D000401")]
    public const int DIBUTTON_SKIING_JUMP = 0x1D000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_CROUCH"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_CROUCH 0x1D000402")]
    public const int DIBUTTON_SKIING_CROUCH = 0x1D000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_CAMERA"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_CAMERA 0x1D000403")]
    public const int DIBUTTON_SKIING_CAMERA = 0x1D000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_SPECIAL1"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_SPECIAL1 0x1D000404")]
    public const int DIBUTTON_SKIING_SPECIAL1 = 0x1D000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_SELECT 0x1D000405")]
    public const int DIBUTTON_SKIING_SELECT = 0x1D000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_SPECIAL2"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_SPECIAL2 0x1D000406")]
    public const int DIBUTTON_SKIING_SPECIAL2 = 0x1D000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_MENU 0x1D0004FD")]
    public const int DIBUTTON_SKIING_MENU = 0x1D0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_ZOOM 0x1D004407")]
    public const int DIBUTTON_SKIING_ZOOM = 0x1D004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_LEFT_LINK 0x1D00C4E4")]
    public const int DIBUTTON_SKIING_LEFT_LINK = 0x1D00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_RIGHT_LINK 0x1D00C4EC")]
    public const int DIBUTTON_SKIING_RIGHT_LINK = 0x1D00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_FASTER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_FASTER_LINK 0x1D0144E0")]
    public const int DIBUTTON_SKIING_FASTER_LINK = 0x1D0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_SLOWER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_SLOWER_LINK 0x1D0144E8")]
    public const int DIBUTTON_SKIING_SLOWER_LINK = 0x1D0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_DEVICE 0x1D0044FE")]
    public const int DIBUTTON_SKIING_DEVICE = 0x1D0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SKIING_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_SKIING_PAUSE 0x1D0044FC")]
    public const int DIBUTTON_SKIING_PAUSE = 0x1D0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_SHOOT"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_SHOOT 0x1E000401")]
    public const int DIBUTTON_SOCCERO_SHOOT = 0x1E000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_PASS"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_PASS 0x1E000402")]
    public const int DIBUTTON_SOCCERO_PASS = 0x1E000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_FAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_FAKE 0x1E000403")]
    public const int DIBUTTON_SOCCERO_FAKE = 0x1E000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_PLAYER"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_PLAYER 0x1E000404")]
    public const int DIBUTTON_SOCCERO_PLAYER = 0x1E000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_SPECIAL1"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_SPECIAL1 0x1E000405")]
    public const int DIBUTTON_SOCCERO_SPECIAL1 = 0x1E000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_SELECT 0x1E000406")]
    public const int DIBUTTON_SOCCERO_SELECT = 0x1E000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_MENU 0x1E0004FD")]
    public const int DIBUTTON_SOCCERO_MENU = 0x1E0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_SUBSTITUTE 0x1E004407")]
    public const int DIBUTTON_SOCCERO_SUBSTITUTE = 0x1E004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_SHOOTLOW"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_SHOOTLOW 0x1E004408")]
    public const int DIBUTTON_SOCCERO_SHOOTLOW = 0x1E004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_SHOOTHIGH"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_SHOOTHIGH 0x1E004409")]
    public const int DIBUTTON_SOCCERO_SHOOTHIGH = 0x1E004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_PASSTHRU"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_PASSTHRU 0x1E00440A")]
    public const int DIBUTTON_SOCCERO_PASSTHRU = 0x1E00440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_SPRINT"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_SPRINT 0x1E00440B")]
    public const int DIBUTTON_SOCCERO_SPRINT = 0x1E00440B;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_CONTROL"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_CONTROL 0x1E00440C")]
    public const int DIBUTTON_SOCCERO_CONTROL = 0x1E00440C;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_HEAD"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_HEAD 0x1E00440D")]
    public const int DIBUTTON_SOCCERO_HEAD = 0x1E00440D;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_LEFT_LINK 0x1E00C4E4")]
    public const int DIBUTTON_SOCCERO_LEFT_LINK = 0x1E00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_RIGHT_LINK 0x1E00C4EC")]
    public const int DIBUTTON_SOCCERO_RIGHT_LINK = 0x1E00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_FORWARD_LINK 0x1E0144E0")]
    public const int DIBUTTON_SOCCERO_FORWARD_LINK = 0x1E0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_BACK_LINK 0x1E0144E8")]
    public const int DIBUTTON_SOCCERO_BACK_LINK = 0x1E0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_DEVICE 0x1E0044FE")]
    public const int DIBUTTON_SOCCERO_DEVICE = 0x1E0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERO_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERO_PAUSE 0x1E0044FC")]
    public const int DIBUTTON_SOCCERO_PAUSE = 0x1E0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_BLOCK"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_BLOCK 0x1F000401")]
    public const int DIBUTTON_SOCCERD_BLOCK = 0x1F000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_STEAL"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_STEAL 0x1F000402")]
    public const int DIBUTTON_SOCCERD_STEAL = 0x1F000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_FAKE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_FAKE 0x1F000403")]
    public const int DIBUTTON_SOCCERD_FAKE = 0x1F000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_PLAYER"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_PLAYER 0x1F000404")]
    public const int DIBUTTON_SOCCERD_PLAYER = 0x1F000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_SPECIAL 0x1F000405")]
    public const int DIBUTTON_SOCCERD_SPECIAL = 0x1F000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_SELECT 0x1F000406")]
    public const int DIBUTTON_SOCCERD_SELECT = 0x1F000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_SLIDE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_SLIDE 0x1F000407")]
    public const int DIBUTTON_SOCCERD_SLIDE = 0x1F000407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_MENU 0x1F0004FD")]
    public const int DIBUTTON_SOCCERD_MENU = 0x1F0004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_FOUL"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_FOUL 0x1F004408")]
    public const int DIBUTTON_SOCCERD_FOUL = 0x1F004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_HEAD"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_HEAD 0x1F004409")]
    public const int DIBUTTON_SOCCERD_HEAD = 0x1F004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_CLEAR"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_CLEAR 0x1F00440A")]
    public const int DIBUTTON_SOCCERD_CLEAR = 0x1F00440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_GOALIECHARGE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_GOALIECHARGE 0x1F00440B")]
    public const int DIBUTTON_SOCCERD_GOALIECHARGE = 0x1F00440B;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_SUBSTITUTE 0x1F00440C")]
    public const int DIBUTTON_SOCCERD_SUBSTITUTE = 0x1F00440C;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_LEFT_LINK 0x1F00C4E4")]
    public const int DIBUTTON_SOCCERD_LEFT_LINK = 0x1F00C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_RIGHT_LINK 0x1F00C4EC")]
    public const int DIBUTTON_SOCCERD_RIGHT_LINK = 0x1F00C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_FORWARD_LINK 0x1F0144E0")]
    public const int DIBUTTON_SOCCERD_FORWARD_LINK = 0x1F0144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_BACK_LINK 0x1F0144E8")]
    public const int DIBUTTON_SOCCERD_BACK_LINK = 0x1F0144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_DEVICE 0x1F0044FE")]
    public const int DIBUTTON_SOCCERD_DEVICE = 0x1F0044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_SOCCERD_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_SOCCERD_PAUSE 0x1F0044FC")]
    public const int DIBUTTON_SOCCERD_PAUSE = 0x1F0044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_SWING"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_SWING 0x20000401")]
    public const int DIBUTTON_RACQUET_SWING = 0x20000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_BACKSWING"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_BACKSWING 0x20000402")]
    public const int DIBUTTON_RACQUET_BACKSWING = 0x20000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_SMASH"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_SMASH 0x20000403")]
    public const int DIBUTTON_RACQUET_SMASH = 0x20000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_SPECIAL 0x20000404")]
    public const int DIBUTTON_RACQUET_SPECIAL = 0x20000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_SELECT 0x20000405")]
    public const int DIBUTTON_RACQUET_SELECT = 0x20000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_MENU 0x200004FD")]
    public const int DIBUTTON_RACQUET_MENU = 0x200004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_TIMEOUT"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_TIMEOUT 0x20004406")]
    public const int DIBUTTON_RACQUET_TIMEOUT = 0x20004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_SUBSTITUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_SUBSTITUTE 0x20004407")]
    public const int DIBUTTON_RACQUET_SUBSTITUTE = 0x20004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_LEFT_LINK 0x2000C4E4")]
    public const int DIBUTTON_RACQUET_LEFT_LINK = 0x2000C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_RIGHT_LINK 0x2000C4EC")]
    public const int DIBUTTON_RACQUET_RIGHT_LINK = 0x2000C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_FORWARD_LINK 0x200144E0")]
    public const int DIBUTTON_RACQUET_FORWARD_LINK = 0x200144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_BACK_LINK 0x200144E8")]
    public const int DIBUTTON_RACQUET_BACK_LINK = 0x200144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_DEVICE 0x200044FE")]
    public const int DIBUTTON_RACQUET_DEVICE = 0x200044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_RACQUET_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_RACQUET_PAUSE 0x200044FC")]
    public const int DIBUTTON_RACQUET_PAUSE = 0x200044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_THROW"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_THROW 0x21000401")]
    public const int DIBUTTON_ARCADES_THROW = 0x21000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_CARRY"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_CARRY 0x21000402")]
    public const int DIBUTTON_ARCADES_CARRY = 0x21000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_ATTACK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_ATTACK 0x21000403")]
    public const int DIBUTTON_ARCADES_ATTACK = 0x21000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_SPECIAL 0x21000404")]
    public const int DIBUTTON_ARCADES_SPECIAL = 0x21000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_SELECT 0x21000405")]
    public const int DIBUTTON_ARCADES_SELECT = 0x21000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_MENU 0x210004FD")]
    public const int DIBUTTON_ARCADES_MENU = 0x210004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_LEFT_LINK 0x2100C4E4")]
    public const int DIBUTTON_ARCADES_LEFT_LINK = 0x2100C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_RIGHT_LINK 0x2100C4EC")]
    public const int DIBUTTON_ARCADES_RIGHT_LINK = 0x2100C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_FORWARD_LINK 0x210144E0")]
    public const int DIBUTTON_ARCADES_FORWARD_LINK = 0x210144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_BACK_LINK 0x210144E8")]
    public const int DIBUTTON_ARCADES_BACK_LINK = 0x210144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_VIEW_UP_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_VIEW_UP_LINK 0x2107C4E0")]
    public const int DIBUTTON_ARCADES_VIEW_UP_LINK = 0x2107C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_VIEW_DOWN_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_VIEW_DOWN_LINK 0x2107C4E8")]
    public const int DIBUTTON_ARCADES_VIEW_DOWN_LINK = 0x2107C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_VIEW_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_VIEW_LEFT_LINK 0x2107C4E4")]
    public const int DIBUTTON_ARCADES_VIEW_LEFT_LINK = 0x2107C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_VIEW_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_VIEW_RIGHT_LINK 0x2107C4EC")]
    public const int DIBUTTON_ARCADES_VIEW_RIGHT_LINK = 0x2107C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_DEVICE 0x210044FE")]
    public const int DIBUTTON_ARCADES_DEVICE = 0x210044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADES_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADES_PAUSE 0x210044FC")]
    public const int DIBUTTON_ARCADES_PAUSE = 0x210044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_JUMP 0x22000401")]
    public const int DIBUTTON_ARCADEP_JUMP = 0x22000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_FIRE"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_FIRE 0x22000402")]
    public const int DIBUTTON_ARCADEP_FIRE = 0x22000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_CROUCH"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_CROUCH 0x22000403")]
    public const int DIBUTTON_ARCADEP_CROUCH = 0x22000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_SPECIAL 0x22000404")]
    public const int DIBUTTON_ARCADEP_SPECIAL = 0x22000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_SELECT 0x22000405")]
    public const int DIBUTTON_ARCADEP_SELECT = 0x22000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_MENU 0x220004FD")]
    public const int DIBUTTON_ARCADEP_MENU = 0x220004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_FIRESECONDARY"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_FIRESECONDARY 0x22004406")]
    public const int DIBUTTON_ARCADEP_FIRESECONDARY = 0x22004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_LEFT_LINK 0x2200C4E4")]
    public const int DIBUTTON_ARCADEP_LEFT_LINK = 0x2200C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_RIGHT_LINK 0x2200C4EC")]
    public const int DIBUTTON_ARCADEP_RIGHT_LINK = 0x2200C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_FORWARD_LINK 0x220144E0")]
    public const int DIBUTTON_ARCADEP_FORWARD_LINK = 0x220144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_BACK_LINK 0x220144E8")]
    public const int DIBUTTON_ARCADEP_BACK_LINK = 0x220144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_VIEW_UP_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_VIEW_UP_LINK 0x2207C4E0")]
    public const int DIBUTTON_ARCADEP_VIEW_UP_LINK = 0x2207C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_VIEW_DOWN_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_VIEW_DOWN_LINK 0x2207C4E8")]
    public const int DIBUTTON_ARCADEP_VIEW_DOWN_LINK = 0x2207C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_VIEW_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_VIEW_LEFT_LINK 0x2207C4E4")]
    public const int DIBUTTON_ARCADEP_VIEW_LEFT_LINK = 0x2207C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_VIEW_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_VIEW_RIGHT_LINK 0x2207C4EC")]
    public const int DIBUTTON_ARCADEP_VIEW_RIGHT_LINK = 0x2207C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_DEVICE 0x220044FE")]
    public const int DIBUTTON_ARCADEP_DEVICE = 0x220044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_ARCADEP_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_ARCADEP_PAUSE 0x220044FC")]
    public const int DIBUTTON_ARCADEP_PAUSE = 0x220044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_2DCONTROL_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_2DCONTROL_SELECT 0x23000401")]
    public const int DIBUTTON_2DCONTROL_SELECT = 0x23000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_2DCONTROL_SPECIAL1"]/*' />
    [NativeTypeName("#define DIBUTTON_2DCONTROL_SPECIAL1 0x23000402")]
    public const int DIBUTTON_2DCONTROL_SPECIAL1 = 0x23000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_2DCONTROL_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_2DCONTROL_SPECIAL 0x23000403")]
    public const int DIBUTTON_2DCONTROL_SPECIAL = 0x23000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_2DCONTROL_SPECIAL2"]/*' />
    [NativeTypeName("#define DIBUTTON_2DCONTROL_SPECIAL2 0x23000404")]
    public const int DIBUTTON_2DCONTROL_SPECIAL2 = 0x23000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_2DCONTROL_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_2DCONTROL_MENU 0x230004FD")]
    public const int DIBUTTON_2DCONTROL_MENU = 0x230004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_2DCONTROL_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_2DCONTROL_DISPLAY 0x23004405")]
    public const int DIBUTTON_2DCONTROL_DISPLAY = 0x23004405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_2DCONTROL_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_2DCONTROL_DEVICE 0x230044FE")]
    public const int DIBUTTON_2DCONTROL_DEVICE = 0x230044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_2DCONTROL_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_2DCONTROL_PAUSE 0x230044FC")]
    public const int DIBUTTON_2DCONTROL_PAUSE = 0x230044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_3DCONTROL_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_3DCONTROL_SELECT 0x24000401")]
    public const int DIBUTTON_3DCONTROL_SELECT = 0x24000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_3DCONTROL_SPECIAL1"]/*' />
    [NativeTypeName("#define DIBUTTON_3DCONTROL_SPECIAL1 0x24000402")]
    public const int DIBUTTON_3DCONTROL_SPECIAL1 = 0x24000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_3DCONTROL_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_3DCONTROL_SPECIAL 0x24000403")]
    public const int DIBUTTON_3DCONTROL_SPECIAL = 0x24000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_3DCONTROL_SPECIAL2"]/*' />
    [NativeTypeName("#define DIBUTTON_3DCONTROL_SPECIAL2 0x24000404")]
    public const int DIBUTTON_3DCONTROL_SPECIAL2 = 0x24000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_3DCONTROL_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_3DCONTROL_MENU 0x240004FD")]
    public const int DIBUTTON_3DCONTROL_MENU = 0x240004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_3DCONTROL_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_3DCONTROL_DISPLAY 0x24004405")]
    public const int DIBUTTON_3DCONTROL_DISPLAY = 0x24004405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_3DCONTROL_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_3DCONTROL_DEVICE 0x240044FE")]
    public const int DIBUTTON_3DCONTROL_DEVICE = 0x240044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_3DCONTROL_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_3DCONTROL_PAUSE 0x240044FC")]
    public const int DIBUTTON_3DCONTROL_PAUSE = 0x240044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADF_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_CADF_SELECT 0x25000401")]
    public const int DIBUTTON_CADF_SELECT = 0x25000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADF_SPECIAL1"]/*' />
    [NativeTypeName("#define DIBUTTON_CADF_SPECIAL1 0x25000402")]
    public const int DIBUTTON_CADF_SPECIAL1 = 0x25000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADF_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_CADF_SPECIAL 0x25000403")]
    public const int DIBUTTON_CADF_SPECIAL = 0x25000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADF_SPECIAL2"]/*' />
    [NativeTypeName("#define DIBUTTON_CADF_SPECIAL2 0x25000404")]
    public const int DIBUTTON_CADF_SPECIAL2 = 0x25000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADF_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_CADF_MENU 0x250004FD")]
    public const int DIBUTTON_CADF_MENU = 0x250004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADF_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_CADF_DISPLAY 0x25004405")]
    public const int DIBUTTON_CADF_DISPLAY = 0x25004405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADF_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_CADF_DEVICE 0x250044FE")]
    public const int DIBUTTON_CADF_DEVICE = 0x250044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADF_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_CADF_PAUSE 0x250044FC")]
    public const int DIBUTTON_CADF_PAUSE = 0x250044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADM_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_CADM_SELECT 0x26000401")]
    public const int DIBUTTON_CADM_SELECT = 0x26000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADM_SPECIAL1"]/*' />
    [NativeTypeName("#define DIBUTTON_CADM_SPECIAL1 0x26000402")]
    public const int DIBUTTON_CADM_SPECIAL1 = 0x26000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADM_SPECIAL"]/*' />
    [NativeTypeName("#define DIBUTTON_CADM_SPECIAL 0x26000403")]
    public const int DIBUTTON_CADM_SPECIAL = 0x26000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADM_SPECIAL2"]/*' />
    [NativeTypeName("#define DIBUTTON_CADM_SPECIAL2 0x26000404")]
    public const int DIBUTTON_CADM_SPECIAL2 = 0x26000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADM_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_CADM_MENU 0x260004FD")]
    public const int DIBUTTON_CADM_MENU = 0x260004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADM_DISPLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_CADM_DISPLAY 0x26004405")]
    public const int DIBUTTON_CADM_DISPLAY = 0x26004405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADM_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_CADM_DEVICE 0x260044FE")]
    public const int DIBUTTON_CADM_DEVICE = 0x260044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_CADM_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_CADM_PAUSE 0x260044FC")]
    public const int DIBUTTON_CADM_PAUSE = 0x260044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_MUTE"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_MUTE 0x27000401")]
    public const int DIBUTTON_REMOTE_MUTE = 0x27000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_SELECT 0x27000402")]
    public const int DIBUTTON_REMOTE_SELECT = 0x27000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_PLAY"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_PLAY 0x27002403")]
    public const int DIBUTTON_REMOTE_PLAY = 0x27002403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_CUE"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_CUE 0x27002404")]
    public const int DIBUTTON_REMOTE_CUE = 0x27002404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_REVIEW"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_REVIEW 0x27002405")]
    public const int DIBUTTON_REMOTE_REVIEW = 0x27002405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_CHANGE"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_CHANGE 0x27002406")]
    public const int DIBUTTON_REMOTE_CHANGE = 0x27002406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_RECORD"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_RECORD 0x27002407")]
    public const int DIBUTTON_REMOTE_RECORD = 0x27002407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_MENU 0x270004FD")]
    public const int DIBUTTON_REMOTE_MENU = 0x270004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_TV"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_TV 0x27005C08")]
    public const int DIBUTTON_REMOTE_TV = 0x27005C08;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_CABLE"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_CABLE 0x27005C09")]
    public const int DIBUTTON_REMOTE_CABLE = 0x27005C09;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_CD"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_CD 0x27005C0A")]
    public const int DIBUTTON_REMOTE_CD = 0x27005C0A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_VCR"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_VCR 0x27005C0B")]
    public const int DIBUTTON_REMOTE_VCR = 0x27005C0B;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_TUNER"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_TUNER 0x27005C0C")]
    public const int DIBUTTON_REMOTE_TUNER = 0x27005C0C;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DVD"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DVD 0x27005C0D")]
    public const int DIBUTTON_REMOTE_DVD = 0x27005C0D;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_ADJUST"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_ADJUST 0x27005C0E")]
    public const int DIBUTTON_REMOTE_ADJUST = 0x27005C0E;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT0"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT0 0x2700540F")]
    public const int DIBUTTON_REMOTE_DIGIT0 = 0x2700540F;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT1"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT1 0x27005410")]
    public const int DIBUTTON_REMOTE_DIGIT1 = 0x27005410;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT2"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT2 0x27005411")]
    public const int DIBUTTON_REMOTE_DIGIT2 = 0x27005411;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT3"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT3 0x27005412")]
    public const int DIBUTTON_REMOTE_DIGIT3 = 0x27005412;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT4"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT4 0x27005413")]
    public const int DIBUTTON_REMOTE_DIGIT4 = 0x27005413;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT5"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT5 0x27005414")]
    public const int DIBUTTON_REMOTE_DIGIT5 = 0x27005414;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT6"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT6 0x27005415")]
    public const int DIBUTTON_REMOTE_DIGIT6 = 0x27005415;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT7"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT7 0x27005416")]
    public const int DIBUTTON_REMOTE_DIGIT7 = 0x27005416;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT8"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT8 0x27005417")]
    public const int DIBUTTON_REMOTE_DIGIT8 = 0x27005417;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DIGIT9"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT9 0x27005418")]
    public const int DIBUTTON_REMOTE_DIGIT9 = 0x27005418;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_DEVICE 0x270044FE")]
    public const int DIBUTTON_REMOTE_DEVICE = 0x270044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_REMOTE_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_REMOTE_PAUSE 0x270044FC")]
    public const int DIBUTTON_REMOTE_PAUSE = 0x270044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_SELECT"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_SELECT 0x28000401")]
    public const int DIBUTTON_BROWSER_SELECT = 0x28000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_REFRESH"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_REFRESH 0x28000402")]
    public const int DIBUTTON_BROWSER_REFRESH = 0x28000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_MENU 0x280004FD")]
    public const int DIBUTTON_BROWSER_MENU = 0x280004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_SEARCH"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_SEARCH 0x28004403")]
    public const int DIBUTTON_BROWSER_SEARCH = 0x28004403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_STOP"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_STOP 0x28004404")]
    public const int DIBUTTON_BROWSER_STOP = 0x28004404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_HOME"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_HOME 0x28004405")]
    public const int DIBUTTON_BROWSER_HOME = 0x28004405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_FAVORITES"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_FAVORITES 0x28004406")]
    public const int DIBUTTON_BROWSER_FAVORITES = 0x28004406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_NEXT"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_NEXT 0x28004407")]
    public const int DIBUTTON_BROWSER_NEXT = 0x28004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_PREVIOUS"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_PREVIOUS 0x28004408")]
    public const int DIBUTTON_BROWSER_PREVIOUS = 0x28004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_HISTORY"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_HISTORY 0x28004409")]
    public const int DIBUTTON_BROWSER_HISTORY = 0x28004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_PRINT"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_PRINT 0x2800440A")]
    public const int DIBUTTON_BROWSER_PRINT = 0x2800440A;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_DEVICE 0x280044FE")]
    public const int DIBUTTON_BROWSER_DEVICE = 0x280044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_BROWSER_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_BROWSER_PAUSE 0x280044FC")]
    public const int DIBUTTON_BROWSER_PAUSE = 0x280044FC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_FIRE"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_FIRE 0x29000401")]
    public const int DIBUTTON_MECHA_FIRE = 0x29000401;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_WEAPONS"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_WEAPONS 0x29000402")]
    public const int DIBUTTON_MECHA_WEAPONS = 0x29000402;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_TARGET"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_TARGET 0x29000403")]
    public const int DIBUTTON_MECHA_TARGET = 0x29000403;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_REVERSE"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_REVERSE 0x29000404")]
    public const int DIBUTTON_MECHA_REVERSE = 0x29000404;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_ZOOM"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_ZOOM 0x29000405")]
    public const int DIBUTTON_MECHA_ZOOM = 0x29000405;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_JUMP"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_JUMP 0x29000406")]
    public const int DIBUTTON_MECHA_JUMP = 0x29000406;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_MENU"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_MENU 0x290004FD")]
    public const int DIBUTTON_MECHA_MENU = 0x290004FD;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_CENTER"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_CENTER 0x29004407")]
    public const int DIBUTTON_MECHA_CENTER = 0x29004407;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_VIEW"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_VIEW 0x29004408")]
    public const int DIBUTTON_MECHA_VIEW = 0x29004408;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_FIRESECONDARY"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_FIRESECONDARY 0x29004409")]
    public const int DIBUTTON_MECHA_FIRESECONDARY = 0x29004409;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_LEFT_LINK 0x2900C4E4")]
    public const int DIBUTTON_MECHA_LEFT_LINK = 0x2900C4E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_RIGHT_LINK 0x2900C4EC")]
    public const int DIBUTTON_MECHA_RIGHT_LINK = 0x2900C4EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_FORWARD_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_FORWARD_LINK 0x290144E0")]
    public const int DIBUTTON_MECHA_FORWARD_LINK = 0x290144E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_BACK_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_BACK_LINK 0x290144E8")]
    public const int DIBUTTON_MECHA_BACK_LINK = 0x290144E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_ROTATE_LEFT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_ROTATE_LEFT_LINK 0x290244E4")]
    public const int DIBUTTON_MECHA_ROTATE_LEFT_LINK = 0x290244E4;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_ROTATE_RIGHT_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_ROTATE_RIGHT_LINK 0x290244EC")]
    public const int DIBUTTON_MECHA_ROTATE_RIGHT_LINK = 0x290244EC;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_FASTER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_FASTER_LINK 0x2903C4E0")]
    public const int DIBUTTON_MECHA_FASTER_LINK = 0x2903C4E0;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_SLOWER_LINK"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_SLOWER_LINK 0x2903C4E8")]
    public const int DIBUTTON_MECHA_SLOWER_LINK = 0x2903C4E8;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_DEVICE"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_DEVICE 0x290044FE")]
    public const int DIBUTTON_MECHA_DEVICE = 0x290044FE;

    /// <include file='DIBUTTON.xml' path='doc/member[@name="DIBUTTON.DIBUTTON_MECHA_PAUSE"]/*' />
    [NativeTypeName("#define DIBUTTON_MECHA_PAUSE 0x290044FC")]
    public const int DIBUTTON_MECHA_PAUSE = 0x290044FC;
}
