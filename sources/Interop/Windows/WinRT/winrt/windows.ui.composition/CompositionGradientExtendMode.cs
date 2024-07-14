// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionGradientExtendMode.xml' path='doc/member[@name="CompositionGradientExtendMode"]/*' />
public enum CompositionGradientExtendMode
{
    /// <include file='CompositionGradientExtendMode.xml' path='doc/member[@name="CompositionGradientExtendMode.CompositionGradientExtendMode_Clamp"]/*' />
    CompositionGradientExtendMode_Clamp = 0,

    /// <include file='CompositionGradientExtendMode.xml' path='doc/member[@name="CompositionGradientExtendMode.CompositionGradientExtendMode_Wrap"]/*' />
    CompositionGradientExtendMode_Wrap = 1,

    /// <include file='CompositionGradientExtendMode.xml' path='doc/member[@name="CompositionGradientExtendMode.CompositionGradientExtendMode_Mirror"]/*' />
    CompositionGradientExtendMode_Mirror = 2,
}
