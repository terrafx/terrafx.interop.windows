// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_ADVANCED_COLOR_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_ADVANCED_COLOR_MODE"]/*' />
public enum DISPLAYCONFIG_ADVANCED_COLOR_MODE
{
    /// <include file='DISPLAYCONFIG_ADVANCED_COLOR_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_ADVANCED_COLOR_MODE.DISPLAYCONFIG_ADVANCED_COLOR_MODE_SDR"]/*' />
    DISPLAYCONFIG_ADVANCED_COLOR_MODE_SDR,

    /// <include file='DISPLAYCONFIG_ADVANCED_COLOR_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_ADVANCED_COLOR_MODE.DISPLAYCONFIG_ADVANCED_COLOR_MODE_WCG"]/*' />
    DISPLAYCONFIG_ADVANCED_COLOR_MODE_WCG,

    /// <include file='DISPLAYCONFIG_ADVANCED_COLOR_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_ADVANCED_COLOR_MODE.DISPLAYCONFIG_ADVANCED_COLOR_MODE_HDR"]/*' />
    DISPLAYCONFIG_ADVANCED_COLOR_MODE_HDR,
}
