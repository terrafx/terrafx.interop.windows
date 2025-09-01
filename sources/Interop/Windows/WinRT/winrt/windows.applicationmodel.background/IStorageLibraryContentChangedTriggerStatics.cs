// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStorageLibraryContentChangedTriggerStatics.xml' path='doc/member[@name="IStorageLibraryContentChangedTriggerStatics"]/*' />
[Guid("7F9F1B39-5F90-4E12-914E-A7D8E0BBFB18")]
[NativeTypeName("struct IStorageLibraryContentChangedTriggerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageLibraryContentChangedTriggerStatics : IStorageLibraryContentChangedTriggerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStorageLibraryContentChangedTriggerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryContentChangedTriggerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerStatics*, uint>)(lpVtbl[1]))((IStorageLibraryContentChangedTriggerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerStatics*, uint>)(lpVtbl[2]))((IStorageLibraryContentChangedTriggerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryContentChangedTriggerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerStatics*, HSTRING*, int>)(lpVtbl[4]))((IStorageLibraryContentChangedTriggerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryContentChangedTriggerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStorageLibraryContentChangedTriggerStatics.xml' path='doc/member[@name="IStorageLibraryContentChangedTriggerStatics.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Storage::IStorageLibrary *")] IStorageLibrary* storageLibrary, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IStorageLibraryContentChangedTrigger **")] IStorageLibraryContentChangedTrigger** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerStatics*, IStorageLibrary*, IStorageLibraryContentChangedTrigger**, int>)(lpVtbl[6]))((IStorageLibraryContentChangedTriggerStatics*)Unsafe.AsPointer(ref this), storageLibrary, result);
    }

    /// <include file='IStorageLibraryContentChangedTriggerStatics.xml' path='doc/member[@name="IStorageLibraryContentChangedTriggerStatics.CreateFromLibraries"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromLibraries([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CStorageLibrary_t *")] IIterable<Pointer<IStorageLibrary>>* storageLibraries, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IStorageLibraryContentChangedTrigger **")] IStorageLibraryContentChangedTrigger** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IStorageLibraryContentChangedTriggerStatics*, IIterable<Pointer<IStorageLibrary>>*, IStorageLibraryContentChangedTrigger**, int>)(lpVtbl[7]))((IStorageLibraryContentChangedTriggerStatics*)Unsafe.AsPointer(ref this), storageLibraries, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Storage::IStorageLibrary *")] IStorageLibrary* storageLibrary, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IStorageLibraryContentChangedTrigger **")] IStorageLibraryContentChangedTrigger** result);

        [VtblIndex(7)]
        HRESULT CreateFromLibraries([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CStorageLibrary_t *")] IIterable<Pointer<IStorageLibrary>>* storageLibraries, [NativeTypeName("ABI::Windows::ApplicationModel::Background::IStorageLibraryContentChangedTrigger **")] IStorageLibraryContentChangedTrigger** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageLibrary *, ABI::Windows::ApplicationModel::Background::IStorageLibraryContentChangedTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageLibrary*, IStorageLibraryContentChangedTrigger**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CStorageLibrary_t *, ABI::Windows::ApplicationModel::Background::IStorageLibraryContentChangedTrigger **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IStorageLibrary>>*, IStorageLibraryContentChangedTrigger**, int> CreateFromLibraries;
    }
}
