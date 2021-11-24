// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

[SupportedOSPlatform("windows8.0")]
public unsafe partial struct DXGI_INFO_QUEUE_FILTER_DESC
{
    public uint NumCategories;

    public DXGI_INFO_QUEUE_MESSAGE_CATEGORY* pCategoryList;

    public uint NumSeverities;

    public DXGI_INFO_QUEUE_MESSAGE_SEVERITY* pSeverityList;

    public uint NumIDs;

    [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID *")]
    public int* pIDList;
}
