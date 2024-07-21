// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowPrinterJob.xml' path='doc/member[@name="IPrintWorkflowPrinterJob"]/*' />
[Guid("12009F94-0D14-5443-BC09-250311CE570B")]
[NativeTypeName("struct IPrintWorkflowPrinterJob : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPrinterJob : IPrintWorkflowPrinterJob.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowPrinterJob));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, uint>)(lpVtbl[1]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, uint>)(lpVtbl[2]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowPrinterJob.xml' path='doc/member[@name="IPrintWorkflowPrinterJob.get_JobId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_JobId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, int*, int>)(lpVtbl[6]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowPrinterJob.xml' path='doc/member[@name="IPrintWorkflowPrinterJob.get_Printer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Printer([NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, IIppPrintDevice**, int>)(lpVtbl[7]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowPrinterJob.xml' path='doc/member[@name="IPrintWorkflowPrinterJob.GetJobStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetJobStatus([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPrinterJobStatus *")] PrintWorkflowPrinterJobStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, PrintWorkflowPrinterJobStatus*, int>)(lpVtbl[8]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPrintWorkflowPrinterJob.xml' path='doc/member[@name="IPrintWorkflowPrinterJob.GetJobPrintTicket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetJobPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, IWorkflowPrintTicket**, int>)(lpVtbl[9]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPrintWorkflowPrinterJob.xml' path='doc/member[@name="IPrintWorkflowPrinterJob.GetJobAttributesAsBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetJobAttributesAsBuffer([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* attributeNames, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, IIterable<HSTRING>*, IBuffer**, int>)(lpVtbl[10]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), attributeNames, result);
    }

    /// <include file='IPrintWorkflowPrinterJob.xml' path='doc/member[@name="IPrintWorkflowPrinterJob.GetJobAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetJobAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* attributeNames, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, IIterable<HSTRING>*, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int>)(lpVtbl[11]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), attributeNames, result);
    }

    /// <include file='IPrintWorkflowPrinterJob.xml' path='doc/member[@name="IPrintWorkflowPrinterJob.SetJobAttributesFromBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetJobAttributesFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* jobAttributesBuffer, [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")] IIppSetAttributesResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, IBuffer*, IIppSetAttributesResult**, int>)(lpVtbl[12]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), jobAttributesBuffer, result);
    }

    /// <include file='IPrintWorkflowPrinterJob.xml' path='doc/member[@name="IPrintWorkflowPrinterJob.SetJobAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetJobAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* jobAttributes, [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")] IIppSetAttributesResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, IIppSetAttributesResult**, int>)(lpVtbl[13]))((IPrintWorkflowPrinterJob*)Unsafe.AsPointer(ref this), jobAttributes, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_JobId([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_Printer([NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")] IIppPrintDevice** value);

        [VtblIndex(8)]
        HRESULT GetJobStatus([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPrinterJobStatus *")] PrintWorkflowPrinterJobStatus* result);

        [VtblIndex(9)]
        HRESULT GetJobPrintTicket([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")] IWorkflowPrintTicket** result);

        [VtblIndex(10)]
        HRESULT GetJobAttributesAsBuffer([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* attributeNames, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result);

        [VtblIndex(11)]
        HRESULT GetJobAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* attributeNames, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result);

        [VtblIndex(12)]
        HRESULT SetJobAttributesFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* jobAttributesBuffer, [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")] IIppSetAttributesResult** result);

        [VtblIndex(13)]
        HRESULT SetJobAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* jobAttributes, [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")] IIppSetAttributesResult** result);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_JobId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IIppPrintDevice **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIppPrintDevice**, int> get_Printer;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPrinterJobStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowPrinterJobStatus*, int> GetJobStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWorkflowPrintTicket**, int> GetJobPrintTicket;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IBuffer**, int> GetJobAttributesAsBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int> GetJobAttributes;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Printers::IIppSetAttributesResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IIppSetAttributesResult**, int> SetJobAttributesFromBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Devices::Printers::IIppSetAttributesResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, IIppSetAttributesResult**, int> SetJobAttributes;
    }
}
