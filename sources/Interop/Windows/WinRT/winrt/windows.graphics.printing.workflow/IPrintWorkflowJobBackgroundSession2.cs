// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowJobBackgroundSession2.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession2"]/*' />
[Guid("592AADAF-EF26-5A55-AD21-5F63FFCF8366")]
[NativeTypeName("struct IPrintWorkflowJobBackgroundSession2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowJobBackgroundSession2 : IPrintWorkflowJobBackgroundSession2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowJobBackgroundSession2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession2*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowJobBackgroundSession2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession2*, uint>)(lpVtbl[1]))((IPrintWorkflowJobBackgroundSession2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession2*, uint>)(lpVtbl[2]))((IPrintWorkflowJobBackgroundSession2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession2*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowJobBackgroundSession2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession2*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowJobBackgroundSession2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession2*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowJobBackgroundSession2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession2.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession2.add_JobIssueDetected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_JobIssueDetected([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobIssueDetectedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowJobIssueDetectedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession2*, ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowJobIssueDetectedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPrintWorkflowJobBackgroundSession2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPrintWorkflowJobBackgroundSession2.xml' path='doc/member[@name="IPrintWorkflowJobBackgroundSession2.remove_JobIssueDetected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_JobIssueDetected(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobBackgroundSession2*, EventRegistrationToken, int>)(lpVtbl[7]))((IPrintWorkflowJobBackgroundSession2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_JobIssueDetected([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobIssueDetectedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowJobIssueDetectedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_JobIssueDetected(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobBackgroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobIssueDetectedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowJobBackgroundSession>, Pointer<IPrintWorkflowJobIssueDetectedEventArgs>>*, EventRegistrationToken*, int> add_JobIssueDetected;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_JobIssueDetected;
    }
}
