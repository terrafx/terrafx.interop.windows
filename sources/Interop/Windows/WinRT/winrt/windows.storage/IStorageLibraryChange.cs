// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageLibraryChange.xml' path='doc/member[@name="IStorageLibraryChange"]/*' />
[Guid("00980B23-2BE2-4909-AA48-159F5203A51E")]
[NativeTypeName("struct IStorageLibraryChange : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageLibraryChange : IStorageLibraryChange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageLibraryChange));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, uint>)(lpVtbl[1]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, uint>)(lpVtbl[2]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, HSTRING*, int>)(lpVtbl[4]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageLibraryChange.xml' path='doc/member[@name="IStorageLibraryChange.get_ChangeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChangeType([NativeTypeName("ABI::Windows::Storage::StorageLibraryChangeType *")] StorageLibraryChangeType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, StorageLibraryChangeType*, int>)(lpVtbl[6]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageLibraryChange.xml' path='doc/member[@name="IStorageLibraryChange.get_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Path(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, HSTRING*, int>)(lpVtbl[7]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageLibraryChange.xml' path='doc/member[@name="IStorageLibraryChange.get_PreviousPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PreviousPath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, HSTRING*, int>)(lpVtbl[8]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStorageLibraryChange.xml' path='doc/member[@name="IStorageLibraryChange.IsOfType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsOfType([NativeTypeName("ABI::Windows::Storage::StorageItemTypes")] StorageItemTypes type, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, StorageItemTypes, byte*, int>)(lpVtbl[9]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), type, value);
    }

    /// <include file='IStorageLibraryChange.xml' path='doc/member[@name="IStorageLibraryChange.GetStorageItemAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetStorageItemAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<Pointer<IStorageItem>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryChange*, IAsyncOperation<Pointer<IStorageItem>>**, int>)(lpVtbl[10]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChangeType([NativeTypeName("ABI::Windows::Storage::StorageLibraryChangeType *")] StorageLibraryChangeType* value);

        [VtblIndex(7)]
        HRESULT get_Path(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_PreviousPath(HSTRING* value);

        [VtblIndex(9)]
        HRESULT IsOfType([NativeTypeName("ABI::Windows::Storage::StorageItemTypes")] StorageItemTypes type, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT GetStorageItemAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<Pointer<IStorageItem>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::StorageLibraryChangeType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageLibraryChangeType*, int> get_ChangeType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Path;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PreviousPath;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::StorageItemTypes, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, StorageItemTypes, byte*, int> IsOfType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IStorageItem>>**, int> GetStorageItemAsync;
    }
}
