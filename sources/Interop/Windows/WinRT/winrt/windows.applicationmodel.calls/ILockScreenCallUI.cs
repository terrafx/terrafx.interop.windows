// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILockScreenCallUI.xml' path='doc/member[@name="ILockScreenCallUI"]/*' />
[Guid("C596FD8D-73C9-4A14-B021-EC1C50A3B727")]
[NativeTypeName("struct ILockScreenCallUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILockScreenCallUI : ILockScreenCallUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILockScreenCallUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, Guid*, void**, int>)(lpVtbl[0]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, uint>)(lpVtbl[1]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, uint>)(lpVtbl[2]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, uint*, Guid**, int>)(lpVtbl[3]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, HSTRING*, int>)(lpVtbl[4]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, TrustLevel*, int>)(lpVtbl[5]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILockScreenCallUI.xml' path='doc/member[@name="ILockScreenCallUI.Dismiss"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Dismiss()
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, int>)(lpVtbl[6]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILockScreenCallUI.xml' path='doc/member[@name="ILockScreenCallUI.add_EndRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_EndRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CLockScreenCallUI_Windows__CApplicationModel__CCalls__CLockScreenCallEndRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ILockScreenCallUI>, Pointer<ILockScreenCallEndRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, ITypedEventHandler<Pointer<ILockScreenCallUI>, Pointer<ILockScreenCallEndRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ILockScreenCallUI.xml' path='doc/member[@name="ILockScreenCallUI.remove_EndRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_EndRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, EventRegistrationToken, int>)(lpVtbl[8]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ILockScreenCallUI.xml' path='doc/member[@name="ILockScreenCallUI.add_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CLockScreenCallUI_IInspectable_t *")] ITypedEventHandler<Pointer<ILockScreenCallUI>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, ITypedEventHandler<Pointer<ILockScreenCallUI>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ILockScreenCallUI.xml' path='doc/member[@name="ILockScreenCallUI.remove_Closed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Closed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, EventRegistrationToken, int>)(lpVtbl[10]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ILockScreenCallUI.xml' path='doc/member[@name="ILockScreenCallUI.get_CallTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CallTitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, HSTRING*, int>)(lpVtbl[11]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ILockScreenCallUI.xml' path='doc/member[@name="ILockScreenCallUI.put_CallTitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_CallTitle(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILockScreenCallUI*, HSTRING, int>)(lpVtbl[12]))((ILockScreenCallUI*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Dismiss();

        [VtblIndex(7)]
        HRESULT add_EndRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CLockScreenCallUI_Windows__CApplicationModel__CCalls__CLockScreenCallEndRequestedEventArgs_t *")] ITypedEventHandler<Pointer<ILockScreenCallUI>, Pointer<ILockScreenCallEndRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_EndRequested(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT add_Closed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CLockScreenCallUI_IInspectable_t *")] ITypedEventHandler<Pointer<ILockScreenCallUI>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Closed(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT get_CallTitle(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_CallTitle(HSTRING value);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Dismiss;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CLockScreenCallUI_Windows__CApplicationModel__CCalls__CLockScreenCallEndRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ILockScreenCallUI>, Pointer<ILockScreenCallEndRequestedEventArgs>>*, EventRegistrationToken*, int> add_EndRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EndRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CLockScreenCallUI_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ILockScreenCallUI>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CallTitle;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CallTitle;
    }
}
