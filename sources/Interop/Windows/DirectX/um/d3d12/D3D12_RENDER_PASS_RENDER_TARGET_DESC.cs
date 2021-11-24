// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public partial struct D3D12_RENDER_PASS_RENDER_TARGET_DESC
{
    public D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor;

    public D3D12_RENDER_PASS_BEGINNING_ACCESS BeginningAccess;

    public D3D12_RENDER_PASS_ENDING_ACCESS EndingAccess;
}
