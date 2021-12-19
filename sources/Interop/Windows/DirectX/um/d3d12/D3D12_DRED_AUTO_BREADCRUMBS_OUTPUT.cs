// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT"]/*' />
public unsafe partial struct D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT
{
    /// <include file='D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT.pHeadAutoBreadcrumbNode"]/*' />
    [NativeTypeName("const D3D12_AUTO_BREADCRUMB_NODE *")]
    public D3D12_AUTO_BREADCRUMB_NODE* pHeadAutoBreadcrumbNode;
}
