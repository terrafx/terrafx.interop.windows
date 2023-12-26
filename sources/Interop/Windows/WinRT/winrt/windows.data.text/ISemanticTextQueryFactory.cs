// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISemanticTextQueryFactory.xml' path='doc/member[@name="ISemanticTextQueryFactory"]/*' />
[Guid("238C0503-F995-4587-8777-A2B7D80ACFEF")]
[NativeTypeName("struct ISemanticTextQueryFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISemanticTextQueryFactory : ISemanticTextQueryFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISemanticTextQueryFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISemanticTextQueryFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISemanticTextQueryFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISemanticTextQueryFactory*, uint>)(lpVtbl[1]))((ISemanticTextQueryFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISemanticTextQueryFactory*, uint>)(lpVtbl[2]))((ISemanticTextQueryFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISemanticTextQueryFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISemanticTextQueryFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISemanticTextQueryFactory*, HSTRING*, int>)(lpVtbl[4]))((ISemanticTextQueryFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISemanticTextQueryFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISemanticTextQueryFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISemanticTextQueryFactory.xml' path='doc/member[@name="ISemanticTextQueryFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Data::Text::ISemanticTextQuery **")] ISemanticTextQuery** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISemanticTextQueryFactory*, HSTRING, ISemanticTextQuery**, int>)(lpVtbl[6]))((ISemanticTextQueryFactory*)Unsafe.AsPointer(ref this), aqsFilter, result);
    }

    /// <include file='ISemanticTextQueryFactory.xml' path='doc/member[@name="ISemanticTextQueryFactory.CreateWithLanguage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithLanguage(HSTRING aqsFilter, HSTRING filterLanguage, [NativeTypeName("ABI::Windows::Data::Text::ISemanticTextQuery **")] ISemanticTextQuery** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISemanticTextQueryFactory*, HSTRING, HSTRING, ISemanticTextQuery**, int>)(lpVtbl[7]))((ISemanticTextQueryFactory*)Unsafe.AsPointer(ref this), aqsFilter, filterLanguage, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING aqsFilter, [NativeTypeName("ABI::Windows::Data::Text::ISemanticTextQuery **")] ISemanticTextQuery** result);

        [VtblIndex(7)]
        HRESULT CreateWithLanguage(HSTRING aqsFilter, HSTRING filterLanguage, [NativeTypeName("ABI::Windows::Data::Text::ISemanticTextQuery **")] ISemanticTextQuery** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Text::ISemanticTextQuery **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISemanticTextQuery**, int> Create;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Data::Text::ISemanticTextQuery **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, ISemanticTextQuery**, int> CreateWithLanguage;
    }
}
