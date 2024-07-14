// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGpioPinProviderValueChangedEventArgs.xml' path='doc/member[@name="IGpioPinProviderValueChangedEventArgs"]/*' />
[Guid("32A6D6F2-3D5B-44CD-8FBE-13A69F2EDB24")]
[NativeTypeName("struct IGpioPinProviderValueChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioPinProviderValueChangedEventArgs : IGpioPinProviderValueChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioPinProviderValueChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProviderValueChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IGpioPinProviderValueChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProviderValueChangedEventArgs*, uint>)(lpVtbl[1]))((IGpioPinProviderValueChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProviderValueChangedEventArgs*, uint>)(lpVtbl[2]))((IGpioPinProviderValueChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProviderValueChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IGpioPinProviderValueChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProviderValueChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IGpioPinProviderValueChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProviderValueChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IGpioPinProviderValueChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGpioPinProviderValueChangedEventArgs.xml' path='doc/member[@name="IGpioPinProviderValueChangedEventArgs.get_Edge"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Edge([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinEdge *")] ProviderGpioPinEdge* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGpioPinProviderValueChangedEventArgs*, ProviderGpioPinEdge*, int>)(lpVtbl[6]))((IGpioPinProviderValueChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Edge([NativeTypeName("ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinEdge *")] ProviderGpioPinEdge* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Gpio::Provider::ProviderGpioPinEdge *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ProviderGpioPinEdge*, int> get_Edge;
    }
}
