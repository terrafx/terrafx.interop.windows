// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognizer2.xml' path='doc/member[@name="ISpeechRecognizer2"]/*' />
[Guid("63C9BAF1-91E3-4EA4-86A1-7C3867D084A6")]
[NativeTypeName("struct ISpeechRecognizer2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognizer2 : ISpeechRecognizer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognizer2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, uint>)(lpVtbl[1]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, uint>)(lpVtbl[2]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognizer2.xml' path='doc/member[@name="ISpeechRecognizer2.get_ContinuousRecognitionSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContinuousRecognitionSession([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechContinuousRecognitionSession **")] ISpeechContinuousRecognitionSession** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, ISpeechContinuousRecognitionSession**, int>)(lpVtbl[6]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizer2.xml' path='doc/member[@name="ISpeechRecognizer2.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognizerState *")] SpeechRecognizerState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, SpeechRecognizerState*, int>)(lpVtbl[7]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizer2.xml' path='doc/member[@name="ISpeechRecognizer2.StopRecognitionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StopRecognitionAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, IAsyncAction**, int>)(lpVtbl[8]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizer2.xml' path='doc/member[@name="ISpeechRecognizer2.add_HypothesisGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_HypothesisGenerated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionHypothesisGeneratedEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognitionHypothesisGeneratedEventArgs>>* value, EventRegistrationToken* returnValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognitionHypothesisGeneratedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this), value, returnValue);
    }

    /// <include file='ISpeechRecognizer2.xml' path='doc/member[@name="ISpeechRecognizer2.remove_HypothesisGenerated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_HypothesisGenerated(EventRegistrationToken value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer2*, EventRegistrationToken, int>)(lpVtbl[10]))((ISpeechRecognizer2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContinuousRecognitionSession([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechContinuousRecognitionSession **")] ISpeechContinuousRecognitionSession** value);

        [VtblIndex(7)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognizerState *")] SpeechRecognizerState* value);

        [VtblIndex(8)]
        HRESULT StopRecognitionAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** value);

        [VtblIndex(9)]
        HRESULT add_HypothesisGenerated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionHypothesisGeneratedEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognitionHypothesisGeneratedEventArgs>>* value, EventRegistrationToken* returnValue);

        [VtblIndex(10)]
        HRESULT remove_HypothesisGenerated(EventRegistrationToken value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::ISpeechContinuousRecognitionSession **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpeechContinuousRecognitionSession**, int> get_ContinuousRecognitionSession;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognizerState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpeechRecognizerState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> StopRecognitionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionHypothesisGeneratedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognitionHypothesisGeneratedEventArgs>>*, EventRegistrationToken*, int> add_HypothesisGenerated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_HypothesisGenerated;
    }
}
