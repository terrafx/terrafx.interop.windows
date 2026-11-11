// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PF
{
    /// <include file='PF.xml' path='doc/member[@name="PF.PF_TEMPORAL_LEVEL_1"]/*' />
    [NativeTypeName("#define PF_TEMPORAL_LEVEL_1 _MM_HINT_T0")]
    public const int PF_TEMPORAL_LEVEL_1 = 1;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_TEMPORAL_LEVEL_2"]/*' />
    [NativeTypeName("#define PF_TEMPORAL_LEVEL_2 _MM_HINT_T1")]
    public const int PF_TEMPORAL_LEVEL_2 = 2;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_TEMPORAL_LEVEL_3"]/*' />
    [NativeTypeName("#define PF_TEMPORAL_LEVEL_3 _MM_HINT_T2")]
    public const int PF_TEMPORAL_LEVEL_3 = 3;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_NON_TEMPORAL_LEVEL_ALL"]/*' />
    [NativeTypeName("#define PF_NON_TEMPORAL_LEVEL_ALL _MM_HINT_NTA")]
    public const int PF_NON_TEMPORAL_LEVEL_ALL = 0;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_FLOATING_POINT_PRECISION_ERRATA"]/*' />
    [NativeTypeName("#define PF_FLOATING_POINT_PRECISION_ERRATA 0")]
    public const int PF_FLOATING_POINT_PRECISION_ERRATA = 0;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_FLOATING_POINT_EMULATED"]/*' />
    [NativeTypeName("#define PF_FLOATING_POINT_EMULATED 1")]
    public const int PF_FLOATING_POINT_EMULATED = 1;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_COMPARE_EXCHANGE_DOUBLE"]/*' />
    [NativeTypeName("#define PF_COMPARE_EXCHANGE_DOUBLE 2")]
    public const int PF_COMPARE_EXCHANGE_DOUBLE = 2;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_MMX_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_MMX_INSTRUCTIONS_AVAILABLE 3")]
    public const int PF_MMX_INSTRUCTIONS_AVAILABLE = 3;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_PPC_MOVEMEM_64BIT_OK"]/*' />
    [NativeTypeName("#define PF_PPC_MOVEMEM_64BIT_OK 4")]
    public const int PF_PPC_MOVEMEM_64BIT_OK = 4;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ALPHA_BYTE_INSTRUCTIONS"]/*' />
    [NativeTypeName("#define PF_ALPHA_BYTE_INSTRUCTIONS 5")]
    public const int PF_ALPHA_BYTE_INSTRUCTIONS = 5;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_XMMI_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_XMMI_INSTRUCTIONS_AVAILABLE 6")]
    public const int PF_XMMI_INSTRUCTIONS_AVAILABLE = 6;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_3DNOW_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_3DNOW_INSTRUCTIONS_AVAILABLE 7")]
    public const int PF_3DNOW_INSTRUCTIONS_AVAILABLE = 7;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_RDTSC_INSTRUCTION_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_RDTSC_INSTRUCTION_AVAILABLE 8")]
    public const int PF_RDTSC_INSTRUCTION_AVAILABLE = 8;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_PAE_ENABLED"]/*' />
    [NativeTypeName("#define PF_PAE_ENABLED 9")]
    public const int PF_PAE_ENABLED = 9;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_XMMI64_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_XMMI64_INSTRUCTIONS_AVAILABLE 10")]
    public const int PF_XMMI64_INSTRUCTIONS_AVAILABLE = 10;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_SSE_DAZ_MODE_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_SSE_DAZ_MODE_AVAILABLE 11")]
    public const int PF_SSE_DAZ_MODE_AVAILABLE = 11;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_NX_ENABLED"]/*' />
    [NativeTypeName("#define PF_NX_ENABLED 12")]
    public const int PF_NX_ENABLED = 12;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_SSE3_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_SSE3_INSTRUCTIONS_AVAILABLE 13")]
    public const int PF_SSE3_INSTRUCTIONS_AVAILABLE = 13;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_COMPARE_EXCHANGE128"]/*' />
    [NativeTypeName("#define PF_COMPARE_EXCHANGE128 14")]
    public const int PF_COMPARE_EXCHANGE128 = 14;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_COMPARE64_EXCHANGE128"]/*' />
    [NativeTypeName("#define PF_COMPARE64_EXCHANGE128 15")]
    public const int PF_COMPARE64_EXCHANGE128 = 15;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_CHANNELS_ENABLED"]/*' />
    [NativeTypeName("#define PF_CHANNELS_ENABLED 16")]
    public const int PF_CHANNELS_ENABLED = 16;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_XSAVE_ENABLED"]/*' />
    [NativeTypeName("#define PF_XSAVE_ENABLED 17")]
    public const int PF_XSAVE_ENABLED = 17;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_VFP_32_REGISTERS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_VFP_32_REGISTERS_AVAILABLE 18")]
    public const int PF_ARM_VFP_32_REGISTERS_AVAILABLE = 18;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_NEON_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_NEON_INSTRUCTIONS_AVAILABLE 19")]
    public const int PF_ARM_NEON_INSTRUCTIONS_AVAILABLE = 19;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_SECOND_LEVEL_ADDRESS_TRANSLATION"]/*' />
    [NativeTypeName("#define PF_SECOND_LEVEL_ADDRESS_TRANSLATION 20")]
    public const int PF_SECOND_LEVEL_ADDRESS_TRANSLATION = 20;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_VIRT_FIRMWARE_ENABLED"]/*' />
    [NativeTypeName("#define PF_VIRT_FIRMWARE_ENABLED 21")]
    public const int PF_VIRT_FIRMWARE_ENABLED = 21;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_RDWRFSGSBASE_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_RDWRFSGSBASE_AVAILABLE 22")]
    public const int PF_RDWRFSGSBASE_AVAILABLE = 22;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_FASTFAIL_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_FASTFAIL_AVAILABLE 23")]
    public const int PF_FASTFAIL_AVAILABLE = 23;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE 24")]
    public const int PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE = 24;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_64BIT_LOADSTORE_ATOMIC"]/*' />
    [NativeTypeName("#define PF_ARM_64BIT_LOADSTORE_ATOMIC 25")]
    public const int PF_ARM_64BIT_LOADSTORE_ATOMIC = 25;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_EXTERNAL_CACHE_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_EXTERNAL_CACHE_AVAILABLE 26")]
    public const int PF_ARM_EXTERNAL_CACHE_AVAILABLE = 26;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE 27")]
    public const int PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE = 27;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_RDRAND_INSTRUCTION_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_RDRAND_INSTRUCTION_AVAILABLE 28")]
    public const int PF_RDRAND_INSTRUCTION_AVAILABLE = 28;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V8_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V8_INSTRUCTIONS_AVAILABLE 29")]
    public const int PF_ARM_V8_INSTRUCTIONS_AVAILABLE = 29;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE 30")]
    public const int PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE = 30;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE 31")]
    public const int PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE = 31;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_RDTSCP_INSTRUCTION_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_RDTSCP_INSTRUCTION_AVAILABLE 32")]
    public const int PF_RDTSCP_INSTRUCTION_AVAILABLE = 32;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_RDPID_INSTRUCTION_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_RDPID_INSTRUCTION_AVAILABLE 33")]
    public const int PF_RDPID_INSTRUCTION_AVAILABLE = 33;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE 34")]
    public const int PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE = 34;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_MONITORX_INSTRUCTION_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_MONITORX_INSTRUCTION_AVAILABLE 35")]
    public const int PF_MONITORX_INSTRUCTION_AVAILABLE = 35;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_SSSE3_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_SSSE3_INSTRUCTIONS_AVAILABLE 36")]
    public const int PF_SSSE3_INSTRUCTIONS_AVAILABLE = 36;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_SSE4_1_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_SSE4_1_INSTRUCTIONS_AVAILABLE 37")]
    public const int PF_SSE4_1_INSTRUCTIONS_AVAILABLE = 37;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_SSE4_2_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_SSE4_2_INSTRUCTIONS_AVAILABLE 38")]
    public const int PF_SSE4_2_INSTRUCTIONS_AVAILABLE = 38;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_AVX_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_AVX_INSTRUCTIONS_AVAILABLE 39")]
    public const int PF_AVX_INSTRUCTIONS_AVAILABLE = 39;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_AVX2_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_AVX2_INSTRUCTIONS_AVAILABLE 40")]
    public const int PF_AVX2_INSTRUCTIONS_AVAILABLE = 40;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_AVX512F_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_AVX512F_INSTRUCTIONS_AVAILABLE 41")]
    public const int PF_AVX512F_INSTRUCTIONS_AVAILABLE = 41;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ERMS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ERMS_AVAILABLE 42")]
    public const int PF_ERMS_AVAILABLE = 42;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V82_DP_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V82_DP_INSTRUCTIONS_AVAILABLE 43")]
    public const int PF_ARM_V82_DP_INSTRUCTIONS_AVAILABLE = 43;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V83_JSCVT_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V83_JSCVT_INSTRUCTIONS_AVAILABLE 44")]
    public const int PF_ARM_V83_JSCVT_INSTRUCTIONS_AVAILABLE = 44;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V83_LRCPC_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V83_LRCPC_INSTRUCTIONS_AVAILABLE 45")]
    public const int PF_ARM_V83_LRCPC_INSTRUCTIONS_AVAILABLE = 45;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_INSTRUCTIONS_AVAILABLE 46")]
    public const int PF_ARM_SVE_INSTRUCTIONS_AVAILABLE = 46;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE2_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE2_INSTRUCTIONS_AVAILABLE 47")]
    public const int PF_ARM_SVE2_INSTRUCTIONS_AVAILABLE = 47;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE2_1_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE2_1_INSTRUCTIONS_AVAILABLE 48")]
    public const int PF_ARM_SVE2_1_INSTRUCTIONS_AVAILABLE = 48;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_AES_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_AES_INSTRUCTIONS_AVAILABLE 49")]
    public const int PF_ARM_SVE_AES_INSTRUCTIONS_AVAILABLE = 49;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_PMULL128_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_PMULL128_INSTRUCTIONS_AVAILABLE 50")]
    public const int PF_ARM_SVE_PMULL128_INSTRUCTIONS_AVAILABLE = 50;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_BITPERM_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_BITPERM_INSTRUCTIONS_AVAILABLE 51")]
    public const int PF_ARM_SVE_BITPERM_INSTRUCTIONS_AVAILABLE = 51;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_BF16_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_BF16_INSTRUCTIONS_AVAILABLE 52")]
    public const int PF_ARM_SVE_BF16_INSTRUCTIONS_AVAILABLE = 52;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_EBF16_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_EBF16_INSTRUCTIONS_AVAILABLE 53")]
    public const int PF_ARM_SVE_EBF16_INSTRUCTIONS_AVAILABLE = 53;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_B16B16_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_B16B16_INSTRUCTIONS_AVAILABLE 54")]
    public const int PF_ARM_SVE_B16B16_INSTRUCTIONS_AVAILABLE = 54;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_SHA3_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_SHA3_INSTRUCTIONS_AVAILABLE 55")]
    public const int PF_ARM_SVE_SHA3_INSTRUCTIONS_AVAILABLE = 55;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_SM4_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_SM4_INSTRUCTIONS_AVAILABLE 56")]
    public const int PF_ARM_SVE_SM4_INSTRUCTIONS_AVAILABLE = 56;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_I8MM_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_I8MM_INSTRUCTIONS_AVAILABLE 57")]
    public const int PF_ARM_SVE_I8MM_INSTRUCTIONS_AVAILABLE = 57;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_F32MM_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_F32MM_INSTRUCTIONS_AVAILABLE 58")]
    public const int PF_ARM_SVE_F32MM_INSTRUCTIONS_AVAILABLE = 58;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SVE_F64MM_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SVE_F64MM_INSTRUCTIONS_AVAILABLE 59")]
    public const int PF_ARM_SVE_F64MM_INSTRUCTIONS_AVAILABLE = 59;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_BMI2_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_BMI2_INSTRUCTIONS_AVAILABLE 60")]
    public const int PF_BMI2_INSTRUCTIONS_AVAILABLE = 60;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_MOVDIR64B_INSTRUCTION_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_MOVDIR64B_INSTRUCTION_AVAILABLE 61")]
    public const int PF_MOVDIR64B_INSTRUCTION_AVAILABLE = 61;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_LSE2_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_LSE2_AVAILABLE 62")]
    public const int PF_ARM_LSE2_AVAILABLE = 62;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_RESERVED_FEATURE"]/*' />
    [NativeTypeName("#define PF_RESERVED_FEATURE 63")]
    public const int PF_RESERVED_FEATURE = 63;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SHA3_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SHA3_INSTRUCTIONS_AVAILABLE 64")]
    public const int PF_ARM_SHA3_INSTRUCTIONS_AVAILABLE = 64;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SHA512_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SHA512_INSTRUCTIONS_AVAILABLE 65")]
    public const int PF_ARM_SHA512_INSTRUCTIONS_AVAILABLE = 65;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V82_I8MM_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V82_I8MM_INSTRUCTIONS_AVAILABLE 66")]
    public const int PF_ARM_V82_I8MM_INSTRUCTIONS_AVAILABLE = 66;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V82_FP16_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V82_FP16_INSTRUCTIONS_AVAILABLE 67")]
    public const int PF_ARM_V82_FP16_INSTRUCTIONS_AVAILABLE = 67;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V86_BF16_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V86_BF16_INSTRUCTIONS_AVAILABLE 68")]
    public const int PF_ARM_V86_BF16_INSTRUCTIONS_AVAILABLE = 68;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_V86_EBF16_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_V86_EBF16_INSTRUCTIONS_AVAILABLE 69")]
    public const int PF_ARM_V86_EBF16_INSTRUCTIONS_AVAILABLE = 69;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_INSTRUCTIONS_AVAILABLE 70")]
    public const int PF_ARM_SME_INSTRUCTIONS_AVAILABLE = 70;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME2_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME2_INSTRUCTIONS_AVAILABLE 71")]
    public const int PF_ARM_SME2_INSTRUCTIONS_AVAILABLE = 71;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME2_1_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME2_1_INSTRUCTIONS_AVAILABLE 72")]
    public const int PF_ARM_SME2_1_INSTRUCTIONS_AVAILABLE = 72;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME2_2_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME2_2_INSTRUCTIONS_AVAILABLE 73")]
    public const int PF_ARM_SME2_2_INSTRUCTIONS_AVAILABLE = 73;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_AES_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_AES_INSTRUCTIONS_AVAILABLE 74")]
    public const int PF_ARM_SME_AES_INSTRUCTIONS_AVAILABLE = 74;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_SBITPERM_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_SBITPERM_INSTRUCTIONS_AVAILABLE 75")]
    public const int PF_ARM_SME_SBITPERM_INSTRUCTIONS_AVAILABLE = 75;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_SF8MM4_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_SF8MM4_INSTRUCTIONS_AVAILABLE 76")]
    public const int PF_ARM_SME_SF8MM4_INSTRUCTIONS_AVAILABLE = 76;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_SF8MM8_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_SF8MM8_INSTRUCTIONS_AVAILABLE 77")]
    public const int PF_ARM_SME_SF8MM8_INSTRUCTIONS_AVAILABLE = 77;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_SF8DP2_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_SF8DP2_INSTRUCTIONS_AVAILABLE 78")]
    public const int PF_ARM_SME_SF8DP2_INSTRUCTIONS_AVAILABLE = 78;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_SF8DP4_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_SF8DP4_INSTRUCTIONS_AVAILABLE 79")]
    public const int PF_ARM_SME_SF8DP4_INSTRUCTIONS_AVAILABLE = 79;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_SF8FMA_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_SF8FMA_INSTRUCTIONS_AVAILABLE 80")]
    public const int PF_ARM_SME_SF8FMA_INSTRUCTIONS_AVAILABLE = 80;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_F8F32_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_F8F32_INSTRUCTIONS_AVAILABLE 81")]
    public const int PF_ARM_SME_F8F32_INSTRUCTIONS_AVAILABLE = 81;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_F8F16_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_F8F16_INSTRUCTIONS_AVAILABLE 82")]
    public const int PF_ARM_SME_F8F16_INSTRUCTIONS_AVAILABLE = 82;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_F16F16_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_F16F16_INSTRUCTIONS_AVAILABLE 83")]
    public const int PF_ARM_SME_F16F16_INSTRUCTIONS_AVAILABLE = 83;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_B16B16_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_B16B16_INSTRUCTIONS_AVAILABLE 84")]
    public const int PF_ARM_SME_B16B16_INSTRUCTIONS_AVAILABLE = 84;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_F64F64_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_F64F64_INSTRUCTIONS_AVAILABLE 85")]
    public const int PF_ARM_SME_F64F64_INSTRUCTIONS_AVAILABLE = 85;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_I16I64_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_I16I64_INSTRUCTIONS_AVAILABLE 86")]
    public const int PF_ARM_SME_I16I64_INSTRUCTIONS_AVAILABLE = 86;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_LUTv2_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_LUTv2_INSTRUCTIONS_AVAILABLE 87")]
    public const int PF_ARM_SME_LUTv2_INSTRUCTIONS_AVAILABLE = 87;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_SME_FA64_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_SME_FA64_INSTRUCTIONS_AVAILABLE 88")]
    public const int PF_ARM_SME_FA64_INSTRUCTIONS_AVAILABLE = 88;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_UMONITOR_INSTRUCTION_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_UMONITOR_INSTRUCTION_AVAILABLE 89")]
    public const int PF_UMONITOR_INSTRUCTION_AVAILABLE = 89;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_APX_F_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_APX_F_INSTRUCTIONS_AVAILABLE 90")]
    public const int PF_APX_F_INSTRUCTIONS_AVAILABLE = 90;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_FEAT_ECV_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_FEAT_ECV_INSTRUCTIONS_AVAILABLE 91")]
    public const int PF_ARM_FEAT_ECV_INSTRUCTIONS_AVAILABLE = 91;

    /// <include file='PF.xml' path='doc/member[@name="PF.PF_ARM_FEAT_ECV_POFF_INSTRUCTIONS_AVAILABLE"]/*' />
    [NativeTypeName("#define PF_ARM_FEAT_ECV_POFF_INSTRUCTIONS_AVAILABLE 92")]
    public const int PF_ARM_FEAT_ECV_POFF_INSTRUCTIONS_AVAILABLE = 92;
}
