// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.extensions.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrint3DWorkflow2.xml' path='doc/member[@name="IPrint3DWorkflow2"]/*' />
[Guid("A2A6C54F-8AC1-4918-9741-E34F3004239E")]
[NativeTypeName("struct IPrint3DWorkflow2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrint3DWorkflow2 : IPrint3DWorkflow2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrint3DWorkflow2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow2*, Guid*, void**, int>)(lpVtbl[0]))((IPrint3DWorkflow2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow2*, uint>)(lpVtbl[1]))((IPrint3DWorkflow2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow2*, uint>)(lpVtbl[2]))((IPrint3DWorkflow2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow2*, uint*, Guid**, int>)(lpVtbl[3]))((IPrint3DWorkflow2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow2*, HSTRING*, int>)(lpVtbl[4]))((IPrint3DWorkflow2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow2*, TrustLevel*, int>)(lpVtbl[5]))((IPrint3DWorkflow2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrint3DWorkflow2.xml' path='doc/member[@name="IPrint3DWorkflow2.add_PrinterChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_PrinterChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflow_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflowPrinterChangedEventArgs_t *")] ITypedEventHandler<Pointer<IPrint3DWorkflow>, Pointer<IPrint3DWorkflowPrinterChangedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow2*, ITypedEventHandler<Pointer<IPrint3DWorkflow>, Pointer<IPrint3DWorkflowPrinterChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPrint3DWorkflow2*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IPrint3DWorkflow2.xml' path='doc/member[@name="IPrint3DWorkflow2.remove_PrinterChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_PrinterChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow2*, EventRegistrationToken, int>)(lpVtbl[7]))((IPrint3DWorkflow2*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_PrinterChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflow_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflowPrinterChangedEventArgs_t *")] ITypedEventHandler<Pointer<IPrint3DWorkflow>, Pointer<IPrint3DWorkflowPrinterChangedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(7)]
        HRESULT remove_PrinterChanged(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflow_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflowPrinterChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrint3DWorkflow>, Pointer<IPrint3DWorkflowPrinterChangedEventArgs>>*, EventRegistrationToken*, int> add_PrinterChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PrinterChanged;
    }
}
