// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IXmlNodeSelector.xml' path='doc/member[@name="IXmlNodeSelector"]/*' />
[Guid("63DBBA8B-D0DB-4FE1-B745-F9433AFDC25B")]
[NativeTypeName("struct IXmlNodeSelector : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlNodeSelector : IXmlNodeSelector.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IXmlNodeSelector);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, Guid*, void**, int>)(lpVtbl[0]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, uint>)(lpVtbl[1]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, uint>)(lpVtbl[2]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, uint*, Guid**, int>)(lpVtbl[3]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, HSTRING*, int>)(lpVtbl[4]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, TrustLevel*, int>)(lpVtbl[5]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IXmlNodeSelector.xml' path='doc/member[@name="IXmlNodeSelector.SelectSingleNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SelectSingleNode(HSTRING xpath, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, HSTRING, IXmlNode**, int>)(lpVtbl[6]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this), xpath, node);
    }

    /// <include file='IXmlNodeSelector.xml' path='doc/member[@name="IXmlNodeSelector.SelectNodes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SelectNodes(HSTRING xpath, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList** nodelist)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, HSTRING, IXmlNodeList**, int>)(lpVtbl[7]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this), xpath, nodelist);
    }

    /// <include file='IXmlNodeSelector.xml' path='doc/member[@name="IXmlNodeSelector.SelectSingleNodeNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SelectSingleNodeNS(HSTRING xpath, IInspectable* namespaces, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, HSTRING, IInspectable*, IXmlNode**, int>)(lpVtbl[8]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this), xpath, namespaces, node);
    }

    /// <include file='IXmlNodeSelector.xml' path='doc/member[@name="IXmlNodeSelector.SelectNodesNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SelectNodesNS(HSTRING xpath, IInspectable* namespaces, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList** nodelist)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNodeSelector*, HSTRING, IInspectable*, IXmlNodeList**, int>)(lpVtbl[9]))((IXmlNodeSelector*)Unsafe.AsPointer(ref this), xpath, namespaces, nodelist);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SelectSingleNode(HSTRING xpath, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node);

        [VtblIndex(7)]
        HRESULT SelectNodes(HSTRING xpath, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList** nodelist);

        [VtblIndex(8)]
        HRESULT SelectSingleNodeNS(HSTRING xpath, IInspectable* namespaces, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node);

        [VtblIndex(9)]
        HRESULT SelectNodesNS(HSTRING xpath, IInspectable* namespaces, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList** nodelist);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlNode**, int> SelectSingleNode;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlNodeList**, int> SelectNodes;

        [NativeTypeName("HRESULT (HSTRING, IInspectable *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IInspectable*, IXmlNode**, int> SelectSingleNodeNS;

        [NativeTypeName("HRESULT (HSTRING, IInspectable *, ABI::Windows::Data::Xml::Dom::IXmlNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IInspectable*, IXmlNodeList**, int> SelectNodesNS;
    }
}
