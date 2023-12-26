// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CompositionBatchTypes.xml' path='doc/member[@name="CompositionBatchTypes"]/*' />
[NativeTypeName("unsigned int")]
public enum CompositionBatchTypes : uint
{
    /// <include file='CompositionBatchTypes.xml' path='doc/member[@name="CompositionBatchTypes.CompositionBatchTypes_None"]/*' />
    CompositionBatchTypes_None = 0,

    /// <include file='CompositionBatchTypes.xml' path='doc/member[@name="CompositionBatchTypes.CompositionBatchTypes_Animation"]/*' />
    CompositionBatchTypes_Animation = 0x1,

    /// <include file='CompositionBatchTypes.xml' path='doc/member[@name="CompositionBatchTypes.CompositionBatchTypes_Effect"]/*' />
    CompositionBatchTypes_Effect = 0x2,

    /// <include file='CompositionBatchTypes.xml' path='doc/member[@name="CompositionBatchTypes.CompositionBatchTypes_InfiniteAnimation"]/*' />
    CompositionBatchTypes_InfiniteAnimation = 0x4,

    /// <include file='CompositionBatchTypes.xml' path='doc/member[@name="CompositionBatchTypes.CompositionBatchTypes_AllAnimations"]/*' />
    CompositionBatchTypes_AllAnimations = 0x5,
}
