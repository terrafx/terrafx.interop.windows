// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageItemExtraProperties.xml' path='doc/member[@name="IStorageItemExtraProperties"]/*' />
[Guid("C54361B2-54CD-432B-BDBC-4B19C4B470D7")]
[NativeTypeName("struct IStorageItemExtraProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageItemExtraProperties : IStorageItemExtraProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageItemExtraProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemExtraProperties*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemExtraProperties*, uint>)(lpVtbl[1]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemExtraProperties*, uint>)(lpVtbl[2]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemExtraProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemExtraProperties*, HSTRING*, int>)(lpVtbl[4]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemExtraProperties*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageItemExtraProperties.xml' path='doc/member[@name="IStorageItemExtraProperties.RetrievePropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RetrievePropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMap_2_HSTRING_IInspectable_t **")] IAsyncOperation<Pointer<IMap<HSTRING, Pointer<IInspectable>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemExtraProperties*, IIterable<HSTRING>*, IAsyncOperation<Pointer<IMap<HSTRING, Pointer<IInspectable>>>>**, int>)(lpVtbl[6]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), propertiesToRetrieve, operation);
    }

    /// <include file='IStorageItemExtraProperties.xml' path='doc/member[@name="IStorageItemExtraProperties.SavePropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SavePropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_IInspectable_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IInspectable>>>>* propertiesToSave, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemExtraProperties*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IInspectable>>>>*, IAsyncAction**, int>)(lpVtbl[7]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), propertiesToSave, operation);
    }

    /// <include file='IStorageItemExtraProperties.xml' path='doc/member[@name="IStorageItemExtraProperties.SavePropertiesAsyncOverloadDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SavePropertiesAsyncOverloadDefault([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageItemExtraProperties*, IAsyncAction**, int>)(lpVtbl[8]))((IStorageItemExtraProperties*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RetrievePropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMap_2_HSTRING_IInspectable_t **")] IAsyncOperation<Pointer<IMap<HSTRING, Pointer<IInspectable>>>>** operation);

        [VtblIndex(7)]
        HRESULT SavePropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_IInspectable_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IInspectable>>>>* propertiesToSave, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);

        [VtblIndex(8)]
        HRESULT SavePropertiesAsyncOverloadDefault([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIMap_2_HSTRING_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IAsyncOperation<Pointer<IMap<HSTRING, Pointer<IInspectable>>>>**, int> RetrievePropertiesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_IInspectable_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IInspectable>>>>*, IAsyncAction**, int> SavePropertiesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> SavePropertiesAsyncOverloadDefault;
    }
}
