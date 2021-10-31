// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F3CFE615-553F-425C-86D8-EE8C1B1FB01C")]
    [NativeTypeName("struct ID3D12VideoProcessor1 : ID3D12VideoProcessor")]
    [NativeInheritance("ID3D12VideoProcessor")]
    public unsafe partial struct ID3D12VideoProcessor1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, uint>)(lpVtbl[1]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, uint>)(lpVtbl[2]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, ushort*, int>)(lpVtbl[6]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public uint GetNodeMask()
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, uint>)(lpVtbl[8]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public uint GetNumInputStreamDescs()
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, uint>)(lpVtbl[9]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetInputStreamDescs(uint NumInputStreamDescs, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs)
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*, int>)(lpVtbl[10]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this), NumInputStreamDescs, pInputStreamDescs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC GetOutputStreamDesc()
        {
            D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC result;
            return *((delegate* unmanaged<ID3D12VideoProcessor1*, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*>)(lpVtbl[11]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession)
        {
            return ((delegate* unmanaged<ID3D12VideoProcessor1*, Guid*, void**, int>)(lpVtbl[12]))((ID3D12VideoProcessor1*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
        }
    }
}
