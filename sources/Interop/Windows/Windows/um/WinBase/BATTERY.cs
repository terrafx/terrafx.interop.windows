// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class BATTERY
{
    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_FLAG_HIGH"]/*' />
    [NativeTypeName("#define BATTERY_FLAG_HIGH 0x01")]
    public const int BATTERY_FLAG_HIGH = 0x01;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_FLAG_LOW"]/*' />
    [NativeTypeName("#define BATTERY_FLAG_LOW 0x02")]
    public const int BATTERY_FLAG_LOW = 0x02;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_FLAG_CRITICAL"]/*' />
    [NativeTypeName("#define BATTERY_FLAG_CRITICAL 0x04")]
    public const int BATTERY_FLAG_CRITICAL = 0x04;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_FLAG_CHARGING"]/*' />
    [NativeTypeName("#define BATTERY_FLAG_CHARGING 0x08")]
    public const int BATTERY_FLAG_CHARGING = 0x08;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_FLAG_NO_BATTERY"]/*' />
    [NativeTypeName("#define BATTERY_FLAG_NO_BATTERY 0x80")]
    public const int BATTERY_FLAG_NO_BATTERY = 0x80;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_FLAG_UNKNOWN"]/*' />
    [NativeTypeName("#define BATTERY_FLAG_UNKNOWN 0xFF")]
    public const int BATTERY_FLAG_UNKNOWN = 0xFF;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_PERCENTAGE_UNKNOWN"]/*' />
    [NativeTypeName("#define BATTERY_PERCENTAGE_UNKNOWN 0xFF")]
    public const int BATTERY_PERCENTAGE_UNKNOWN = 0xFF;

    /// <include file='BATTERY.xml' path='doc/member[@name="BATTERY.BATTERY_LIFE_UNKNOWN"]/*' />
    [NativeTypeName("#define BATTERY_LIFE_UNKNOWN 0xFFFFFFFF")]
    public const uint BATTERY_LIFE_UNKNOWN = 0xFFFFFFFF;
}
