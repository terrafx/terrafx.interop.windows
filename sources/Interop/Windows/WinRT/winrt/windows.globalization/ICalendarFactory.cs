// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICalendarFactory.xml' path='doc/member[@name="ICalendarFactory"]/*' />
[Guid("83F58412-E56B-4C75-A66E-0F63D57758A6")]
[NativeTypeName("struct ICalendarFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICalendarFactory : ICalendarFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICalendarFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICalendarFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarFactory*, uint>)(lpVtbl[1]))((ICalendarFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarFactory*, uint>)(lpVtbl[2]))((ICalendarFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICalendarFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarFactory*, HSTRING*, int>)(lpVtbl[4]))((ICalendarFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICalendarFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICalendarFactory.xml' path='doc/member[@name="ICalendarFactory.CreateCalendarDefaultCalendarAndClock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCalendarDefaultCalendarAndClock([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* languages, [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarFactory*, IIterable<HSTRING>*, ICalendar**, int>)(lpVtbl[6]))((ICalendarFactory*)Unsafe.AsPointer(ref this), languages, result);
    }

    /// <include file='ICalendarFactory.xml' path='doc/member[@name="ICalendarFactory.CreateCalendar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateCalendar([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* languages, HSTRING calendar, HSTRING clock, [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICalendarFactory*, IIterable<HSTRING>*, HSTRING, HSTRING, ICalendar**, int>)(lpVtbl[7]))((ICalendarFactory*)Unsafe.AsPointer(ref this), languages, calendar, clock, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateCalendarDefaultCalendarAndClock([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* languages, [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar** result);

        [VtblIndex(7)]
        HRESULT CreateCalendar([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* languages, HSTRING calendar, HSTRING clock, [NativeTypeName("ABI::Windows::Globalization::ICalendar **")] ICalendar** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Globalization::ICalendar **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, ICalendar**, int> CreateCalendarDefaultCalendarAndClock;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, HSTRING, HSTRING, ABI::Windows::Globalization::ICalendar **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, HSTRING, HSTRING, ICalendar**, int> CreateCalendar;
    }
}
