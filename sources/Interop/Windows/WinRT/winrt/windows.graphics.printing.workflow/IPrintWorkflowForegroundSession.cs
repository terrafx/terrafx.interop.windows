// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowForegroundSession.xml' path='doc/member[@name="IPrintWorkflowForegroundSession"]/*' />
[Guid("C79B63D0-F8EC-4CEB-953A-C8876157DD33")]
[NativeTypeName("struct IPrintWorkflowForegroundSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowForegroundSession : IPrintWorkflowForegroundSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowForegroundSession);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, uint>)(lpVtbl[1]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, uint>)(lpVtbl[2]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowForegroundSession.xml' path='doc/member[@name="IPrintWorkflowForegroundSession.add_SetupRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_SetupRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSetupRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowForegroundSession>, Pointer<IPrintWorkflowForegroundSetupRequestedEventArgs>>* setupEventHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, ITypedEventHandler<Pointer<IPrintWorkflowForegroundSession>, Pointer<IPrintWorkflowForegroundSetupRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this), setupEventHandler, token);
    }

    /// <include file='IPrintWorkflowForegroundSession.xml' path='doc/member[@name="IPrintWorkflowForegroundSession.remove_SetupRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_SetupRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, EventRegistrationToken, int>)(lpVtbl[7]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPrintWorkflowForegroundSession.xml' path='doc/member[@name="IPrintWorkflowForegroundSession.add_XpsDataAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_XpsDataAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowXpsDataAvailableEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowForegroundSession>, Pointer<IPrintWorkflowXpsDataAvailableEventArgs>>* xpsDataAvailableEventHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, ITypedEventHandler<Pointer<IPrintWorkflowForegroundSession>, Pointer<IPrintWorkflowXpsDataAvailableEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this), xpsDataAvailableEventHandler, token);
    }

    /// <include file='IPrintWorkflowForegroundSession.xml' path='doc/member[@name="IPrintWorkflowForegroundSession.remove_XpsDataAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_XpsDataAvailable(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, EventRegistrationToken, int>)(lpVtbl[9]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPrintWorkflowForegroundSession.xml' path='doc/member[@name="IPrintWorkflowForegroundSession.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")] PrintWorkflowSessionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, PrintWorkflowSessionStatus*, int>)(lpVtbl[10]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowForegroundSession.xml' path='doc/member[@name="IPrintWorkflowForegroundSession.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowForegroundSession*, int>)(lpVtbl[11]))((IPrintWorkflowForegroundSession*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_SetupRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSetupRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowForegroundSession>, Pointer<IPrintWorkflowForegroundSetupRequestedEventArgs>>* setupEventHandler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_SetupRequested(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_XpsDataAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowXpsDataAvailableEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowForegroundSession>, Pointer<IPrintWorkflowXpsDataAvailableEventArgs>>* xpsDataAvailableEventHandler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_XpsDataAvailable(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")] PrintWorkflowSessionStatus* value);

        [VtblIndex(11)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSetupRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowForegroundSession>, Pointer<IPrintWorkflowForegroundSetupRequestedEventArgs>>*, EventRegistrationToken*, int> add_SetupRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SetupRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowXpsDataAvailableEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowForegroundSession>, Pointer<IPrintWorkflowXpsDataAvailableEventArgs>>*, EventRegistrationToken*, int> add_XpsDataAvailable;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_XpsDataAvailable;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowSessionStatus*, int> get_Status;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;
    }
}
