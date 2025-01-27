// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Presentation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

/// <include file='CompositionFrameDisplayInstance.xml' path='doc/member[@name="CompositionFrameDisplayInstance"]/*' />
public partial struct CompositionFrameDisplayInstance
{
    /// <include file='CompositionFrameDisplayInstance.xml' path='doc/member[@name="CompositionFrameDisplayInstance.displayAdapterLUID"]/*' />
    public LUID displayAdapterLUID;

    /// <include file='CompositionFrameDisplayInstance.xml' path='doc/member[@name="CompositionFrameDisplayInstance.displayVidPnSourceId"]/*' />
    public uint displayVidPnSourceId;

    /// <include file='CompositionFrameDisplayInstance.xml' path='doc/member[@name="CompositionFrameDisplayInstance.displayUniqueId"]/*' />
    public uint displayUniqueId;

    /// <include file='CompositionFrameDisplayInstance.xml' path='doc/member[@name="CompositionFrameDisplayInstance.renderAdapterLUID"]/*' />
    public LUID renderAdapterLUID;

    /// <include file='CompositionFrameDisplayInstance.xml' path='doc/member[@name="CompositionFrameDisplayInstance.instanceKind"]/*' />
    public CompositionFrameInstanceKind instanceKind;

    /// <include file='CompositionFrameDisplayInstance.xml' path='doc/member[@name="CompositionFrameDisplayInstance.finalTransform"]/*' />
    public PresentationTransform finalTransform;

    /// <include file='CompositionFrameDisplayInstance.xml' path='doc/member[@name="CompositionFrameDisplayInstance.requiredCrossAdapterCopy"]/*' />
    [NativeTypeName("boolean")]
    public byte requiredCrossAdapterCopy;

    /// <include file='CompositionFrameDisplayInstance.xml' path='doc/member[@name="CompositionFrameDisplayInstance.colorSpace"]/*' />
    public DXGI_COLOR_SPACE_TYPE colorSpace;
}
