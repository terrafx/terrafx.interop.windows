// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BDB64DF4-EA2F-4C70-B861-AAAB1258BB5D")]
    public unsafe partial struct ID3D11On12Device1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11On12Device1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11On12Device1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11On12Device1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateWrappedResource(ID3D11On12Device1* pThis, [NativeTypeName("IUnknown *")] IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, [NativeTypeName("D3D12_RESOURCE_STATES")] int InState, [NativeTypeName("D3D12_RESOURCE_STATES")] int OutState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppResource11);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseWrappedResources(ID3D11On12Device1* pThis, [NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _AcquireWrappedResources(ID3D11On12Device1* pThis, [NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetD3D12Device(ID3D11On12Device1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11On12Device1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11On12Device1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11On12Device1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateWrappedResource([NativeTypeName("IUnknown *")] IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, [NativeTypeName("D3D12_RESOURCE_STATES")] int InState, [NativeTypeName("D3D12_RESOURCE_STATES")] int OutState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppResource11)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateWrappedResource>(lpVtbl->CreateWrappedResource)((ID3D11On12Device1*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
        }

        public void ReleaseWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseWrappedResources>(lpVtbl->ReleaseWrappedResources)((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        public void AcquireWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            Marshal.GetDelegateForFunctionPointer<_AcquireWrappedResources>(lpVtbl->AcquireWrappedResources)((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetD3D12Device([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetD3D12Device>(lpVtbl->GetD3D12Device)((ID3D11On12Device1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IUnknown *, const D3D11_RESOURCE_FLAGS *, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr CreateWrappedResource;

            [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
            public IntPtr ReleaseWrappedResources;

            [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
            public IntPtr AcquireWrappedResources;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetD3D12Device;
        }
    }
}
