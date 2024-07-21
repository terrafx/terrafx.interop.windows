// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionColorSpace.xml' path='doc/member[@name="CompositionColorSpace"]/*' />
public enum CompositionColorSpace
{
    /// <include file='CompositionColorSpace.xml' path='doc/member[@name="CompositionColorSpace.CompositionColorSpace_Auto"]/*' />
    CompositionColorSpace_Auto = 0,

    /// <include file='CompositionColorSpace.xml' path='doc/member[@name="CompositionColorSpace.CompositionColorSpace_Hsl"]/*' />
    CompositionColorSpace_Hsl = 1,

    /// <include file='CompositionColorSpace.xml' path='doc/member[@name="CompositionColorSpace.CompositionColorSpace_Rgb"]/*' />
    CompositionColorSpace_Rgb = 2,

    /// <include file='CompositionColorSpace.xml' path='doc/member[@name="CompositionColorSpace.CompositionColorSpace_HslLinear"]/*' />
    CompositionColorSpace_HslLinear = 3,

    /// <include file='CompositionColorSpace.xml' path='doc/member[@name="CompositionColorSpace.CompositionColorSpace_RgbLinear"]/*' />
    CompositionColorSpace_RgbLinear = 4,
}
