// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("304FDB32-BEDE-410A-8545-943AC6A46138")]
    [NativeTypeName("struct ID3D12VideoProcessor : ID3D12Pageable")]
    public unsafe partial struct ID3D12VideoProcessor
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, uint>)(lpVtbl[1]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, uint>)(lpVtbl[2]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, ushort*, int>)(lpVtbl[6]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [return: NativeTypeName("UINT")]
        public uint GetNodeMask()
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, uint>)(lpVtbl[8]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInputStreamDescs()
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, uint>)(lpVtbl[9]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamDescs([NativeTypeName("UINT")] uint NumInputStreamDescs, [NativeTypeName("D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs)
        {
            return ((delegate* stdcall<ID3D12VideoProcessor*, uint, D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC*, int>)(lpVtbl[10]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this), NumInputStreamDescs, pInputStreamDescs);
        }

        public D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC GetOutputStreamDesc()
        {
            D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC result;
            return *((delegate* stdcall<ID3D12VideoProcessor*, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*, D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC*>)(lpVtbl[11]))((ID3D12VideoProcessor*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
