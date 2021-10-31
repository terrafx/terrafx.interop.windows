// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5EFB46D7-47C0-4B68-ACDA-DED47C90EC91")]
    [NativeTypeName("struct IStorageProviderBanners : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IStorageProviderBanners
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageProviderBanners*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageProviderBanners*, uint>)(lpVtbl[1]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageProviderBanners*, uint>)(lpVtbl[2]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetBanner([NativeTypeName("LPCWSTR")] ushort* providerIdentity, [NativeTypeName("LPCWSTR")] ushort* subscriptionId, [NativeTypeName("LPCWSTR")] ushort* contentId)
        {
            return ((delegate* unmanaged<IStorageProviderBanners*, ushort*, ushort*, ushort*, int>)(lpVtbl[3]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), providerIdentity, subscriptionId, contentId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ClearBanner([NativeTypeName("LPCWSTR")] ushort* providerIdentity, [NativeTypeName("LPCWSTR")] ushort* subscriptionId)
        {
            return ((delegate* unmanaged<IStorageProviderBanners*, ushort*, ushort*, int>)(lpVtbl[4]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), providerIdentity, subscriptionId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ClearAllBanners([NativeTypeName("LPCWSTR")] ushort* providerIdentity)
        {
            return ((delegate* unmanaged<IStorageProviderBanners*, ushort*, int>)(lpVtbl[5]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), providerIdentity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetBanner([NativeTypeName("LPCWSTR")] ushort* providerIdentity, [NativeTypeName("LPCWSTR")] ushort* subscriptionId, [NativeTypeName("LPWSTR *")] ushort** contentId)
        {
            return ((delegate* unmanaged<IStorageProviderBanners*, ushort*, ushort*, ushort**, int>)(lpVtbl[6]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), providerIdentity, subscriptionId, contentId);
        }
    }
}
