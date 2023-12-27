// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextPredictionGenerator2.xml' path='doc/member[@name="ITextPredictionGenerator2"]/*' />
[Guid("B84723B8-2C77-486A-900A-A3453EEDC15D")]
[NativeTypeName("struct ITextPredictionGenerator2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextPredictionGenerator2 : ITextPredictionGenerator2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextPredictionGenerator2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, Guid*, void**, int>)(lpVtbl[0]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, uint>)(lpVtbl[1]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, uint>)(lpVtbl[2]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, uint*, Guid**, int>)(lpVtbl[3]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, HSTRING*, int>)(lpVtbl[4]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, TrustLevel*, int>)(lpVtbl[5]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextPredictionGenerator2.xml' path='doc/member[@name="ITextPredictionGenerator2.GetCandidatesWithParametersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCandidatesWithParametersAsync(HSTRING input, [NativeTypeName("UINT32")] uint maxCandidates, [NativeTypeName("ABI::Windows::Data::Text::TextPredictionOptions")] TextPredictionOptions predictionOptions, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* previousStrings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, HSTRING, uint, TextPredictionOptions, IIterable<HSTRING>*, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int>)(lpVtbl[6]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this), input, maxCandidates, predictionOptions, previousStrings, result);
    }

    /// <include file='ITextPredictionGenerator2.xml' path='doc/member[@name="ITextPredictionGenerator2.GetNextWordCandidatesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNextWordCandidatesAsync([NativeTypeName("UINT32")] uint maxCandidates, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* previousStrings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, uint, IIterable<HSTRING>*, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int>)(lpVtbl[7]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this), maxCandidates, previousStrings, result);
    }

    /// <include file='ITextPredictionGenerator2.xml' path='doc/member[@name="ITextPredictionGenerator2.get_InputScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InputScope([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope *")] CoreTextInputScope* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, CoreTextInputScope*, int>)(lpVtbl[8]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITextPredictionGenerator2.xml' path='doc/member[@name="ITextPredictionGenerator2.put_InputScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InputScope([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope")] CoreTextInputScope value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextPredictionGenerator2*, CoreTextInputScope, int>)(lpVtbl[9]))((ITextPredictionGenerator2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCandidatesWithParametersAsync(HSTRING input, [NativeTypeName("UINT32")] uint maxCandidates, [NativeTypeName("ABI::Windows::Data::Text::TextPredictionOptions")] TextPredictionOptions predictionOptions, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* previousStrings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** result);

        [VtblIndex(7)]
        HRESULT GetNextWordCandidatesAsync([NativeTypeName("UINT32")] uint maxCandidates, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* previousStrings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **")] IAsyncOperation<Pointer<IVectorView<HSTRING>>>** result);

        [VtblIndex(8)]
        HRESULT get_InputScope([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope *")] CoreTextInputScope* value);

        [VtblIndex(9)]
        HRESULT put_InputScope([NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope")] CoreTextInputScope value);
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

        [NativeTypeName("HRESULT (HSTRING, UINT32, ABI::Windows::Data::Text::TextPredictionOptions, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint, TextPredictionOptions, IIterable<HSTRING>*, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int> GetCandidatesWithParametersAsync;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IIterable<HSTRING>*, IAsyncOperation<Pointer<IVectorView<HSTRING>>>**, int> GetNextWordCandidatesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputScope *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextInputScope*, int> get_InputScope;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputScope) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CoreTextInputScope, int> put_InputScope;
    }
}
