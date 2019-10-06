// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("80EABF42-2568-4E5E-BD82-C37F86961DC3")]
    public unsafe partial struct ID3D12PipelineLibrary1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12PipelineLibrary1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12PipelineLibrary1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12PipelineLibrary1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12PipelineLibrary1* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12PipelineLibrary1* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12PipelineLibrary1* This, [NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12PipelineLibrary1* This, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12PipelineLibrary1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _StorePipeline(ID3D12PipelineLibrary1* This, [Optional, NativeTypeName("LPCWSTR")] ushort* pName, ID3D12PipelineState* pPipeline);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadGraphicsPipeline(ID3D12PipelineLibrary1* This, [NativeTypeName("LPCWSTR")] ushort* pName, D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadComputePipeline(ID3D12PipelineLibrary1* This, [NativeTypeName("LPCWSTR")] ushort* pName, D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("SIZE_T")]
        public delegate UIntPtr _GetSerializedSize(ID3D12PipelineLibrary1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Serialize(ID3D12PipelineLibrary1* This, void* pData, [NativeTypeName("SIZE_T")] UIntPtr DataSizeInBytes);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadPipeline(ID3D12PipelineLibrary1* This, [NativeTypeName("LPCWSTR")] ushort* pName, D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, guid, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, guid, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, guid, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppvDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int StorePipeline([Optional, NativeTypeName("LPCWSTR")] ushort* pName, ID3D12PipelineState* pPipeline)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_StorePipeline>(lpVtbl->StorePipeline)(This, pName, pPipeline);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] ushort* pName, D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadGraphicsPipeline>(lpVtbl->LoadGraphicsPipeline)(This, pName, pDesc, riid, ppPipelineState);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadComputePipeline([NativeTypeName("LPCWSTR")] ushort* pName, D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadComputePipeline>(lpVtbl->LoadComputePipeline)(This, pName, pDesc, riid, ppPipelineState);
            }
        }

        [return: NativeTypeName("SIZE_T")]
        public UIntPtr GetSerializedSize()
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSerializedSize>(lpVtbl->GetSerializedSize)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Serialize(void* pData, [NativeTypeName("SIZE_T")] UIntPtr DataSizeInBytes)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Serialize>(lpVtbl->Serialize)(This, pData, DataSizeInBytes);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadPipeline([NativeTypeName("LPCWSTR")] ushort* pName, D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("REFIID")] Guid* riid, void** ppPipelineState)
        {
            fixed (ID3D12PipelineLibrary1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadPipeline>(lpVtbl->LoadPipeline)(This, pName, pDesc, riid, ppPipelineState);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetPrivateData;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr SetName;

            public IntPtr GetDevice;

            public IntPtr StorePipeline;

            public IntPtr LoadGraphicsPipeline;

            public IntPtr LoadComputePipeline;

            public IntPtr GetSerializedSize;

            public IntPtr Serialize;

            public IntPtr LoadPipeline;
        }
    }
}
