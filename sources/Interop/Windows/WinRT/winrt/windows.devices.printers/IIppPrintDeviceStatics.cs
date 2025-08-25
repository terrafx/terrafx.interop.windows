// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppPrintDeviceStatics.xml' path='doc/member[@name="IIppPrintDeviceStatics"]/*' />
[Guid("7DC19F08-7F20-52AB-94A7-894B83B2A17E")]
[NativeTypeName("struct IIppPrintDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppPrintDeviceStatics : IIppPrintDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIppPrintDeviceStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, uint>)(lpVtbl[1]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, uint>)(lpVtbl[2]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppPrintDeviceStatics.xml' path='doc/member[@name="IIppPrintDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, HSTRING*, int>)(lpVtbl[6]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppPrintDeviceStatics.xml' path='doc/member[@name="IIppPrintDeviceStatics.FromId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromId(HSTRING deviceId, [NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, HSTRING, IIppPrintDevice**, int>)(lpVtbl[7]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this), deviceId, result);
    }

    /// <include file='IIppPrintDeviceStatics.xml' path='doc/member[@name="IIppPrintDeviceStatics.FromPrinterName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromPrinterName(HSTRING printerName, [NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, HSTRING, IIppPrintDevice**, int>)(lpVtbl[8]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this), printerName, result);
    }

    /// <include file='IIppPrintDeviceStatics.xml' path='doc/member[@name="IIppPrintDeviceStatics.IsIppPrinter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsIppPrinter(HSTRING printerName, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDeviceStatics*, HSTRING, byte*, int>)(lpVtbl[9]))((IIppPrintDeviceStatics*)Unsafe.AsPointer(ref this), printerName, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector(HSTRING* result);

        [VtblIndex(7)]
        HRESULT FromId(HSTRING deviceId, [NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** result);

        [VtblIndex(8)]
        HRESULT FromPrinterName(HSTRING printerName, [NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** result);

        [VtblIndex(9)]
        HRESULT IsIppPrinter(HSTRING printerName, [NativeTypeName("boolean *")] byte* result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppPrintDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIppPrintDevice**, int> FromId;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppPrintDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IIppPrintDevice**, int> FromPrinterName;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> IsIppPrinter;
    }
}
