// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AFFAA4CA-63FE-4D8E-B8AD-159000AF4304")]
    public unsafe partial struct ID3D12Debug1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12Debug1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12Debug1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12Debug1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _EnableDebugLayer(ID3D12Debug1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetEnableGPUBasedValidation(ID3D12Debug1* pThis, [NativeTypeName("BOOL")] int Enable);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _SetEnableSynchronizedCommandQueueValidation(ID3D12Debug1* pThis, [NativeTypeName("BOOL")] int Enable);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12Debug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12Debug1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12Debug1*)Unsafe.AsPointer(ref this));
        }

        public void EnableDebugLayer()
        {
            Marshal.GetDelegateForFunctionPointer<_EnableDebugLayer>(lpVtbl->EnableDebugLayer)((ID3D12Debug1*)Unsafe.AsPointer(ref this));
        }

        public void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] int Enable)
        {
            Marshal.GetDelegateForFunctionPointer<_SetEnableGPUBasedValidation>(lpVtbl->SetEnableGPUBasedValidation)((ID3D12Debug1*)Unsafe.AsPointer(ref this), Enable);
        }

        public void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] int Enable)
        {
            Marshal.GetDelegateForFunctionPointer<_SetEnableSynchronizedCommandQueueValidation>(lpVtbl->SetEnableSynchronizedCommandQueueValidation)((ID3D12Debug1*)Unsafe.AsPointer(ref this), Enable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr EnableDebugLayer;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public IntPtr SetEnableGPUBasedValidation;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public IntPtr SetEnableSynchronizedCommandQueueValidation;
        }
    }
}
