// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SpatialAnchorExportPurpose.xml' path='doc/member[@name="SpatialAnchorExportPurpose"]/*' />
public enum SpatialAnchorExportPurpose
{
    /// <include file='SpatialAnchorExportPurpose.xml' path='doc/member[@name="SpatialAnchorExportPurpose.SpatialAnchorExportPurpose_Relocalization"]/*' />
    SpatialAnchorExportPurpose_Relocalization = 0,

    /// <include file='SpatialAnchorExportPurpose.xml' path='doc/member[@name="SpatialAnchorExportPurpose.SpatialAnchorExportPurpose_Sharing"]/*' />
    SpatialAnchorExportPurpose_Sharing = 1,
}
