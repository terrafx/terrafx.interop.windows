// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer"]/*' />
[Guid("0BC3C9CB-C26A-40F2-AEB5-8096B2E48073")]
[NativeTypeName("struct ISpeechRecognizer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognizer : ISpeechRecognizer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_WinRT_ISpeechRecognizer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, uint>)(lpVtbl[1]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, uint>)(lpVtbl[2]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.get_CurrentLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentLanguage([NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage** language)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, ILanguage**, int>)(lpVtbl[6]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), language);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.get_Constraints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Constraints([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CSpeechRecognition__CISpeechRecognitionConstraint_t **")] IVector<Pointer<ISpeechRecognitionConstraint>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, IVector<Pointer<ISpeechRecognitionConstraint>>**, int>)(lpVtbl[7]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.get_Timeouts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Timeouts([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerTimeouts **")] ISpeechRecognizerTimeouts** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, ISpeechRecognizerTimeouts**, int>)(lpVtbl[8]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.get_UIOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UIOptions([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerUIOptions **")] ISpeechRecognizerUIOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, ISpeechRecognizerUIOptions**, int>)(lpVtbl[9]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.CompileConstraintsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CompileConstraintsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionCompilationResult_t **")] IAsyncOperation<Pointer<ISpeechRecognitionCompilationResult>>** asyncOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, IAsyncOperation<Pointer<ISpeechRecognitionCompilationResult>>**, int>)(lpVtbl[10]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), asyncOperation);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.RecognizeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RecognizeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **")] IAsyncOperation<Pointer<ISpeechRecognitionResult>>** asyncOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, IAsyncOperation<Pointer<ISpeechRecognitionResult>>**, int>)(lpVtbl[11]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), asyncOperation);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.RecognizeWithUIAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RecognizeWithUIAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **")] IAsyncOperation<Pointer<ISpeechRecognitionResult>>** asyncOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, IAsyncOperation<Pointer<ISpeechRecognitionResult>>**, int>)(lpVtbl[12]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), asyncOperation);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.add_RecognitionQualityDegrading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_RecognitionQualityDegrading([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionQualityDegradingEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognitionQualityDegradingEventArgs>>* speechRecognitionQualityDegradingHandler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognitionQualityDegradingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), speechRecognitionQualityDegradingHandler, cookie);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.remove_RecognitionQualityDegrading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_RecognitionQualityDegrading(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, EventRegistrationToken, int>)(lpVtbl[14]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.add_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognizerStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognizerStateChangedEventArgs>>* stateChangedHandler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognizerStateChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), stateChangedHandler, cookie);
    }

    /// <include file='ISpeechRecognizer.xml' path='doc/member[@name="ISpeechRecognizer.remove_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_StateChanged(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizer*, EventRegistrationToken, int>)(lpVtbl[16]))((ISpeechRecognizer*)Unsafe.AsPointer(ref this), cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentLanguage([NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage** language);

        [VtblIndex(7)]
        HRESULT get_Constraints([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CSpeechRecognition__CISpeechRecognitionConstraint_t **")] IVector<Pointer<ISpeechRecognitionConstraint>>** value);

        [VtblIndex(8)]
        HRESULT get_Timeouts([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerTimeouts **")] ISpeechRecognizerTimeouts** value);

        [VtblIndex(9)]
        HRESULT get_UIOptions([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerUIOptions **")] ISpeechRecognizerUIOptions** value);

        [VtblIndex(10)]
        HRESULT CompileConstraintsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionCompilationResult_t **")] IAsyncOperation<Pointer<ISpeechRecognitionCompilationResult>>** asyncOperation);

        [VtblIndex(11)]
        HRESULT RecognizeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **")] IAsyncOperation<Pointer<ISpeechRecognitionResult>>** asyncOperation);

        [VtblIndex(12)]
        HRESULT RecognizeWithUIAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **")] IAsyncOperation<Pointer<ISpeechRecognitionResult>>** asyncOperation);

        [VtblIndex(13)]
        HRESULT add_RecognitionQualityDegrading([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionQualityDegradingEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognitionQualityDegradingEventArgs>>* speechRecognitionQualityDegradingHandler, EventRegistrationToken* cookie);

        [VtblIndex(14)]
        HRESULT remove_RecognitionQualityDegrading(EventRegistrationToken cookie);

        [VtblIndex(15)]
        HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognizerStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognizerStateChangedEventArgs>>* stateChangedHandler, EventRegistrationToken* cookie);

        [VtblIndex(16)]
        HRESULT remove_StateChanged(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Globalization::ILanguage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILanguage**, int> get_CurrentLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CMedia__CSpeechRecognition__CISpeechRecognitionConstraint_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<ISpeechRecognitionConstraint>>**, int> get_Constraints;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerTimeouts **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpeechRecognizerTimeouts**, int> get_Timeouts;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::ISpeechRecognizerUIOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpeechRecognizerUIOptions**, int> get_UIOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionCompilationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISpeechRecognitionCompilationResult>>**, int> CompileConstraintsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISpeechRecognitionResult>>**, int> RecognizeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISpeechRecognitionResult>>**, int> RecognizeWithUIAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionQualityDegradingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognitionQualityDegradingEventArgs>>*, EventRegistrationToken*, int> add_RecognitionQualityDegrading;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RecognitionQualityDegrading;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CSpeechRecognition__CSpeechRecognizer_Windows__CMedia__CSpeechRecognition__CSpeechRecognizerStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ISpeechRecognizer>, Pointer<ISpeechRecognizerStateChangedEventArgs>>*, EventRegistrationToken*, int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StateChanged;
    }
}
