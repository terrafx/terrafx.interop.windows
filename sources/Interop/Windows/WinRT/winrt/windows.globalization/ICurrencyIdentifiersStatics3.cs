// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICurrencyIdentifiersStatics3.xml' path='doc/member[@name="ICurrencyIdentifiersStatics3"]/*' />
[Guid("4FB23BFA-ED25-4F4D-857F-237F1748C21C")]
[NativeTypeName("struct ICurrencyIdentifiersStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICurrencyIdentifiersStatics3 : ICurrencyIdentifiersStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICurrencyIdentifiersStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, Guid*, void**, int>)(lpVtbl[0]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, uint>)(lpVtbl[1]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, uint>)(lpVtbl[2]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, HSTRING*, int>)(lpVtbl[4]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, TrustLevel*, int>)(lpVtbl[5]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICurrencyIdentifiersStatics3.xml' path='doc/member[@name="ICurrencyIdentifiersStatics3.get_MRU"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MRU(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, HSTRING*, int>)(lpVtbl[6]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics3.xml' path='doc/member[@name="ICurrencyIdentifiersStatics3.get_SSP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SSP(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, HSTRING*, int>)(lpVtbl[7]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics3.xml' path='doc/member[@name="ICurrencyIdentifiersStatics3.get_STN"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_STN(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, HSTRING*, int>)(lpVtbl[8]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICurrencyIdentifiersStatics3.xml' path='doc/member[@name="ICurrencyIdentifiersStatics3.get_VES"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VES(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICurrencyIdentifiersStatics3*, HSTRING*, int>)(lpVtbl[9]))((ICurrencyIdentifiersStatics3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MRU(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_SSP(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_STN(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_VES(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MRU;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SSP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_STN;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_VES;
    }
}
