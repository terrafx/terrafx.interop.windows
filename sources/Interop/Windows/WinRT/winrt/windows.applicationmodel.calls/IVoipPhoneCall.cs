// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall"]/*' />
[Guid("6CF1F19A-7794-4A5A-8C68-AE87947A6990")]
[NativeTypeName("struct IVoipPhoneCall : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipPhoneCall : IVoipPhoneCall.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVoipPhoneCall);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, Guid*, void**, int>)(lpVtbl[0]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, uint>)(lpVtbl[1]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, uint>)(lpVtbl[2]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, uint*, Guid**, int>)(lpVtbl[3]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, HSTRING*, int>)(lpVtbl[4]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, TrustLevel*, int>)(lpVtbl[5]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.add_EndRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_EndRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.remove_EndRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_EndRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, EventRegistrationToken, int>)(lpVtbl[7]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.add_HoldRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_HoldRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.remove_HoldRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_HoldRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, EventRegistrationToken, int>)(lpVtbl[9]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.add_ResumeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ResumeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.remove_ResumeRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ResumeRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, EventRegistrationToken, int>)(lpVtbl[11]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.add_AnswerRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_AnswerRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallAnswerEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallAnswerEventArgs>>* acceptHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallAnswerEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), acceptHandler, token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.remove_AnswerRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_AnswerRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, EventRegistrationToken, int>)(lpVtbl[13]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.add_RejectRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_RejectRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallRejectEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallRejectEventArgs>>* rejectHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallRejectEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), rejectHandler, token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.remove_RejectRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_RejectRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, EventRegistrationToken, int>)(lpVtbl[15]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.NotifyCallHeld"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT NotifyCallHeld()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, int>)(lpVtbl[16]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.NotifyCallActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT NotifyCallActive()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, int>)(lpVtbl[17]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.NotifyCallEnded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT NotifyCallEnded()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, int>)(lpVtbl[18]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.get_ContactName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ContactName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, HSTRING*, int>)(lpVtbl[19]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.put_ContactName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_ContactName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, HSTRING, int>)(lpVtbl[20]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, WinRTDateTime*, int>)(lpVtbl[21]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.put_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, WinRTDateTime, int>)(lpVtbl[22]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.get_CallMedia"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_CallMedia([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")] VoipPhoneCallMedia* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, VoipPhoneCallMedia*, int>)(lpVtbl[23]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.put_CallMedia"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_CallMedia([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, VoipPhoneCallMedia, int>)(lpVtbl[24]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVoipPhoneCall.xml' path='doc/member[@name="IVoipPhoneCall.NotifyCallReady"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT NotifyCallReady()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipPhoneCall*, int>)(lpVtbl[25]))((IVoipPhoneCall*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_EndRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_EndRequested(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_HoldRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_HoldRequested(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_ResumeRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ResumeRequested(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_AnswerRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallAnswerEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallAnswerEventArgs>>* acceptHandler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_AnswerRequested(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT add_RejectRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallRejectEventArgs_t *")] ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallRejectEventArgs>>* rejectHandler, EventRegistrationToken* token);

        [VtblIndex(15)]
        HRESULT remove_RejectRequested(EventRegistrationToken token);

        [VtblIndex(16)]
        HRESULT NotifyCallHeld();

        [VtblIndex(17)]
        HRESULT NotifyCallActive();

        [VtblIndex(18)]
        HRESULT NotifyCallEnded();

        [VtblIndex(19)]
        HRESULT get_ContactName(HSTRING* value);

        [VtblIndex(20)]
        HRESULT put_ContactName(HSTRING value);

        [VtblIndex(21)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(22)]
        HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(23)]
        HRESULT get_CallMedia([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")] VoipPhoneCallMedia* value);

        [VtblIndex(24)]
        HRESULT put_CallMedia([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia value);

        [VtblIndex(25)]
        HRESULT NotifyCallReady();
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>*, EventRegistrationToken*, int> add_EndRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EndRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>*, EventRegistrationToken*, int> add_HoldRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_HoldRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallStateChangeEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallStateChangeEventArgs>>*, EventRegistrationToken*, int> add_ResumeRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ResumeRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallAnswerEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallAnswerEventArgs>>*, EventRegistrationToken*, int> add_AnswerRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AnswerRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CVoipPhoneCall_Windows__CApplicationModel__CCalls__CCallRejectEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IVoipPhoneCall>, Pointer<ICallRejectEventArgs>>*, EventRegistrationToken*, int> add_RejectRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RejectRequested;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> NotifyCallHeld;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> NotifyCallActive;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> NotifyCallEnded;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContactName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContactName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VoipPhoneCallMedia*, int> get_CallMedia;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VoipPhoneCallMedia, int> put_CallMedia;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> NotifyCallReady;
    }
}
