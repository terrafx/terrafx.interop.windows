// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowForegroundSetupRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowForegroundSetupRequestedEventArgs"]/*' />
[Guid("BBE38247-9C1B-4DD3-9B2B-C80468D941B3")]
[NativeTypeName("struct IPrintWorkflowForegroundSetupRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowForegroundSetupRequestedEventArgs : IPrintWorkflowForegroundSetupRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowForegroundSetupRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSetupRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowForegroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSetupRequestedEventArgs*, uint>)(lpVtbl[1]))((IPrintWorkflowForegroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSetupRequestedEventArgs*, uint>)(lpVtbl[2]))((IPrintWorkflowForegroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSetupRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowForegroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSetupRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowForegroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSetupRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowForegroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowForegroundSetupRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowForegroundSetupRequestedEventArgs.GetUserPrintTicketAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetUserPrintTicketAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicket_t **")] IAsyncOperation<Pointer<IWorkflowPrintTicket>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSetupRequestedEventArgs*, IAsyncOperation<Pointer<IWorkflowPrintTicket>>**, int>)(lpVtbl[6]))((IPrintWorkflowForegroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPrintWorkflowForegroundSetupRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowForegroundSetupRequestedEventArgs.get_Configuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSetupRequestedEventArgs*, IPrintWorkflowConfiguration**, int>)(lpVtbl[7]))((IPrintWorkflowForegroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowForegroundSetupRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowForegroundSetupRequestedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSetupRequestedEventArgs*, IDeferral**, int>)(lpVtbl[8]))((IPrintWorkflowForegroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetUserPrintTicketAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicket_t **")] IAsyncOperation<Pointer<IWorkflowPrintTicket>>** operation);

        [VtblIndex(7)]
        HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value);

        [VtblIndex(8)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicket_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IWorkflowPrintTicket>>**, int> GetUserPrintTicketAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowConfiguration**, int> get_Configuration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
