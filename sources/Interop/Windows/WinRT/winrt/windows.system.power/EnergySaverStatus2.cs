// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EnergySaverStatus2.xml' path='doc/member[@name="EnergySaverStatus2"]/*' />
public enum EnergySaverStatus2
{
    /// <include file='EnergySaverStatus2.xml' path='doc/member[@name="EnergySaverStatus2.EnergySaverStatus2_Unknown"]/*' />
    EnergySaverStatus2_Unknown = 0,

    /// <include file='EnergySaverStatus2.xml' path='doc/member[@name="EnergySaverStatus2.EnergySaverStatus2_Off"]/*' />
    EnergySaverStatus2_Off = 1,

    /// <include file='EnergySaverStatus2.xml' path='doc/member[@name="EnergySaverStatus2.EnergySaverStatus2_Standard"]/*' />
    EnergySaverStatus2_Standard = 2,

    /// <include file='EnergySaverStatus2.xml' path='doc/member[@name="EnergySaverStatus2.EnergySaverStatus2_HighSavings"]/*' />
    EnergySaverStatus2_HighSavings = 3,
}
