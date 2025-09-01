// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker"]/*' />
[Guid("084F7799-F3FB-400A-99B1-7B4A772FD60D")]
[NativeTypeName("struct IFolderPicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFolderPicker : IFolderPicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFolderPicker);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, Guid*, void**, int>)(lpVtbl[0]))((IFolderPicker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, uint>)(lpVtbl[1]))((IFolderPicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, uint>)(lpVtbl[2]))((IFolderPicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, uint*, Guid**, int>)(lpVtbl[3]))((IFolderPicker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, HSTRING*, int>)(lpVtbl[4]))((IFolderPicker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, TrustLevel*, int>)(lpVtbl[5]))((IFolderPicker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.get_ViewMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ViewMode([NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode *")] PickerViewMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, PickerViewMode*, int>)(lpVtbl[6]))((IFolderPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.put_ViewMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ViewMode([NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode")] PickerViewMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, PickerViewMode, int>)(lpVtbl[7]))((IFolderPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.get_SettingsIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SettingsIdentifier(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, HSTRING*, int>)(lpVtbl[8]))((IFolderPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.put_SettingsIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SettingsIdentifier(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, HSTRING, int>)(lpVtbl[9]))((IFolderPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.get_SuggestedStartLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId *")] PickerLocationId* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, PickerLocationId*, int>)(lpVtbl[10]))((IFolderPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.put_SuggestedStartLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId")] PickerLocationId value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, PickerLocationId, int>)(lpVtbl[11]))((IFolderPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.get_CommitButtonText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CommitButtonText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, HSTRING*, int>)(lpVtbl[12]))((IFolderPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.put_CommitButtonText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CommitButtonText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, HSTRING, int>)(lpVtbl[13]))((IFolderPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.get_FileTypeFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_FileTypeFilter([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, IVector<HSTRING>**, int>)(lpVtbl[14]))((IFolderPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFolderPicker.xml' path='doc/member[@name="IFolderPicker.PickSingleFolderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT PickSingleFolderAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFolderPicker*, IAsyncOperation<Pointer<IStorageFolder>>**, int>)(lpVtbl[15]))((IFolderPicker*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ViewMode([NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode *")] PickerViewMode* value);

        [VtblIndex(7)]
        HRESULT put_ViewMode([NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode")] PickerViewMode value);

        [VtblIndex(8)]
        HRESULT get_SettingsIdentifier(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_SettingsIdentifier(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId *")] PickerLocationId* value);

        [VtblIndex(11)]
        HRESULT put_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId")] PickerLocationId value);

        [VtblIndex(12)]
        HRESULT get_CommitButtonText(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_CommitButtonText(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_FileTypeFilter([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(15)]
        HRESULT PickSingleFolderAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<Pointer<IStorageFolder>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Pickers::PickerViewMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PickerViewMode*, int> get_ViewMode;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Pickers::PickerViewMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PickerViewMode, int> put_ViewMode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SettingsIdentifier;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SettingsIdentifier;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Pickers::PickerLocationId *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PickerLocationId*, int> get_SuggestedStartLocation;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Pickers::PickerLocationId) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PickerLocationId, int> put_SuggestedStartLocation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CommitButtonText;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CommitButtonText;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_FileTypeFilter;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IStorageFolder>>**, int> PickSingleFolderAsync;
    }
}
