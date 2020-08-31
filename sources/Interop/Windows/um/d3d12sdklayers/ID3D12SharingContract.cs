// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0ADF7D52-929C-4E61-ADDB-FFED30DE66EF")]
    [NativeTypeName("struct ID3D12SharingContract : IUnknown")]
    public unsafe partial struct ID3D12SharingContract
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12SharingContract*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12SharingContract*, uint>)(lpVtbl[1]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12SharingContract*, uint>)(lpVtbl[2]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Present([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("HWND")] IntPtr window)
        {
            ((delegate* stdcall<ID3D12SharingContract*, ID3D12Resource*, uint, IntPtr, void>)(lpVtbl[3]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pResource, Subresource, window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SharedFenceSignal([NativeTypeName("ID3D12Fence *")] ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong FenceValue)
        {
            ((delegate* stdcall<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)(lpVtbl[4]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pFence, FenceValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            ((delegate* stdcall<ID3D12SharingContract*, Guid*, void>)(lpVtbl[5]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            ((delegate* stdcall<ID3D12SharingContract*, Guid*, void>)(lpVtbl[6]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
        }
    }
}
