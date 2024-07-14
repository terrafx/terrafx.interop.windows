// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession"]/*' />
[Guid("6A213C04-6614-49F8-99A2-B5E9B3A085C8")]
[NativeTypeName("struct ISpeechContinuousRecognitionSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechContinuousRecognitionSession : ISpeechContinuousRecognitionSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechContinuousRecognitionSession));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, uint>)(lpVtbl[1]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, uint>)(lpVtbl[2]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, HSTRING*, int>)(lpVtbl[4]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.get_AutoStopSilenceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AutoStopSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, TimeSpan*, int>)(lpVtbl[6]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.put_AutoStopSilenceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AutoStopSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, TimeSpan, int>)(lpVtbl[7]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.StartAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, IAsyncAction**, int>)(lpVtbl[8]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.StartWithModeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StartWithModeAsync([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechContinuousRecognitionMode")] SpeechContinuousRecognitionMode mode, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, SpeechContinuousRecognitionMode, IAsyncAction**, int>)(lpVtbl[9]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), mode, value);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.StopAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT StopAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, IAsyncAction**, int>)(lpVtbl[10]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.CancelAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CancelAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, IAsyncAction**, int>)(lpVtbl[11]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.PauseAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PauseAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, IAsyncAction**, int>)(lpVtbl[12]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.Resume"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, int>)(lpVtbl[13]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.add_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_Completed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionCompletedEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechContinuousRecognitionSession>, Pointer<ISpeechContinuousRecognitionCompletedEventArgs>>* value, EventRegistrationToken* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, ITypedEventHandler<Pointer<ISpeechContinuousRecognitionSession>, Pointer<ISpeechContinuousRecognitionCompletedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value, returnValue);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.remove_Completed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_Completed(EventRegistrationToken value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, EventRegistrationToken, int>)(lpVtbl[15]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.add_ResultGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_ResultGenerated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionResultGeneratedEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechContinuousRecognitionSession>, Pointer<ISpeechContinuousRecognitionResultGeneratedEventArgs>>* value, EventRegistrationToken* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, ITypedEventHandler<Pointer<ISpeechContinuousRecognitionSession>, Pointer<ISpeechContinuousRecognitionResultGeneratedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value, returnValue);
    }

    /// <include file='ISpeechContinuousRecognitionSession.xml' path='doc/member[@name="ISpeechContinuousRecognitionSession.remove_ResultGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_ResultGenerated(EventRegistrationToken value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechContinuousRecognitionSession*, EventRegistrationToken, int>)(lpVtbl[17]))((ISpeechContinuousRecognitionSession*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AutoStopSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(7)]
        HRESULT put_AutoStopSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(8)]
        HRESULT StartAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(9)]
        HRESULT StartWithModeAsync([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechContinuousRecognitionMode")] SpeechContinuousRecognitionMode mode, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(10)]
        HRESULT StopAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(11)]
        HRESULT CancelAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(12)]
        HRESULT PauseAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(13)]
        HRESULT Resume();

        [VtblIndex(14)]
        HRESULT add_Completed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionCompletedEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechContinuousRecognitionSession>, Pointer<ISpeechContinuousRecognitionCompletedEventArgs>>* value, EventRegistrationToken* returnValue);

        [VtblIndex(15)]
        HRESULT remove_Completed(EventRegistrationToken value);

        [VtblIndex(16)]
        HRESULT add_ResultGenerated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionResultGeneratedEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechContinuousRecognitionSession>, Pointer<ISpeechContinuousRecognitionResultGeneratedEventArgs>>* value, EventRegistrationToken* returnValue);

        [VtblIndex(17)]
        HRESULT remove_ResultGenerated(EventRegistrationToken value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_AutoStopSilenceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_AutoStopSilenceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StartAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechContinuousRecognitionMode, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpeechContinuousRecognitionMode, IAsyncAction**, int> StartWithModeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StopAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> CancelAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> PauseAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Resume;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISpeechContinuousRecognitionSession>, Pointer<ISpeechContinuousRecognitionCompletedEventArgs>>*, EventRegistrationToken*, int> add_Completed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Completed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionSession_Windows__CMedia__CSpeechRecognition__CSpeechContinuousRecognitionResultGeneratedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISpeechContinuousRecognitionSession>, Pointer<ISpeechContinuousRecognitionResultGeneratedEventArgs>>*, EventRegistrationToken*, int> add_ResultGenerated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ResultGenerated;
    }
}
