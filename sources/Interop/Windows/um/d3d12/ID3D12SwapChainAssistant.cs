// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F1DF64B6-57FD-49CD-8807-C0EB88B45C8F")]
    [NativeTypeName("struct ID3D12SwapChainAssistant : IUnknown")]
    public unsafe partial struct ID3D12SwapChainAssistant
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant*, uint>)(lpVtbl[1]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant*, uint>)(lpVtbl[2]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LUID GetLUID()
        {
            LUID result;
            return *((delegate* unmanaged<ID3D12SwapChainAssistant*, LUID*, LUID*>)(lpVtbl[3]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSwapChainObject([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, int>)(lpVtbl[4]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentResourceAndCommandQueue([NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource, [NativeTypeName("const IID &")] Guid* riidQueue, void** ppvQueue)
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(lpVtbl[5]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riidResource, ppvResource, riidQueue, ppvQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertImplicitSync()
        {
            return ((delegate* unmanaged<ID3D12SwapChainAssistant*, int>)(lpVtbl[6]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
        }
    }
}
