// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppPrintDevice4.xml' path='doc/member[@name="IIppPrintDevice4"]/*' />
[Guid("8C48247E-E869-59FB-BC6D-DAEA0614F93E")]
[NativeTypeName("struct IIppPrintDevice4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppPrintDevice4 : IIppPrintDevice4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppPrintDevice4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, Guid*, void**, int>)(lpVtbl[0]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, uint>)(lpVtbl[1]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, uint>)(lpVtbl[2]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, uint*, Guid**, int>)(lpVtbl[3]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, HSTRING*, int>)(lpVtbl[4]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, TrustLevel*, int>)(lpVtbl[5]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppPrintDevice4.xml' path='doc/member[@name="IIppPrintDevice4.get_DeviceKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceKind([NativeTypeName("ABI::Windows::Devices::Printers::IppPrintDeviceKind *")] IppPrintDeviceKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, IppPrintDeviceKind*, int>)(lpVtbl[6]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppPrintDevice4.xml' path='doc/member[@name="IIppPrintDevice4.get_CanModifyUserDefaultPrintTicket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CanModifyUserDefaultPrintTicket([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, byte*, int>)(lpVtbl[7]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppPrintDevice4.xml' path='doc/member[@name="IIppPrintDevice4.get_UserDefaultPrintTicket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UserDefaultPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, IWorkflowPrintTicket**, int>)(lpVtbl[8]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppPrintDevice4.xml' path='doc/member[@name="IIppPrintDevice4.put_UserDefaultPrintTicket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_UserDefaultPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, IWorkflowPrintTicket*, int>)(lpVtbl[9]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppPrintDevice4.xml' path='doc/member[@name="IIppPrintDevice4.RefreshPrintDeviceCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RefreshPrintDeviceCapabilities()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, int>)(lpVtbl[10]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIppPrintDevice4.xml' path='doc/member[@name="IIppPrintDevice4.GetMaxSupportedPdlVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMaxSupportedPdlVersion(HSTRING pdlContentType, HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice4*, HSTRING, HSTRING*, int>)(lpVtbl[11]))((IIppPrintDevice4*)Unsafe.AsPointer(ref this), pdlContentType, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceKind([NativeTypeName("ABI::Windows::Devices::Printers::IppPrintDeviceKind *")] IppPrintDeviceKind* value);

        [VtblIndex(7)]
        HRESULT get_CanModifyUserDefaultPrintTicket([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_UserDefaultPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** value);

        [VtblIndex(9)]
        HRESULT put_UserDefaultPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* value);

        [VtblIndex(10)]
        HRESULT RefreshPrintDeviceCapabilities();

        [VtblIndex(11)]
        HRESULT GetMaxSupportedPdlVersion(HSTRING pdlContentType, HSTRING* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IppPrintDeviceKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IppPrintDeviceKind*, int> get_DeviceKind;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanModifyUserDefaultPrintTicket;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWorkflowPrintTicket**, int> get_UserDefaultPrintTicket;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWorkflowPrintTicket*, int> put_UserDefaultPrintTicket;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RefreshPrintDeviceCapabilities;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING*, int> GetMaxSupportedPdlVersion;
    }
}
