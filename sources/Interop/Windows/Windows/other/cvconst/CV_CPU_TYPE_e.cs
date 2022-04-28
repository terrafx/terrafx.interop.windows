// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e"]/*' />
public enum CV_CPU_TYPE_e
{
    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_8080"]/*' />
    CV_CFL_8080 = 0x00,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_8086"]/*' />
    CV_CFL_8086 = 0x01,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_80286"]/*' />
    CV_CFL_80286 = 0x02,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_80386"]/*' />
    CV_CFL_80386 = 0x03,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_80486"]/*' />
    CV_CFL_80486 = 0x04,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PENTIUM"]/*' />
    CV_CFL_PENTIUM = 0x05,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PENTIUMII"]/*' />
    CV_CFL_PENTIUMII = 0x06,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PENTIUMPRO"]/*' />
    CV_CFL_PENTIUMPRO = CV_CFL_PENTIUMII,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PENTIUMIII"]/*' />
    CV_CFL_PENTIUMIII = 0x07,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPS"]/*' />
    CV_CFL_MIPS = 0x10,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPSR4000"]/*' />
    CV_CFL_MIPSR4000 = CV_CFL_MIPS,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPS16"]/*' />
    CV_CFL_MIPS16 = 0x11,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPS32"]/*' />
    CV_CFL_MIPS32 = 0x12,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPS64"]/*' />
    CV_CFL_MIPS64 = 0x13,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPSI"]/*' />
    CV_CFL_MIPSI = 0x14,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPSII"]/*' />
    CV_CFL_MIPSII = 0x15,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPSIII"]/*' />
    CV_CFL_MIPSIII = 0x16,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPSIV"]/*' />
    CV_CFL_MIPSIV = 0x17,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_MIPSV"]/*' />
    CV_CFL_MIPSV = 0x18,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_M68000"]/*' />
    CV_CFL_M68000 = 0x20,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_M68010"]/*' />
    CV_CFL_M68010 = 0x21,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_M68020"]/*' />
    CV_CFL_M68020 = 0x22,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_M68030"]/*' />
    CV_CFL_M68030 = 0x23,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_M68040"]/*' />
    CV_CFL_M68040 = 0x24,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ALPHA"]/*' />
    CV_CFL_ALPHA = 0x30,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ALPHA_21064"]/*' />
    CV_CFL_ALPHA_21064 = 0x30,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ALPHA_21164"]/*' />
    CV_CFL_ALPHA_21164 = 0x31,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ALPHA_21164A"]/*' />
    CV_CFL_ALPHA_21164A = 0x32,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ALPHA_21264"]/*' />
    CV_CFL_ALPHA_21264 = 0x33,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ALPHA_21364"]/*' />
    CV_CFL_ALPHA_21364 = 0x34,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PPC601"]/*' />
    CV_CFL_PPC601 = 0x40,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PPC603"]/*' />
    CV_CFL_PPC603 = 0x41,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PPC604"]/*' />
    CV_CFL_PPC604 = 0x42,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PPC620"]/*' />
    CV_CFL_PPC620 = 0x43,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PPCFP"]/*' />
    CV_CFL_PPCFP = 0x44,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_PPCBE"]/*' />
    CV_CFL_PPCBE = 0x45,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_SH3"]/*' />
    CV_CFL_SH3 = 0x50,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_SH3E"]/*' />
    CV_CFL_SH3E = 0x51,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_SH3DSP"]/*' />
    CV_CFL_SH3DSP = 0x52,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_SH4"]/*' />
    CV_CFL_SH4 = 0x53,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_SHMEDIA"]/*' />
    CV_CFL_SHMEDIA = 0x54,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM3"]/*' />
    CV_CFL_ARM3 = 0x60,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM4"]/*' />
    CV_CFL_ARM4 = 0x61,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM4T"]/*' />
    CV_CFL_ARM4T = 0x62,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM5"]/*' />
    CV_CFL_ARM5 = 0x63,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM5T"]/*' />
    CV_CFL_ARM5T = 0x64,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM6"]/*' />
    CV_CFL_ARM6 = 0x65,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM_XMAC"]/*' />
    CV_CFL_ARM_XMAC = 0x66,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM_WMMX"]/*' />
    CV_CFL_ARM_WMMX = 0x67,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM7"]/*' />
    CV_CFL_ARM7 = 0x68,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_OMNI"]/*' />
    CV_CFL_OMNI = 0x70,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_IA64"]/*' />
    CV_CFL_IA64 = 0x80,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_IA64_1"]/*' />
    CV_CFL_IA64_1 = 0x80,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_IA64_2"]/*' />
    CV_CFL_IA64_2 = 0x81,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_CEE"]/*' />
    CV_CFL_CEE = 0x90,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_AM33"]/*' />
    CV_CFL_AM33 = 0xA0,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_M32R"]/*' />
    CV_CFL_M32R = 0xB0,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_TRICORE"]/*' />
    CV_CFL_TRICORE = 0xC0,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_X64"]/*' />
    CV_CFL_X64 = 0xD0,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_AMD64"]/*' />
    CV_CFL_AMD64 = CV_CFL_X64,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_EBC"]/*' />
    CV_CFL_EBC = 0xE0,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_THUMB"]/*' />
    CV_CFL_THUMB = 0xF0,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARMNT"]/*' />
    CV_CFL_ARMNT = 0xF4,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM64"]/*' />
    CV_CFL_ARM64 = 0xF6,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_HYBRID_X86_ARM64"]/*' />
    CV_CFL_HYBRID_X86_ARM64 = 0xF7,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM64EC"]/*' />
    CV_CFL_ARM64EC = 0xF8,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_ARM64X"]/*' />
    CV_CFL_ARM64X = 0xF9,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_UNKNOWN"]/*' />
    CV_CFL_UNKNOWN = 0xFF,

    /// <include file='CV_CPU_TYPE_e.xml' path='doc/member[@name="CV_CPU_TYPE_e.CV_CFL_D3D11_SHADER"]/*' />
    CV_CFL_D3D11_SHADER = 0x100,
}
