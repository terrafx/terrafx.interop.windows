// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowJobBackgroundSession3.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession3"]/*' />
[Guid("5757086C-EDCC-5A94-90EC-A0A87C1115E7")]
[NativeTypeName("struct IPrintWorkflowJobBackgroundSession3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowJobBackgroundSession3 : IPrintWorkflowJobBackgroundSession3.Interface, INativeGuid
{
    /// <include file='IPrintWorkflowJobBackgroundSession3.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession3.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowJobBackgroundSession3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession3*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowJobBackgroundSession3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession3*, uint>)(lpVtbl[1]))((IPrintWorkflowJobBackgroundSession3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession3*, uint>)(lpVtbl[2]))((IPrintWorkflowJobBackgroundSession3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession3*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowJobBackgroundSession3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession3*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowJobBackgroundSession3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession3*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowJobBackgroundSession3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession3.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession3.add_JobStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_JobStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowPrinterJobStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowPrinterJobStatusChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession3*, ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowPrinterJobStatusChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPrintWorkflowJobBackgroundSession3*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession3.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession3.remove_JobStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_JobStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession3*, EventRegistrationToken, int>)(lpVtbl[7]))((IPrintWorkflowJobBackgroundSession3*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_JobStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowPrinterJobStatusChangedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowPrinterJobStatusChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_JobStatusChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowPrinterJobStatusChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowPrinterJobStatusChangedEventArgs>>*, EventRegistrationToken*, int> add_JobStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_JobStatusChanged;
    }
}
