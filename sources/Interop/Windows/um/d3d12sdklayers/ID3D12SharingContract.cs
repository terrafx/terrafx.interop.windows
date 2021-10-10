// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0ADF7D52-929C-4E61-ADDB-FFED30DE66EF")]
    [NativeTypeName("struct ID3D12SharingContract : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D12SharingContract
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12SharingContract*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12SharingContract*, uint>)(lpVtbl[1]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12SharingContract*, uint>)(lpVtbl[2]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Present(ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("HWND")] IntPtr window)
        {
            ((delegate* unmanaged<ID3D12SharingContract*, ID3D12Resource*, uint, IntPtr, void>)(lpVtbl[3]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pResource, Subresource, window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SharedFenceSignal(ID3D12Fence* pFence, [NativeTypeName("UINT64")] ulong FenceValue)
        {
            ((delegate* unmanaged<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)(lpVtbl[4]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pFence, FenceValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void BeginCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            ((delegate* unmanaged<ID3D12SharingContract*, Guid*, void>)(lpVtbl[5]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void EndCapturableWork([NativeTypeName("const GUID &")] Guid* guid)
        {
            ((delegate* unmanaged<ID3D12SharingContract*, Guid*, void>)(lpVtbl[6]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
        }
    }
}
