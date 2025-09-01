// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IXmlNamedNodeMap.xml' path='doc/member[@name="IXmlNamedNodeMap"]/*' />
[Guid("B3A69EB0-AAB0-4B82-A6FA-B1453F7C021B")]
[NativeTypeName("struct IXmlNamedNodeMap : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlNamedNodeMap : IXmlNamedNodeMap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IXmlNamedNodeMap);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, Guid*, void**, int>)(lpVtbl[0]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, uint>)(lpVtbl[1]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, uint>)(lpVtbl[2]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, uint*, Guid**, int>)(lpVtbl[3]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, HSTRING*, int>)(lpVtbl[4]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, TrustLevel*, int>)(lpVtbl[5]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IXmlNamedNodeMap.xml' path='doc/member[@name="IXmlNamedNodeMap.get_Length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, uint*, int>)(lpVtbl[6]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXmlNamedNodeMap.xml' path='doc/member[@name="IXmlNamedNodeMap.Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Item([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, uint, IXmlNode**, int>)(lpVtbl[7]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), index, node);
    }

    /// <include file='IXmlNamedNodeMap.xml' path='doc/member[@name="IXmlNamedNodeMap.GetNamedItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNamedItem(HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, HSTRING, IXmlNode**, int>)(lpVtbl[8]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), name, node);
    }

    /// <include file='IXmlNamedNodeMap.xml' path='doc/member[@name="IXmlNamedNodeMap.SetNamedItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetNamedItem([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode* node, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** previousNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, IXmlNode*, IXmlNode**, int>)(lpVtbl[9]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), node, previousNode);
    }

    /// <include file='IXmlNamedNodeMap.xml' path='doc/member[@name="IXmlNamedNodeMap.RemoveNamedItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RemoveNamedItem(HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** previousNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, HSTRING, IXmlNode**, int>)(lpVtbl[10]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), name, previousNode);
    }

    /// <include file='IXmlNamedNodeMap.xml' path='doc/member[@name="IXmlNamedNodeMap.GetNamedItemNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetNamedItemNS(IInspectable* namespaceUri, HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, IInspectable*, HSTRING, IXmlNode**, int>)(lpVtbl[11]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), namespaceUri, name, node);
    }

    /// <include file='IXmlNamedNodeMap.xml' path='doc/member[@name="IXmlNamedNodeMap.RemoveNamedItemNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveNamedItemNS(IInspectable* namespaceUri, HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** previousNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, IInspectable*, HSTRING, IXmlNode**, int>)(lpVtbl[12]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), namespaceUri, name, previousNode);
    }

    /// <include file='IXmlNamedNodeMap.xml' path='doc/member[@name="IXmlNamedNodeMap.SetNamedItemNS"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetNamedItemNS([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode* node, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** previousNode)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlNamedNodeMap*, IXmlNode*, IXmlNode**, int>)(lpVtbl[13]))((IXmlNamedNodeMap*)Unsafe.AsPointer(ref this), node, previousNode);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT Item([NativeTypeName("UINT32")] uint index, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node);

        [VtblIndex(8)]
        HRESULT GetNamedItem(HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node);

        [VtblIndex(9)]
        HRESULT SetNamedItem([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode* node, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** previousNode);

        [VtblIndex(10)]
        HRESULT RemoveNamedItem(HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** previousNode);

        [VtblIndex(11)]
        HRESULT GetNamedItemNS(IInspectable* namespaceUri, HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** node);

        [VtblIndex(12)]
        HRESULT RemoveNamedItemNS(IInspectable* namespaceUri, HSTRING name, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** previousNode);

        [VtblIndex(13)]
        HRESULT SetNamedItemNS([NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode* node, [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode** previousNode);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Length;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IXmlNode**, int> Item;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlNode**, int> GetNamedItem;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlNode*, IXmlNode**, int> SetNamedItem;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IXmlNode**, int> RemoveNamedItem;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, HSTRING, IXmlNode**, int> GetNamedItemNS;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, HSTRING, IXmlNode**, int> RemoveNamedItemNS;

        [NativeTypeName("HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IXmlNode*, IXmlNode**, int> SetNamedItemNS;
    }
}
