// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D11On12On7.h in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ID3D11On12On7Device
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int AcquireResource([NativeTypeName("ID3D11On12On7Resource *")] void* pResource, D3D12_RESOURCE_STATES state)
        {
            return ((delegate* unmanaged<ID3D11On12On7Device*, void*, D3D12_RESOURCE_STATES, int>)(lpVtbl[0]))((ID3D11On12On7Device*)Unsafe.AsPointer(ref this), pResource, state);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseResource([NativeTypeName("ID3D11On12On7Resource *")] void* pResource, D3D12_RESOURCE_STATES state)
        {
            return ((delegate* unmanaged<ID3D11On12On7Device*, void*, D3D12_RESOURCE_STATES, int>)(lpVtbl[1]))((ID3D11On12On7Device*)Unsafe.AsPointer(ref this), pResource, state);
        }
    }
}
