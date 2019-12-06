// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_GRAPHICS_STATES
    {
        D3D12_GRAPHICS_STATE_NONE = 0,
        D3D12_GRAPHICS_STATE_IA_VERTEX_BUFFERS = (1 << 0),
        D3D12_GRAPHICS_STATE_IA_INDEX_BUFFER = (1 << 1),
        D3D12_GRAPHICS_STATE_IA_PRIMITIVE_TOPOLOGY = (1 << 2),
        D3D12_GRAPHICS_STATE_DESCRIPTOR_HEAP = (1 << 3),
        D3D12_GRAPHICS_STATE_GRAPHICS_ROOT_SIGNATURE = (1 << 4),
        D3D12_GRAPHICS_STATE_COMPUTE_ROOT_SIGNATURE = (1 << 5),
        D3D12_GRAPHICS_STATE_RS_VIEWPORTS = (1 << 6),
        D3D12_GRAPHICS_STATE_RS_SCISSOR_RECTS = (1 << 7),
        D3D12_GRAPHICS_STATE_PREDICATION = (1 << 8),
        D3D12_GRAPHICS_STATE_OM_RENDER_TARGETS = (1 << 9),
        D3D12_GRAPHICS_STATE_OM_STENCIL_REF = (1 << 10),
        D3D12_GRAPHICS_STATE_OM_BLEND_FACTOR = (1 << 11),
        D3D12_GRAPHICS_STATE_PIPELINE_STATE = (1 << 12),
        D3D12_GRAPHICS_STATE_SO_TARGETS = (1 << 13),
        D3D12_GRAPHICS_STATE_OM_DEPTH_BOUNDS = (1 << 14),
        D3D12_GRAPHICS_STATE_SAMPLE_POSITIONS = (1 << 15),
        D3D12_GRAPHICS_STATE_VIEW_INSTANCE_MASK = (1 << 16),
    }
}
