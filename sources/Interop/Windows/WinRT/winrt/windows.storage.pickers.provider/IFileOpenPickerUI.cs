// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI"]/*' />
[Guid("DDA45A10-F9D4-40C4-8AF5-C5B6B5A61D1D")]
[NativeTypeName("struct IFileOpenPickerUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileOpenPickerUI : IFileOpenPickerUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IFileOpenPickerUI);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, Guid*, void**, int>)(lpVtbl[0]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, uint>)(lpVtbl[1]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, uint>)(lpVtbl[2]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, uint*, Guid**, int>)(lpVtbl[3]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, HSTRING*, int>)(lpVtbl[4]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, TrustLevel*, int>)(lpVtbl[5]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.AddFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddFile(HSTRING id, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Pickers::Provider::AddFileResult *")] AddFileResult* addResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, HSTRING, IStorageFile*, AddFileResult*, int>)(lpVtbl[6]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), id, file, addResult);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.RemoveFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveFile(HSTRING id)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, HSTRING, int>)(lpVtbl[7]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), id);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.ContainsFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ContainsFile(HSTRING id, [NativeTypeName("boolean *")] byte* isContained)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, HSTRING, byte*, int>)(lpVtbl[8]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), id, isContained);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.CanAddFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CanAddFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("boolean *")] byte* canAdd)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, IStorageFile*, byte*, int>)(lpVtbl[9]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), file, canAdd);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.get_AllowedFileTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AllowedFileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, IVectorView<HSTRING>**, int>)(lpVtbl[10]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.get_SelectionMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SelectionMode([NativeTypeName("ABI::Windows::Storage::Pickers::Provider::FileSelectionMode *")] FileSelectionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, FileSelectionMode*, int>)(lpVtbl[11]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.get_SettingsIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SettingsIdentifier(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, HSTRING*, int>)(lpVtbl[12]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, HSTRING*, int>)(lpVtbl[13]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, HSTRING, int>)(lpVtbl[14]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.add_FileRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.")]
    public HRESULT add_FileRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CFileRemovedEventArgs_t *")] ITypedEventHandler<Pointer<IFileOpenPickerUI>, Pointer<IFileRemovedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, ITypedEventHandler<Pointer<IFileOpenPickerUI>, Pointer<IFileRemovedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.remove_FileRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.")]
    public HRESULT remove_FileRemoved(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, EventRegistrationToken, int>)(lpVtbl[16]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.add_Closing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_Closing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CPickerClosingEventArgs_t *")] ITypedEventHandler<Pointer<IFileOpenPickerUI>, Pointer<IPickerClosingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, ITypedEventHandler<Pointer<IFileOpenPickerUI>, Pointer<IPickerClosingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IFileOpenPickerUI.xml' path='doc/member[@name="IFileOpenPickerUI.remove_Closing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_Closing(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenPickerUI*, EventRegistrationToken, int>)(lpVtbl[18]))((IFileOpenPickerUI*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddFile(HSTRING id, [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Storage::Pickers::Provider::AddFileResult *")] AddFileResult* addResult);

        [VtblIndex(7)]
        HRESULT RemoveFile(HSTRING id);

        [VtblIndex(8)]
        HRESULT ContainsFile(HSTRING id, [NativeTypeName("boolean *")] byte* isContained);

        [VtblIndex(9)]
        HRESULT CanAddFile([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("boolean *")] byte* canAdd);

        [VtblIndex(10)]
        HRESULT get_AllowedFileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(11)]
        HRESULT get_SelectionMode([NativeTypeName("ABI::Windows::Storage::Pickers::Provider::FileSelectionMode *")] FileSelectionMode* value);

        [VtblIndex(12)]
        HRESULT get_SettingsIdentifier(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(15)]
        [Obsolete("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.")]
        HRESULT add_FileRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CFileRemovedEventArgs_t *")] ITypedEventHandler<Pointer<IFileOpenPickerUI>, Pointer<IFileRemovedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        [Obsolete("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.")]
        HRESULT remove_FileRemoved(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_Closing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CPickerClosingEventArgs_t *")] ITypedEventHandler<Pointer<IFileOpenPickerUI>, Pointer<IPickerClosingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(18)]
        HRESULT remove_Closing(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Pickers::Provider::AddFileResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IStorageFile*, AddFileResult*, int> AddFile;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> RemoveFile;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> ContainsFile;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFile*, byte*, int> CanAddFile;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_AllowedFileTypes;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Pickers::Provider::FileSelectionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FileSelectionMode*, int> get_SelectionMode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SettingsIdentifier;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CFileRemovedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IFileOpenPickerUI>, Pointer<IFileRemovedEventArgs>>*, EventRegistrationToken*, int> add_FileRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Since Windows 10, only apps can remove files, not end users so the FileRemoved event will not be raised.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FileRemoved;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileOpenPickerUI_Windows__CStorage__CPickers__CProvider__CPickerClosingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IFileOpenPickerUI>, Pointer<IPickerClosingEventArgs>>*, EventRegistrationToken*, int> add_Closing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closing;
    }
}
