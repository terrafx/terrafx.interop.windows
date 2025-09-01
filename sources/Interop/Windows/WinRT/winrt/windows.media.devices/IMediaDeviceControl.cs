// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaDeviceControl.xml' path='doc/member[@name="IMediaDeviceControl"]/*' />
[Guid("EFA8DFA9-6F75-4863-BA0B-583F3036B4DE")]
[NativeTypeName("struct IMediaDeviceControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaDeviceControl : IMediaDeviceControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMediaDeviceControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, Guid*, void**, int>)(lpVtbl[0]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, uint>)(lpVtbl[1]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, uint>)(lpVtbl[2]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, HSTRING*, int>)(lpVtbl[4]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, TrustLevel*, int>)(lpVtbl[5]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaDeviceControl.xml' path='doc/member[@name="IMediaDeviceControl.get_Capabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Capabilities([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControlCapabilities **")] IMediaDeviceControlCapabilities** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, IMediaDeviceControlCapabilities**, int>)(lpVtbl[6]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaDeviceControl.xml' path='doc/member[@name="IMediaDeviceControl.TryGetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryGetValue(double* value, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, double*, byte*, int>)(lpVtbl[7]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this), value, succeeded);
    }

    /// <include file='IMediaDeviceControl.xml' path='doc/member[@name="IMediaDeviceControl.TrySetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TrySetValue(double value, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, double, byte*, int>)(lpVtbl[8]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this), value, succeeded);
    }

    /// <include file='IMediaDeviceControl.xml' path='doc/member[@name="IMediaDeviceControl.TryGetAuto"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryGetAuto([NativeTypeName("boolean *")] byte* value, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, byte*, byte*, int>)(lpVtbl[9]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this), value, succeeded);
    }

    /// <include file='IMediaDeviceControl.xml' path='doc/member[@name="IMediaDeviceControl.TrySetAuto"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TrySetAuto([NativeTypeName("boolean")] byte value, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaDeviceControl*, byte, byte*, int>)(lpVtbl[10]))((IMediaDeviceControl*)Unsafe.AsPointer(ref this), value, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Capabilities([NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControlCapabilities **")] IMediaDeviceControlCapabilities** value);

        [VtblIndex(7)]
        HRESULT TryGetValue(double* value, [NativeTypeName("boolean *")] byte* succeeded);

        [VtblIndex(8)]
        HRESULT TrySetValue(double value, [NativeTypeName("boolean *")] byte* succeeded);

        [VtblIndex(9)]
        HRESULT TryGetAuto([NativeTypeName("boolean *")] byte* value, [NativeTypeName("boolean *")] byte* succeeded);

        [VtblIndex(10)]
        HRESULT TrySetAuto([NativeTypeName("boolean")] byte value, [NativeTypeName("boolean *")] byte* succeeded);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControlCapabilities **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaDeviceControlCapabilities**, int> get_Capabilities;

        [NativeTypeName("HRESULT (DOUBLE *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, byte*, int> TryGetValue;

        [NativeTypeName("HRESULT (DOUBLE, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, byte*, int> TrySetValue;

        [NativeTypeName("HRESULT (boolean *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, byte*, int> TryGetAuto;

        [NativeTypeName("HRESULT (boolean, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, byte*, int> TrySetAuto;
    }
}
