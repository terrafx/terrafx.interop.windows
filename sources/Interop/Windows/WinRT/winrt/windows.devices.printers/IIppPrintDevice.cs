// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppPrintDevice.xml' path='doc/member[@name="IIppPrintDevice"]/*' />
[Guid("D748AC56-76F3-5DC6-AFD4-C2A8686B9359")]
[NativeTypeName("struct IIppPrintDevice : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppPrintDevice : IIppPrintDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppPrintDevice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, Guid*, void**, int>)(lpVtbl[0]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, uint>)(lpVtbl[1]))((IIppPrintDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, uint>)(lpVtbl[2]))((IIppPrintDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, uint*, Guid**, int>)(lpVtbl[3]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, HSTRING*, int>)(lpVtbl[4]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, TrustLevel*, int>)(lpVtbl[5]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppPrintDevice.xml' path='doc/member[@name="IIppPrintDevice.get_PrinterName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PrinterName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, HSTRING*, int>)(lpVtbl[6]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppPrintDevice.xml' path='doc/member[@name="IIppPrintDevice.get_PrinterUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PrinterUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, IUriRuntimeClass**, int>)(lpVtbl[7]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIppPrintDevice.xml' path='doc/member[@name="IIppPrintDevice.GetPrinterAttributesAsBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPrinterAttributesAsBuffer([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* attributeNames, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, IIterable<HSTRING>*, IBuffer**, int>)(lpVtbl[8]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), attributeNames, result);
    }

    /// <include file='IIppPrintDevice.xml' path='doc/member[@name="IIppPrintDevice.GetPrinterAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPrinterAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* attributeNames, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, IIterable<HSTRING>*, IMap<HSTRING, IntPtr>**, int>)(lpVtbl[9]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), attributeNames, result);
    }

    /// <include file='IIppPrintDevice.xml' path='doc/member[@name="IIppPrintDevice.SetPrinterAttributesFromBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPrinterAttributesFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* printerAttributesBuffer, [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")] IIppSetAttributesResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, IBuffer*, IIppSetAttributesResult**, int>)(lpVtbl[10]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), printerAttributesBuffer, result);
    }

    /// <include file='IIppPrintDevice.xml' path='doc/member[@name="IIppPrintDevice.SetPrinterAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetPrinterAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<IntPtr>* printerAttributes, [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")] IIppSetAttributesResult** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice*, IIterable<IntPtr>*, IIppSetAttributesResult**, int>)(lpVtbl[11]))((IIppPrintDevice*)Unsafe.AsPointer(ref this), printerAttributes, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PrinterName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_PrinterUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(8)]
        HRESULT GetPrinterAttributesAsBuffer([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* attributeNames, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** result);

        [VtblIndex(9)]
        HRESULT GetPrinterAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<HSTRING>* attributeNames, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, IntPtr>** result);

        [VtblIndex(10)]
        HRESULT SetPrinterAttributesFromBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* printerAttributesBuffer, [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")] IIppSetAttributesResult** result);

        [VtblIndex(11)]
        HRESULT SetPrinterAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<IntPtr>* printerAttributes, [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")] IIppSetAttributesResult** result);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PrinterName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_PrinterUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IBuffer**, int> GetPrinterAttributesAsBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<HSTRING>*, IMap<HSTRING, IntPtr>**, int> GetPrinterAttributes;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Printers::IIppSetAttributesResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IIppSetAttributesResult**, int> SetPrinterAttributesFromBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Devices::Printers::IIppSetAttributesResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<IntPtr>*, IIppSetAttributesResult**, int> SetPrinterAttributes;
    }
}
