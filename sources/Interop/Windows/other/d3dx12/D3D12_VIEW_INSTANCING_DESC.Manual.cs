// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D12_VIEW_INSTANCING_FLAGS;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIEW_INSTANCING_DESC
    {
        public static readonly D3D12_VIEW_INSTANCING_DESC DEFAULT = new D3D12_VIEW_INSTANCING_DESC {
            ViewInstanceCount = 0,
            pViewInstanceLocations = null,
            Flags = D3D12_VIEW_INSTANCING_FLAG_NONE
        };

        public D3D12_VIEW_INSTANCING_DESC([NativeTypeName("UINT")] uint InViewInstanceCount, [NativeTypeName("const D3D12_VIEW_INSTANCE_LOCATION *")] D3D12_VIEW_INSTANCE_LOCATION* InViewInstanceLocations, D3D12_VIEW_INSTANCING_FLAGS InFlags)
        {
            ViewInstanceCount = InViewInstanceCount;
            pViewInstanceLocations = InViewInstanceLocations;
            Flags = InFlags;
        }
}
}
