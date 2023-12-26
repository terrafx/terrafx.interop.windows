// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAlternateWordForm.xml' path='doc/member[@name="IAlternateWordForm"]/*' />
[Guid("47396C1E-51B9-4207-9146-248E636A1D1D")]
[NativeTypeName("struct IAlternateWordForm : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAlternateWordForm : IAlternateWordForm.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAlternateWordForm));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlternateWordForm*, Guid*, void**, int>)(lpVtbl[0]))((IAlternateWordForm*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAlternateWordForm*, uint>)(lpVtbl[1]))((IAlternateWordForm*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAlternateWordForm*, uint>)(lpVtbl[2]))((IAlternateWordForm*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlternateWordForm*, uint*, Guid**, int>)(lpVtbl[3]))((IAlternateWordForm*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlternateWordForm*, HSTRING*, int>)(lpVtbl[4]))((IAlternateWordForm*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlternateWordForm*, TrustLevel*, int>)(lpVtbl[5]))((IAlternateWordForm*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAlternateWordForm.xml' path='doc/member[@name="IAlternateWordForm.get_SourceTextSegment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceTextSegment([NativeTypeName("ABI::Windows::Data::Text::TextSegment *")] TextSegment* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlternateWordForm*, TextSegment*, int>)(lpVtbl[6]))((IAlternateWordForm*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAlternateWordForm.xml' path='doc/member[@name="IAlternateWordForm.get_AlternateText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AlternateText(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlternateWordForm*, HSTRING*, int>)(lpVtbl[7]))((IAlternateWordForm*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAlternateWordForm.xml' path='doc/member[@name="IAlternateWordForm.get_NormalizationFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NormalizationFormat([NativeTypeName("ABI::Windows::Data::Text::AlternateNormalizationFormat *")] AlternateNormalizationFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlternateWordForm*, AlternateNormalizationFormat*, int>)(lpVtbl[8]))((IAlternateWordForm*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceTextSegment([NativeTypeName("ABI::Windows::Data::Text::TextSegment *")] TextSegment* value);

        [VtblIndex(7)]
        HRESULT get_AlternateText(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_NormalizationFormat([NativeTypeName("ABI::Windows::Data::Text::AlternateNormalizationFormat *")] AlternateNormalizationFormat* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Text::TextSegment *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TextSegment*, int> get_SourceTextSegment;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_AlternateText;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Text::AlternateNormalizationFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AlternateNormalizationFormat*, int> get_NormalizationFormat;
    }
}
