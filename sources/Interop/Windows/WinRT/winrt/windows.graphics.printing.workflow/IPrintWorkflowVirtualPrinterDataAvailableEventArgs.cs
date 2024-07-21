// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowVirtualPrinterDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterDataAvailableEventArgs"]/*' />
[Guid("6B7D5003-14A8-5D52-A428-07330FBAB11F")]
[NativeTypeName("struct IPrintWorkflowVirtualPrinterDataAvailableEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowVirtualPrinterDataAvailableEventArgs : IPrintWorkflowVirtualPrinterDataAvailableEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowVirtualPrinterDataAvailableEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, uint>)(lpVtbl[1]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, uint>)(lpVtbl[2]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowVirtualPrinterDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterDataAvailableEventArgs.get_Configuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, IPrintWorkflowConfiguration**, int>)(lpVtbl[6]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowVirtualPrinterDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterDataAvailableEventArgs.get_SourceContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SourceContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **")] IPrintWorkflowPdlSourceContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, IPrintWorkflowPdlSourceContent**, int>)(lpVtbl[7]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowVirtualPrinterDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterDataAvailableEventArgs.get_UILauncher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UILauncher([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **")] IPrintWorkflowUILauncher** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, IPrintWorkflowUILauncher**, int>)(lpVtbl[8]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowVirtualPrinterDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterDataAvailableEventArgs.GetJobPrintTicket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetJobPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, IWorkflowPrintTicket**, int>)(lpVtbl[9]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPrintWorkflowVirtualPrinterDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterDataAvailableEventArgs.GetPdlConverter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPdlConverter([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType")] PrintWorkflowPdlConversionType conversionType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **")] IPrintWorkflowPdlConverter** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, PrintWorkflowPdlConversionType, IPrintWorkflowPdlConverter**, int>)(lpVtbl[10]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), conversionType, result);
    }

    /// <include file='IPrintWorkflowVirtualPrinterDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterDataAvailableEventArgs.GetTargetFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetTargetFileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[11]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPrintWorkflowVirtualPrinterDataAvailableEventArgs.xml' path='doc/member[@name="IPrintWorkflowVirtualPrinterDataAvailableEventArgs.CompleteJob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CompleteJob([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus")] PrintWorkflowSubmittedStatus status)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowVirtualPrinterDataAvailableEventArgs*, PrintWorkflowSubmittedStatus, int>)(lpVtbl[12]))((IPrintWorkflowVirtualPrinterDataAvailableEventArgs*)Unsafe.AsPointer(ref this), status);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value);

        [VtblIndex(7)]
        HRESULT get_SourceContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **")] IPrintWorkflowPdlSourceContent** value);

        [VtblIndex(8)]
        HRESULT get_UILauncher([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **")] IPrintWorkflowUILauncher** value);

        [VtblIndex(9)]
        HRESULT GetJobPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** result);

        [VtblIndex(10)]
        HRESULT GetPdlConverter([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType")] PrintWorkflowPdlConversionType conversionType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **")] IPrintWorkflowPdlConverter** result);

        [VtblIndex(11)]
        HRESULT GetTargetFileAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** operation);

        [VtblIndex(12)]
        HRESULT CompleteJob([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus")] PrintWorkflowSubmittedStatus status);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowPdlSourceContent**, int> get_SourceContent;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowUILauncher**, int> get_UILauncher;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWorkflowPrintTicket**, int> GetJobPrintTicket;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowPdlConversionType, IPrintWorkflowPdlConverter**, int> GetPdlConverter;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IStorageFile>>**, int> GetTargetFileAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowSubmittedStatus, int> CompleteJob;
    }
}
