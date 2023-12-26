// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CoreInputViewOcclusionKind.xml' path='doc/member[@name="CoreInputViewOcclusionKind"]/*' />
public enum CoreInputViewOcclusionKind
{
    /// <include file='CoreInputViewOcclusionKind.xml' path='doc/member[@name="CoreInputViewOcclusionKind.CoreInputViewOcclusionKind_Docked"]/*' />
    CoreInputViewOcclusionKind_Docked = 0,

    /// <include file='CoreInputViewOcclusionKind.xml' path='doc/member[@name="CoreInputViewOcclusionKind.CoreInputViewOcclusionKind_Floating"]/*' />
    CoreInputViewOcclusionKind_Floating = 1,

    /// <include file='CoreInputViewOcclusionKind.xml' path='doc/member[@name="CoreInputViewOcclusionKind.CoreInputViewOcclusionKind_Overlay"]/*' />
    CoreInputViewOcclusionKind_Overlay = 2,
}
