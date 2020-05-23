// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("98931D33-5AE8-4791-AA3C-1A73A2934E71")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedData
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12DeviceRemovedExtendedData* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12DeviceRemovedExtendedData* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12DeviceRemovedExtendedData* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAutoBreadcrumbsOutput(ID3D12DeviceRemovedExtendedData* pThis, [NativeTypeName("D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT *")] D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT* pOutput);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPageFaultAllocationOutput(ID3D12DeviceRemovedExtendedData* pThis, [NativeTypeName("D3D12_DRED_PAGE_FAULT_OUTPUT *")] D3D12_DRED_PAGE_FAULT_OUTPUT* pOutput);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAutoBreadcrumbsOutput([NativeTypeName("D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT *")] D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT* pOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAutoBreadcrumbsOutput>(lpVtbl->GetAutoBreadcrumbsOutput)((ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref this), pOutput);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPageFaultAllocationOutput([NativeTypeName("D3D12_DRED_PAGE_FAULT_OUTPUT *")] D3D12_DRED_PAGE_FAULT_OUTPUT* pOutput)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPageFaultAllocationOutput>(lpVtbl->GetPageFaultAllocationOutput)((ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref this), pOutput);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT *) __attribute__((stdcall))")]
            public IntPtr GetAutoBreadcrumbsOutput;

            [NativeTypeName("HRESULT (D3D12_DRED_PAGE_FAULT_OUTPUT *) __attribute__((stdcall))")]
            public IntPtr GetPageFaultAllocationOutput;
        }
    }
}
