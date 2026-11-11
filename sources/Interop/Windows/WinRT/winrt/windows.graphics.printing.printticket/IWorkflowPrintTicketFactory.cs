// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWorkflowPrintTicketFactory.xml' path='doc/member[@name="IWorkflowPrintTicketFactory"]/*' />
[Guid("966D1166-D9C7-569E-B7D8-F2B341C8F976")]
[NativeTypeName("struct IWorkflowPrintTicketFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWorkflowPrintTicketFactory : IWorkflowPrintTicketFactory.Interface, INativeGuid
{
    /// <include file='IWorkflowPrintTicketFactory.xml' path='doc/member[@name="IWorkflowPrintTicketFactory.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWorkflowPrintTicketFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkflowPrintTicketFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWorkflowPrintTicketFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkflowPrintTicketFactory*, uint>)(lpVtbl[1]))((IWorkflowPrintTicketFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkflowPrintTicketFactory*, uint>)(lpVtbl[2]))((IWorkflowPrintTicketFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkflowPrintTicketFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWorkflowPrintTicketFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkflowPrintTicketFactory*, HSTRING*, int>)(lpVtbl[4]))((IWorkflowPrintTicketFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkflowPrintTicketFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWorkflowPrintTicketFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWorkflowPrintTicketFactory.xml' path='doc/member[@name="IWorkflowPrintTicketFactory.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance(HSTRING printerName, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* printTicketStream, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWorkflowPrintTicketFactory*, HSTRING, IInputStream*, IWorkflowPrintTicket**, int>)(lpVtbl[6]))((IWorkflowPrintTicketFactory*)Unsafe.AsPointer(ref this), printerName, printTicketStream, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstance(HSTRING printerName, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* printTicketStream, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IInputStream*, IWorkflowPrintTicket**, int> CreateInstance;
    }
}
