// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionCompositeMode.xml' path='doc/member[@name="CompositionCompositeMode"]/*' />
public enum CompositionCompositeMode
{
    /// <include file='CompositionCompositeMode.xml' path='doc/member[@name="CompositionCompositeMode.CompositionCompositeMode_Inherit"]/*' />
    CompositionCompositeMode_Inherit = 0,

    /// <include file='CompositionCompositeMode.xml' path='doc/member[@name="CompositionCompositeMode.CompositionCompositeMode_SourceOver"]/*' />
    CompositionCompositeMode_SourceOver = 1,

    /// <include file='CompositionCompositeMode.xml' path='doc/member[@name="CompositionCompositeMode.CompositionCompositeMode_DestinationInvert"]/*' />
    CompositionCompositeMode_DestinationInvert = 2,

    /// <include file='CompositionCompositeMode.xml' path='doc/member[@name="CompositionCompositeMode.CompositionCompositeMode_MinBlend"]/*' />
    CompositionCompositeMode_MinBlend = 3,
}
