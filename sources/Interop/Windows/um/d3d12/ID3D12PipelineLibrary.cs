// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C64226A8-9201-46AF-B4CC-53FB9FF7414F")]
    [NativeTypeName("struct ID3D12PipelineLibrary : ID3D12DeviceChild")]
    public unsafe partial struct ID3D12PipelineLibrary
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, uint>)(lpVtbl[1]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, uint>)(lpVtbl[2]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, ushort*, int>)(lpVtbl[6]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StorePipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("ID3D12PipelineState *")] ID3D12PipelineState* pPipeline)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, ushort*, ID3D12PipelineState*, int>)(lpVtbl[8]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), pName, pPipeline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, ushort*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int>)(lpVtbl[9]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadComputePipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, ushort*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int>)(lpVtbl[10]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("SIZE_T")]
        public nuint GetSerializedSize()
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, nuint>)(lpVtbl[11]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Serialize([NativeTypeName("void *")] void* pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary*, void*, nuint, int>)(lpVtbl[12]))((ID3D12PipelineLibrary*)Unsafe.AsPointer(ref this), pData, DataSizeInBytes);
        }
    }
}
