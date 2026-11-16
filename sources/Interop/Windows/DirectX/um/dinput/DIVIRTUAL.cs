// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIVIRTUAL
{
    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_DRIVING_RACE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_DRIVING_RACE 0x01000000")]
    public const int DIVIRTUAL_DRIVING_RACE = 0x01000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_DRIVING_COMBAT"]/*' />
    [NativeTypeName("#define DIVIRTUAL_DRIVING_COMBAT 0x02000000")]
    public const int DIVIRTUAL_DRIVING_COMBAT = 0x02000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_DRIVING_TANK"]/*' />
    [NativeTypeName("#define DIVIRTUAL_DRIVING_TANK 0x03000000")]
    public const int DIVIRTUAL_DRIVING_TANK = 0x03000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_FLYING_CIVILIAN"]/*' />
    [NativeTypeName("#define DIVIRTUAL_FLYING_CIVILIAN 0x04000000")]
    public const int DIVIRTUAL_FLYING_CIVILIAN = 0x04000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_FLYING_MILITARY"]/*' />
    [NativeTypeName("#define DIVIRTUAL_FLYING_MILITARY 0x05000000")]
    public const int DIVIRTUAL_FLYING_MILITARY = 0x05000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_FLYING_HELICOPTER"]/*' />
    [NativeTypeName("#define DIVIRTUAL_FLYING_HELICOPTER 0x06000000")]
    public const int DIVIRTUAL_FLYING_HELICOPTER = 0x06000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPACESIM"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPACESIM 0x07000000")]
    public const int DIVIRTUAL_SPACESIM = 0x07000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_FIGHTING_HAND2HAND"]/*' />
    [NativeTypeName("#define DIVIRTUAL_FIGHTING_HAND2HAND 0x08000000")]
    public const int DIVIRTUAL_FIGHTING_HAND2HAND = 0x08000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_FIGHTING_FPS"]/*' />
    [NativeTypeName("#define DIVIRTUAL_FIGHTING_FPS 0x09000000")]
    public const int DIVIRTUAL_FIGHTING_FPS = 0x09000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_FIGHTING_THIRDPERSON"]/*' />
    [NativeTypeName("#define DIVIRTUAL_FIGHTING_THIRDPERSON 0x0A000000")]
    public const int DIVIRTUAL_FIGHTING_THIRDPERSON = 0x0A000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_STRATEGY_ROLEPLAYING"]/*' />
    [NativeTypeName("#define DIVIRTUAL_STRATEGY_ROLEPLAYING 0x0B000000")]
    public const int DIVIRTUAL_STRATEGY_ROLEPLAYING = 0x0B000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_STRATEGY_TURN"]/*' />
    [NativeTypeName("#define DIVIRTUAL_STRATEGY_TURN 0x0C000000")]
    public const int DIVIRTUAL_STRATEGY_TURN = 0x0C000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_HUNTING"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_HUNTING 0x0D000000")]
    public const int DIVIRTUAL_SPORTS_HUNTING = 0x0D000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_FISHING"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_FISHING 0x0E000000")]
    public const int DIVIRTUAL_SPORTS_FISHING = 0x0E000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_BASEBALL_BAT"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASEBALL_BAT 0x0F000000")]
    public const int DIVIRTUAL_SPORTS_BASEBALL_BAT = 0x0F000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_BASEBALL_PITCH"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASEBALL_PITCH 0x10000000")]
    public const int DIVIRTUAL_SPORTS_BASEBALL_PITCH = 0x10000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_BASEBALL_FIELD"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASEBALL_FIELD 0x11000000")]
    public const int DIVIRTUAL_SPORTS_BASEBALL_FIELD = 0x11000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_BASKETBALL_OFFENSE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASKETBALL_OFFENSE 0x12000000")]
    public const int DIVIRTUAL_SPORTS_BASKETBALL_OFFENSE = 0x12000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_BASKETBALL_DEFENSE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASKETBALL_DEFENSE 0x13000000")]
    public const int DIVIRTUAL_SPORTS_BASKETBALL_DEFENSE = 0x13000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_FOOTBALL_FIELD"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_FOOTBALL_FIELD 0x14000000")]
    public const int DIVIRTUAL_SPORTS_FOOTBALL_FIELD = 0x14000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_FOOTBALL_QBCK"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_FOOTBALL_QBCK 0x15000000")]
    public const int DIVIRTUAL_SPORTS_FOOTBALL_QBCK = 0x15000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_FOOTBALL_OFFENSE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_FOOTBALL_OFFENSE 0x16000000")]
    public const int DIVIRTUAL_SPORTS_FOOTBALL_OFFENSE = 0x16000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_FOOTBALL_DEFENSE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_FOOTBALL_DEFENSE 0x17000000")]
    public const int DIVIRTUAL_SPORTS_FOOTBALL_DEFENSE = 0x17000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_GOLF"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_GOLF 0x18000000")]
    public const int DIVIRTUAL_SPORTS_GOLF = 0x18000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_HOCKEY_OFFENSE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_HOCKEY_OFFENSE 0x19000000")]
    public const int DIVIRTUAL_SPORTS_HOCKEY_OFFENSE = 0x19000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_HOCKEY_DEFENSE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_HOCKEY_DEFENSE 0x1A000000")]
    public const int DIVIRTUAL_SPORTS_HOCKEY_DEFENSE = 0x1A000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_HOCKEY_GOALIE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_HOCKEY_GOALIE 0x1B000000")]
    public const int DIVIRTUAL_SPORTS_HOCKEY_GOALIE = 0x1B000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_BIKING_MOUNTAIN"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_BIKING_MOUNTAIN 0x1C000000")]
    public const int DIVIRTUAL_SPORTS_BIKING_MOUNTAIN = 0x1C000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_SKIING"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_SKIING 0x1D000000")]
    public const int DIVIRTUAL_SPORTS_SKIING = 0x1D000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_SOCCER_OFFENSE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_SOCCER_OFFENSE 0x1E000000")]
    public const int DIVIRTUAL_SPORTS_SOCCER_OFFENSE = 0x1E000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_SOCCER_DEFENSE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_SOCCER_DEFENSE 0x1F000000")]
    public const int DIVIRTUAL_SPORTS_SOCCER_DEFENSE = 0x1F000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_SPORTS_RACQUET"]/*' />
    [NativeTypeName("#define DIVIRTUAL_SPORTS_RACQUET 0x20000000")]
    public const int DIVIRTUAL_SPORTS_RACQUET = 0x20000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_ARCADE_SIDE2SIDE"]/*' />
    [NativeTypeName("#define DIVIRTUAL_ARCADE_SIDE2SIDE 0x21000000")]
    public const int DIVIRTUAL_ARCADE_SIDE2SIDE = 0x21000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_ARCADE_PLATFORM"]/*' />
    [NativeTypeName("#define DIVIRTUAL_ARCADE_PLATFORM 0x22000000")]
    public const int DIVIRTUAL_ARCADE_PLATFORM = 0x22000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_CAD_2DCONTROL"]/*' />
    [NativeTypeName("#define DIVIRTUAL_CAD_2DCONTROL 0x23000000")]
    public const int DIVIRTUAL_CAD_2DCONTROL = 0x23000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_CAD_3DCONTROL"]/*' />
    [NativeTypeName("#define DIVIRTUAL_CAD_3DCONTROL 0x24000000")]
    public const int DIVIRTUAL_CAD_3DCONTROL = 0x24000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_CAD_FLYBY"]/*' />
    [NativeTypeName("#define DIVIRTUAL_CAD_FLYBY 0x25000000")]
    public const int DIVIRTUAL_CAD_FLYBY = 0x25000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_CAD_MODEL"]/*' />
    [NativeTypeName("#define DIVIRTUAL_CAD_MODEL 0x26000000")]
    public const int DIVIRTUAL_CAD_MODEL = 0x26000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_REMOTE_CONTROL"]/*' />
    [NativeTypeName("#define DIVIRTUAL_REMOTE_CONTROL 0x27000000")]
    public const int DIVIRTUAL_REMOTE_CONTROL = 0x27000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_BROWSER_CONTROL"]/*' />
    [NativeTypeName("#define DIVIRTUAL_BROWSER_CONTROL 0x28000000")]
    public const int DIVIRTUAL_BROWSER_CONTROL = 0x28000000;

    /// <include file='DIVIRTUAL.xml' path='doc/member[@name="DIVIRTUAL.DIVIRTUAL_DRIVING_MECHA"]/*' />
    [NativeTypeName("#define DIVIRTUAL_DRIVING_MECHA 0x29000000")]
    public const int DIVIRTUAL_DRIVING_MECHA = 0x29000000;
}
