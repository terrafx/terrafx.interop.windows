// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITextReverseConversionGeneratorFactory.xml' path='doc/member[@name="ITextReverseConversionGeneratorFactory"]/*' />
[Guid("63BED326-1FDA-41F6-89D5-23DDEA3C729A")]
[NativeTypeName("struct ITextReverseConversionGeneratorFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITextReverseConversionGeneratorFactory : ITextReverseConversionGeneratorFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextReverseConversionGeneratorFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextReverseConversionGeneratorFactory*, Guid*, void**, int>)(lpVtbl[0]))((ITextReverseConversionGeneratorFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextReverseConversionGeneratorFactory*, uint>)(lpVtbl[1]))((ITextReverseConversionGeneratorFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITextReverseConversionGeneratorFactory*, uint>)(lpVtbl[2]))((ITextReverseConversionGeneratorFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextReverseConversionGeneratorFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ITextReverseConversionGeneratorFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextReverseConversionGeneratorFactory*, HSTRING*, int>)(lpVtbl[4]))((ITextReverseConversionGeneratorFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextReverseConversionGeneratorFactory*, TrustLevel*, int>)(lpVtbl[5]))((ITextReverseConversionGeneratorFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITextReverseConversionGeneratorFactory.xml' path='doc/member[@name="ITextReverseConversionGeneratorFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING languageTag, [NativeTypeName("ABI::Windows::Data::Text::ITextReverseConversionGenerator **")] ITextReverseConversionGenerator** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITextReverseConversionGeneratorFactory*, HSTRING, ITextReverseConversionGenerator**, int>)(lpVtbl[6]))((ITextReverseConversionGeneratorFactory*)Unsafe.AsPointer(ref this), languageTag, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING languageTag, [NativeTypeName("ABI::Windows::Data::Text::ITextReverseConversionGenerator **")] ITextReverseConversionGenerator** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Text::ITextReverseConversionGenerator **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ITextReverseConversionGenerator**, int> Create;
    }
}
