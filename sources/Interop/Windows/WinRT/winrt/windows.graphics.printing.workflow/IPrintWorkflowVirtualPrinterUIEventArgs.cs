// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowVirtualPrinterUIEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterUIEventArgs"]/*' />
[Guid("334DBBCA-BF10-585F-B7E0-58C4AA43A03F")]
[NativeTypeName("struct IPrintWorkflowVirtualPrinterUIEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowVirtualPrinterUIEventArgs : IPrintWorkflowVirtualPrinterUIEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowVirtualPrinterUIEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, uint>)(lpVtbl[1]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, uint>)(lpVtbl[2]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowVirtualPrinterUIEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterUIEventArgs.get_Configuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, IPrintWorkflowConfiguration**, int>)(lpVtbl[6]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowVirtualPrinterUIEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterUIEventArgs.get_Printer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Printer([NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, IIppPrintDevice**, int>)(lpVtbl[7]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowVirtualPrinterUIEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterUIEventArgs.get_SourceContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **")] IPrintWorkflowPdlSourceContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, IPrintWorkflowPdlSourceContent**, int>)(lpVtbl[8]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowVirtualPrinterUIEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterUIEventArgs.GetJobPrintTicket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetJobPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, IWorkflowPrintTicket**, int>)(lpVtbl[9]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPrintWorkflowVirtualPrinterUIEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterUIEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterUIEventArgs*, IDeferral**, int>)(lpVtbl[10]))((IPrintWorkflowVirtualPrinterUIEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value);

        [VtblIndex(7)]
        HRESULT get_Printer([NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** value);

        [VtblIndex(8)]
        HRESULT get_SourceContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **")] IPrintWorkflowPdlSourceContent** value);

        [VtblIndex(9)]
        HRESULT GetJobPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** result);

        [VtblIndex(10)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowConfiguration**, int> get_Configuration;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppPrintDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppPrintDevice**, int> get_Printer;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowPdlSourceContent**, int> get_SourceContent;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWorkflowPrintTicket**, int> GetJobPrintTicket;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
