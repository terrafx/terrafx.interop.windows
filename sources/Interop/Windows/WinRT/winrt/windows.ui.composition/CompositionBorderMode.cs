// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionBorderMode.xml' path='doc/member[@name="CompositionBorderMode"]/*' />
public enum CompositionBorderMode
{
    /// <include file='CompositionBorderMode.xml' path='doc/member[@name="CompositionBorderMode.CompositionBorderMode_Inherit"]/*' />
    CompositionBorderMode_Inherit = 0,

    /// <include file='CompositionBorderMode.xml' path='doc/member[@name="CompositionBorderMode.CompositionBorderMode_Soft"]/*' />
    CompositionBorderMode_Soft = 1,

    /// <include file='CompositionBorderMode.xml' path='doc/member[@name="CompositionBorderMode.CompositionBorderMode_Hard"]/*' />
    CompositionBorderMode_Hard = 2,
}
