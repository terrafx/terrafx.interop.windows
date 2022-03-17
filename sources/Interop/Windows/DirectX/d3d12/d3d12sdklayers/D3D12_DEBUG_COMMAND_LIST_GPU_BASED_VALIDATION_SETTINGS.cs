// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS.xml' path='doc/member[@name="D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS"]/*' />
public partial struct D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS
{
    /// <include file='D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS.xml' path='doc/member[@name="D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS.ShaderPatchMode"]/*' />
    public D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE ShaderPatchMode;
}
