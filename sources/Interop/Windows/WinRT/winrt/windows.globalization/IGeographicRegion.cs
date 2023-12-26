// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGeographicRegion.xml' path='doc/member[@name="IGeographicRegion"]/*' />
[Guid("01E9A621-4A64-4ED9-954F-9EDEB07BD903")]
[NativeTypeName("struct IGeographicRegion : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeographicRegion : IGeographicRegion.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeographicRegion));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, Guid*, void**, int>)(lpVtbl[0]))((IGeographicRegion*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, uint>)(lpVtbl[1]))((IGeographicRegion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, uint>)(lpVtbl[2]))((IGeographicRegion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, uint*, Guid**, int>)(lpVtbl[3]))((IGeographicRegion*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, HSTRING*, int>)(lpVtbl[4]))((IGeographicRegion*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, TrustLevel*, int>)(lpVtbl[5]))((IGeographicRegion*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGeographicRegion.xml' path='doc/member[@name="IGeographicRegion.get_Code"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Code(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, HSTRING*, int>)(lpVtbl[6]))((IGeographicRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeographicRegion.xml' path='doc/member[@name="IGeographicRegion.get_CodeTwoLetter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CodeTwoLetter(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, HSTRING*, int>)(lpVtbl[7]))((IGeographicRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeographicRegion.xml' path='doc/member[@name="IGeographicRegion.get_CodeThreeLetter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CodeThreeLetter(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, HSTRING*, int>)(lpVtbl[8]))((IGeographicRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeographicRegion.xml' path='doc/member[@name="IGeographicRegion.get_CodeThreeDigit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CodeThreeDigit(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, HSTRING*, int>)(lpVtbl[9]))((IGeographicRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeographicRegion.xml' path='doc/member[@name="IGeographicRegion.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, HSTRING*, int>)(lpVtbl[10]))((IGeographicRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeographicRegion.xml' path='doc/member[@name="IGeographicRegion.get_NativeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NativeName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, HSTRING*, int>)(lpVtbl[11]))((IGeographicRegion*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGeographicRegion.xml' path='doc/member[@name="IGeographicRegion.get_CurrenciesInUse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CurrenciesInUse([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGeographicRegion*, IVectorView<HSTRING>**, int>)(lpVtbl[12]))((IGeographicRegion*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Code(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_CodeTwoLetter(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_CodeThreeLetter(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_CodeThreeDigit(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_NativeName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_CurrenciesInUse([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Code;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CodeTwoLetter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CodeThreeLetter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CodeThreeDigit;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NativeName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_CurrenciesInUse;
    }
}
