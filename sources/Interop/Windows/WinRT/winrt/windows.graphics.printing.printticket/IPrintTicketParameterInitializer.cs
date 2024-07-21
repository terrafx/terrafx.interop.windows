// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTicketParameterInitializer.xml' path='doc/member[@name="IPrintTicketParameterInitializer"]/*' />
[Guid("5E3335BB-A0A5-48B1-9D5C-07116DDC597A")]
[NativeTypeName("struct IPrintTicketParameterInitializer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTicketParameterInitializer : IPrintTicketParameterInitializer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTicketParameterInitializer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, uint>)(lpVtbl[1]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, uint>)(lpVtbl[2]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, HSTRING*, int>)(lpVtbl[4]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTicketParameterInitializer.xml' path='doc/member[@name="IPrintTicketParameterInitializer.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, HSTRING*, int>)(lpVtbl[6]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterInitializer.xml' path='doc/member[@name="IPrintTicketParameterInitializer.get_XmlNamespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_XmlNamespace(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, HSTRING*, int>)(lpVtbl[7]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterInitializer.xml' path='doc/member[@name="IPrintTicketParameterInitializer.get_XmlNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_XmlNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, IXmlNode**, int>)(lpVtbl[8]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterInitializer.xml' path='doc/member[@name="IPrintTicketParameterInitializer.put_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Value([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue *")] IPrintTicketValue* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, IPrintTicketValue*, int>)(lpVtbl[9]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterInitializer.xml' path='doc/member[@name="IPrintTicketParameterInitializer.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Value([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")] IPrintTicketValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterInitializer*, IPrintTicketValue**, int>)(lpVtbl[10]))((IPrintTicketParameterInitializer*)Unsafe.AsPointer(ref this), value);
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
        HRESULT put_Value([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue *")] IPrintTicketValue* value);

        [VtblIndex(10)]
        HRESULT get_Value([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")] IPrintTicketValue** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketValue*, int> put_Value;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTicketValue**, int> get_Value;
    }
}
