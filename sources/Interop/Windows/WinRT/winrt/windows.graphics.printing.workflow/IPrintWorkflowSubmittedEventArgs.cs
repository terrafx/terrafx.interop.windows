// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowSubmittedEventArgs.xml' path='doc/member[@name="IPrintWorkflowSubmittedEventArgs"]/*' />
[Guid("3ADD0A41-3794-5569-5C87-40E8FF720F83")]
[NativeTypeName("struct IPrintWorkflowSubmittedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowSubmittedEventArgs : IPrintWorkflowSubmittedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowSubmittedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowSubmittedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedEventArgs*, uint>)(lpVtbl[1]))((IPrintWorkflowSubmittedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedEventArgs*, uint>)(lpVtbl[2]))((IPrintWorkflowSubmittedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowSubmittedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowSubmittedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowSubmittedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowSubmittedEventArgs.xml' path='doc/member[@name="IPrintWorkflowSubmittedEventArgs.get_Operation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Operation([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSubmittedOperation **")] IPrintWorkflowSubmittedOperation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedEventArgs*, IPrintWorkflowSubmittedOperation**, int>)(lpVtbl[6]))((IPrintWorkflowSubmittedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowSubmittedEventArgs.xml' path='doc/member[@name="IPrintWorkflowSubmittedEventArgs.GetTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTarget([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* jobPrintTicket, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowTarget **")] IPrintWorkflowTarget** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedEventArgs*, IWorkflowPrintTicket*, IPrintWorkflowTarget**, int>)(lpVtbl[7]))((IPrintWorkflowSubmittedEventArgs*)Unsafe.AsPointer(ref this), jobPrintTicket, result);
    }

    /// <include file='IPrintWorkflowSubmittedEventArgs.xml' path='doc/member[@name="IPrintWorkflowSubmittedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedEventArgs*, IDeferral**, int>)(lpVtbl[8]))((IPrintWorkflowSubmittedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Operation([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSubmittedOperation **")] IPrintWorkflowSubmittedOperation** value);

        [VtblIndex(7)]
        HRESULT GetTarget([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* jobPrintTicket, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowTarget **")] IPrintWorkflowTarget** result);

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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSubmittedOperation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowSubmittedOperation**, int> get_Operation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowTarget **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWorkflowPrintTicket*, IPrintWorkflowTarget**, int> GetTarget;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
