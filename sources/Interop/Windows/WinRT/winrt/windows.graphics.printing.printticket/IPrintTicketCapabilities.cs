// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities"]/*' />
[Guid("8C45508B-BBDC-4256-A142-2FD615ECB416")]
[NativeTypeName("struct IPrintTicketCapabilities : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTicketCapabilities : IPrintTicketCapabilities.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTicketCapabilities));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, uint>)(lpVtbl[1]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, uint>)(lpVtbl[2]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, HSTRING*, int>)(lpVtbl[4]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, HSTRING*, int>)(lpVtbl[6]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_XmlNamespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_XmlNamespace(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, HSTRING*, int>)(lpVtbl[7]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_XmlNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_XmlNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IXmlNode**, int>)(lpVtbl[8]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_DocumentBindingFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DocumentBindingFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[9]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_DocumentCollateFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DocumentCollateFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[10]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_DocumentDuplexFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DocumentDuplexFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[11]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_DocumentHolePunchFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DocumentHolePunchFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[12]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_DocumentInputBinFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DocumentInputBinFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[13]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_DocumentNUpFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DocumentNUpFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[14]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_DocumentStapleFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DocumentStapleFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[15]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_JobPasscodeFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_JobPasscodeFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[16]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_PageBorderlessFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_PageBorderlessFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[17]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_PageMediaSizeFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_PageMediaSizeFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[18]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_PageMediaTypeFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_PageMediaTypeFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[19]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_PageOrientationFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PageOrientationFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[20]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_PageOutputColorFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_PageOutputColorFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[21]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_PageOutputQualityFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_PageOutputQualityFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[22]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.get_PageResolutionFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_PageResolutionFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, IPrintTicketFeature**, int>)(lpVtbl[23]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.GetFeature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetFeature(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, HSTRING, HSTRING, IPrintTicketFeature**, int>)(lpVtbl[24]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), name, xmlNamespace, result);
    }

    /// <include file='IPrintTicketCapabilities.xml' path='doc/member[@name="IPrintTicketCapabilities.GetParameterDefinition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetParameterDefinition(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterDefinition **")] IPrintTicketParameterDefinition** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketCapabilities*, HSTRING, HSTRING, IPrintTicketParameterDefinition**, int>)(lpVtbl[25]))((IPrintTicketCapabilities*)Unsafe.AsPointer(ref this), name, xmlNamespace, result);
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
        HRESULT get_DocumentBindingFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(10)]
        HRESULT get_DocumentCollateFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(11)]
        HRESULT get_DocumentDuplexFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(12)]
        HRESULT get_DocumentHolePunchFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(13)]
        HRESULT get_DocumentInputBinFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(14)]
        HRESULT get_DocumentNUpFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(15)]
        HRESULT get_DocumentStapleFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(16)]
        HRESULT get_JobPasscodeFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(17)]
        HRESULT get_PageBorderlessFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(18)]
        HRESULT get_PageMediaSizeFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(19)]
        HRESULT get_PageMediaTypeFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(20)]
        HRESULT get_PageOrientationFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(21)]
        HRESULT get_PageOutputColorFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(22)]
        HRESULT get_PageOutputQualityFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(23)]
        HRESULT get_PageResolutionFeature([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** value);

        [VtblIndex(24)]
        HRESULT GetFeature(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")] IPrintTicketFeature** result);

        [VtblIndex(25)]
        HRESULT GetParameterDefinition(HSTRING name, HSTRING xmlNamespace, [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterDefinition **")] IPrintTicketParameterDefinition** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_DocumentBindingFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_DocumentCollateFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_DocumentDuplexFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_DocumentHolePunchFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_DocumentInputBinFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_DocumentNUpFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_DocumentStapleFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_JobPasscodeFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_PageBorderlessFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_PageMediaSizeFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_PageMediaTypeFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_PageOrientationFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_PageOutputColorFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_PageOutputQualityFeature;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketFeature**, int> get_PageResolutionFeature;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPrintTicketFeature**, int> GetFeature;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterDefinition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPrintTicketParameterDefinition**, int> GetParameterDefinition;
    }
}
