// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PBT
{
    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMQUERYSUSPEND"]/*' />
    [NativeTypeName("#define PBT_APMQUERYSUSPEND 0x0000")]
    public const int PBT_APMQUERYSUSPEND = 0x0000;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMQUERYSTANDBY"]/*' />
    [NativeTypeName("#define PBT_APMQUERYSTANDBY 0x0001")]
    public const int PBT_APMQUERYSTANDBY = 0x0001;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMQUERYSUSPENDFAILED"]/*' />
    [NativeTypeName("#define PBT_APMQUERYSUSPENDFAILED 0x0002")]
    public const int PBT_APMQUERYSUSPENDFAILED = 0x0002;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMQUERYSTANDBYFAILED"]/*' />
    [NativeTypeName("#define PBT_APMQUERYSTANDBYFAILED 0x0003")]
    public const int PBT_APMQUERYSTANDBYFAILED = 0x0003;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMSUSPEND"]/*' />
    [NativeTypeName("#define PBT_APMSUSPEND 0x0004")]
    public const int PBT_APMSUSPEND = 0x0004;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMSTANDBY"]/*' />
    [NativeTypeName("#define PBT_APMSTANDBY 0x0005")]
    public const int PBT_APMSTANDBY = 0x0005;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMRESUMECRITICAL"]/*' />
    [NativeTypeName("#define PBT_APMRESUMECRITICAL 0x0006")]
    public const int PBT_APMRESUMECRITICAL = 0x0006;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMRESUMESUSPEND"]/*' />
    [NativeTypeName("#define PBT_APMRESUMESUSPEND 0x0007")]
    public const int PBT_APMRESUMESUSPEND = 0x0007;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMRESUMESTANDBY"]/*' />
    [NativeTypeName("#define PBT_APMRESUMESTANDBY 0x0008")]
    public const int PBT_APMRESUMESTANDBY = 0x0008;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMBATTERYLOW"]/*' />
    [NativeTypeName("#define PBT_APMBATTERYLOW 0x0009")]
    public const int PBT_APMBATTERYLOW = 0x0009;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMPOWERSTATUSCHANGE"]/*' />
    [NativeTypeName("#define PBT_APMPOWERSTATUSCHANGE 0x000A")]
    public const int PBT_APMPOWERSTATUSCHANGE = 0x000A;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMOEMEVENT"]/*' />
    [NativeTypeName("#define PBT_APMOEMEVENT 0x000B")]
    public const int PBT_APMOEMEVENT = 0x000B;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_APMRESUMEAUTOMATIC"]/*' />
    [NativeTypeName("#define PBT_APMRESUMEAUTOMATIC 0x0012")]
    public const int PBT_APMRESUMEAUTOMATIC = 0x0012;

    /// <include file='PBT.xml' path='doc/member[@name="PBT.PBT_POWERSETTINGCHANGE"]/*' />
    [NativeTypeName("#define PBT_POWERSETTINGCHANGE 0x8013")]
    public const int PBT_POWERSETTINGCHANGE = 0x8013;
}
