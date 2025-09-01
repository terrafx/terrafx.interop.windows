// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement"]/*' />
[Guid("64FF8CCC-B287-4DAE-B08A-A72CBF45F453")]
[NativeTypeName("struct IAppHostElement : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostElement : IAppHostElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostElement);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, uint>)(lpVtbl[1]))((IAppHostElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, uint>)(lpVtbl[2]))((IAppHostElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, char**, int>)(lpVtbl[3]))((IAppHostElement*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.get_Collection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Collection(IAppHostElementCollection** ppCollection)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, IAppHostElementCollection**, int>)(lpVtbl[4]))((IAppHostElement*)Unsafe.AsPointer(ref this), ppCollection);
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Properties(IAppHostPropertyCollection** ppProperties)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, IAppHostPropertyCollection**, int>)(lpVtbl[5]))((IAppHostElement*)Unsafe.AsPointer(ref this), ppProperties);
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.get_ChildElements"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChildElements(IAppHostChildElementCollection** ppElements)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, IAppHostChildElementCollection**, int>)(lpVtbl[6]))((IAppHostElement*)Unsafe.AsPointer(ref this), ppElements);
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, char*, VARIANT*, int>)(lpVtbl[7]))((IAppHostElement*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.SetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, char*, VARIANT, int>)(lpVtbl[8]))((IAppHostElement*)Unsafe.AsPointer(ref this), bstrMetadataType, value);
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.get_Schema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Schema(IAppHostElementSchema** ppSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, IAppHostElementSchema**, int>)(lpVtbl[9]))((IAppHostElement*)Unsafe.AsPointer(ref this), ppSchema);
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.GetElementByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetElementByName([NativeTypeName("BSTR")] char* bstrSubName, IAppHostElement** ppElement)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, char*, IAppHostElement**, int>)(lpVtbl[10]))((IAppHostElement*)Unsafe.AsPointer(ref this), bstrSubName, ppElement);
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.GetPropertyByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPropertyByName([NativeTypeName("BSTR")] char* bstrSubName, IAppHostProperty** ppProperty)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, char*, IAppHostProperty**, int>)(lpVtbl[11]))((IAppHostElement*)Unsafe.AsPointer(ref this), bstrSubName, ppProperty);
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, int>)(lpVtbl[12]))((IAppHostElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostElement.xml' path='doc/member[@name="IAppHostElement.get_Methods"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Methods(IAppHostMethodCollection** ppMethods)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElement*, IAppHostMethodCollection**, int>)(lpVtbl[13]))((IAppHostElement*)Unsafe.AsPointer(ref this), ppMethods);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Collection(IAppHostElementCollection** ppCollection);

        [VtblIndex(5)]
        HRESULT get_Properties(IAppHostPropertyCollection** ppProperties);

        [VtblIndex(6)]
        HRESULT get_ChildElements(IAppHostChildElementCollection** ppElements);

        [VtblIndex(7)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(8)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value);

        [VtblIndex(9)]
        HRESULT get_Schema(IAppHostElementSchema** ppSchema);

        [VtblIndex(10)]
        HRESULT GetElementByName([NativeTypeName("BSTR")] char* bstrSubName, IAppHostElement** ppElement);

        [VtblIndex(11)]
        HRESULT GetPropertyByName([NativeTypeName("BSTR")] char* bstrSubName, IAppHostProperty** ppProperty);

        [VtblIndex(12)]
        HRESULT Clear();

        [VtblIndex(13)]
        HRESULT get_Methods(IAppHostMethodCollection** ppMethods);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Name;

        [NativeTypeName("HRESULT (IAppHostElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElementCollection**, int> get_Collection;

        [NativeTypeName("HRESULT (IAppHostPropertyCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostPropertyCollection**, int> get_Properties;

        [NativeTypeName("HRESULT (IAppHostChildElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostChildElementCollection**, int> get_ChildElements;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, int> SetMetadata;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElementSchema**, int> get_Schema;

        [NativeTypeName("HRESULT (BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppHostElement**, int> GetElementByName;

        [NativeTypeName("HRESULT (BSTR, IAppHostProperty **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppHostProperty**, int> GetPropertyByName;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (IAppHostMethodCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostMethodCollection**, int> get_Methods;
    }
}
