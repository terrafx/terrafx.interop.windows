// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIAXIS
{
    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGR_STEER"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGR_STEER 0x01008A01")]
    public const int DIAXIS_DRIVINGR_STEER = 0x01008A01;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGR_ACCELERATE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGR_ACCELERATE 0x01039202")]
    public const int DIAXIS_DRIVINGR_ACCELERATE = 0x01039202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGR_BRAKE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGR_BRAKE 0x01041203")]
    public const int DIAXIS_DRIVINGR_BRAKE = 0x01041203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGR_ACCEL_AND_BRAKE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGR_ACCEL_AND_BRAKE 0x01014A04")]
    public const int DIAXIS_DRIVINGR_ACCEL_AND_BRAKE = 0x01014A04;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGC_STEER"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGC_STEER 0x02008A01")]
    public const int DIAXIS_DRIVINGC_STEER = 0x02008A01;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGC_ACCELERATE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGC_ACCELERATE 0x02039202")]
    public const int DIAXIS_DRIVINGC_ACCELERATE = 0x02039202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGC_BRAKE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGC_BRAKE 0x02041203")]
    public const int DIAXIS_DRIVINGC_BRAKE = 0x02041203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGC_ACCEL_AND_BRAKE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGC_ACCEL_AND_BRAKE 0x02014A04")]
    public const int DIAXIS_DRIVINGC_ACCEL_AND_BRAKE = 0x02014A04;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGT_STEER"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGT_STEER 0x03008A01")]
    public const int DIAXIS_DRIVINGT_STEER = 0x03008A01;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGT_BARREL"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGT_BARREL 0x03010202")]
    public const int DIAXIS_DRIVINGT_BARREL = 0x03010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGT_ACCELERATE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGT_ACCELERATE 0x03039203")]
    public const int DIAXIS_DRIVINGT_ACCELERATE = 0x03039203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGT_ROTATE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGT_ROTATE 0x03020204")]
    public const int DIAXIS_DRIVINGT_ROTATE = 0x03020204;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGT_BRAKE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGT_BRAKE 0x03045205")]
    public const int DIAXIS_DRIVINGT_BRAKE = 0x03045205;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_DRIVINGT_ACCEL_AND_BRAKE"]/*' />
    [NativeTypeName("#define DIAXIS_DRIVINGT_ACCEL_AND_BRAKE 0x03014A06")]
    public const int DIAXIS_DRIVINGT_ACCEL_AND_BRAKE = 0x03014A06;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGC_BANK"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGC_BANK 0x04008A01")]
    public const int DIAXIS_FLYINGC_BANK = 0x04008A01;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGC_PITCH"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGC_PITCH 0x04010A02")]
    public const int DIAXIS_FLYINGC_PITCH = 0x04010A02;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGC_THROTTLE"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGC_THROTTLE 0x04039203")]
    public const int DIAXIS_FLYINGC_THROTTLE = 0x04039203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGC_BRAKE"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGC_BRAKE 0x04046A04")]
    public const int DIAXIS_FLYINGC_BRAKE = 0x04046A04;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGC_RUDDER"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGC_RUDDER 0x04025205")]
    public const int DIAXIS_FLYINGC_RUDDER = 0x04025205;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGC_FLAPS"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGC_FLAPS 0x04055A06")]
    public const int DIAXIS_FLYINGC_FLAPS = 0x04055A06;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGM_BANK"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGM_BANK 0x05008A01")]
    public const int DIAXIS_FLYINGM_BANK = 0x05008A01;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGM_PITCH"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGM_PITCH 0x05010A02")]
    public const int DIAXIS_FLYINGM_PITCH = 0x05010A02;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGM_THROTTLE"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGM_THROTTLE 0x05039203")]
    public const int DIAXIS_FLYINGM_THROTTLE = 0x05039203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGM_RUDDER"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGM_RUDDER 0x05024A04")]
    public const int DIAXIS_FLYINGM_RUDDER = 0x05024A04;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGM_BRAKE"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGM_BRAKE 0x05046205")]
    public const int DIAXIS_FLYINGM_BRAKE = 0x05046205;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGM_FLAPS"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGM_FLAPS 0x05055206")]
    public const int DIAXIS_FLYINGM_FLAPS = 0x05055206;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGH_BANK"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGH_BANK 0x06008A01")]
    public const int DIAXIS_FLYINGH_BANK = 0x06008A01;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGH_PITCH"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGH_PITCH 0x06010A02")]
    public const int DIAXIS_FLYINGH_PITCH = 0x06010A02;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGH_COLLECTIVE"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGH_COLLECTIVE 0x06018A03")]
    public const int DIAXIS_FLYINGH_COLLECTIVE = 0x06018A03;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGH_TORQUE"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGH_TORQUE 0x06025A04")]
    public const int DIAXIS_FLYINGH_TORQUE = 0x06025A04;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FLYINGH_THROTTLE"]/*' />
    [NativeTypeName("#define DIAXIS_FLYINGH_THROTTLE 0x0603DA05")]
    public const int DIAXIS_FLYINGH_THROTTLE = 0x0603DA05;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SPACESIM_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_SPACESIM_LATERAL 0x07008201")]
    public const int DIAXIS_SPACESIM_LATERAL = 0x07008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SPACESIM_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_SPACESIM_MOVE 0x07010202")]
    public const int DIAXIS_SPACESIM_MOVE = 0x07010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SPACESIM_THROTTLE"]/*' />
    [NativeTypeName("#define DIAXIS_SPACESIM_THROTTLE 0x07038203")]
    public const int DIAXIS_SPACESIM_THROTTLE = 0x07038203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SPACESIM_CLIMB"]/*' />
    [NativeTypeName("#define DIAXIS_SPACESIM_CLIMB 0x0701C204")]
    public const int DIAXIS_SPACESIM_CLIMB = 0x0701C204;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SPACESIM_ROTATE"]/*' />
    [NativeTypeName("#define DIAXIS_SPACESIM_ROTATE 0x07024205")]
    public const int DIAXIS_SPACESIM_ROTATE = 0x07024205;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FIGHTINGH_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_FIGHTINGH_LATERAL 0x08008201")]
    public const int DIAXIS_FIGHTINGH_LATERAL = 0x08008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FIGHTINGH_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_FIGHTINGH_MOVE 0x08010202")]
    public const int DIAXIS_FIGHTINGH_MOVE = 0x08010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FIGHTINGH_ROTATE"]/*' />
    [NativeTypeName("#define DIAXIS_FIGHTINGH_ROTATE 0x08024203")]
    public const int DIAXIS_FIGHTINGH_ROTATE = 0x08024203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FPS_ROTATE"]/*' />
    [NativeTypeName("#define DIAXIS_FPS_ROTATE 0x09008201")]
    public const int DIAXIS_FPS_ROTATE = 0x09008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FPS_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_FPS_MOVE 0x09010202")]
    public const int DIAXIS_FPS_MOVE = 0x09010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FPS_LOOKUPDOWN"]/*' />
    [NativeTypeName("#define DIAXIS_FPS_LOOKUPDOWN 0x09018203")]
    public const int DIAXIS_FPS_LOOKUPDOWN = 0x09018203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FPS_SIDESTEP"]/*' />
    [NativeTypeName("#define DIAXIS_FPS_SIDESTEP 0x09024204")]
    public const int DIAXIS_FPS_SIDESTEP = 0x09024204;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_TPS_TURN"]/*' />
    [NativeTypeName("#define DIAXIS_TPS_TURN 0x0A020201")]
    public const int DIAXIS_TPS_TURN = 0x0A020201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_TPS_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_TPS_MOVE 0x0A010202")]
    public const int DIAXIS_TPS_MOVE = 0x0A010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_TPS_STEP"]/*' />
    [NativeTypeName("#define DIAXIS_TPS_STEP 0x0A00C203")]
    public const int DIAXIS_TPS_STEP = 0x0A00C203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_STRATEGYR_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_STRATEGYR_LATERAL 0x0B008201")]
    public const int DIAXIS_STRATEGYR_LATERAL = 0x0B008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_STRATEGYR_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_STRATEGYR_MOVE 0x0B010202")]
    public const int DIAXIS_STRATEGYR_MOVE = 0x0B010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_STRATEGYR_ROTATE"]/*' />
    [NativeTypeName("#define DIAXIS_STRATEGYR_ROTATE 0x0B024203")]
    public const int DIAXIS_STRATEGYR_ROTATE = 0x0B024203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_STRATEGYT_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_STRATEGYT_LATERAL 0x0C008201")]
    public const int DIAXIS_STRATEGYT_LATERAL = 0x0C008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_STRATEGYT_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_STRATEGYT_MOVE 0x0C010202")]
    public const int DIAXIS_STRATEGYT_MOVE = 0x0C010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_HUNTING_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_HUNTING_LATERAL 0x0D008201")]
    public const int DIAXIS_HUNTING_LATERAL = 0x0D008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_HUNTING_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_HUNTING_MOVE 0x0D010202")]
    public const int DIAXIS_HUNTING_MOVE = 0x0D010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_HUNTING_ROTATE"]/*' />
    [NativeTypeName("#define DIAXIS_HUNTING_ROTATE 0x0D024203")]
    public const int DIAXIS_HUNTING_ROTATE = 0x0D024203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FISHING_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_FISHING_LATERAL 0x0E008201")]
    public const int DIAXIS_FISHING_LATERAL = 0x0E008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FISHING_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_FISHING_MOVE 0x0E010202")]
    public const int DIAXIS_FISHING_MOVE = 0x0E010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FISHING_ROTATE"]/*' />
    [NativeTypeName("#define DIAXIS_FISHING_ROTATE 0x0E024203")]
    public const int DIAXIS_FISHING_ROTATE = 0x0E024203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BASEBALLB_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_BASEBALLB_LATERAL 0x0F008201")]
    public const int DIAXIS_BASEBALLB_LATERAL = 0x0F008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BASEBALLB_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_BASEBALLB_MOVE 0x0F010202")]
    public const int DIAXIS_BASEBALLB_MOVE = 0x0F010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BASEBALLP_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_BASEBALLP_LATERAL 0x10008201")]
    public const int DIAXIS_BASEBALLP_LATERAL = 0x10008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BASEBALLP_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_BASEBALLP_MOVE 0x10010202")]
    public const int DIAXIS_BASEBALLP_MOVE = 0x10010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BASEBALLF_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_BASEBALLF_LATERAL 0x11008201")]
    public const int DIAXIS_BASEBALLF_LATERAL = 0x11008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BASEBALLF_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_BASEBALLF_MOVE 0x11010202")]
    public const int DIAXIS_BASEBALLF_MOVE = 0x11010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BBALLO_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_BBALLO_LATERAL 0x12008201")]
    public const int DIAXIS_BBALLO_LATERAL = 0x12008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BBALLO_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_BBALLO_MOVE 0x12010202")]
    public const int DIAXIS_BBALLO_MOVE = 0x12010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BBALLD_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_BBALLD_LATERAL 0x13008201")]
    public const int DIAXIS_BBALLD_LATERAL = 0x13008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BBALLD_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_BBALLD_MOVE 0x13010202")]
    public const int DIAXIS_BBALLD_MOVE = 0x13010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FOOTBALLQ_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_FOOTBALLQ_LATERAL 0x15008201")]
    public const int DIAXIS_FOOTBALLQ_LATERAL = 0x15008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FOOTBALLQ_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_FOOTBALLQ_MOVE 0x15010202")]
    public const int DIAXIS_FOOTBALLQ_MOVE = 0x15010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FOOTBALLO_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_FOOTBALLO_LATERAL 0x16008201")]
    public const int DIAXIS_FOOTBALLO_LATERAL = 0x16008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FOOTBALLO_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_FOOTBALLO_MOVE 0x16010202")]
    public const int DIAXIS_FOOTBALLO_MOVE = 0x16010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FOOTBALLD_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_FOOTBALLD_LATERAL 0x17008201")]
    public const int DIAXIS_FOOTBALLD_LATERAL = 0x17008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_FOOTBALLD_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_FOOTBALLD_MOVE 0x17010202")]
    public const int DIAXIS_FOOTBALLD_MOVE = 0x17010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_GOLF_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_GOLF_LATERAL 0x18008201")]
    public const int DIAXIS_GOLF_LATERAL = 0x18008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_GOLF_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_GOLF_MOVE 0x18010202")]
    public const int DIAXIS_GOLF_MOVE = 0x18010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_HOCKEYO_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_HOCKEYO_LATERAL 0x19008201")]
    public const int DIAXIS_HOCKEYO_LATERAL = 0x19008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_HOCKEYO_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_HOCKEYO_MOVE 0x19010202")]
    public const int DIAXIS_HOCKEYO_MOVE = 0x19010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_HOCKEYD_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_HOCKEYD_LATERAL 0x1A008201")]
    public const int DIAXIS_HOCKEYD_LATERAL = 0x1A008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_HOCKEYD_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_HOCKEYD_MOVE 0x1A010202")]
    public const int DIAXIS_HOCKEYD_MOVE = 0x1A010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_HOCKEYG_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_HOCKEYG_LATERAL 0x1B008201")]
    public const int DIAXIS_HOCKEYG_LATERAL = 0x1B008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_HOCKEYG_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_HOCKEYG_MOVE 0x1B010202")]
    public const int DIAXIS_HOCKEYG_MOVE = 0x1B010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BIKINGM_TURN"]/*' />
    [NativeTypeName("#define DIAXIS_BIKINGM_TURN 0x1C008201")]
    public const int DIAXIS_BIKINGM_TURN = 0x1C008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BIKINGM_PEDAL"]/*' />
    [NativeTypeName("#define DIAXIS_BIKINGM_PEDAL 0x1C010202")]
    public const int DIAXIS_BIKINGM_PEDAL = 0x1C010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BIKINGM_BRAKE"]/*' />
    [NativeTypeName("#define DIAXIS_BIKINGM_BRAKE 0x1C044203")]
    public const int DIAXIS_BIKINGM_BRAKE = 0x1C044203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SKIING_TURN"]/*' />
    [NativeTypeName("#define DIAXIS_SKIING_TURN 0x1D008201")]
    public const int DIAXIS_SKIING_TURN = 0x1D008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SKIING_SPEED"]/*' />
    [NativeTypeName("#define DIAXIS_SKIING_SPEED 0x1D010202")]
    public const int DIAXIS_SKIING_SPEED = 0x1D010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SOCCERO_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_SOCCERO_LATERAL 0x1E008201")]
    public const int DIAXIS_SOCCERO_LATERAL = 0x1E008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SOCCERO_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_SOCCERO_MOVE 0x1E010202")]
    public const int DIAXIS_SOCCERO_MOVE = 0x1E010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SOCCERO_BEND"]/*' />
    [NativeTypeName("#define DIAXIS_SOCCERO_BEND 0x1E018203")]
    public const int DIAXIS_SOCCERO_BEND = 0x1E018203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SOCCERD_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_SOCCERD_LATERAL 0x1F008201")]
    public const int DIAXIS_SOCCERD_LATERAL = 0x1F008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_SOCCERD_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_SOCCERD_MOVE 0x1F010202")]
    public const int DIAXIS_SOCCERD_MOVE = 0x1F010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_RACQUET_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_RACQUET_LATERAL 0x20008201")]
    public const int DIAXIS_RACQUET_LATERAL = 0x20008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_RACQUET_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_RACQUET_MOVE 0x20010202")]
    public const int DIAXIS_RACQUET_MOVE = 0x20010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ARCADES_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_ARCADES_LATERAL 0x21008201")]
    public const int DIAXIS_ARCADES_LATERAL = 0x21008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ARCADES_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_ARCADES_MOVE 0x21010202")]
    public const int DIAXIS_ARCADES_MOVE = 0x21010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ARCADEP_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_ARCADEP_LATERAL 0x22008201")]
    public const int DIAXIS_ARCADEP_LATERAL = 0x22008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ARCADEP_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_ARCADEP_MOVE 0x22010202")]
    public const int DIAXIS_ARCADEP_MOVE = 0x22010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_2DCONTROL_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_2DCONTROL_LATERAL 0x23008201")]
    public const int DIAXIS_2DCONTROL_LATERAL = 0x23008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_2DCONTROL_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_2DCONTROL_MOVE 0x23010202")]
    public const int DIAXIS_2DCONTROL_MOVE = 0x23010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_2DCONTROL_INOUT"]/*' />
    [NativeTypeName("#define DIAXIS_2DCONTROL_INOUT 0x23018203")]
    public const int DIAXIS_2DCONTROL_INOUT = 0x23018203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_2DCONTROL_ROTATEZ"]/*' />
    [NativeTypeName("#define DIAXIS_2DCONTROL_ROTATEZ 0x23024204")]
    public const int DIAXIS_2DCONTROL_ROTATEZ = 0x23024204;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_3DCONTROL_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_3DCONTROL_LATERAL 0x24008201")]
    public const int DIAXIS_3DCONTROL_LATERAL = 0x24008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_3DCONTROL_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_3DCONTROL_MOVE 0x24010202")]
    public const int DIAXIS_3DCONTROL_MOVE = 0x24010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_3DCONTROL_INOUT"]/*' />
    [NativeTypeName("#define DIAXIS_3DCONTROL_INOUT 0x24018203")]
    public const int DIAXIS_3DCONTROL_INOUT = 0x24018203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_3DCONTROL_ROTATEX"]/*' />
    [NativeTypeName("#define DIAXIS_3DCONTROL_ROTATEX 0x24034204")]
    public const int DIAXIS_3DCONTROL_ROTATEX = 0x24034204;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_3DCONTROL_ROTATEY"]/*' />
    [NativeTypeName("#define DIAXIS_3DCONTROL_ROTATEY 0x2402C205")]
    public const int DIAXIS_3DCONTROL_ROTATEY = 0x2402C205;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_3DCONTROL_ROTATEZ"]/*' />
    [NativeTypeName("#define DIAXIS_3DCONTROL_ROTATEZ 0x24024206")]
    public const int DIAXIS_3DCONTROL_ROTATEZ = 0x24024206;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADF_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_CADF_LATERAL 0x25008201")]
    public const int DIAXIS_CADF_LATERAL = 0x25008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADF_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_CADF_MOVE 0x25010202")]
    public const int DIAXIS_CADF_MOVE = 0x25010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADF_INOUT"]/*' />
    [NativeTypeName("#define DIAXIS_CADF_INOUT 0x25018203")]
    public const int DIAXIS_CADF_INOUT = 0x25018203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADF_ROTATEX"]/*' />
    [NativeTypeName("#define DIAXIS_CADF_ROTATEX 0x25034204")]
    public const int DIAXIS_CADF_ROTATEX = 0x25034204;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADF_ROTATEY"]/*' />
    [NativeTypeName("#define DIAXIS_CADF_ROTATEY 0x2502C205")]
    public const int DIAXIS_CADF_ROTATEY = 0x2502C205;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADF_ROTATEZ"]/*' />
    [NativeTypeName("#define DIAXIS_CADF_ROTATEZ 0x25024206")]
    public const int DIAXIS_CADF_ROTATEZ = 0x25024206;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADM_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_CADM_LATERAL 0x26008201")]
    public const int DIAXIS_CADM_LATERAL = 0x26008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADM_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_CADM_MOVE 0x26010202")]
    public const int DIAXIS_CADM_MOVE = 0x26010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADM_INOUT"]/*' />
    [NativeTypeName("#define DIAXIS_CADM_INOUT 0x26018203")]
    public const int DIAXIS_CADM_INOUT = 0x26018203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADM_ROTATEX"]/*' />
    [NativeTypeName("#define DIAXIS_CADM_ROTATEX 0x26034204")]
    public const int DIAXIS_CADM_ROTATEX = 0x26034204;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADM_ROTATEY"]/*' />
    [NativeTypeName("#define DIAXIS_CADM_ROTATEY 0x2602C205")]
    public const int DIAXIS_CADM_ROTATEY = 0x2602C205;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_CADM_ROTATEZ"]/*' />
    [NativeTypeName("#define DIAXIS_CADM_ROTATEZ 0x26024206")]
    public const int DIAXIS_CADM_ROTATEZ = 0x26024206;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_REMOTE_SLIDER"]/*' />
    [NativeTypeName("#define DIAXIS_REMOTE_SLIDER 0x27050201")]
    public const int DIAXIS_REMOTE_SLIDER = 0x27050201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_REMOTE_SLIDER2"]/*' />
    [NativeTypeName("#define DIAXIS_REMOTE_SLIDER2 0x27054202")]
    public const int DIAXIS_REMOTE_SLIDER2 = 0x27054202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BROWSER_LATERAL"]/*' />
    [NativeTypeName("#define DIAXIS_BROWSER_LATERAL 0x28008201")]
    public const int DIAXIS_BROWSER_LATERAL = 0x28008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BROWSER_MOVE"]/*' />
    [NativeTypeName("#define DIAXIS_BROWSER_MOVE 0x28010202")]
    public const int DIAXIS_BROWSER_MOVE = 0x28010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_BROWSER_VIEW"]/*' />
    [NativeTypeName("#define DIAXIS_BROWSER_VIEW 0x28018203")]
    public const int DIAXIS_BROWSER_VIEW = 0x28018203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_MECHA_STEER"]/*' />
    [NativeTypeName("#define DIAXIS_MECHA_STEER 0x29008201")]
    public const int DIAXIS_MECHA_STEER = 0x29008201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_MECHA_TORSO"]/*' />
    [NativeTypeName("#define DIAXIS_MECHA_TORSO 0x29010202")]
    public const int DIAXIS_MECHA_TORSO = 0x29010202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_MECHA_ROTATE"]/*' />
    [NativeTypeName("#define DIAXIS_MECHA_ROTATE 0x29020203")]
    public const int DIAXIS_MECHA_ROTATE = 0x29020203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_MECHA_THROTTLE"]/*' />
    [NativeTypeName("#define DIAXIS_MECHA_THROTTLE 0x29038204")]
    public const int DIAXIS_MECHA_THROTTLE = 0x29038204;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_X_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_X_1 0xFF00C201")]
    public const uint DIAXIS_ANY_X_1 = 0xFF00C201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_X_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_X_2 0xFF00C202")]
    public const uint DIAXIS_ANY_X_2 = 0xFF00C202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_Y_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_Y_1 0xFF014201")]
    public const uint DIAXIS_ANY_Y_1 = 0xFF014201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_Y_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_Y_2 0xFF014202")]
    public const uint DIAXIS_ANY_Y_2 = 0xFF014202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_Z_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_Z_1 0xFF01C201")]
    public const uint DIAXIS_ANY_Z_1 = 0xFF01C201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_Z_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_Z_2 0xFF01C202")]
    public const uint DIAXIS_ANY_Z_2 = 0xFF01C202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_R_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_R_1 0xFF024201")]
    public const uint DIAXIS_ANY_R_1 = 0xFF024201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_R_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_R_2 0xFF024202")]
    public const uint DIAXIS_ANY_R_2 = 0xFF024202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_U_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_U_1 0xFF02C201")]
    public const uint DIAXIS_ANY_U_1 = 0xFF02C201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_U_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_U_2 0xFF02C202")]
    public const uint DIAXIS_ANY_U_2 = 0xFF02C202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_V_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_V_1 0xFF034201")]
    public const uint DIAXIS_ANY_V_1 = 0xFF034201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_V_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_V_2 0xFF034202")]
    public const uint DIAXIS_ANY_V_2 = 0xFF034202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_A_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_A_1 0xFF03C201")]
    public const uint DIAXIS_ANY_A_1 = 0xFF03C201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_A_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_A_2 0xFF03C202")]
    public const uint DIAXIS_ANY_A_2 = 0xFF03C202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_B_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_B_1 0xFF044201")]
    public const uint DIAXIS_ANY_B_1 = 0xFF044201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_B_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_B_2 0xFF044202")]
    public const uint DIAXIS_ANY_B_2 = 0xFF044202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_C_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_C_1 0xFF04C201")]
    public const uint DIAXIS_ANY_C_1 = 0xFF04C201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_C_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_C_2 0xFF04C202")]
    public const uint DIAXIS_ANY_C_2 = 0xFF04C202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_S_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_S_1 0xFF054201")]
    public const uint DIAXIS_ANY_S_1 = 0xFF054201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_S_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_S_2 0xFF054202")]
    public const uint DIAXIS_ANY_S_2 = 0xFF054202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_1"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_1 0xFF004201")]
    public const uint DIAXIS_ANY_1 = 0xFF004201;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_2"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_2 0xFF004202")]
    public const uint DIAXIS_ANY_2 = 0xFF004202;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_3"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_3 0xFF004203")]
    public const uint DIAXIS_ANY_3 = 0xFF004203;

    /// <include file='DIAXIS.xml' path='doc/member[@name="DIAXIS.DIAXIS_ANY_4"]/*' />
    [NativeTypeName("#define DIAXIS_ANY_4 0xFF004204")]
    public const uint DIAXIS_ANY_4 = 0xFF004204;
}
