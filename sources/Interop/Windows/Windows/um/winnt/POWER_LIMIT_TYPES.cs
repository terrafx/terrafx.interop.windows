// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES"]/*' />
public enum POWER_LIMIT_TYPES
{
    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitContinuous"]/*' />
    PowerLimitContinuous = 0,

    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitType1"]/*' />
    PowerLimitType1 = PowerLimitContinuous,

    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitBurst"]/*' />
    PowerLimitBurst,

    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitType2"]/*' />
    PowerLimitType2 = PowerLimitBurst,

    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitRapid"]/*' />
    PowerLimitRapid,

    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitType3"]/*' />
    PowerLimitType3 = PowerLimitRapid,

    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitPreemptive"]/*' />
    PowerLimitPreemptive,

    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitType4"]/*' />
    PowerLimitType4 = PowerLimitPreemptive,

    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitPreemptiveOffset"]/*' />
    PowerLimitPreemptiveOffset,

    /// <include file='POWER_LIMIT_TYPES.xml' path='doc/member[@name="POWER_LIMIT_TYPES.PowerLimitTypeMax"]/*' />
    PowerLimitTypeMax,
}
