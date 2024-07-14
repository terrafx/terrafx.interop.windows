// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognizerStatics.xml' path='doc/member[@name="ISpeechRecognizerStatics"]/*' />
[Guid("87A35EAC-A7DC-4B0B-BCC9-24F47C0B7EBF")]
[NativeTypeName("struct ISpeechRecognizerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognizerStatics : ISpeechRecognizerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognizerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognizerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerStatics*, uint>)(lpVtbl[1]))((ISpeechRecognizerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerStatics*, uint>)(lpVtbl[2]))((ISpeechRecognizerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognizerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerStatics*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognizerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognizerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognizerStatics.xml' path='doc/member[@name="ISpeechRecognizerStatics.get_SystemSpeechLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SystemSpeechLanguage([NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage** language)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerStatics*, ILanguage**, int>)(lpVtbl[6]))((ISpeechRecognizerStatics*)Unsafe.AsPointer(ref this), language);
    }

    /// <include file='ISpeechRecognizerStatics.xml' path='doc/member[@name="ISpeechRecognizerStatics.get_SupportedTopicLanguages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedTopicLanguages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CLanguage_t **")] IVectorView<Pointer<ILanguage>>** languages)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerStatics*, IVectorView<Pointer<ILanguage>>**, int>)(lpVtbl[7]))((ISpeechRecognizerStatics*)Unsafe.AsPointer(ref this), languages);
    }

    /// <include file='ISpeechRecognizerStatics.xml' path='doc/member[@name="ISpeechRecognizerStatics.get_SupportedGrammarLanguages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportedGrammarLanguages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CLanguage_t **")] IVectorView<Pointer<ILanguage>>** languages)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerStatics*, IVectorView<Pointer<ILanguage>>**, int>)(lpVtbl[8]))((ISpeechRecognizerStatics*)Unsafe.AsPointer(ref this), languages);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SystemSpeechLanguage([NativeTypeName("ABI::Windows::Globalization::ILanguage **")] ILanguage** language);

        [VtblIndex(7)]
        HRESULT get_SupportedTopicLanguages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CLanguage_t **")] IVectorView<Pointer<ILanguage>>** languages);

        [VtblIndex(8)]
        HRESULT get_SupportedGrammarLanguages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CLanguage_t **")] IVectorView<Pointer<ILanguage>>** languages);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, ILanguage**, int> get_SystemSpeechLanguage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CLanguage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ILanguage>>**, int> get_SupportedTopicLanguages;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CLanguage_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ILanguage>>**, int> get_SupportedGrammarLanguages;
    }
}
