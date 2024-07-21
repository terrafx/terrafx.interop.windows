// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTicketOption.xml' path='doc/member[@name="IPrintTicketOption"]/*' />
[Guid("B086CF90-B367-4E4B-BD48-9C78A0BB31CE")]
[NativeTypeName("struct IPrintTicketOption : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTicketOption : IPrintTicketOption.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTicketOption));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, uint>)(lpVtbl[1]))((IPrintTicketOption*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, uint>)(lpVtbl[2]))((IPrintTicketOption*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, HSTRING*, int>)(lpVtbl[4]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTicketOption.xml' path='doc/member[@name="IPrintTicketOption.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, HSTRING*, int>)(lpVtbl[6]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketOption.xml' path='doc/member[@name="IPrintTicketOption.get_XmlNamespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_XmlNamespace(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, HSTRING*, int>)(lpVtbl[7]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketOption.xml' path='doc/member[@name="IPrintTicketOption.get_XmlNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_XmlNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, IXmlNode**, int>)(lpVtbl[8]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketOption.xml' path='doc/member[@name="IPrintTicketOption.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, HSTRING*, int>)(lpVtbl[9]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketOption.xml' path='doc/member[@name="IPrintTicketOption.GetPropertyNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertyNode(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, HSTRING, HSTRING, IXmlNode**, int>)(lpVtbl[10]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), name, xmlNamespace, result);
    }

    /// <include file='IPrintTicketOption.xml' path='doc/member[@name="IPrintTicketOption.GetScoredPropertyNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetScoredPropertyNode(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, HSTRING, HSTRING, IXmlNode**, int>)(lpVtbl[11]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), name, xmlNamespace, result);
    }

    /// <include file='IPrintTicketOption.xml' path='doc/member[@name="IPrintTicketOption.GetPropertyValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPropertyValue(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")] IPrintTicketValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, HSTRING, HSTRING, IPrintTicketValue**, int>)(lpVtbl[12]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), name, xmlNamespace, result);
    }

    /// <include file='IPrintTicketOption.xml' path='doc/member[@name="IPrintTicketOption.GetScoredPropertyValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetScoredPropertyValue(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")] IPrintTicketValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketOption*, HSTRING, HSTRING, IPrintTicketValue**, int>)(lpVtbl[13]))((IPrintTicketOption*)Unsafe.AsPointer(ref this), name, xmlNamespace, result);
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
        HRESULT GetPropertyNode(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** result);

        [VtblIndex(11)]
        HRESULT GetScoredPropertyNode(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** result);

        [VtblIndex(12)]
        HRESULT GetPropertyValue(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")] IPrintTicketValue** result);

        [VtblIndex(13)]
        HRESULT GetScoredPropertyValue(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")] IPrintTicketValue** result);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IXmlNode**, int> GetPropertyNode;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IXmlNode**, int> GetScoredPropertyNode;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPrintTicketValue**, int> GetPropertyValue;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPrintTicketValue**, int> GetScoredPropertyValue;
    }
}
