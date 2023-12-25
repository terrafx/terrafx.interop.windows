// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWakeOnApproachOptions.xml' path='doc/member[@name="IWakeOnApproachOptions"]/*' />
[Guid("F0B87AE7-7E1F-5EA5-814D-6B7E07DEFC2B")]
[NativeTypeName("struct IWakeOnApproachOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWakeOnApproachOptions : IWakeOnApproachOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWakeOnApproachOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, Guid*, void**, int>)(lpVtbl[0]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, uint>)(lpVtbl[1]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, uint>)(lpVtbl[2]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, HSTRING*, int>)(lpVtbl[4]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, TrustLevel*, int>)(lpVtbl[5]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWakeOnApproachOptions.xml' path='doc/member[@name="IWakeOnApproachOptions.get_AllowWhenExternalDisplayConnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllowWhenExternalDisplayConnected([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, byte*, int>)(lpVtbl[6]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWakeOnApproachOptions.xml' path='doc/member[@name="IWakeOnApproachOptions.put_AllowWhenExternalDisplayConnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllowWhenExternalDisplayConnected([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, byte, int>)(lpVtbl[7]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWakeOnApproachOptions.xml' path='doc/member[@name="IWakeOnApproachOptions.get_DisableWhenBatterySaverOn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisableWhenBatterySaverOn([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, byte*, int>)(lpVtbl[8]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWakeOnApproachOptions.xml' path='doc/member[@name="IWakeOnApproachOptions.put_DisableWhenBatterySaverOn"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisableWhenBatterySaverOn([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWakeOnApproachOptions*, byte, int>)(lpVtbl[9]))((IWakeOnApproachOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllowWhenExternalDisplayConnected([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AllowWhenExternalDisplayConnected([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_DisableWhenBatterySaverOn([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_DisableWhenBatterySaverOn([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowWhenExternalDisplayConnected;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowWhenExternalDisplayConnected;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DisableWhenBatterySaverOn;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_DisableWhenBatterySaverOn;
    }
}
