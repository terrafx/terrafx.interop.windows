// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionStrokeLineJoin.xml' path='doc/member[@name="CompositionStrokeLineJoin"]/*' />
public enum CompositionStrokeLineJoin
{
    /// <include file='CompositionStrokeLineJoin.xml' path='doc/member[@name="CompositionStrokeLineJoin.CompositionStrokeLineJoin_Miter"]/*' />
    CompositionStrokeLineJoin_Miter = 0,

    /// <include file='CompositionStrokeLineJoin.xml' path='doc/member[@name="CompositionStrokeLineJoin.CompositionStrokeLineJoin_Bevel"]/*' />
    CompositionStrokeLineJoin_Bevel = 1,

    /// <include file='CompositionStrokeLineJoin.xml' path='doc/member[@name="CompositionStrokeLineJoin.CompositionStrokeLineJoin_Round"]/*' />
    CompositionStrokeLineJoin_Round = 2,

    /// <include file='CompositionStrokeLineJoin.xml' path='doc/member[@name="CompositionStrokeLineJoin.CompositionStrokeLineJoin_MiterOrBevel"]/*' />
    CompositionStrokeLineJoin_MiterOrBevel = 3,
}
