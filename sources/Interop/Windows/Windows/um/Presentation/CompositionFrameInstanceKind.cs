// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CompositionFrameInstanceKind.xml' path='doc/member[@name="CompositionFrameInstanceKind"]/*' />
public enum CompositionFrameInstanceKind
{
    /// <include file='CompositionFrameInstanceKind.xml' path='doc/member[@name="CompositionFrameInstanceKind.CompositionFrameInstanceKind_ComposedOnScreen"]/*' />
    CompositionFrameInstanceKind_ComposedOnScreen = 0,

    /// <include file='CompositionFrameInstanceKind.xml' path='doc/member[@name="CompositionFrameInstanceKind.CompositionFrameInstanceKind_ScanoutOnScreen"]/*' />
    CompositionFrameInstanceKind_ScanoutOnScreen = 1,

    /// <include file='CompositionFrameInstanceKind.xml' path='doc/member[@name="CompositionFrameInstanceKind.CompositionFrameInstanceKind_ComposedToIntermediate"]/*' />
    CompositionFrameInstanceKind_ComposedToIntermediate = 2,
}
