// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowJobUISession.xml' path='doc/member[@name="IPrintWorkflowJobUISession"]/*' />
[Guid("00C8736B-7637-5687-A302-0F664D2AAC65")]
[NativeTypeName("struct IPrintWorkflowJobUISession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowJobUISession : IPrintWorkflowJobUISession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowJobUISession));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, uint>)(lpVtbl[1]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, uint>)(lpVtbl[2]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowJobUISession.xml' path='doc/member[@name="IPrintWorkflowJobUISession.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")] PrintWorkflowSessionStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, PrintWorkflowSessionStatus*, int>)(lpVtbl[6]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobUISession.xml' path='doc/member[@name="IPrintWorkflowJobUISession.add_PdlDataAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_PdlDataAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobUISession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowPdlDataAvailableEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowPdlDataAvailableEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowPdlDataAvailableEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPrintWorkflowJobUISession.xml' path='doc/member[@name="IPrintWorkflowJobUISession.remove_PdlDataAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_PdlDataAvailable(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, EventRegistrationToken, int>)(lpVtbl[8]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPrintWorkflowJobUISession.xml' path='doc/member[@name="IPrintWorkflowJobUISession.add_JobNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_JobNotification([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobUISession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobNotificationEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowJobNotificationEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowJobNotificationEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPrintWorkflowJobUISession.xml' path='doc/member[@name="IPrintWorkflowJobUISession.remove_JobNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_JobNotification(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, EventRegistrationToken, int>)(lpVtbl[10]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPrintWorkflowJobUISession.xml' path='doc/member[@name="IPrintWorkflowJobUISession.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession*, int>)(lpVtbl[11]))((IPrintWorkflowJobUISession*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")] PrintWorkflowSessionStatus* value);

        [VtblIndex(7)]
        HRESULT add_PdlDataAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobUISession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowPdlDataAvailableEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowPdlDataAvailableEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_PdlDataAvailable(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT add_JobNotification([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobUISession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobNotificationEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowJobNotificationEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_JobNotification(EventRegistrationToken token);

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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobUISession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowPdlDataAvailableEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowPdlDataAvailableEventArgs>>*, EventRegistrationToken*, int> add_PdlDataAvailable;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PdlDataAvailable;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobUISession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobNotificationEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowJobNotificationEventArgs>>*, EventRegistrationToken*, int> add_JobNotification;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_JobNotification;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;
    }
}
