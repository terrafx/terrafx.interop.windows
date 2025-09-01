// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty"]/*' />
[Guid("ED35F7A1-5024-4E7B-A44D-07DDAF4B524D")]
[NativeTypeName("struct IAppHostProperty : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostProperty : IAppHostProperty.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostProperty);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, uint>)(lpVtbl[1]))((IAppHostProperty*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, uint>)(lpVtbl[2]))((IAppHostProperty*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, char**, int>)(lpVtbl[3]))((IAppHostProperty*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Value(VARIANT* pVariant)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, VARIANT*, int>)(lpVtbl[4]))((IAppHostProperty*)Unsafe.AsPointer(ref this), pVariant);
    }

    /// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty.put_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT put_Value(VARIANT value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, VARIANT, int>)(lpVtbl[5]))((IAppHostProperty*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, int>)(lpVtbl[6]))((IAppHostProperty*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty.get_StringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StringValue([NativeTypeName("BSTR *")] char** pbstrValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, char**, int>)(lpVtbl[7]))((IAppHostProperty*)Unsafe.AsPointer(ref this), pbstrValue);
    }

    /// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty.get_Exception"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Exception(IAppHostPropertyException** ppException)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, IAppHostPropertyException**, int>)(lpVtbl[8]))((IAppHostProperty*)Unsafe.AsPointer(ref this), ppException);
    }

    /// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, char*, VARIANT*, int>)(lpVtbl[9]))((IAppHostProperty*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    /// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty.SetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, char*, VARIANT, int>)(lpVtbl[10]))((IAppHostProperty*)Unsafe.AsPointer(ref this), bstrMetadataType, value);
    }

    /// <include file='IAppHostProperty.xml' path='doc/member[@name="IAppHostProperty.get_Schema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Schema(IAppHostPropertySchema** ppSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostProperty*, IAppHostPropertySchema**, int>)(lpVtbl[11]))((IAppHostProperty*)Unsafe.AsPointer(ref this), ppSchema);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName);

        [VtblIndex(4)]
        HRESULT get_Value(VARIANT* pVariant);

        [VtblIndex(5)]
        HRESULT put_Value(VARIANT value);

        [VtblIndex(6)]
        HRESULT Clear();

        [VtblIndex(7)]
        HRESULT get_StringValue([NativeTypeName("BSTR *")] char** pbstrValue);

        [VtblIndex(8)]
        HRESULT get_Exception(IAppHostPropertyException** ppException);

        [VtblIndex(9)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(10)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT value);

        [VtblIndex(11)]
        HRESULT get_Schema(IAppHostPropertySchema** ppSchema);
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

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_Value;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_Value;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_StringValue;

        [NativeTypeName("HRESULT (IAppHostPropertyException **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostPropertyException**, int> get_Exception;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT, int> SetMetadata;

        [NativeTypeName("HRESULT (IAppHostPropertySchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostPropertySchema**, int> get_Schema;
    }
}
