// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowJobUISession2.xml' path='doc/member[@name="IPrintWorkflowJobUISession2"]/*' />
[Guid("A8529368-9174-5C78-9FDB-894A82E92ADA")]
[NativeTypeName("struct IPrintWorkflowJobUISession2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowJobUISession2 : IPrintWorkflowJobUISession2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowJobUISession2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession2*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowJobUISession2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession2*, uint>)(lpVtbl[1]))((IPrintWorkflowJobUISession2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession2*, uint>)(lpVtbl[2]))((IPrintWorkflowJobUISession2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession2*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowJobUISession2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession2*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowJobUISession2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession2*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowJobUISession2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowJobUISession2.xml' path='doc/member[@name="IPrintWorkflowJobUISession2.add_VirtualPrinterUIDataAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_VirtualPrinterUIDataAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobUISession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowVirtualPrinterUIEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowVirtualPrinterUIEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession2*, ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowVirtualPrinterUIEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPrintWorkflowJobUISession2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPrintWorkflowJobUISession2.xml' path='doc/member[@name="IPrintWorkflowJobUISession2.remove_VirtualPrinterUIDataAvailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_VirtualPrinterUIDataAvailable(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobUISession2*, EventRegistrationToken, int>)(lpVtbl[7]))((IPrintWorkflowJobUISession2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_VirtualPrinterUIDataAvailable([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobUISession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowVirtualPrinterUIEventArgs_t *")] ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowVirtualPrinterUIEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_VirtualPrinterUIDataAvailable(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowJobUISession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowVirtualPrinterUIEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintWorkflowJobUISession>, Pointer<IPrintWorkflowVirtualPrinterUIEventArgs>>*, EventRegistrationToken*, int> add_VirtualPrinterUIDataAvailable;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_VirtualPrinterUIDataAvailable;
    }
}
