// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE"]/*' />
public enum D3D12_META_COMMAND_PARAMETER_STAGE
{
    /// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE.D3D12_META_COMMAND_PARAMETER_STAGE_CREATION"]/*' />
    D3D12_META_COMMAND_PARAMETER_STAGE_CREATION = 0,

    /// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE.D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION"]/*' />
    D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION = 1,

    /// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE.D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION"]/*' />
    D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION = 2,
}
