// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PIPELINE_STATE_FLAGS.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_FLAGS"]/*' />
[Flags]
public enum D3D12_PIPELINE_STATE_FLAGS
{
    /// <include file='D3D12_PIPELINE_STATE_FLAGS.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_FLAGS.D3D12_PIPELINE_STATE_FLAG_NONE"]/*' />
    D3D12_PIPELINE_STATE_FLAG_NONE = 0,

    /// <include file='D3D12_PIPELINE_STATE_FLAGS.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_FLAGS.D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG"]/*' />
    D3D12_PIPELINE_STATE_FLAG_TOOL_DEBUG = 0x1,

    /// <include file='D3D12_PIPELINE_STATE_FLAGS.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_FLAGS.D3D12_PIPELINE_STATE_FLAG_DYNAMIC_DEPTH_BIAS"]/*' />
    D3D12_PIPELINE_STATE_FLAG_DYNAMIC_DEPTH_BIAS = 0x4,

    /// <include file='D3D12_PIPELINE_STATE_FLAGS.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_FLAGS.D3D12_PIPELINE_STATE_FLAG_DYNAMIC_INDEX_BUFFER_STRIP_CUT"]/*' />
    D3D12_PIPELINE_STATE_FLAG_DYNAMIC_INDEX_BUFFER_STRIP_CUT = 0x8,
}
