// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IJapanesePhoneticAnalyzerStatics.xml' path='doc/member[@name="IJapanesePhoneticAnalyzerStatics"]/*' />
[Guid("88AB9E90-93DE-41B2-B4D5-8EDB227FD1C2")]
[NativeTypeName("struct IJapanesePhoneticAnalyzerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJapanesePhoneticAnalyzerStatics : IJapanesePhoneticAnalyzerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJapanesePhoneticAnalyzerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IJapanesePhoneticAnalyzerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IJapanesePhoneticAnalyzerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IJapanesePhoneticAnalyzerStatics*, uint>)(lpVtbl[1]))((IJapanesePhoneticAnalyzerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IJapanesePhoneticAnalyzerStatics*, uint>)(lpVtbl[2]))((IJapanesePhoneticAnalyzerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IJapanesePhoneticAnalyzerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IJapanesePhoneticAnalyzerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IJapanesePhoneticAnalyzerStatics*, HSTRING*, int>)(lpVtbl[4]))((IJapanesePhoneticAnalyzerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IJapanesePhoneticAnalyzerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IJapanesePhoneticAnalyzerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IJapanesePhoneticAnalyzerStatics.xml' path='doc/member[@name="IJapanesePhoneticAnalyzerStatics.GetWords"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetWords(HSTRING input, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CJapanesePhoneme_t **")] IVectorView<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IJapanesePhoneticAnalyzerStatics*, HSTRING, IVectorView<IntPtr>**, int>)(lpVtbl[6]))((IJapanesePhoneticAnalyzerStatics*)Unsafe.AsPointer(ref this), input, result);
    }

    /// <include file='IJapanesePhoneticAnalyzerStatics.xml' path='doc/member[@name="IJapanesePhoneticAnalyzerStatics.GetWordsWithMonoRubyOption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetWordsWithMonoRubyOption(HSTRING input, [NativeTypeName("boolean")] byte monoRuby, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CJapanesePhoneme_t **")] IVectorView<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IJapanesePhoneticAnalyzerStatics*, HSTRING, byte, IVectorView<IntPtr>**, int>)(lpVtbl[7]))((IJapanesePhoneticAnalyzerStatics*)Unsafe.AsPointer(ref this), input, monoRuby, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetWords(HSTRING input, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CJapanesePhoneme_t **")] IVectorView<IntPtr>** result);

        [VtblIndex(7)]
        HRESULT GetWordsWithMonoRubyOption(HSTRING input, [NativeTypeName("boolean")] byte monoRuby, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CJapanesePhoneme_t **")] IVectorView<IntPtr>** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CJapanesePhoneme_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<IntPtr>**, int> GetWords;

        [NativeTypeName("HRESULT (HSTRING, boolean, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGlobalization__CJapanesePhoneme_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte, IVectorView<IntPtr>**, int> GetWordsWithMonoRubyOption;
    }
}
