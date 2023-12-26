// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AdvancedColorKind.xml' path='doc/member[@name="AdvancedColorKind"]/*' />
public enum AdvancedColorKind
{
    /// <include file='AdvancedColorKind.xml' path='doc/member[@name="AdvancedColorKind.AdvancedColorKind_StandardDynamicRange"]/*' />
    AdvancedColorKind_StandardDynamicRange = 0,

    /// <include file='AdvancedColorKind.xml' path='doc/member[@name="AdvancedColorKind.AdvancedColorKind_WideColorGamut"]/*' />
    AdvancedColorKind_WideColorGamut = 1,

    /// <include file='AdvancedColorKind.xml' path='doc/member[@name="AdvancedColorKind.AdvancedColorKind_HighDynamicRange"]/*' />
    AdvancedColorKind_HighDynamicRange = 2,
}
