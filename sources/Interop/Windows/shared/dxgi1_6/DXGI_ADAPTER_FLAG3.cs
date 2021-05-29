// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DXGI_ADAPTER_FLAG3 : uint
    {
        DXGI_ADAPTER_FLAG3_NONE = 0,
        DXGI_ADAPTER_FLAG3_REMOTE = 1,
        DXGI_ADAPTER_FLAG3_SOFTWARE = 2,
        DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE = 4,
        DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES = 8,
        DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES = 0x10,
        DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE = 0x20,
        DXGI_ADAPTER_FLAG3_FORCE_DWORD = 0xffffffff,
    }
}
