// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppPrintDeviceInstallationResult.xml' path='doc/member[@name="IIppPrintDeviceInstallationResult"]/*' />
[Guid("FB102FCC-87BE-57FF-A086-92272148A256")]
[NativeTypeName("struct IIppPrintDeviceInstallationResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppPrintDeviceInstallationResult : IIppPrintDeviceInstallationResult.Interface, INativeGuid
{
    /// <include file='IIppPrintDeviceInstallationResult.xml' path='doc/member[@name="IIppPrintDeviceInstallationResult.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIppPrintDeviceInstallationResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceInstallationResult*, Guid*, void**, int>)(lpVtbl[0]))((IIppPrintDeviceInstallationResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceInstallationResult*, uint>)(lpVtbl[1]))((IIppPrintDeviceInstallationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceInstallationResult*, uint>)(lpVtbl[2]))((IIppPrintDeviceInstallationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceInstallationResult*, uint*, Guid**, int>)(lpVtbl[3]))((IIppPrintDeviceInstallationResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceInstallationResult*, HSTRING*, int>)(lpVtbl[4]))((IIppPrintDeviceInstallationResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceInstallationResult*, TrustLevel*, int>)(lpVtbl[5]))((IIppPrintDeviceInstallationResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppPrintDeviceInstallationResult.xml' path='doc/member[@name="IIppPrintDeviceInstallationResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Printers::IppPrintDeviceInstallationStatus *")] IppPrintDeviceInstallationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceInstallationResult*, IppPrintDeviceInstallationStatus*, int>)(lpVtbl[6]))((IIppPrintDeviceInstallationResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppPrintDeviceInstallationResult.xml' path='doc/member[@name="IIppPrintDeviceInstallationResult.get_InstalledPrinterName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_InstalledPrinterName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceInstallationResult*, HSTRING*, int>)(lpVtbl[7]))((IIppPrintDeviceInstallationResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppPrintDeviceInstallationResult.xml' path='doc/member[@name="IIppPrintDeviceInstallationResult.get_ExtendedError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceInstallationResult*, HRESULT*, int>)(lpVtbl[8]))((IIppPrintDeviceInstallationResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Printers::IppPrintDeviceInstallationStatus *")] IppPrintDeviceInstallationStatus* value);

        [VtblIndex(7)]
        HRESULT get_InstalledPrinterName(HSTRING* value);

        [VtblIndex(8)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IppPrintDeviceInstallationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IppPrintDeviceInstallationStatus*, int> get_Status;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_InstalledPrinterName;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT*, int> get_ExtendedError;
    }
}
