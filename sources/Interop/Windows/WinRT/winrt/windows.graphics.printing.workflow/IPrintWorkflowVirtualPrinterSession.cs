// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowVirtualPrinterSession.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterSession"]/*' />
[Guid("AA3926F2-8485-5C27-A016-9D39E3BA2614")]
[NativeTypeName("struct IPrintWorkflowVirtualPrinterSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowVirtualPrinterSession : IPrintWorkflowVirtualPrinterSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowVirtualPrinterSession));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, uint>)(lpVtbl[1]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, uint>)(lpVtbl[2]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowVirtualPrinterSession.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterSession.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")] PrintWorkflowSessionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, PrintWorkflowSessionStatus*, int>)(lpVtbl[6]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowVirtualPrinterSession.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterSession.get_Printer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Printer([NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, IIppPrintDevice**, int>)(lpVtbl[7]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowVirtualPrinterSession.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterSession.add_VirtualPrinterDataAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_VirtualPrinterDataAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowVirtualPrinterSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowVirtualPrinterDataAvailableEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowVirtualPrinterSession>, Pointer<IPrintWorkflowVirtualPrinterDataAvailableEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, ITypedEventHandler<Pointer<IPrintWorkflowVirtualPrinterSession>, Pointer<IPrintWorkflowVirtualPrinterDataAvailableEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPrintWorkflowVirtualPrinterSession.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterSession.remove_VirtualPrinterDataAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_VirtualPrinterDataAvailable(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, EventRegistrationToken, int>)(lpVtbl[9]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPrintWorkflowVirtualPrinterSession.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterSession.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterSession*, int>)(lpVtbl[10]))((IPrintWorkflowVirtualPrinterSession*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")] PrintWorkflowSessionStatus* value);

        [VtblIndex(7)]
        HRESULT get_Printer([NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** value);

        [VtblIndex(8)]
        HRESULT add_VirtualPrinterDataAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowVirtualPrinterSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowVirtualPrinterDataAvailableEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowVirtualPrinterSession>, Pointer<IPrintWorkflowVirtualPrinterDataAvailableEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_VirtualPrinterDataAvailable(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT Start();
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowSessionStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppPrintDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppPrintDevice**, int> get_Printer;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowVirtualPrinterSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowVirtualPrinterDataAvailableEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowVirtualPrinterSession>, Pointer<IPrintWorkflowVirtualPrinterDataAvailableEventArgs>>*, EventRegistrationToken*, int> add_VirtualPrinterDataAvailable;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VirtualPrinterDataAvailable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;
    }
}
