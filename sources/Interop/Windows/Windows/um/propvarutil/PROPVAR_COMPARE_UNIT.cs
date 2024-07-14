// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PROPVAR_COMPARE_UNIT.xml' path='doc/member[@name="PROPVAR_COMPARE_UNIT"]/*' />
public enum PROPVAR_COMPARE_UNIT
{
    /// <include file='PROPVAR_COMPARE_UNIT.xml' path='doc/member[@name="PROPVAR_COMPARE_UNIT.PVCU_DEFAULT"]/*' />
    PVCU_DEFAULT = 0,

    /// <include file='PROPVAR_COMPARE_UNIT.xml' path='doc/member[@name="PROPVAR_COMPARE_UNIT.PVCU_SECOND"]/*' />
    PVCU_SECOND = 1,

    /// <include file='PROPVAR_COMPARE_UNIT.xml' path='doc/member[@name="PROPVAR_COMPARE_UNIT.PVCU_MINUTE"]/*' />
    PVCU_MINUTE = 2,

    /// <include file='PROPVAR_COMPARE_UNIT.xml' path='doc/member[@name="PROPVAR_COMPARE_UNIT.PVCU_HOUR"]/*' />
    PVCU_HOUR = 3,

    /// <include file='PROPVAR_COMPARE_UNIT.xml' path='doc/member[@name="PROPVAR_COMPARE_UNIT.PVCU_DAY"]/*' />
    PVCU_DAY = 4,

    /// <include file='PROPVAR_COMPARE_UNIT.xml' path='doc/member[@name="PROPVAR_COMPARE_UNIT.PVCU_MONTH"]/*' />
    PVCU_MONTH = 5,

    /// <include file='PROPVAR_COMPARE_UNIT.xml' path='doc/member[@name="PROPVAR_COMPARE_UNIT.PVCU_YEAR"]/*' />
    PVCU_YEAR = 6,
}
