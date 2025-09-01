// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker"]/*' />
[Guid("2CA8278A-12C5-4C5F-8977-94547793C241")]
[NativeTypeName("struct IFileOpenPicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileOpenPicker : IFileOpenPicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFileOpenPicker);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, Guid*, void**, int>)(lpVtbl[0]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, uint>)(lpVtbl[1]))((IFileOpenPicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, uint>)(lpVtbl[2]))((IFileOpenPicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, uint*, Guid**, int>)(lpVtbl[3]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, HSTRING*, int>)(lpVtbl[4]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, TrustLevel*, int>)(lpVtbl[5]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.get_ViewMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ViewMode([NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode *")] PickerViewMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, PickerViewMode*, int>)(lpVtbl[6]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.put_ViewMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ViewMode([NativeTypeName("ABI::Windows::Storage::Pickers::PickerViewMode")] PickerViewMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, PickerViewMode, int>)(lpVtbl[7]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.get_SettingsIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SettingsIdentifier(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, HSTRING*, int>)(lpVtbl[8]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.put_SettingsIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SettingsIdentifier(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, HSTRING, int>)(lpVtbl[9]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.get_SuggestedStartLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId *")] PickerLocationId* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, PickerLocationId*, int>)(lpVtbl[10]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.put_SuggestedStartLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId")] PickerLocationId value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, PickerLocationId, int>)(lpVtbl[11]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.get_CommitButtonText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CommitButtonText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, HSTRING*, int>)(lpVtbl[12]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.put_CommitButtonText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CommitButtonText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, HSTRING, int>)(lpVtbl[13]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.get_FileTypeFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_FileTypeFilter([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, IVector<HSTRING>**, int>)(lpVtbl[14]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.PickSingleFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT PickSingleFileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[15]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IFileOpenPicker.xml' path='doc/member[@name="IFileOpenPicker.PickMultipleFilesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PickMultipleFilesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPicker*, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>**, int>)(lpVtbl[16]))((IFileOpenPicker*)Unsafe.AsPointer(ref this), operation);
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
        HRESULT PickSingleFileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(16)]
        HRESULT PickMultipleFilesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IStorageFile>>**, int> PickSingleFileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IStorageFile>>>>**, int> PickMultipleFilesAsync;
    }
}
