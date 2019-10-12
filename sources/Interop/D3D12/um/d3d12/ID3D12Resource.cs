// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("696442BE-A72E-4059-BC79-5B5C98040FAD")]
    public unsafe partial struct ID3D12Resource
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12Resource* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12Resource* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12Resource* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12Resource* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12Resource* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12Resource* This, [NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12Resource* This, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12Resource* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Map(ID3D12Resource* This, [NativeTypeName("UINT")] uint Subresource, D3D12_RANGE* pReadRange = null, void** ppData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Unmap(ID3D12Resource* This, [NativeTypeName("UINT")] uint Subresource, D3D12_RANGE* pWrittenRange = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_RESOURCE_DESC* _GetDesc(ID3D12Resource* This, D3D12_RESOURCE_DESC* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public delegate ulong _GetGPUVirtualAddress(ID3D12Resource* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteToSubresource(ID3D12Resource* This, [NativeTypeName("UINT")] uint DstSubresource, [Optional] D3D12_BOX* pDstBox, void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReadFromSubresource(ID3D12Resource* This, void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("UINT")] uint SrcSubresource, D3D12_BOX* pSrcBox = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHeapProperties(ID3D12Resource* This, D3D12_HEAP_PROPERTIES* pHeapProperties = null, D3D12_HEAP_FLAGS* pHeapFlags = null);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, guid, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, guid, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, guid, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppvDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("UINT")] uint Subresource, D3D12_RANGE* pReadRange = null, void** ppData = null)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Map>(lpVtbl->Map)(This, Subresource, pReadRange, ppData);
            }
        }

        public void Unmap([NativeTypeName("UINT")] uint Subresource, D3D12_RANGE* pWrittenRange = null)
        {
            fixed (ID3D12Resource* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Unmap>(lpVtbl->Unmap)(This, Subresource, pWrittenRange);
            }
        }

        public D3D12_RESOURCE_DESC GetDesc()
        {
            D3D12_RESOURCE_DESC result;

            fixed (ID3D12Resource* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, &result);
            }

            return result;
        }

        [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong GetGPUVirtualAddress()
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGPUVirtualAddress>(lpVtbl->GetGPUVirtualAddress)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteToSubresource([NativeTypeName("UINT")] uint DstSubresource, [Optional] D3D12_BOX* pDstBox, void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_WriteToSubresource>(lpVtbl->WriteToSubresource)(This, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadFromSubresource(void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("UINT")] uint SrcSubresource, D3D12_BOX* pSrcBox = null)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReadFromSubresource>(lpVtbl->ReadFromSubresource)(This, pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHeapProperties(D3D12_HEAP_PROPERTIES* pHeapProperties = null, D3D12_HEAP_FLAGS* pHeapFlags = null)
        {
            fixed (ID3D12Resource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetHeapProperties>(lpVtbl->GetHeapProperties)(This, pHeapProperties, pHeapFlags);
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

            public IntPtr Map;

            public IntPtr Unmap;

            public IntPtr GetDesc;

            public IntPtr GetGPUVirtualAddress;

            public IntPtr WriteToSubresource;

            public IntPtr ReadFromSubresource;

            public IntPtr GetHeapProperties;
        }
    }
}
