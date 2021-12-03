// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA1.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA1"]/*' />
public partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA1
{
    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA1.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA1.DeviceRemovedReason"]/*' />
    public HRESULT DeviceRemovedReason;

    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA1.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA1.AutoBreadcrumbsOutput"]/*' />
    public D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT AutoBreadcrumbsOutput;

    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA1.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA1.PageFaultOutput"]/*' />
    public D3D12_DRED_PAGE_FAULT_OUTPUT PageFaultOutput;
}
