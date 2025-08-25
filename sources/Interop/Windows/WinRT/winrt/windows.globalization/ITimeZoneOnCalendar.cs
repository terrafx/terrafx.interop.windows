// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimeZoneOnCalendar.xml' path='doc/member[@name="ITimeZoneOnCalendar"]/*' />
[Guid("BB3C25E5-46CF-4317-A3F5-02621AD54478")]
[NativeTypeName("struct ITimeZoneOnCalendar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimeZoneOnCalendar : ITimeZoneOnCalendar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ITimeZoneOnCalendar);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, Guid*, void**, int>)(lpVtbl[0]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, uint>)(lpVtbl[1]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, uint>)(lpVtbl[2]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, uint*, Guid**, int>)(lpVtbl[3]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, HSTRING*, int>)(lpVtbl[4]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, TrustLevel*, int>)(lpVtbl[5]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimeZoneOnCalendar.xml' path='doc/member[@name="ITimeZoneOnCalendar.GetTimeZone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTimeZone(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, HSTRING*, int>)(lpVtbl[6]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ITimeZoneOnCalendar.xml' path='doc/member[@name="ITimeZoneOnCalendar.ChangeTimeZone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ChangeTimeZone(HSTRING timeZoneId)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, HSTRING, int>)(lpVtbl[7]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this), timeZoneId);
    }

    /// <include file='ITimeZoneOnCalendar.xml' path='doc/member[@name="ITimeZoneOnCalendar.TimeZoneAsFullString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TimeZoneAsFullString(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, HSTRING*, int>)(lpVtbl[8]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ITimeZoneOnCalendar.xml' path='doc/member[@name="ITimeZoneOnCalendar.TimeZoneAsString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TimeZoneAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimeZoneOnCalendar*, int, HSTRING*, int>)(lpVtbl[9]))((ITimeZoneOnCalendar*)Unsafe.AsPointer(ref this), idealLength, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetTimeZone(HSTRING* value);

        [VtblIndex(7)]
        HRESULT ChangeTimeZone(HSTRING timeZoneId);

        [VtblIndex(8)]
        HRESULT TimeZoneAsFullString(HSTRING* result);

        [VtblIndex(9)]
        HRESULT TimeZoneAsString([NativeTypeName("INT32")] int idealLength, HSTRING* result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetTimeZone;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ChangeTimeZone;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> TimeZoneAsFullString;

        [NativeTypeName("HRESULT (INT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, HSTRING*, int> TimeZoneAsString;
    }
}
