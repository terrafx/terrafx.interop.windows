// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DPSHADERCAPS2_0.xml' path='doc/member[@name="D3DPSHADERCAPS2_0"]/*' />
public partial struct D3DPSHADERCAPS2_0
{
    /// <include file='D3DPSHADERCAPS2_0.xml' path='doc/member[@name="D3DPSHADERCAPS2_0.Caps"]/*' />
    [NativeTypeName("DWORD")]
    public uint Caps;

    /// <include file='D3DPSHADERCAPS2_0.xml' path='doc/member[@name="D3DPSHADERCAPS2_0.DynamicFlowControlDepth"]/*' />
    public int DynamicFlowControlDepth;

    /// <include file='D3DPSHADERCAPS2_0.xml' path='doc/member[@name="D3DPSHADERCAPS2_0.NumTemps"]/*' />
    public int NumTemps;

    /// <include file='D3DPSHADERCAPS2_0.xml' path='doc/member[@name="D3DPSHADERCAPS2_0.StaticFlowControlDepth"]/*' />
    public int StaticFlowControlDepth;

    /// <include file='D3DPSHADERCAPS2_0.xml' path='doc/member[@name="D3DPSHADERCAPS2_0.NumInstructionSlots"]/*' />
    public int NumInstructionSlots;
}
