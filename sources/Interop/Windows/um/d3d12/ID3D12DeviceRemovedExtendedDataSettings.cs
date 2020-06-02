// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("82BC481C-6B9B-4030-AEDB-7EE3D1DF1E63")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this));
        }

        public void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            lpVtbl->SetAutoBreadcrumbsEnablement((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
        }

        public void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            lpVtbl->SetPageFaultEnablement((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
        }

        public void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement)
        {
            lpVtbl->SetWatsonDumpEnablement((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, uint> Release;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void> SetAutoBreadcrumbsEnablement;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void> SetPageFaultEnablement;

            [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void> SetWatsonDumpEnablement;
        }
    }
}
