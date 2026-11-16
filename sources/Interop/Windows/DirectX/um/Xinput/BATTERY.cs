// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

public static partial class BATTERY
{
    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_DEVTYPE_GAMEPAD"]/*' />
    [NativeTypeName("#define BATTERY_DEVTYPE_GAMEPAD 0x00")]
    public const int BATTERY_DEVTYPE_GAMEPAD = 0x00;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_DEVTYPE_HEADSET"]/*' />
    [NativeTypeName("#define BATTERY_DEVTYPE_HEADSET 0x01")]
    public const int BATTERY_DEVTYPE_HEADSET = 0x01;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_TYPE_DISCONNECTED"]/*' />
    [NativeTypeName("#define BATTERY_TYPE_DISCONNECTED 0x00")]
    public const int BATTERY_TYPE_DISCONNECTED = 0x00;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_TYPE_WIRED"]/*' />
    [NativeTypeName("#define BATTERY_TYPE_WIRED 0x01")]
    public const int BATTERY_TYPE_WIRED = 0x01;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_TYPE_ALKALINE"]/*' />
    [NativeTypeName("#define BATTERY_TYPE_ALKALINE 0x02")]
    public const int BATTERY_TYPE_ALKALINE = 0x02;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_TYPE_NIMH"]/*' />
    [NativeTypeName("#define BATTERY_TYPE_NIMH 0x03")]
    public const int BATTERY_TYPE_NIMH = 0x03;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_TYPE_UNKNOWN"]/*' />
    [NativeTypeName("#define BATTERY_TYPE_UNKNOWN 0xFF")]
    public const int BATTERY_TYPE_UNKNOWN = 0xFF;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_LEVEL_EMPTY"]/*' />
    [NativeTypeName("#define BATTERY_LEVEL_EMPTY 0x00")]
    public const int BATTERY_LEVEL_EMPTY = 0x00;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_LEVEL_LOW"]/*' />
    [NativeTypeName("#define BATTERY_LEVEL_LOW 0x01")]
    public const int BATTERY_LEVEL_LOW = 0x01;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_LEVEL_MEDIUM"]/*' />
    [NativeTypeName("#define BATTERY_LEVEL_MEDIUM 0x02")]
    public const int BATTERY_LEVEL_MEDIUM = 0x02;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_LEVEL_FULL"]/*' />
    [NativeTypeName("#define BATTERY_LEVEL_FULL 0x03")]
    public const int BATTERY_LEVEL_FULL = 0x03;
}
