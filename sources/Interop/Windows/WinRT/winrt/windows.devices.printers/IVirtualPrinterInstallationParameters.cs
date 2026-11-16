// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters"]/*' />
[Guid("BBC159B3-12F3-584C-8D26-B22C0DC83241")]
[NativeTypeName("struct IVirtualPrinterInstallationParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVirtualPrinterInstallationParameters : IVirtualPrinterInstallationParameters.Interface, INativeGuid
{
    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVirtualPrinterInstallationParameters);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, Guid*, void**, int>)(lpVtbl[0]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, uint>)(lpVtbl[1]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, uint>)(lpVtbl[2]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, uint*, Guid**, int>)(lpVtbl[3]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, HSTRING*, int>)(lpVtbl[4]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, TrustLevel*, int>)(lpVtbl[5]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.get_PrinterName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PrinterName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, HSTRING*, int>)(lpVtbl[6]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.put_PrinterName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PrinterName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, HSTRING, int>)(lpVtbl[7]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.get_OutputFileExtensions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutputFileExtensions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, IVector<HSTRING>**, int>)(lpVtbl[8]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.get_SupportedInputFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SupportedInputFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CVirtualPrinterSupportedFormat_t **")] IVector<Pointer<IVirtualPrinterSupportedFormat>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, IVector<Pointer<IVirtualPrinterSupportedFormat>>**, int>)(lpVtbl[9]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.get_PrintDeviceCapabilitiesPackageRelativeFilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PrintDeviceCapabilitiesPackageRelativeFilePath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, HSTRING*, int>)(lpVtbl[10]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.put_PrintDeviceCapabilitiesPackageRelativeFilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PrintDeviceCapabilitiesPackageRelativeFilePath(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, HSTRING, int>)(lpVtbl[11]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.get_PrintDeviceResourcesPackageRelativeFilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PrintDeviceResourcesPackageRelativeFilePath(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, HSTRING*, int>)(lpVtbl[12]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.put_PrintDeviceResourcesPackageRelativeFilePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PrintDeviceResourcesPackageRelativeFilePath(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, HSTRING, int>)(lpVtbl[13]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.get_PreferredInputFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PreferredInputFormat([NativeTypeName("ABI::Windows::Devices::Printers::VirtualPrinterPreferredInputFormat *")] VirtualPrinterPreferredInputFormat* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, VirtualPrinterPreferredInputFormat*, int>)(lpVtbl[14]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.put_PreferredInputFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_PreferredInputFormat([NativeTypeName("ABI::Windows::Devices::Printers::VirtualPrinterPreferredInputFormat")] VirtualPrinterPreferredInputFormat value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, VirtualPrinterPreferredInputFormat, int>)(lpVtbl[15]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.get_PrinterUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_PrinterUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, IUriRuntimeClass**, int>)(lpVtbl[16]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.put_PrinterUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_PrinterUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, IUriRuntimeClass*, int>)(lpVtbl[17]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.get_EntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_EntryPoint(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, HSTRING*, int>)(lpVtbl[18]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterInstallationParameters.xml' path='doc/member[@name="IVirtualPrinterInstallationParameters.put_EntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_EntryPoint(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterInstallationParameters*, HSTRING, int>)(lpVtbl[19]))((IVirtualPrinterInstallationParameters*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PrinterName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_PrinterName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_OutputFileExtensions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(9)]
        HRESULT get_SupportedInputFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CVirtualPrinterSupportedFormat_t **")] IVector<Pointer<IVirtualPrinterSupportedFormat>>** value);

        [VtblIndex(10)]
        HRESULT get_PrintDeviceCapabilitiesPackageRelativeFilePath(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_PrintDeviceCapabilitiesPackageRelativeFilePath(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_PrintDeviceResourcesPackageRelativeFilePath(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_PrintDeviceResourcesPackageRelativeFilePath(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_PreferredInputFormat([NativeTypeName("ABI::Windows::Devices::Printers::VirtualPrinterPreferredInputFormat *")] VirtualPrinterPreferredInputFormat* value);

        [VtblIndex(15)]
        HRESULT put_PreferredInputFormat([NativeTypeName("ABI::Windows::Devices::Printers::VirtualPrinterPreferredInputFormat")] VirtualPrinterPreferredInputFormat value);

        [VtblIndex(16)]
        HRESULT get_PrinterUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(17)]
        HRESULT put_PrinterUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(18)]
        HRESULT get_EntryPoint(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_EntryPoint(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PrinterName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PrinterName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_OutputFileExtensions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CVirtualPrinterSupportedFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IVirtualPrinterSupportedFormat>>**, int> get_SupportedInputFormats;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PrintDeviceCapabilitiesPackageRelativeFilePath;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PrintDeviceCapabilitiesPackageRelativeFilePath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PrintDeviceResourcesPackageRelativeFilePath;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_PrintDeviceResourcesPackageRelativeFilePath;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::VirtualPrinterPreferredInputFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualPrinterPreferredInputFormat*, int> get_PreferredInputFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::VirtualPrinterPreferredInputFormat) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VirtualPrinterPreferredInputFormat, int> put_PreferredInputFormat;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_PrinterUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_PrinterUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EntryPoint;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_EntryPoint;
    }
}
