// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics"]/*' />
[Guid("80653F68-2CB2-4C1F-B590-F0F52BF4FD1A")]
[NativeTypeName("struct ICalendarIdentifiersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICalendarIdentifiersStatics : ICalendarIdentifiersStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICalendarIdentifiersStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, uint>)(lpVtbl[1]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, uint>)(lpVtbl[2]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[4]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics.get_Gregorian"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Gregorian(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[6]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics.get_Hebrew"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Hebrew(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[7]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics.get_Hijri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Hijri(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[8]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics.get_Japanese"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Japanese(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[9]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics.get_Julian"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Julian(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[10]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics.get_Korean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Korean(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[11]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics.get_Taiwan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Taiwan(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[12]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics.get_Thai"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Thai(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[13]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICalendarIdentifiersStatics.xml' path='doc/member[@name="ICalendarIdentifiersStatics.get_UmAlQura"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_UmAlQura(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarIdentifiersStatics*, HSTRING*, int>)(lpVtbl[14]))((ICalendarIdentifiersStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Gregorian(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Hebrew(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Hijri(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Japanese(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Julian(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Korean(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Taiwan(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_Thai(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_UmAlQura(HSTRING* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Gregorian;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Hebrew;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Hijri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Japanese;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Julian;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Korean;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Taiwan;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Thai;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UmAlQura;
    }
}
