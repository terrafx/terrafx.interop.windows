// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISelectableWordsSegmenter.xml' path='doc/member[@name="ISelectableWordsSegmenter"]/*' />
[Guid("F6DC31E7-4B13-45C5-8897-7D71269E085D")]
[NativeTypeName("struct ISelectableWordsSegmenter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISelectableWordsSegmenter : ISelectableWordsSegmenter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISelectableWordsSegmenter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, Guid*, void**, int>)(lpVtbl[0]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, uint>)(lpVtbl[1]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, uint>)(lpVtbl[2]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, uint*, Guid**, int>)(lpVtbl[3]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, HSTRING*, int>)(lpVtbl[4]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, TrustLevel*, int>)(lpVtbl[5]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISelectableWordsSegmenter.xml' path='doc/member[@name="ISelectableWordsSegmenter.get_ResolvedLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResolvedLanguage(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, HSTRING*, int>)(lpVtbl[6]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISelectableWordsSegmenter.xml' path='doc/member[@name="ISelectableWordsSegmenter.GetTokenAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTokenAt(HSTRING text, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordSegment **")] ISelectableWordSegment** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, HSTRING, uint, ISelectableWordSegment**, int>)(lpVtbl[7]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this), text, startIndex, result);
    }

    /// <include file='ISelectableWordsSegmenter.xml' path='doc/member[@name="ISelectableWordsSegmenter.GetTokens"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTokens(HSTRING text, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CSelectableWordSegment_t **")] IVectorView<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, HSTRING, IVectorView<IntPtr>**, int>)(lpVtbl[8]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this), text, result);
    }

    /// <include file='ISelectableWordsSegmenter.xml' path='doc/member[@name="ISelectableWordsSegmenter.Tokenize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Tokenize(HSTRING text, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordSegmentsTokenizingHandler *")] ISelectableWordSegmentsTokenizingHandler* handler)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenter*, HSTRING, uint, ISelectableWordSegmentsTokenizingHandler*, int>)(lpVtbl[9]))((ISelectableWordsSegmenter*)Unsafe.AsPointer(ref this), text, startIndex, handler);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResolvedLanguage(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetTokenAt(HSTRING text, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordSegment **")] ISelectableWordSegment** result);

        [VtblIndex(8)]
        HRESULT GetTokens(HSTRING text, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CSelectableWordSegment_t **")] IVectorView<IntPtr>** result);

        [VtblIndex(9)]
        HRESULT Tokenize(HSTRING text, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordSegmentsTokenizingHandler *")] ISelectableWordSegmentsTokenizingHandler* handler);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ResolvedLanguage;

        [NativeTypeName("HRESULT (HSTRING, UINT32, ABI::Windows::Data::Text::ISelectableWordSegment **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint, ISelectableWordSegment**, int> GetTokenAt;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CData__CText__CSelectableWordSegment_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<IntPtr>**, int> GetTokens;

        [NativeTypeName("HRESULT (HSTRING, UINT32, ABI::Windows::Data::Text::ISelectableWordSegmentsTokenizingHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, uint, ISelectableWordSegmentsTokenizingHandler*, int> Tokenize;
    }
}
