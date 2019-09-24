// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C64226A8-9201-46AF-B4CC-53FB9FF7414F")]
    public unsafe struct ID3D12PipelineLibrary
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID3D12PipelineLibrary* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID3D12PipelineLibrary* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID3D12PipelineLibrary* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] ID3D12PipelineLibrary* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] ID3D12PipelineLibrary* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] ID3D12PipelineLibrary* This,
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In] IUnknown* pData = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetName(
            [In] ID3D12PipelineLibrary* This,
            [In, NativeTypeName("LPCWSTR")] char* Name
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDevice(
            [In] ID3D12PipelineLibrary* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvDevice = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _StorePipeline(
            [In] ID3D12PipelineLibrary* This,
            [In, Optional, NativeTypeName("LPCWSTR")] char* pName,
            [In] ID3D12PipelineState* pPipeline
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _LoadGraphicsPipeline(
            [In] ID3D12PipelineLibrary* This,
            [In, NativeTypeName("LPCWSTR")] char* pName,
            [In] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineState
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _LoadComputePipeline(
            [In] ID3D12PipelineLibrary* This,
            [In, NativeTypeName("LPCWSTR")] char* pName,
            [In] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineState
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("SIZE_T")]
        public /* static */ delegate UIntPtr _GetSerializedSize(
            [In] ID3D12PipelineLibrary* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Serialize(
            [In] ID3D12PipelineLibrary* This,
            [Out] void* pData,
            [In, NativeTypeName("SIZE_T")] UIntPtr DataSizeInBytes
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData = null
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(
                    This,
                    guid,
                    pDataSize,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData = null
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(
                    This,
                    guid,
                    DataSize,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface(
            [In, NativeTypeName("REFGUID")] Guid* guid,
            [In] IUnknown* pData = null
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(
                    This,
                    guid,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName(
            [In, NativeTypeName("LPCWSTR")] char* Name
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(
                    This,
                    Name
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvDevice = null
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(
                    This,
                    riid,
                    ppvDevice
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int StorePipeline(
            [In, Optional, NativeTypeName("LPCWSTR")] char* pName,
            [In] ID3D12PipelineState* pPipeline
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_StorePipeline>(lpVtbl->StorePipeline)(
                    This,
                    pName,
                    pPipeline
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadGraphicsPipeline(
            [In, NativeTypeName("LPCWSTR")] char* pName,
            [In] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineState
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadGraphicsPipeline>(lpVtbl->LoadGraphicsPipeline)(
                    This,
                    pName,
                    pDesc,
                    riid,
                    ppPipelineState
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadComputePipeline(
            [In, NativeTypeName("LPCWSTR")] char* pName,
            [In] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppPipelineState
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadComputePipeline>(lpVtbl->LoadComputePipeline)(
                    This,
                    pName,
                    pDesc,
                    riid,
                    ppPipelineState
                );
            }
        }

        [return: NativeTypeName("SIZE_T")]
        public UIntPtr GetSerializedSize()
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSerializedSize>(lpVtbl->GetSerializedSize)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Serialize(
            [Out] void* pData,
            [In, NativeTypeName("SIZE_T")] UIntPtr DataSizeInBytes
        )
        {
            fixed (ID3D12PipelineLibrary* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Serialize>(lpVtbl->Serialize)(
                    This,
                    pData,
                    DataSizeInBytes
                );
            }
        }

        public struct Vtbl
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
        }
    }
}
