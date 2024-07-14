// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionEasingFunctionMode.xml' path='doc/member[@name="CompositionEasingFunctionMode"]/*' />
public enum CompositionEasingFunctionMode
{
    /// <include file='CompositionEasingFunctionMode.xml' path='doc/member[@name="CompositionEasingFunctionMode.CompositionEasingFunctionMode_In"]/*' />
    CompositionEasingFunctionMode_In = 0,

    /// <include file='CompositionEasingFunctionMode.xml' path='doc/member[@name="CompositionEasingFunctionMode.CompositionEasingFunctionMode_Out"]/*' />
    CompositionEasingFunctionMode_Out = 1,

    /// <include file='CompositionEasingFunctionMode.xml' path='doc/member[@name="CompositionEasingFunctionMode.CompositionEasingFunctionMode_InOut"]/*' />
    CompositionEasingFunctionMode_InOut = 2,
}
