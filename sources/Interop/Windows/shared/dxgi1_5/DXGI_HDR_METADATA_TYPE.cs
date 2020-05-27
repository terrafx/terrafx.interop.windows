// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DXGI_HDR_METADATA_TYPE
    {
        DXGI_HDR_METADATA_TYPE_NONE = 0,
        DXGI_HDR_METADATA_TYPE_HDR10 = 1,
        DXGI_HDR_METADATA_TYPE_HDR10PLUS = 2,
    }
}
