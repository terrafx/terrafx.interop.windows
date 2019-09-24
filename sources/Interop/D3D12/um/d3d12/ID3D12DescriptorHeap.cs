// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8EFB471D-616C-4F49-90F7-127BB763FA51")]
    public unsafe struct ID3D12DescriptorHeap
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12DescriptorHeap* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12DescriptorHeap* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12DescriptorHeap* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(ID3D12DescriptorHeap* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(ID3D12DescriptorHeap* This, [NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(ID3D12DescriptorHeap* This, [NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(ID3D12DescriptorHeap* This, [NativeTypeName("LPCWSTR")] ushort* Name);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(ID3D12DescriptorHeap* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_DESCRIPTOR_HEAP_DESC* _GetDesc(ID3D12DescriptorHeap* This, D3D12_DESCRIPTOR_HEAP_DESC* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_CPU_DESCRIPTOR_HANDLE* _GetCPUDescriptorHandleForHeapStart(ID3D12DescriptorHeap* This, D3D12_CPU_DESCRIPTOR_HANDLE* _result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_GPU_DESCRIPTOR_HANDLE* _GetGPUDescriptorHandleForHeapStart(ID3D12DescriptorHeap* This, D3D12_GPU_DESCRIPTOR_HANDLE* _result);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12DescriptorHeap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12DescriptorHeap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12DescriptorHeap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint* pDataSize, void* pData = null)
        {
            fixed (ID3D12DescriptorHeap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(This, guid, pDataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("REFGUID")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, void* pData = null)
        {
            fixed (ID3D12DescriptorHeap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(This, guid, DataSize, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("REFGUID")] Guid* guid, IUnknown* pData = null)
        {
            fixed (ID3D12DescriptorHeap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(This, guid, pData);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            fixed (ID3D12DescriptorHeap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)(This, Name);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("REFIID")] Guid* riid, void** ppvDevice = null)
        {
            fixed (ID3D12DescriptorHeap* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)(This, riid, ppvDevice);
            }
        }

        public D3D12_DESCRIPTOR_HEAP_DESC GetDesc()
        {
            fixed (ID3D12DescriptorHeap* This = &this)
            {
                D3D12_DESCRIPTOR_HEAP_DESC result;
                return *Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(This, &result);
            }
        }

        public D3D12_CPU_DESCRIPTOR_HANDLE GetCPUDescriptorHandleForHeapStart()
        {
            D3D12_CPU_DESCRIPTOR_HANDLE result;

            fixed (ID3D12DescriptorHeap* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetCPUDescriptorHandleForHeapStart>(lpVtbl->GetCPUDescriptorHandleForHeapStart)(This, &result);
            }

            return result;
        }

        public D3D12_GPU_DESCRIPTOR_HANDLE GetGPUDescriptorHandleForHeapStart()
        {
            D3D12_GPU_DESCRIPTOR_HANDLE result;

            fixed (ID3D12DescriptorHeap* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetGPUDescriptorHandleForHeapStart>(lpVtbl->GetGPUDescriptorHandleForHeapStart)(This, &result);
            }

            return result;
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

            public IntPtr GetDesc;

            public IntPtr GetCPUDescriptorHandleForHeapStart;

            public IntPtr GetGPUDescriptorHandleForHeapStart;
        }
    }
}