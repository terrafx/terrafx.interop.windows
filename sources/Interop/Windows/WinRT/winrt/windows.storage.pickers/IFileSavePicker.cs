// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker"]/*' />
[Guid("3286FFCB-617F-4CC5-AF6A-B3FDF29AD145")]
[NativeTypeName("struct IFileSavePicker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileSavePicker : IFileSavePicker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSavePicker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, Guid*, void**, int>)(lpVtbl[0]))((IFileSavePicker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, uint>)(lpVtbl[1]))((IFileSavePicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, uint>)(lpVtbl[2]))((IFileSavePicker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, uint*, Guid**, int>)(lpVtbl[3]))((IFileSavePicker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, HSTRING*, int>)(lpVtbl[4]))((IFileSavePicker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, TrustLevel*, int>)(lpVtbl[5]))((IFileSavePicker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.get_SettingsIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SettingsIdentifier(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, HSTRING*, int>)(lpVtbl[6]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.put_SettingsIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SettingsIdentifier(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, HSTRING, int>)(lpVtbl[7]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.get_SuggestedStartLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId *")] PickerLocationId* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, PickerLocationId*, int>)(lpVtbl[8]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.put_SuggestedStartLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId")] PickerLocationId value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, PickerLocationId, int>)(lpVtbl[9]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.get_CommitButtonText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CommitButtonText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, HSTRING*, int>)(lpVtbl[10]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.put_CommitButtonText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CommitButtonText(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, HSTRING, int>)(lpVtbl[11]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.get_FileTypeChoices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FileTypeChoices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING___FIVector_1_HSTRING_t **")] IMap<HSTRING, Pointer<IVector<HSTRING>>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, IMap<HSTRING, Pointer<IVector<HSTRING>>>**, int>)(lpVtbl[12]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.get_DefaultFileExtension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DefaultFileExtension(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, HSTRING*, int>)(lpVtbl[13]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.put_DefaultFileExtension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_DefaultFileExtension(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, HSTRING, int>)(lpVtbl[14]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.get_SuggestedSaveFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SuggestedSaveFile([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, IStorageFile**, int>)(lpVtbl[15]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.put_SuggestedSaveFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_SuggestedSaveFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, IStorageFile*, int>)(lpVtbl[16]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.get_SuggestedFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SuggestedFileName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, HSTRING*, int>)(lpVtbl[17]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.put_SuggestedFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_SuggestedFileName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, HSTRING, int>)(lpVtbl[18]))((IFileSavePicker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePicker.xml' path='doc/member[@name="IFileSavePicker.PickSaveFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT PickSaveFileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePicker*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[19]))((IFileSavePicker*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SettingsIdentifier(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_SettingsIdentifier(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId *")] PickerLocationId* value);

        [VtblIndex(9)]
        HRESULT put_SuggestedStartLocation([NativeTypeName("ABI::Windows::Storage::Pickers::PickerLocationId")] PickerLocationId value);

        [VtblIndex(10)]
        HRESULT get_CommitButtonText(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_CommitButtonText(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_FileTypeChoices([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING___FIVector_1_HSTRING_t **")] IMap<HSTRING, Pointer<IVector<HSTRING>>>** value);

        [VtblIndex(13)]
        HRESULT get_DefaultFileExtension(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_DefaultFileExtension(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_SuggestedSaveFile([NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile** value);

        [VtblIndex(16)]
        HRESULT put_SuggestedSaveFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* value);

        [VtblIndex(17)]
        HRESULT get_SuggestedFileName(HSTRING* value);

        [VtblIndex(18)]
        HRESULT put_SuggestedFileName(HSTRING value);

        [VtblIndex(19)]
        HRESULT PickSaveFileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING___FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IVector<HSTRING>>>**, int> get_FileTypeChoices;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DefaultFileExtension;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DefaultFileExtension;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile**, int> get_SuggestedSaveFile;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, int> put_SuggestedSaveFile;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SuggestedFileName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SuggestedFileName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IStorageFile>>**, int> PickSaveFileAsync;
    }
}
