// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowPrinterJob2.xml' path='doc/member[@name="IPrintWorkflowPrinterJob2"]/*' />
[Guid("747E21D7-69A9-5229-B8F0-874CA1A8871B")]
[NativeTypeName("struct IPrintWorkflowPrinterJob2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPrinterJob2 : IPrintWorkflowPrinterJob2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowPrinterJob2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob2*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowPrinterJob2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob2*, uint>)(lpVtbl[1]))((IPrintWorkflowPrinterJob2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob2*, uint>)(lpVtbl[2]))((IPrintWorkflowPrinterJob2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob2*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowPrinterJob2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob2*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowPrinterJob2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob2*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowPrinterJob2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowPrinterJob2.xml' path='doc/member[@name="IPrintWorkflowPrinterJob2.ConvertPrintTicketToJobAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConvertPrintTicketToJobAttributes([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* printTicket, HSTRING targetPdlFormat, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob2*, IWorkflowPrintTicket*, HSTRING, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int>)(lpVtbl[6]))((IPrintWorkflowPrinterJob2*)Unsafe.AsPointer(ref this), printTicket, targetPdlFormat, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ConvertPrintTicketToJobAttributes([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* printTicket, HSTRING targetPdlFormat, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *, HSTRING, ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWorkflowPrintTicket*, HSTRING, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int> ConvertPrintTicketToJobAttributes;
    }
}
