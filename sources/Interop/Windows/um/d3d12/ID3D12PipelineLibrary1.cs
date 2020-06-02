// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("80EABF42-2568-4E5E-BD82-C37F86961DC3")]
    public unsafe partial struct ID3D12PipelineLibrary1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return lpVtbl->SetName((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return lpVtbl->GetDevice((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int StorePipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipeline)
        {
            return lpVtbl->StorePipeline((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pPipeline);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return lpVtbl->LoadGraphicsPipeline((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadComputePipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return lpVtbl->LoadComputePipeline((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetSerializedSize()
        {
            return lpVtbl->GetSerializedSize((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Serialize([NativeTypeName("void *")] void* pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes)
        {
            return lpVtbl->Serialize((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pData, DataSizeInBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return lpVtbl->LoadPipeline((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, Guid*, void**, int> GetDevice;

            [NativeTypeName("HRESULT (LPCWSTR, ID3D12PipelineState *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, ushort*, ID3D12PipelineState*, int> StorePipeline;

            [NativeTypeName("HRESULT (LPCWSTR, const D3D12_GRAPHICS_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, ushort*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int> LoadGraphicsPipeline;

            [NativeTypeName("HRESULT (LPCWSTR, const D3D12_COMPUTE_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, ushort*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int> LoadComputePipeline;

            [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, nuint> GetSerializedSize;

            [NativeTypeName("HRESULT (void *, SIZE_T) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, void*, nuint, int> Serialize;

            [NativeTypeName("HRESULT (LPCWSTR, const D3D12_PIPELINE_STATE_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12PipelineLibrary1*, ushort*, D3D12_PIPELINE_STATE_STREAM_DESC*, Guid*, void**, int> LoadPipeline;
        }
    }
}
