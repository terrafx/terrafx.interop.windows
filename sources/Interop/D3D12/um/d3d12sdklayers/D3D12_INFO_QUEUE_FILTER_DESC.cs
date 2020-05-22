// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_INFO_QUEUE_FILTER_DESC
    {
        [NativeTypeName("UINT")]
        public uint NumCategories;

        [NativeTypeName("D3D12_MESSAGE_CATEGORY *")]
        public D3D12_MESSAGE_CATEGORY* pCategoryList;

        [NativeTypeName("UINT")]
        public uint NumSeverities;

        [NativeTypeName("D3D12_MESSAGE_SEVERITY *")]
        public D3D12_MESSAGE_SEVERITY* pSeverityList;

        [NativeTypeName("UINT")]
        public uint NumIDs;

        [NativeTypeName("D3D12_MESSAGE_ID *")]
        public D3D12_MESSAGE_ID* pIDList;
    }
}
