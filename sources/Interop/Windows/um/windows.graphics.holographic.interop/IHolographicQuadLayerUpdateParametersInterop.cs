// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E5F549CD-C909-444F-8809-7CC18A9C8920")]
    [NativeTypeName("struct IHolographicQuadLayerUpdateParametersInterop : IInspectable")]
    public unsafe partial struct IHolographicQuadLayerUpdateParametersInterop
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IHolographicQuadLayerUpdateParametersInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IHolographicQuadLayerUpdateParametersInterop*, uint>)(lpVtbl[1]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IHolographicQuadLayerUpdateParametersInterop*, uint>)(lpVtbl[2]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* stdcall<IHolographicQuadLayerUpdateParametersInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* stdcall<IHolographicQuadLayerUpdateParametersInterop*, IntPtr*, int>)(lpVtbl[4]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), className);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* stdcall<IHolographicQuadLayerUpdateParametersInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [return: NativeTypeName("HRESULT")]
        public int CommitDirect3D12Resource([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pColorResourceToCommit, [NativeTypeName("ID3D12Fence *")] ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue)
        {
            return ((delegate* stdcall<IHolographicQuadLayerUpdateParametersInterop*, ID3D12Resource*, ID3D12Fence*, ulong, int>)(lpVtbl[6]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), pColorResourceToCommit, pColorResourceFence, colorResourceFenceSignalValue);
        }
    }
}
