// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DXGI_INFO_QUEUE_FILTER_DESC
    {
        [NativeTypeName("UINT")]
        public uint NumCategories;

        public DXGI_INFO_QUEUE_MESSAGE_CATEGORY* pCategoryList;

        [NativeTypeName("UINT")]
        public uint NumSeverities;

        public DXGI_INFO_QUEUE_MESSAGE_SEVERITY* pSeverityList;

        [NativeTypeName("UINT")]
        public uint NumIDs;

        [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID *")]
        public int* pIDList;
    }
}
