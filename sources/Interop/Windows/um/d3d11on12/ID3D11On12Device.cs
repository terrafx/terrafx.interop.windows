// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("85611E73-70A9-490E-9614-A9E302777904")]
    public unsafe partial struct ID3D11On12Device
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11On12Device* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11On12Device* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11On12Device* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateWrappedResource(ID3D11On12Device* pThis, [NativeTypeName("IUnknown *")] IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppResource11);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ReleaseWrappedResources(ID3D11On12Device* pThis, [NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _AcquireWrappedResources(ID3D11On12Device* pThis, [NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11On12Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11On12Device*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11On12Device*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateWrappedResource([NativeTypeName("IUnknown *")] IUnknown* pResource12, [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppResource11)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateWrappedResource>(lpVtbl->CreateWrappedResource)((ID3D11On12Device*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
        }

        public void ReleaseWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseWrappedResources>(lpVtbl->ReleaseWrappedResources)((ID3D11On12Device*)Unsafe.AsPointer(ref this), ppResources, NumResources);
        }

        public void AcquireWrappedResources([NativeTypeName("ID3D11Resource *const *")] ID3D11Resource** ppResources, [NativeTypeName("UINT")] uint NumResources)
        {
            Marshal.GetDelegateForFunctionPointer<_AcquireWrappedResources>(lpVtbl->AcquireWrappedResources)((ID3D11On12Device*)Unsafe.AsPointer(ref this), ppResources, NumResources);
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
        }
    }
}
