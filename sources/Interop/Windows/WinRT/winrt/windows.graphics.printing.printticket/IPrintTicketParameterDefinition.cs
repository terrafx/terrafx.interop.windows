// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTicketParameterDefinition.xml' path='doc/member[@name="IPrintTicketParameterDefinition"]/*' />
[Guid("D6BAB4E4-2962-4C01-B7F3-9A9294EB8335")]
[NativeTypeName("struct IPrintTicketParameterDefinition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTicketParameterDefinition : IPrintTicketParameterDefinition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintTicketParameterDefinition);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, uint>)(lpVtbl[1]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, uint>)(lpVtbl[2]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, HSTRING*, int>)(lpVtbl[4]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTicketParameterDefinition.xml' path='doc/member[@name="IPrintTicketParameterDefinition.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, HSTRING*, int>)(lpVtbl[6]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterDefinition.xml' path='doc/member[@name="IPrintTicketParameterDefinition.get_XmlNamespace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_XmlNamespace(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, HSTRING*, int>)(lpVtbl[7]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterDefinition.xml' path='doc/member[@name="IPrintTicketParameterDefinition.get_XmlNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_XmlNode([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, IXmlNode**, int>)(lpVtbl[8]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterDefinition.xml' path='doc/member[@name="IPrintTicketParameterDefinition.get_DataType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DataType([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::PrintTicketParameterDataType *")] PrintTicketParameterDataType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, PrintTicketParameterDataType*, int>)(lpVtbl[9]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterDefinition.xml' path='doc/member[@name="IPrintTicketParameterDefinition.get_UnitType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UnitType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, HSTRING*, int>)(lpVtbl[10]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterDefinition.xml' path='doc/member[@name="IPrintTicketParameterDefinition.get_RangeMin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RangeMin([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, int*, int>)(lpVtbl[11]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTicketParameterDefinition.xml' path='doc/member[@name="IPrintTicketParameterDefinition.get_RangeMax"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RangeMax([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTicketParameterDefinition*, int*, int>)(lpVtbl[12]))((IPrintTicketParameterDefinition*)Unsafe.AsPointer(ref this), value);
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
        HRESULT get_DataType([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::PrintTicketParameterDataType *")] PrintTicketParameterDataType* value);

        [VtblIndex(10)]
        HRESULT get_UnitType(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_RangeMin([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_RangeMax([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::PrintTicketParameterDataType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintTicketParameterDataType*, int> get_DataType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UnitType;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_RangeMin;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_RangeMax;
    }
}
