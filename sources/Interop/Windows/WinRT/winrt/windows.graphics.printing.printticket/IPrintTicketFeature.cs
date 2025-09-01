// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature"]/*' />
[Guid("E7607D6A-59F5-4103-8858-B97710963D39")]
[NativeTypeName("struct IPrintTicketFeature : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTicketFeature : IPrintTicketFeature.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintTicketFeature);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, uint>)(lpVtbl[1]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, uint>)(lpVtbl[2]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, HSTRING*, int>)(lpVtbl[4]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, HSTRING*, int>)(lpVtbl[6]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature.get_XmlNamespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_XmlNamespace(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, HSTRING*, int>)(lpVtbl[7]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature.get_XmlNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_XmlNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, IXmlNode**, int>)(lpVtbl[8]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, HSTRING*, int>)(lpVtbl[9]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature.GetOption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetOption(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **")] IPrintTicketOption** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, HSTRING, HSTRING, IPrintTicketOption**, int>)(lpVtbl[10]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), name, xmlNamespace, result);
    }

    /// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature.get_Options"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Options([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CPrinting__CPrintTicket__CPrintTicketOption_t **")] IVectorView<Pointer<IPrintTicketOption>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, IVectorView<Pointer<IPrintTicketOption>>**, int>)(lpVtbl[11]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature.GetSelectedOption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSelectedOption([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **")] IPrintTicketOption** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, IPrintTicketOption**, int>)(lpVtbl[12]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature.SetSelectedOption"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetSelectedOption([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption *")] IPrintTicketOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, IPrintTicketOption*, int>)(lpVtbl[13]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketFeature.xml' path='doc/member[@name="IPrintTicketFeature.get_SelectionType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SelectionType([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::PrintTicketFeatureSelectionType *")] PrintTicketFeatureSelectionType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketFeature*, PrintTicketFeatureSelectionType*, int>)(lpVtbl[14]))((IPrintTicketFeature*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_XmlNamespace(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_XmlNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** value);

        [VtblIndex(9)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT GetOption(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **")] IPrintTicketOption** result);

        [VtblIndex(11)]
        HRESULT get_Options([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CPrinting__CPrintTicket__CPrintTicketOption_t **")] IVectorView<Pointer<IPrintTicketOption>>** result);

        [VtblIndex(12)]
        HRESULT GetSelectedOption([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **")] IPrintTicketOption** value);

        [VtblIndex(13)]
        HRESULT SetSelectedOption([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption *")] IPrintTicketOption* value);

        [VtblIndex(14)]
        HRESULT get_SelectionType([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::PrintTicketFeatureSelectionType *")] PrintTicketFeatureSelectionType* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_XmlNamespace;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlNode**, int> get_XmlNode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPrintTicketOption**, int> GetOption;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CPrinting__CPrintTicket__CPrintTicketOption_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IPrintTicketOption>>**, int> get_Options;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketOption**, int> GetSelectedOption;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketOption*, int> SetSelectedOption;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::PrintTicketFeatureSelectionType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintTicketFeatureSelectionType*, int> get_SelectionType;
    }
}
