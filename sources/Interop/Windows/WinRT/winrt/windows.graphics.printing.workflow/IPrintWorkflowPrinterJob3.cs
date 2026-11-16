// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowPrinterJob3.xml' path='doc/member[@name="IPrintWorkflowPrinterJob3"]/*' />
[Guid("F0C8EEEC-66AC-5E14-8906-0DE610769368")]
[NativeTypeName("struct IPrintWorkflowPrinterJob3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPrinterJob3 : IPrintWorkflowPrinterJob3.Interface, INativeGuid
{
    /// <include file='IPrintWorkflowPrinterJob3.xml' path='doc/member[@name="IPrintWorkflowPrinterJob3.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowPrinterJob3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob3*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowPrinterJob3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob3*, uint>)(lpVtbl[1]))((IPrintWorkflowPrinterJob3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob3*, uint>)(lpVtbl[2]))((IPrintWorkflowPrinterJob3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob3*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowPrinterJob3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob3*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowPrinterJob3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob3*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowPrinterJob3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowPrinterJob3.xml' path='doc/member[@name="IPrintWorkflowPrinterJob3.get_IsPassthroughJobWithAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsPassthroughJobWithAttributes([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob3*, byte*, int>)(lpVtbl[6]))((IPrintWorkflowPrinterJob3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowPrinterJob3.xml' path='doc/member[@name="IPrintWorkflowPrinterJob3.GetPassthroughJobAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPassthroughJobAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob3*, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int>)(lpVtbl[7]))((IPrintWorkflowPrinterJob3*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPrintWorkflowPrinterJob3.xml' path='doc/member[@name="IPrintWorkflowPrinterJob3.GetPassthroughJobOperationAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPassthroughJobOperationAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPrinterJob3*, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int>)(lpVtbl[8]))((IPrintWorkflowPrinterJob3*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsPassthroughJobWithAttributes([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT GetPassthroughJobAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result);

        [VtblIndex(8)]
        HRESULT GetPassthroughJobOperationAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **")] IMap<HSTRING, Pointer<IIppAttributeValue>>** result);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPassthroughJobWithAttributes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int> GetPassthroughJobAttributes;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IIppAttributeValue>>**, int> GetPassthroughJobOperationAttributes;
    }
}
