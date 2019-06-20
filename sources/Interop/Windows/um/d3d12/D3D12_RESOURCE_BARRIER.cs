// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Utilities;
using static TerraFX.Interop.D3D12;
using static TerraFX.Interop.D3D12_RESOURCE_BARRIER_FLAGS;
using static TerraFX.Interop.D3D12_RESOURCE_BARRIER_TYPE;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct D3D12_RESOURCE_BARRIER
    {
        #region Fields
        public D3D12_RESOURCE_BARRIER_TYPE Type;

        public D3D12_RESOURCE_BARRIER_FLAGS Flags;

        public _Anonymous_e__Union Anonymous;
        #endregion

        #region Methods
        public static D3D12_RESOURCE_BARRIER InitTransition(ID3D12Resource* pResource, D3D12_RESOURCE_STATES stateBefore, D3D12_RESOURCE_STATES stateAfter, uint subresource = D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES, D3D12_RESOURCE_BARRIER_FLAGS flags = D3D12_RESOURCE_BARRIER_FLAG_NONE)
        {
            D3D12_RESOURCE_BARRIER result = default;
            result.Type = D3D12_RESOURCE_BARRIER_TYPE_TRANSITION;
            result.Flags = flags;
            result.Anonymous.Transition.pResource = pResource;
            result.Anonymous.Transition.StateBefore = stateBefore;
            result.Anonymous.Transition.StateAfter = stateAfter;
            result.Anonymous.Transition.Subresource = subresource;
            return result;
        }
        public static D3D12_RESOURCE_BARRIER InitAliasing(ID3D12Resource* pResourceBefore, ID3D12Resource* pResourceAfter)
        {
            D3D12_RESOURCE_BARRIER result = default;
            result.Type = D3D12_RESOURCE_BARRIER_TYPE_ALIASING;
            result.Anonymous.Aliasing.pResourceBefore = pResourceBefore;
            result.Anonymous.Aliasing.pResourceAfter = pResourceAfter;
            return result;
        }
        public static D3D12_RESOURCE_BARRIER InitUAV(ID3D12Resource* pResource)
        {
            D3D12_RESOURCE_BARRIER result = default;
            result.Type = D3D12_RESOURCE_BARRIER_TYPE_UAV;
            result.Anonymous.UAV.pResource = pResource;
            return result;
        }
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        [Unmanaged]
        public struct _Anonymous_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            public D3D12_RESOURCE_TRANSITION_BARRIER Transition;

            [FieldOffset(0)]
            public D3D12_RESOURCE_ALIASING_BARRIER Aliasing;

            [FieldOffset(0)]
            public D3D12_RESOURCE_UAV_BARRIER UAV;
            #endregion
        }
        #endregion
    }
}
