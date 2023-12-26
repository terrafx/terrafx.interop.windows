// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICachedFileUpdaterUI.xml' path='doc/member[@name="ICachedFileUpdaterUI"]/*' />
[Guid("9E6F41E6-BAF2-4A97-B600-9333F5DF80FD")]
[NativeTypeName("struct ICachedFileUpdaterUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICachedFileUpdaterUI : ICachedFileUpdaterUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICachedFileUpdaterUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, Guid*, void**, int>)(lpVtbl[0]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, uint>)(lpVtbl[1]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, uint>)(lpVtbl[2]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, uint*, Guid**, int>)(lpVtbl[3]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, HSTRING*, int>)(lpVtbl[4]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, TrustLevel*, int>)(lpVtbl[5]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICachedFileUpdaterUI.xml' path='doc/member[@name="ICachedFileUpdaterUI.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, HSTRING*, int>)(lpVtbl[6]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICachedFileUpdaterUI.xml' path='doc/member[@name="ICachedFileUpdaterUI.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, HSTRING, int>)(lpVtbl[7]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICachedFileUpdaterUI.xml' path='doc/member[@name="ICachedFileUpdaterUI.get_UpdateTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UpdateTarget([NativeTypeName("ABI::Windows::Storage::Provider::CachedFileTarget *")] CachedFileTarget* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, CachedFileTarget*, int>)(lpVtbl[8]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICachedFileUpdaterUI.xml' path='doc/member[@name="ICachedFileUpdaterUI.add_FileUpdateRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_FileUpdateRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_Windows__CStorage__CProvider__CFileUpdateRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICachedFileUpdaterUI.xml' path='doc/member[@name="ICachedFileUpdaterUI.remove_FileUpdateRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_FileUpdateRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, EventRegistrationToken, int>)(lpVtbl[10]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICachedFileUpdaterUI.xml' path='doc/member[@name="ICachedFileUpdaterUI.add_UIRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_UIRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ICachedFileUpdaterUI.xml' path='doc/member[@name="ICachedFileUpdaterUI.remove_UIRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_UIRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, EventRegistrationToken, int>)(lpVtbl[12]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ICachedFileUpdaterUI.xml' path='doc/member[@name="ICachedFileUpdaterUI.get_UIStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_UIStatus([NativeTypeName("ABI::Windows::Storage::Provider::UIStatus *")] UIStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICachedFileUpdaterUI*, UIStatus*, int>)(lpVtbl[13]))((ICachedFileUpdaterUI*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_UpdateTarget([NativeTypeName("ABI::Windows::Storage::Provider::CachedFileTarget *")] CachedFileTarget* value);

        [VtblIndex(9)]
        HRESULT add_FileUpdateRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_Windows__CStorage__CProvider__CFileUpdateRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_FileUpdateRequested(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_UIRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_UIRequested(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT get_UIStatus([NativeTypeName("ABI::Windows::Storage::Provider::UIStatus *")] UIStatus* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::CachedFileTarget *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CachedFileTarget*, int> get_UpdateTarget;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_Windows__CStorage__CProvider__CFileUpdateRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_FileUpdateRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_FileUpdateRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_UIRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_UIRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Provider::UIStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UIStatus*, int> get_UIStatus;
    }
}
