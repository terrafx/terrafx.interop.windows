// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionDropShadowSourcePolicy.xml' path='doc/member[@name="CompositionDropShadowSourcePolicy"]/*' />
public enum CompositionDropShadowSourcePolicy
{
    /// <include file='CompositionDropShadowSourcePolicy.xml' path='doc/member[@name="CompositionDropShadowSourcePolicy.CompositionDropShadowSourcePolicy_Default"]/*' />
    CompositionDropShadowSourcePolicy_Default = 0,

    /// <include file='CompositionDropShadowSourcePolicy.xml' path='doc/member[@name="CompositionDropShadowSourcePolicy.CompositionDropShadowSourcePolicy_InheritFromVisualContent"]/*' />
    CompositionDropShadowSourcePolicy_InheritFromVisualContent = 1,
}
