// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowBackgroundSetupRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowBackgroundSetupRequestedEventArgs"]/*' />
[Guid("43E97342-1750-59C9-61FB-383748A20362")]
[NativeTypeName("struct IPrintWorkflowBackgroundSetupRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowBackgroundSetupRequestedEventArgs : IPrintWorkflowBackgroundSetupRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowBackgroundSetupRequestedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, uint>)(lpVtbl[1]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, uint>)(lpVtbl[2]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowBackgroundSetupRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowBackgroundSetupRequestedEventArgs.GetUserPrintTicketAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetUserPrintTicketAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicket_t **")] IAsyncOperation<Pointer<IWorkflowPrintTicket>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, IAsyncOperation<Pointer<IWorkflowPrintTicket>>**, int>)(lpVtbl[6]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPrintWorkflowBackgroundSetupRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowBackgroundSetupRequestedEventArgs.get_Configuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, IPrintWorkflowConfiguration**, int>)(lpVtbl[7]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <include file='IPrintWorkflowBackgroundSetupRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowBackgroundSetupRequestedEventArgs.SetRequiresUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRequiresUI()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, int>)(lpVtbl[8]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintWorkflowBackgroundSetupRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowBackgroundSetupRequestedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSetupRequestedEventArgs*, IDeferral**, int>)(lpVtbl[9]))((IPrintWorkflowBackgroundSetupRequestedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetUserPrintTicketAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicket_t **")] IAsyncOperation<Pointer<IWorkflowPrintTicket>>** operation);

        [VtblIndex(7)]
        HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** configuration);

        [VtblIndex(8)]
        HRESULT SetRequiresUI();

        [VtblIndex(9)]
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SetRequiresUI;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
