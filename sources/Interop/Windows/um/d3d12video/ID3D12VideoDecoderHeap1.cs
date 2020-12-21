// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DA1D98C5-539F-41B2-BF6B-1198A03B6D26")]
    [NativeTypeName("struct ID3D12VideoDecoderHeap1 : ID3D12VideoDecoderHeap")]
    public unsafe partial struct ID3D12VideoDecoderHeap1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, uint>)(lpVtbl[1]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, uint>)(lpVtbl[2]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, ushort*, int>)(lpVtbl[6]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D3D12_VIDEO_DECODER_HEAP_DESC GetDesc()
        {
            D3D12_VIDEO_DECODER_HEAP_DESC result;
            return *((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, D3D12_VIDEO_DECODER_HEAP_DESC*, D3D12_VIDEO_DECODER_HEAP_DESC*>)(lpVtbl[8]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppProtectedSession)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)(lpVtbl[9]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
        }
    }
}
