// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DBD5AE51-3317-4F0A-ADF9-1D7CEDCAAE0B")]
    [NativeTypeName("struct ID3D12DeviceRemovedExtendedDataSettings1 : ID3D12DeviceRemovedExtendedDataSettings")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, uint>)(lpVtbl[1]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, uint>)(lpVtbl[2]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[3]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[4]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[5]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetBreadcrumbContextEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[6]))((ID3D12DeviceRemovedExtendedDataSettings1*)Unsafe.AsPointer(ref this), Enablement);
        }
    }
}
