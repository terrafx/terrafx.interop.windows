// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectivityInterval.xml' path='doc/member[@name="IConnectivityInterval"]/*' />
[Guid("4FAA3FFF-6746-4824-A964-EED8E87F8709")]
[NativeTypeName("struct IConnectivityInterval : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IConnectivityInterval : IConnectivityInterval.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectivityInterval));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityInterval*, Guid*, void**, int>)(lpVtbl[0]))((IConnectivityInterval*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityInterval*, uint>)(lpVtbl[1]))((IConnectivityInterval*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityInterval*, uint>)(lpVtbl[2]))((IConnectivityInterval*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityInterval*, uint*, Guid**, int>)(lpVtbl[3]))((IConnectivityInterval*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityInterval*, HSTRING*, int>)(lpVtbl[4]))((IConnectivityInterval*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityInterval*, TrustLevel*, int>)(lpVtbl[5]))((IConnectivityInterval*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IConnectivityInterval.xml' path='doc/member[@name="IConnectivityInterval.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* startTime)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityInterval*, WinRTDateTime*, int>)(lpVtbl[6]))((IConnectivityInterval*)Unsafe.AsPointer(ref this), startTime);
    }

    /// <include file='IConnectivityInterval.xml' path='doc/member[@name="IConnectivityInterval.get_ConnectionDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* duration)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectivityInterval*, TimeSpan*, int>)(lpVtbl[7]))((IConnectivityInterval*)Unsafe.AsPointer(ref this), duration);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* startTime);

        [VtblIndex(7)]
        HRESULT get_ConnectionDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* duration);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_ConnectionDuration;
    }
}
