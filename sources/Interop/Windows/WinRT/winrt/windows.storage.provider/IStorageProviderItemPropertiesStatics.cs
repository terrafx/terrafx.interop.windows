// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageProviderItemPropertiesStatics.xml' path='doc/member[@name="IStorageProviderItemPropertiesStatics"]/*' />
[Guid("2D2C1C97-2704-4729-8FA9-7E6B8E158C2F")]
[NativeTypeName("struct IStorageProviderItemPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderItemPropertiesStatics : IStorageProviderItemPropertiesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderItemPropertiesStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertiesStatics*, Guid*, void**, int>)(lpVtbl[0]))((IStorageProviderItemPropertiesStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertiesStatics*, uint>)(lpVtbl[1]))((IStorageProviderItemPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertiesStatics*, uint>)(lpVtbl[2]))((IStorageProviderItemPropertiesStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertiesStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageProviderItemPropertiesStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertiesStatics*, HSTRING*, int>)(lpVtbl[4]))((IStorageProviderItemPropertiesStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertiesStatics*, TrustLevel*, int>)(lpVtbl[5]))((IStorageProviderItemPropertiesStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageProviderItemPropertiesStatics.xml' path='doc/member[@name="IStorageProviderItemPropertiesStatics.SetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* item, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CProvider__CStorageProviderItemProperty_t *")] IIterable<IntPtr>* itemProperties, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageProviderItemPropertiesStatics*, IStorageItem*, IIterable<IntPtr>*, IAsyncAction**, int>)(lpVtbl[6]))((IStorageProviderItemPropertiesStatics*)Unsafe.AsPointer(ref this), item, itemProperties, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetAsync([NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem* item, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CProvider__CStorageProviderItemProperty_t *")] IIterable<IntPtr>* itemProperties, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CProvider__CStorageProviderItemProperty_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageItem*, IIterable<IntPtr>*, IAsyncAction**, int> SetAsync;
    }
}
