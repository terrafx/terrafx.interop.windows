// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0ADF7D52-929C-4E61-ADDB-FFED30DE66EF")]
    public unsafe partial struct ID3D12SharingContract
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12SharingContract*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
        }

        public void Present([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("HWND")] IntPtr window)
        {
            lpVtbl->Present((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pResource, Subresource, window);
        }

        public void SharedFenceSignal([NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong FenceValue)
        {
            lpVtbl->SharedFenceSignal((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pFence, FenceValue);
        }

        public void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            lpVtbl->BeginCapturableWork((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
        }

        public void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            lpVtbl->EndCapturableWork((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SharingContract*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SharingContract*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SharingContract*, uint> Release;

            [NativeTypeName("void (ID3D12Resource *, UINT, HWND) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SharingContract*, ID3D12Resource*, uint, IntPtr, void> Present;

            [NativeTypeName("void (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SharingContract*, ID3D12Fence*, ulong, void> SharedFenceSignal;

            [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SharingContract*, Guid*, void> BeginCapturableWork;

            [NativeTypeName("void (const GUID &) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12SharingContract*, Guid*, void> EndCapturableWork;
        }
    }
}
