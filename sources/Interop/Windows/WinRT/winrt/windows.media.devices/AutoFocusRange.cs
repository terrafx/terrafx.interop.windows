// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AutoFocusRange.xml' path='doc/member[@name="AutoFocusRange"]/*' />
public enum AutoFocusRange
{
    /// <include file='AutoFocusRange.xml' path='doc/member[@name="AutoFocusRange.AutoFocusRange_FullRange"]/*' />
    AutoFocusRange_FullRange = 0,

    /// <include file='AutoFocusRange.xml' path='doc/member[@name="AutoFocusRange.AutoFocusRange_Macro"]/*' />
    AutoFocusRange_Macro = 1,

    /// <include file='AutoFocusRange.xml' path='doc/member[@name="AutoFocusRange.AutoFocusRange_Normal"]/*' />
    AutoFocusRange_Normal = 2,
}
