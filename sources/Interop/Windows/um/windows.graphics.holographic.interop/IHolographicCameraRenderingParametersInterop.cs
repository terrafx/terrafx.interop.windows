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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IHolographicCameraRenderingParametersInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IHolographicCameraRenderingParametersInterop*, uint>)(lpVtbl[1]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IHolographicCameraRenderingParametersInterop*, uint>)(lpVtbl[2]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* stdcall<IHolographicCameraRenderingParametersInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* stdcall<IHolographicCameraRenderingParametersInterop*, IntPtr*, int>)(lpVtbl[4]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), className);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* stdcall<IHolographicCameraRenderingParametersInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int CommitDirect3D12Resource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pColorResourceToCommit, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue)
        {
            return ((delegate* stdcall<IHolographicCameraRenderingParametersInterop*, ID3D12Resource*, ID3D12Fence*, ulong, int>)(lpVtbl[6]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), pColorResourceToCommit, pColorResourceFence, colorResourceFenceSignalValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CommitDirect3D12ResourceWithDepthData([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pColorResourceToCommit, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pDepthResourceToCommit, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pDepthResourceFence, [NativeTypeName("UINT64")] ulong depthResourceFenceSignalValue)
        {
            return ((delegate* stdcall<IHolographicCameraRenderingParametersInterop*, ID3D12Resource*, ID3D12Fence*, ulong, ID3D12Resource*, ID3D12Fence*, ulong, int>)(lpVtbl[7]))((IHolographicCameraRenderingParametersInterop*)Unsafe.AsPointer(ref this), pColorResourceToCommit, pColorResourceFence, colorResourceFenceSignalValue, pDepthResourceToCommit, pDepthResourceFence, depthResourceFenceSignalValue);
        }
    }
}
