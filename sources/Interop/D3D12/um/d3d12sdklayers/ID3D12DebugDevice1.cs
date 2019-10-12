// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9B71770-D099-4A65-A698-3DEE10020F88")]
    public unsafe partial struct ID3D12DebugDevice1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12DebugDevice1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12DebugDevice1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12DebugDevice1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDebugParameter(ID3D12DebugDevice1* This, D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, [NativeTypeName("UINT")] uint DataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDebugParameter(ID3D12DebugDevice1* This, D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, [NativeTypeName("UINT")] uint DataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReportLiveDeviceObjects(ID3D12DebugDevice1* This, D3D12_RLDO_FLAGS Flags);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetDebugParameter>(lpVtbl->SetDebugParameter)(This, Type, pData, DataSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDebugParameter>(lpVtbl->GetDebugParameter)(This, Type, pData, DataSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags)
        {
            fixed (ID3D12DebugDevice1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReportLiveDeviceObjects>(lpVtbl->ReportLiveDeviceObjects)(This, Flags);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetDebugParameter;

            public IntPtr GetDebugParameter;

            public IntPtr ReportLiveDeviceObjects;
        }
    }
}
