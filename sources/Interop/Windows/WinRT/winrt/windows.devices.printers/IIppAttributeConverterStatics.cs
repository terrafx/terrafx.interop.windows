// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppAttributeConverterStatics.xml' path='doc/member[@name="IIppAttributeConverterStatics"]/*' />
[Guid("91E368DF-BFA4-5CA1-A92D-0793F988E82D")]
[NativeTypeName("struct IIppAttributeConverterStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppAttributeConverterStatics : IIppAttributeConverterStatics.Interface, INativeGuid
{
    /// <include file='IIppAttributeConverterStatics.xml' path='doc/member[@name="IIppAttributeConverterStatics.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIppAttributeConverterStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeConverterStatics*, Guid*, void**, int>)(lpVtbl[0]))((IIppAttributeConverterStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeConverterStatics*, uint>)(lpVtbl[1]))((IIppAttributeConverterStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeConverterStatics*, uint>)(lpVtbl[2]))((IIppAttributeConverterStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeConverterStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IIppAttributeConverterStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeConverterStatics*, HSTRING*, int>)(lpVtbl[4]))((IIppAttributeConverterStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeConverterStatics*, TrustLevel*, int>)(lpVtbl[5]))((IIppAttributeConverterStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppAttributeConverterStatics.xml' path='doc/member[@name="IIppAttributeConverterStatics.ConvertPrintTicketToIppAttributesForPrinter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConvertPrintTicketToIppAttributesForPrinter(HSTRING printerName, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* printTicket, HSTRING targetPdlFormat, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_Windows__CDevices__CPrinters__CIppAttributeGroupKind___FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<IppAttributeGroupKind, Pointer<IMap<HSTRING, Pointer<IIppAttributeValue>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeConverterStatics*, HSTRING, IWorkflowPrintTicket*, HSTRING, IMap<IppAttributeGroupKind, Pointer<IMap<HSTRING, Pointer<IIppAttributeValue>>>>**, int>)(lpVtbl[6]))((IIppAttributeConverterStatics*)Unsafe.AsPointer(ref this), printerName, printTicket, targetPdlFormat, result);
    }

    /// <include file='IIppAttributeConverterStatics.xml' path='doc/member[@name="IIppAttributeConverterStatics.ConvertBufferToIppAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConvertBufferToIppAttributes([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* attributesBuffer, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeConverterStatics*, IBuffer*, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int>)(lpVtbl[7]))((IIppAttributeConverterStatics*)Unsafe.AsPointer(ref this), attributesBuffer, result);
    }

    /// <include file='IIppAttributeConverterStatics.xml' path='doc/member[@name="IIppAttributeConverterStatics.ConvertIppAttributesToBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConvertIppAttributesToBuffer([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* attributes, [NativeTypeName("ABI::Windows::Devices::Printers::IppAttributeGroupKind")] IppAttributeGroupKind attributeGroupKind, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppAttributeConverterStatics*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, IppAttributeGroupKind, IBuffer**, int>)(lpVtbl[8]))((IIppAttributeConverterStatics*)Unsafe.AsPointer(ref this), attributes, attributeGroupKind, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ConvertPrintTicketToIppAttributesForPrinter(HSTRING printerName, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* printTicket, HSTRING targetPdlFormat, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_Windows__CDevices__CPrinters__CIppAttributeGroupKind___FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<IppAttributeGroupKind, Pointer<IMap<HSTRING, Pointer<IIppAttributeValue>>>>** result);

        [VtblIndex(7)]
        HRESULT ConvertBufferToIppAttributes([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* attributesBuffer, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result);

        [VtblIndex(8)]
        HRESULT ConvertIppAttributesToBuffer([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* attributes, [NativeTypeName("ABI::Windows::Devices::Printers::IppAttributeGroupKind")] IppAttributeGroupKind attributeGroupKind, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *, HSTRING, ABI::Windows::Foundation::Collections::__FIMap_2_Windows__CDevices__CPrinters__CIppAttributeGroupKind___FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IWorkflowPrintTicket*, HSTRING, IMap<IppAttributeGroupKind, Pointer<IMap<HSTRING, Pointer<IIppAttributeValue>>>>**, int> ConvertPrintTicketToIppAttributesForPrinter;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int> ConvertBufferToIppAttributes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Devices::Printers::IppAttributeGroupKind, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, IppAttributeGroupKind, IBuffer**, int> ConvertIppAttributesToBuffer;
    }
}
