// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognitionResult.xml' path='doc/member[@name="ISpeechRecognitionResult"]/*' />
[Guid("4E303157-034E-4652-857E-D0454CC4BEEC")]
[NativeTypeName("struct ISpeechRecognitionResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognitionResult : ISpeechRecognitionResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpeechRecognitionResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, uint>)(lpVtbl[1]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, uint>)(lpVtbl[2]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognitionResult.xml' path='doc/member[@name="ISpeechRecognitionResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionResultStatus *")] SpeechRecognitionResultStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, SpeechRecognitionResultStatus*, int>)(lpVtbl[6]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionResult.xml' path='doc/member[@name="ISpeechRecognitionResult.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Text(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, HSTRING*, int>)(lpVtbl[7]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionResult.xml' path='doc/member[@name="ISpeechRecognitionResult.get_Confidence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Confidence([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConfidence *")] SpeechRecognitionConfidence* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, SpeechRecognitionConfidence*, int>)(lpVtbl[8]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionResult.xml' path='doc/member[@name="ISpeechRecognitionResult.get_SemanticInterpretation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SemanticInterpretation([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionSemanticInterpretation **")] ISpeechRecognitionSemanticInterpretation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, ISpeechRecognitionSemanticInterpretation**, int>)(lpVtbl[9]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionResult.xml' path='doc/member[@name="ISpeechRecognitionResult.GetAlternates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAlternates([NativeTypeName("UINT32")] uint maxAlternates, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **")] IVectorView<Pointer<ISpeechRecognitionResult>>** alternates)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, uint, IVectorView<Pointer<ISpeechRecognitionResult>>**, int>)(lpVtbl[10]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), maxAlternates, alternates);
    }

    /// <include file='ISpeechRecognitionResult.xml' path='doc/member[@name="ISpeechRecognitionResult.get_Constraint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Constraint([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionConstraint **")] ISpeechRecognitionConstraint** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, ISpeechRecognitionConstraint**, int>)(lpVtbl[11]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionResult.xml' path='doc/member[@name="ISpeechRecognitionResult.get_RulePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RulePath([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, IVectorView<HSTRING>**, int>)(lpVtbl[12]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognitionResult.xml' path='doc/member[@name="ISpeechRecognitionResult.get_RawConfidence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RawConfidence(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognitionResult*, double*, int>)(lpVtbl[13]))((ISpeechRecognitionResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionResultStatus *")] SpeechRecognitionResultStatus* value);

        [VtblIndex(7)]
        HRESULT get_Text(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Confidence([NativeTypeName("ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConfidence *")] SpeechRecognitionConfidence* value);

        [VtblIndex(9)]
        HRESULT get_SemanticInterpretation([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionSemanticInterpretation **")] ISpeechRecognitionSemanticInterpretation** value);

        [VtblIndex(10)]
        HRESULT GetAlternates([NativeTypeName("UINT32")] uint maxAlternates, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **")] IVectorView<Pointer<ISpeechRecognitionResult>>** alternates);

        [VtblIndex(11)]
        HRESULT get_Constraint([NativeTypeName("ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionConstraint **")] ISpeechRecognitionConstraint** value);

        [VtblIndex(12)]
        HRESULT get_RulePath([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(13)]
        HRESULT get_RawConfidence(double* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionResultStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpeechRecognitionResultStatus*, int> get_Status;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Text;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::SpeechRecognitionConfidence *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SpeechRecognitionConfidence*, int> get_Confidence;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionSemanticInterpretation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpeechRecognitionSemanticInterpretation**, int> get_SemanticInterpretation;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CSpeechRecognition__CSpeechRecognitionResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IVectorView<Pointer<ISpeechRecognitionResult>>**, int> GetAlternates;

        [NativeTypeName("HRESULT (ABI::Windows::Media::SpeechRecognition::ISpeechRecognitionConstraint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpeechRecognitionConstraint**, int> get_Constraint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_RulePath;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_RawConfidence;
    }
}
