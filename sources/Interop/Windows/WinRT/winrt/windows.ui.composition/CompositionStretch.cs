// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionStretch.xml' path='doc/member[@name="CompositionStretch"]/*' />
public enum CompositionStretch
{
    /// <include file='CompositionStretch.xml' path='doc/member[@name="CompositionStretch.CompositionStretch_None"]/*' />
    CompositionStretch_None = 0,

    /// <include file='CompositionStretch.xml' path='doc/member[@name="CompositionStretch.CompositionStretch_Fill"]/*' />
    CompositionStretch_Fill = 1,

    /// <include file='CompositionStretch.xml' path='doc/member[@name="CompositionStretch.CompositionStretch_Uniform"]/*' />
    CompositionStretch_Uniform = 2,

    /// <include file='CompositionStretch.xml' path='doc/member[@name="CompositionStretch.CompositionStretch_UniformToFill"]/*' />
    CompositionStretch_UniformToFill = 3,
}
