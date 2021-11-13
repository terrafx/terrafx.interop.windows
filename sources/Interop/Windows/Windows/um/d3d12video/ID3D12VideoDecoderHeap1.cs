// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("DA1D98C5-539F-41B2-BF6B-1198A03B6D26")]
    [NativeTypeName("struct ID3D12VideoDecoderHeap1 : ID3D12VideoDecoderHeap")]
    [NativeInheritance("ID3D12VideoDecoderHeap")]
    public unsafe partial struct ID3D12VideoDecoderHeap1 : ID3D12VideoDecoderHeap1.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VideoDecoderHeap1*, uint>)(lpVtbl[1]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12VideoDecoderHeap1*, uint>)(lpVtbl[2]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12VideoDecoderHeap1*, ushort*, int>)(lpVtbl[6]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public D3D12_VIDEO_DECODER_HEAP_DESC GetDesc()
        {
            D3D12_VIDEO_DECODER_HEAP_DESC result;
            return *((delegate* unmanaged<ID3D12VideoDecoderHeap1*, D3D12_VIDEO_DECODER_HEAP_DESC*, D3D12_VIDEO_DECODER_HEAP_DESC*>)(lpVtbl[8]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession)
        {
            return ((delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, void**, int>)(lpVtbl[9]))((ID3D12VideoDecoderHeap1*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
        }

        public interface Interface : ID3D12VideoDecoderHeap.Interface
        {
            [VtblIndex(9)]
            HRESULT GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, void**, int> GetDevice;

            [NativeTypeName("D3D12_VIDEO_DECODER_HEAP_DESC () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, D3D12_VIDEO_DECODER_HEAP_DESC*, D3D12_VIDEO_DECODER_HEAP_DESC*> GetDesc;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12VideoDecoderHeap1*, Guid*, void**, int> GetProtectedResourceSession;
        }
    }
}
