// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='ENERGY_SAVER_STATUS.xml' path='doc/member[@name="ENERGY_SAVER_STATUS"]/*' />
public enum ENERGY_SAVER_STATUS
{
    /// <include file='ENERGY_SAVER_STATUS.xml' path='doc/member[@name="ENERGY_SAVER_STATUS.ENERGY_SAVER_OFF"]/*' />
    ENERGY_SAVER_OFF = 0,

    /// <include file='ENERGY_SAVER_STATUS.xml' path='doc/member[@name="ENERGY_SAVER_STATUS.ENERGY_SAVER_STANDARD"]/*' />
    ENERGY_SAVER_STANDARD,

    /// <include file='ENERGY_SAVER_STATUS.xml' path='doc/member[@name="ENERGY_SAVER_STATUS.ENERGY_SAVER_HIGH_SAVINGS"]/*' />
    ENERGY_SAVER_HIGH_SAVINGS,
}
