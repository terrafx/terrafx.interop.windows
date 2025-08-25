// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowBackgroundSession"]/*' />
[Guid("5B7913BA-0C5E-528A-7458-86A46CBDDC45")]
[NativeTypeName("struct IPrintWorkflowBackgroundSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowBackgroundSession : IPrintWorkflowBackgroundSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowBackgroundSession);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, uint>)(lpVtbl[1]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, uint>)(lpVtbl[2]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowBackgroundSession.add_SetupRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_SetupRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowBackgroundSetupRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowBackgroundSession>, Pointer<IPrintWorkflowBackgroundSetupRequestedEventArgs>>* setupEventHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, ITypedEventHandler<Pointer<IPrintWorkflowBackgroundSession>, Pointer<IPrintWorkflowBackgroundSetupRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this), setupEventHandler, token);
    }

    /// <include file='IPrintWorkflowBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowBackgroundSession.remove_SetupRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_SetupRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, EventRegistrationToken, int>)(lpVtbl[7]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPrintWorkflowBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowBackgroundSession.add_Submitted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Submitted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowSubmittedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowBackgroundSession>, Pointer<IPrintWorkflowSubmittedEventArgs>>* submittedEventHandler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, ITypedEventHandler<Pointer<IPrintWorkflowBackgroundSession>, Pointer<IPrintWorkflowSubmittedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this), submittedEventHandler, token);
    }

    /// <include file='IPrintWorkflowBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowBackgroundSession.remove_Submitted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Submitted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, EventRegistrationToken, int>)(lpVtbl[9]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPrintWorkflowBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowBackgroundSession.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")] PrintWorkflowSessionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, PrintWorkflowSessionStatus*, int>)(lpVtbl[10]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowBackgroundSession.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowBackgroundSession*, int>)(lpVtbl[11]))((IPrintWorkflowBackgroundSession*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_SetupRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowBackgroundSetupRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowBackgroundSession>, Pointer<IPrintWorkflowBackgroundSetupRequestedEventArgs>>* setupEventHandler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_SetupRequested(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_Submitted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowSubmittedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowBackgroundSession>, Pointer<IPrintWorkflowSubmittedEventArgs>>* submittedEventHandler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_Submitted(EventRegistrationToken token);

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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowBackgroundSetupRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowBackgroundSession>, Pointer<IPrintWorkflowBackgroundSetupRequestedEventArgs>>*, EventRegistrationToken*, int> add_SetupRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SetupRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowSubmittedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowBackgroundSession>, Pointer<IPrintWorkflowSubmittedEventArgs>>*, EventRegistrationToken*, int> add_Submitted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Submitted;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowSessionStatus*, int> get_Status;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;
    }
}
