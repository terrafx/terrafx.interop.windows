// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISelectableWordsSegmenterFactory.xml' path='doc/member[@name="ISelectableWordsSegmenterFactory"]/*' />
[Guid("8C7A7648-6057-4339-BC70-F210010A4150")]
[NativeTypeName("struct ISelectableWordsSegmenterFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISelectableWordsSegmenterFactory : ISelectableWordsSegmenterFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISelectableWordsSegmenterFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenterFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISelectableWordsSegmenterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenterFactory*, uint>)(lpVtbl[1]))((ISelectableWordsSegmenterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenterFactory*, uint>)(lpVtbl[2]))((ISelectableWordsSegmenterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenterFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISelectableWordsSegmenterFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenterFactory*, HSTRING*, int>)(lpVtbl[4]))((ISelectableWordsSegmenterFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenterFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISelectableWordsSegmenterFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISelectableWordsSegmenterFactory.xml' path='doc/member[@name="ISelectableWordsSegmenterFactory.CreateWithLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithLanguage(HSTRING language, [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordsSegmenter **")] ISelectableWordsSegmenter** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordsSegmenterFactory*, HSTRING, ISelectableWordsSegmenter**, int>)(lpVtbl[6]))((ISelectableWordsSegmenterFactory*)Unsafe.AsPointer(ref this), language, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithLanguage(HSTRING language, [NativeTypeName("ABI::Windows::Data::Text::ISelectableWordsSegmenter **")] ISelectableWordsSegmenter** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Text::ISelectableWordsSegmenter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISelectableWordsSegmenter**, int> CreateWithLanguage;
    }
}
