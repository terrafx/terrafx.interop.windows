// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PROCESSOR
{
    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_INTEL_386"]/*' />
    [NativeTypeName("#define PROCESSOR_INTEL_386 386")]
    public const int PROCESSOR_INTEL_386 = 386;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_INTEL_486"]/*' />
    [NativeTypeName("#define PROCESSOR_INTEL_486 486")]
    public const int PROCESSOR_INTEL_486 = 486;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_INTEL_PENTIUM"]/*' />
    [NativeTypeName("#define PROCESSOR_INTEL_PENTIUM 586")]
    public const int PROCESSOR_INTEL_PENTIUM = 586;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_INTEL_IA64"]/*' />
    [NativeTypeName("#define PROCESSOR_INTEL_IA64 2200")]
    public const int PROCESSOR_INTEL_IA64 = 2200;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_AMD_X8664"]/*' />
    [NativeTypeName("#define PROCESSOR_AMD_X8664 8664")]
    public const int PROCESSOR_AMD_X8664 = 8664;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_MIPS_R4000"]/*' />
    [NativeTypeName("#define PROCESSOR_MIPS_R4000 4000")]
    public const int PROCESSOR_MIPS_R4000 = 4000;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ALPHA_21064"]/*' />
    [NativeTypeName("#define PROCESSOR_ALPHA_21064 21064")]
    public const int PROCESSOR_ALPHA_21064 = 21064;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PPC_601"]/*' />
    [NativeTypeName("#define PROCESSOR_PPC_601 601")]
    public const int PROCESSOR_PPC_601 = 601;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PPC_603"]/*' />
    [NativeTypeName("#define PROCESSOR_PPC_603 603")]
    public const int PROCESSOR_PPC_603 = 603;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PPC_604"]/*' />
    [NativeTypeName("#define PROCESSOR_PPC_604 604")]
    public const int PROCESSOR_PPC_604 = 604;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PPC_620"]/*' />
    [NativeTypeName("#define PROCESSOR_PPC_620 620")]
    public const int PROCESSOR_PPC_620 = 620;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_HITACHI_SH3"]/*' />
    [NativeTypeName("#define PROCESSOR_HITACHI_SH3 10003")]
    public const int PROCESSOR_HITACHI_SH3 = 10003;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_HITACHI_SH3E"]/*' />
    [NativeTypeName("#define PROCESSOR_HITACHI_SH3E 10004")]
    public const int PROCESSOR_HITACHI_SH3E = 10004;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_HITACHI_SH4"]/*' />
    [NativeTypeName("#define PROCESSOR_HITACHI_SH4 10005")]
    public const int PROCESSOR_HITACHI_SH4 = 10005;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_MOTOROLA_821"]/*' />
    [NativeTypeName("#define PROCESSOR_MOTOROLA_821 821")]
    public const int PROCESSOR_MOTOROLA_821 = 821;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_SHx_SH3"]/*' />
    [NativeTypeName("#define PROCESSOR_SHx_SH3 103")]
    public const int PROCESSOR_SHx_SH3 = 103;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_SHx_SH4"]/*' />
    [NativeTypeName("#define PROCESSOR_SHx_SH4 104")]
    public const int PROCESSOR_SHx_SH4 = 104;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_STRONGARM"]/*' />
    [NativeTypeName("#define PROCESSOR_STRONGARM 2577")]
    public const int PROCESSOR_STRONGARM = 2577;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARM720"]/*' />
    [NativeTypeName("#define PROCESSOR_ARM720 1824")]
    public const int PROCESSOR_ARM720 = 1824;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARM820"]/*' />
    [NativeTypeName("#define PROCESSOR_ARM820 2080")]
    public const int PROCESSOR_ARM820 = 2080;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARM920"]/*' />
    [NativeTypeName("#define PROCESSOR_ARM920 2336")]
    public const int PROCESSOR_ARM920 = 2336;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARM_7TDMI"]/*' />
    [NativeTypeName("#define PROCESSOR_ARM_7TDMI 70001")]
    public const int PROCESSOR_ARM_7TDMI = 70001;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_OPTIL"]/*' />
    [NativeTypeName("#define PROCESSOR_OPTIL 0x494f")]
    public const int PROCESSOR_OPTIL = 0x494f;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_INTEL"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_INTEL 0")]
    public const int PROCESSOR_ARCHITECTURE_INTEL = 0;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_MIPS"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_MIPS 1")]
    public const int PROCESSOR_ARCHITECTURE_MIPS = 1;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_ALPHA"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ALPHA 2")]
    public const int PROCESSOR_ARCHITECTURE_ALPHA = 2;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_PPC"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_PPC 3")]
    public const int PROCESSOR_ARCHITECTURE_PPC = 3;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_SHX"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_SHX 4")]
    public const int PROCESSOR_ARCHITECTURE_SHX = 4;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_ARM"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ARM 5")]
    public const int PROCESSOR_ARCHITECTURE_ARM = 5;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_IA64"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_IA64 6")]
    public const int PROCESSOR_ARCHITECTURE_IA64 = 6;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_ALPHA64"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ALPHA64 7")]
    public const int PROCESSOR_ARCHITECTURE_ALPHA64 = 7;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_MSIL"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_MSIL 8")]
    public const int PROCESSOR_ARCHITECTURE_MSIL = 8;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_AMD64"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_AMD64 9")]
    public const int PROCESSOR_ARCHITECTURE_AMD64 = 9;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_IA32_ON_WIN64"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 10")]
    public const int PROCESSOR_ARCHITECTURE_IA32_ON_WIN64 = 10;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_NEUTRAL"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_NEUTRAL 11")]
    public const int PROCESSOR_ARCHITECTURE_NEUTRAL = 11;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_ARM64"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ARM64 12")]
    public const int PROCESSOR_ARCHITECTURE_ARM64 = 12;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64 13")]
    public const int PROCESSOR_ARCHITECTURE_ARM32_ON_WIN64 = 13;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_IA32_ON_ARM64"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_IA32_ON_ARM64 14")]
    public const int PROCESSOR_ARCHITECTURE_IA32_ON_ARM64 = 14;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_ARCHITECTURE_UNKNOWN"]/*' />
    [NativeTypeName("#define PROCESSOR_ARCHITECTURE_UNKNOWN 0xFFFF")]
    public const int PROCESSOR_ARCHITECTURE_UNKNOWN = 0xFFFF;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_THROTTLE_DISABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_THROTTLE_DISABLED 0")]
    public const int PROCESSOR_THROTTLE_DISABLED = 0;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_THROTTLE_ENABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_THROTTLE_ENABLED 1")]
    public const int PROCESSOR_THROTTLE_ENABLED = 1;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_THROTTLE_AUTOMATIC"]/*' />
    [NativeTypeName("#define PROCESSOR_THROTTLE_AUTOMATIC 2")]
    public const int PROCESSOR_THROTTLE_AUTOMATIC = 2;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_POLICY_DISABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_POLICY_DISABLED 0")]
    public const int PROCESSOR_PERF_BOOST_POLICY_DISABLED = 0;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_POLICY_MAX"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_POLICY_MAX 100")]
    public const int PROCESSOR_PERF_BOOST_POLICY_MAX = 100;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_MODE_DISABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_DISABLED 0")]
    public const int PROCESSOR_PERF_BOOST_MODE_DISABLED = 0;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_MODE_ENABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_ENABLED 1")]
    public const int PROCESSOR_PERF_BOOST_MODE_ENABLED = 1;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE 2")]
    public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE = 2;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED 3")]
    public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_ENABLED = 3;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE 4")]
    public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE = 4;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED 5")]
    public const int PROCESSOR_PERF_BOOST_MODE_AGGRESSIVE_AT_GUARANTEED = 5;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED 6")]
    public const int PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED = 6;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_BOOST_MODE_MAX"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_BOOST_MODE_MAX PROCESSOR_PERF_BOOST_MODE_EFFICIENT_AGGRESSIVE_AT_GUARANTEED")]
    public const int PROCESSOR_PERF_BOOST_MODE_MAX = 6;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED 0")]
    public const int PROCESSOR_PERF_AUTONOMOUS_MODE_DISABLED = 0;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED 1")]
    public const int PROCESSOR_PERF_AUTONOMOUS_MODE_ENABLED = 1;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_PERFORMANCE_PREFERENCE"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_PERFORMANCE_PREFERENCE 0xff")]
    public const int PROCESSOR_PERF_PERFORMANCE_PREFERENCE = 0xff;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_ENERGY_PREFERENCE"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_ENERGY_PREFERENCE 0")]
    public const int PROCESSOR_PERF_ENERGY_PREFERENCE = 0;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW 0")]
    public const int PROCESSOR_PERF_MINIMUM_ACTIVITY_WINDOW = 0;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW"]/*' />
    [NativeTypeName("#define PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW 1270000000")]
    public const int PROCESSOR_PERF_MAXIMUM_ACTIVITY_WINDOW = 1270000000;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_DUTY_CYCLING_DISABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_DUTY_CYCLING_DISABLED 0")]
    public const int PROCESSOR_DUTY_CYCLING_DISABLED = 0;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_DUTY_CYCLING_ENABLED"]/*' />
    [NativeTypeName("#define PROCESSOR_DUTY_CYCLING_ENABLED 1")]
    public const int PROCESSOR_DUTY_CYCLING_ENABLED = 1;

    /// <include file='PROCESSOR.xml' path='doc/member[@name="PROCESSOR.PROCESSOR_IDLESTATE_POLICY_COUNT"]/*' />
    [NativeTypeName("#define PROCESSOR_IDLESTATE_POLICY_COUNT 0x3")]
    public const int PROCESSOR_IDLESTATE_POLICY_COUNT = 0x3;
}
