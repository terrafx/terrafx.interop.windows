// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='PROPVAR_COMPARE_FLAGS.xml' path='doc/member[@name="PROPVAR_COMPARE_FLAGS"]/*' />
[Flags]
public enum PROPVAR_COMPARE_FLAGS
{
    /// <include file='PROPVAR_COMPARE_FLAGS.xml' path='doc/member[@name="PROPVAR_COMPARE_FLAGS.PVCF_DEFAULT"]/*' />
    PVCF_DEFAULT = 0x00000000,

    /// <include file='PROPVAR_COMPARE_FLAGS.xml' path='doc/member[@name="PROPVAR_COMPARE_FLAGS.PVCF_TREATEMPTYASGREATERTHAN"]/*' />
    PVCF_TREATEMPTYASGREATERTHAN = 0x00000001,

    /// <include file='PROPVAR_COMPARE_FLAGS.xml' path='doc/member[@name="PROPVAR_COMPARE_FLAGS.PVCF_USESTRCMP"]/*' />
    PVCF_USESTRCMP = 0x00000002,

    /// <include file='PROPVAR_COMPARE_FLAGS.xml' path='doc/member[@name="PROPVAR_COMPARE_FLAGS.PVCF_USESTRCMPC"]/*' />
    PVCF_USESTRCMPC = 0x00000004,

    /// <include file='PROPVAR_COMPARE_FLAGS.xml' path='doc/member[@name="PROPVAR_COMPARE_FLAGS.PVCF_USESTRCMPI"]/*' />
    PVCF_USESTRCMPI = 0x00000008,

    /// <include file='PROPVAR_COMPARE_FLAGS.xml' path='doc/member[@name="PROPVAR_COMPARE_FLAGS.PVCF_USESTRCMPIC"]/*' />
    PVCF_USESTRCMPIC = 0x00000010,

    /// <include file='PROPVAR_COMPARE_FLAGS.xml' path='doc/member[@name="PROPVAR_COMPARE_FLAGS.PVCF_DIGITSASNUMBERS_CASESENSITIVE"]/*' />
    PVCF_DIGITSASNUMBERS_CASESENSITIVE = 0x00000020,
}
