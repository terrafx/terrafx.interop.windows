// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IReplaceDevicePropertiesResult.xml' path='doc/member[@name="IReplaceDevicePropertiesResult"]/*' />
[Guid("12FECA4B-D973-57E1-826B-F75B9518A9F1")]
[NativeTypeName("struct IReplaceDevicePropertiesResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IReplaceDevicePropertiesResult : IReplaceDevicePropertiesResult.Interface, INativeGuid
{
    /// <include file='IReplaceDevicePropertiesResult.xml' path='doc/member[@name="IReplaceDevicePropertiesResult.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IReplaceDevicePropertiesResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceDevicePropertiesResult*, Guid*, void**, int>)(lpVtbl[0]))((IReplaceDevicePropertiesResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceDevicePropertiesResult*, uint>)(lpVtbl[1]))((IReplaceDevicePropertiesResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceDevicePropertiesResult*, uint>)(lpVtbl[2]))((IReplaceDevicePropertiesResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceDevicePropertiesResult*, uint*, Guid**, int>)(lpVtbl[3]))((IReplaceDevicePropertiesResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceDevicePropertiesResult*, HSTRING*, int>)(lpVtbl[4]))((IReplaceDevicePropertiesResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceDevicePropertiesResult*, TrustLevel*, int>)(lpVtbl[5]))((IReplaceDevicePropertiesResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IReplaceDevicePropertiesResult.xml' path='doc/member[@name="IReplaceDevicePropertiesResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Printers::ReplaceDevicePropertiesStatus *")] ReplaceDevicePropertiesStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceDevicePropertiesResult*, ReplaceDevicePropertiesStatus*, int>)(lpVtbl[6]))((IReplaceDevicePropertiesResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IReplaceDevicePropertiesResult.xml' path='doc/member[@name="IReplaceDevicePropertiesResult.get_ExtendedError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IReplaceDevicePropertiesResult*, HRESULT*, int>)(lpVtbl[7]))((IReplaceDevicePropertiesResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Printers::ReplaceDevicePropertiesStatus *")] ReplaceDevicePropertiesStatus* value);

        [VtblIndex(7)]
        HRESULT get_ExtendedError(HRESULT* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::ReplaceDevicePropertiesStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ReplaceDevicePropertiesStatus*, int> get_Status;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT*, int> get_ExtendedError;
    }
}
