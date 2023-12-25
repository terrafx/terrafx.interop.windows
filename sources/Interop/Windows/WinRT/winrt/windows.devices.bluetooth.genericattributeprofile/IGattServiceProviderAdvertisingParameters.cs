// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceProviderAdvertisingParameters.xml' path='doc/member[@name="IGattServiceProviderAdvertisingParameters"]/*' />
[Guid("E2CE31AB-6315-4C22-9BD7-781DBC3D8D82")]
[NativeTypeName("struct IGattServiceProviderAdvertisingParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProviderAdvertisingParameters : IGattServiceProviderAdvertisingParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceProviderAdvertisingParameters));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, uint>)(lpVtbl[1]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, uint>)(lpVtbl[2]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceProviderAdvertisingParameters.xml' path='doc/member[@name="IGattServiceProviderAdvertisingParameters.put_IsConnectable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsConnectable([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, byte, int>)(lpVtbl[6]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderAdvertisingParameters.xml' path='doc/member[@name="IGattServiceProviderAdvertisingParameters.get_IsConnectable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsConnectable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, byte*, int>)(lpVtbl[7]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderAdvertisingParameters.xml' path='doc/member[@name="IGattServiceProviderAdvertisingParameters.put_IsDiscoverable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsDiscoverable([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, byte, int>)(lpVtbl[8]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceProviderAdvertisingParameters.xml' path='doc/member[@name="IGattServiceProviderAdvertisingParameters.get_IsDiscoverable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsDiscoverable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceProviderAdvertisingParameters*, byte*, int>)(lpVtbl[9]))((IGattServiceProviderAdvertisingParameters*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsConnectable([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_IsConnectable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_IsDiscoverable([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_IsDiscoverable([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsConnectable;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsConnectable;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsDiscoverable;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsDiscoverable;
    }
}
