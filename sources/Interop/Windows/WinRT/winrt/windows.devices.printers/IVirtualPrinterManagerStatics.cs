// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics"]/*' />
[Guid("141084B6-6702-5B5F-83DA-C75891657554")]
[NativeTypeName("struct IVirtualPrinterManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVirtualPrinterManagerStatics : IVirtualPrinterManagerStatics.Interface, INativeGuid
{
    /// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVirtualPrinterManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, uint>)(lpVtbl[1]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, uint>)(lpVtbl[2]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics.InstallVirtualPrinterAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InstallVirtualPrinterAsync([NativeTypeName("ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *")] IVirtualPrinterInstallationParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **")] IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, IVirtualPrinterInstallationParameters*, IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>**, int>)(lpVtbl[6]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), parameters, operation);
    }

    /// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics.InstallVirtualPrinterAsync2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InstallVirtualPrinterAsync2([NativeTypeName("ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *")] IVirtualPrinterInstallationParameters* parameters, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **")] IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, IVirtualPrinterInstallationParameters*, HSTRING, IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>**, int>)(lpVtbl[7]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), parameters, appPackageFamilyName, operation);
    }

    /// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics.InstallVirtualPrinterForAllUsersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InstallVirtualPrinterForAllUsersAsync([NativeTypeName("ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *")] IVirtualPrinterInstallationParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **")] IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, IVirtualPrinterInstallationParameters*, IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>**, int>)(lpVtbl[8]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), parameters, operation);
    }

    /// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics.InstallVirtualPrinterForAllUsersAsync2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InstallVirtualPrinterForAllUsersAsync2([NativeTypeName("ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *")] IVirtualPrinterInstallationParameters* parameters, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **")] IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, IVirtualPrinterInstallationParameters*, HSTRING, IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>**, int>)(lpVtbl[9]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), parameters, appPackageFamilyName, operation);
    }

    /// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics.FindAllVirtualPrinters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindAllVirtualPrinters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, IVectorView<HSTRING>**, int>)(lpVtbl[10]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics.FindAllVirtualPrinters2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindAllVirtualPrinters2(HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, HSTRING, IVectorView<HSTRING>**, int>)(lpVtbl[11]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), appPackageFamilyName, result);
    }

    /// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics.RemoveVirtualPrinterAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveVirtualPrinterAsync(HSTRING printerName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[12]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), printerName, operation);
    }

    /// <include file='IVirtualPrinterManagerStatics.xml' path='doc/member[@name="IVirtualPrinterManagerStatics.RemoveVirtualPrinterForAllUsersAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RemoveVirtualPrinterForAllUsersAsync(HSTRING printerName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterManagerStatics*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[13]))((IVirtualPrinterManagerStatics*)Unsafe.AsPointer(ref this), printerName, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InstallVirtualPrinterAsync([NativeTypeName("ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *")] IVirtualPrinterInstallationParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **")] IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>** operation);

        [VtblIndex(7)]
        HRESULT InstallVirtualPrinterAsync2([NativeTypeName("ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *")] IVirtualPrinterInstallationParameters* parameters, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **")] IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>** operation);

        [VtblIndex(8)]
        HRESULT InstallVirtualPrinterForAllUsersAsync([NativeTypeName("ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *")] IVirtualPrinterInstallationParameters* parameters, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **")] IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>** operation);

        [VtblIndex(9)]
        HRESULT InstallVirtualPrinterForAllUsersAsync2([NativeTypeName("ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *")] IVirtualPrinterInstallationParameters* parameters, HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **")] IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>** operation);

        [VtblIndex(10)]
        HRESULT FindAllVirtualPrinters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** result);

        [VtblIndex(11)]
        HRESULT FindAllVirtualPrinters2(HSTRING appPackageFamilyName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** result);

        [VtblIndex(12)]
        HRESULT RemoveVirtualPrinterAsync(HSTRING printerName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(13)]
        HRESULT RemoveVirtualPrinterForAllUsersAsync(HSTRING printerName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVirtualPrinterInstallationParameters*, IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>**, int> InstallVirtualPrinterAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVirtualPrinterInstallationParameters*, HSTRING, IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>**, int> InstallVirtualPrinterAsync2;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVirtualPrinterInstallationParameters*, IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>**, int> InstallVirtualPrinterForAllUsersAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IVirtualPrinterInstallationParameters *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CPrinters__CVirtualPrinterInstallationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVirtualPrinterInstallationParameters*, HSTRING, IAsyncOperation<Pointer<IVirtualPrinterInstallationResult>>**, int> InstallVirtualPrinterForAllUsersAsync2;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> FindAllVirtualPrinters;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVectorView<HSTRING>**, int> FindAllVirtualPrinters2;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<bool>**, int> RemoveVirtualPrinterAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<bool>**, int> RemoveVirtualPrinterForAllUsersAsync;
    }
}
