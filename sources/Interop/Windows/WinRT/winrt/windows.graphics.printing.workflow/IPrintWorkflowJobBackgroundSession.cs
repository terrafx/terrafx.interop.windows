// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowJobBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession"]/*' />
[Guid("C5EC6AD8-20C9-5D51-8507-2734B46F96C5")]
[NativeTypeName("struct IPrintWorkflowJobBackgroundSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowJobBackgroundSession : IPrintWorkflowJobBackgroundSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowJobBackgroundSession);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, uint>)(lpVtbl[1]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, uint>)(lpVtbl[2]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")] PrintWorkflowSessionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, PrintWorkflowSessionStatus*, int>)(lpVtbl[6]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession.add_JobStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_JobStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobStartingEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowJobStartingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowJobStartingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession.remove_JobStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_JobStarting(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, EventRegistrationToken, int>)(lpVtbl[8]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession.add_PdlModificationRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_PdlModificationRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowPdlModificationRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowPdlModificationRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowPdlModificationRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession.remove_PdlModificationRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_PdlModificationRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, EventRegistrationToken, int>)(lpVtbl[10]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession*, int>)(lpVtbl[11]))((IPrintWorkflowJobBackgroundSession*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")] PrintWorkflowSessionStatus* value);

        [VtblIndex(7)]
        HRESULT add_JobStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobStartingEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowJobStartingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_JobStarting(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT add_PdlModificationRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowPdlModificationRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowPdlModificationRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_PdlModificationRequested(EventRegistrationToken token);

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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowSessionStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobStartingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowJobStartingEventArgs>>*, EventRegistrationToken*, int> add_JobStarting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_JobStarting;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowPdlModificationRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowPdlModificationRequestedEventArgs>>*, EventRegistrationToken*, int> add_PdlModificationRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PdlModificationRequested;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;
    }
}
