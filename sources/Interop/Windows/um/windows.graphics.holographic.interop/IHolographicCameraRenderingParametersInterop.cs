// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F75B68D6-D1FD-4707-AAFD-FA6F4C0E3BF4")]
    [NativeTypeName("struct IHolographicCameraRenderingParametersInterop : IInspectable")]
    public unsafe partial struct IHolographicCameraRenderingParametersInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHolographicCameraRenderingParametersInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHolographicCameraRenderingParametersInterop*, uint>)(lpVtbl[1]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHolographicCameraRenderingParametersInterop*, uint>)(lpVtbl[2]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IHolographicCameraRenderingParametersInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IHolographicCameraRenderingParametersInterop*, IntPtr*, int>)(lpVtbl[4]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IHolographicCameraRenderingParametersInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitDirect3D12Resource(ID3D12Resource* pColorResourceToCommit, ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue)
        {
            return ((delegate* unmanaged<IHolographicCameraRenderingParametersInterop*, ID3D12Resource*, ID3D12Fence*, ulong, int>)(lpVtbl[6]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), pColorResourceToCommit, pColorResourceFence, colorResourceFenceSignalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitDirect3D12ResourceWithDepthData(ID3D12Resource* pColorResourceToCommit, ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue, ID3D12Resource* pDepthResourceToCommit, ID3D12Fence* pDepthResourceFence, [NativeTypeName("UINT64")] ulong depthResourceFenceSignalValue)
        {
            return ((delegate* unmanaged<IHolographicCameraRenderingParametersInterop*, ID3D12Resource*, ID3D12Fence*, ulong, ID3D12Resource*, ID3D12Fence*, ulong, int>)(lpVtbl[7]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), pColorResourceToCommit, pColorResourceFence, colorResourceFenceSignalValue, pDepthResourceToCommit, pDepthResourceFence, depthResourceFenceSignalValue);
        }
    }
}
