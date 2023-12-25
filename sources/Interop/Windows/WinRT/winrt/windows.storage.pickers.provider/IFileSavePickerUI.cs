// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI"]/*' />
[Guid("9656C1E7-3E56-43CC-8A39-33C73D9D542B")]
[NativeTypeName("struct IFileSavePickerUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileSavePickerUI : IFileSavePickerUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSavePickerUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, Guid*, void**, int>)(lpVtbl[0]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, uint>)(lpVtbl[1]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, uint>)(lpVtbl[2]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, uint*, Guid**, int>)(lpVtbl[3]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, HSTRING*, int>)(lpVtbl[4]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, TrustLevel*, int>)(lpVtbl[5]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, HSTRING*, int>)(lpVtbl[6]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, HSTRING, int>)(lpVtbl[7]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.get_AllowedFileTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AllowedFileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, IVectorView<HSTRING>**, int>)(lpVtbl[8]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.get_SettingsIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SettingsIdentifier(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, HSTRING*, int>)(lpVtbl[9]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.get_FileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FileName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, HSTRING*, int>)(lpVtbl[10]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.TrySetFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TrySetFileName(HSTRING value, [NativeTypeName("ABI::Windows::Storage::Pickers::Provider::SetFileNameResult *")] SetFileNameResult* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, HSTRING, SetFileNameResult*, int>)(lpVtbl[11]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), value, result);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.add_FileNameChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_FileNameChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileSavePickerUI_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.remove_FileNameChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_FileNameChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, EventRegistrationToken, int>)(lpVtbl[13]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.add_TargetFileRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_TargetFileRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileSavePickerUI_Windows__CStorage__CPickers__CProvider__CTargetFileRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IFileSavePickerUI.xml' path='doc/member[@name="IFileSavePickerUI.remove_TargetFileRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_TargetFileRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileSavePickerUI*, EventRegistrationToken, int>)(lpVtbl[15]))((IFileSavePickerUI*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_AllowedFileTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(9)]
        HRESULT get_SettingsIdentifier(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_FileName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT TrySetFileName(HSTRING value, [NativeTypeName("ABI::Windows::Storage::Pickers::Provider::SetFileNameResult *")] SetFileNameResult* result);

        [VtblIndex(12)]
        HRESULT add_FileNameChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileSavePickerUI_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_FileNameChanged(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_TargetFileRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileSavePickerUI_Windows__CStorage__CPickers__CProvider__CTargetFileRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_TargetFileRequested(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_AllowedFileTypes;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SettingsIdentifier;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FileName;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Pickers::Provider::SetFileNameResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, SetFileNameResult*, int> TrySetFileName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileSavePickerUI_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_FileNameChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FileNameChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CPickers__CProvider__CFileSavePickerUI_Windows__CStorage__CPickers__CProvider__CTargetFileRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_TargetFileRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_TargetFileRequested;
    }
}
