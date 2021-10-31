// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("67FC5816-E4CA-4915-BF18-42541272DA54")]
    [NativeTypeName("struct ID3D12DeviceRemovedExtendedData2 : ID3D12DeviceRemovedExtendedData1")]
    [NativeInheritance("ID3D12DeviceRemovedExtendedData1")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedData2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, uint>)(lpVtbl[1]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, uint>)(lpVtbl[2]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetAutoBreadcrumbsOutput(D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT*, int>)(lpVtbl[3]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPageFaultAllocationOutput(D3D12_DRED_PAGE_FAULT_OUTPUT* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, D3D12_DRED_PAGE_FAULT_OUTPUT*, int>)(lpVtbl[4]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetAutoBreadcrumbsOutput1(D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1*, int>)(lpVtbl[5]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPageFaultAllocationOutput1(D3D12_DRED_PAGE_FAULT_OUTPUT1* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, D3D12_DRED_PAGE_FAULT_OUTPUT1*, int>)(lpVtbl[6]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPageFaultAllocationOutput2(D3D12_DRED_PAGE_FAULT_OUTPUT2* pOutput)
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, D3D12_DRED_PAGE_FAULT_OUTPUT2*, int>)(lpVtbl[7]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public D3D12_DRED_DEVICE_STATE GetDeviceState()
        {
            return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, D3D12_DRED_DEVICE_STATE>)(lpVtbl[8]))((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this));
        }
    }
}
