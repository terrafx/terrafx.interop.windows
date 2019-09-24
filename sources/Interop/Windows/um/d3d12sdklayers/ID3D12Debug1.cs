// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AFFAA4CA-63FE-4D8E-B8AD-159000AF4304")]
    public unsafe struct ID3D12Debug1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12Debug1* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12Debug1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12Debug1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _EnableDebugLayer(ID3D12Debug1* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetEnableGPUBasedValidation(ID3D12Debug1* This, [NativeTypeName("BOOL")] int Enable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetEnableSynchronizedCommandQueueValidation(ID3D12Debug1* This, [NativeTypeName("BOOL")] int Enable);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID3D12Debug1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12Debug1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12Debug1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void EnableDebugLayer()
        {
            fixed (ID3D12Debug1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_EnableDebugLayer>(lpVtbl->EnableDebugLayer)(This);
            }
        }

        public void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] int Enable)
        {
            fixed (ID3D12Debug1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetEnableGPUBasedValidation>(lpVtbl->SetEnableGPUBasedValidation)(This, Enable);
            }
        }

        public void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] int Enable)
        {
            fixed (ID3D12Debug1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetEnableSynchronizedCommandQueueValidation>(lpVtbl->SetEnableSynchronizedCommandQueueValidation)(This, Enable);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr EnableDebugLayer;

            public IntPtr SetEnableGPUBasedValidation;

            public IntPtr SetEnableSynchronizedCommandQueueValidation;
        }
    }
}
