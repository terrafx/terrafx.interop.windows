// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostElementSchema.xml' path='doc/member[@name="IAppHostElementSchema"]/*' />
[Guid("EF13D885-642C-4709-99EC-B89561C6BC69")]
[NativeTypeName("struct IAppHostElementSchema : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostElementSchema : IAppHostElementSchema.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostElementSchema));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, uint>)(lpVtbl[1]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, uint>)(lpVtbl[2]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostElementSchema.xml' path='doc/member[@name="IAppHostElementSchema.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, char**, int>)(lpVtbl[3]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='IAppHostElementSchema.xml' path='doc/member[@name="IAppHostElementSchema.get_DoesAllowUnschematizedProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_DoesAllowUnschematizedProperties([NativeTypeName("VARIANT_BOOL *")] short* pfAllowUnschematized)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, short*, int>)(lpVtbl[4]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this), pfAllowUnschematized);
    }

    /// <include file='IAppHostElementSchema.xml' path='doc/member[@name="IAppHostElementSchema.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, char*, VARIANT*, int>)(lpVtbl[5]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    /// <include file='IAppHostElementSchema.xml' path='doc/member[@name="IAppHostElementSchema.get_CollectionSchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CollectionSchema(IAppHostCollectionSchema** ppCollectionSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, IAppHostCollectionSchema**, int>)(lpVtbl[6]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this), ppCollectionSchema);
    }

    /// <include file='IAppHostElementSchema.xml' path='doc/member[@name="IAppHostElementSchema.get_ChildElementSchemas"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ChildElementSchemas(IAppHostElementSchemaCollection** ppChildSchemas)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, IAppHostElementSchemaCollection**, int>)(lpVtbl[7]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this), ppChildSchemas);
    }

    /// <include file='IAppHostElementSchema.xml' path='doc/member[@name="IAppHostElementSchema.get_PropertySchemas"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PropertySchemas(IAppHostPropertySchemaCollection** ppPropertySchemas)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, IAppHostPropertySchemaCollection**, int>)(lpVtbl[8]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this), ppPropertySchemas);
    }

    /// <include file='IAppHostElementSchema.xml' path='doc/member[@name="IAppHostElementSchema.get_IsCollectionDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsCollectionDefault([NativeTypeName("VARIANT_BOOL *")] short* pfIsCollectionDefault)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostElementSchema*, short*, int>)(lpVtbl[9]))((IAppHostElementSchema*)Unsafe.AsPointer(ref this), pfIsCollectionDefault);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Name([NativeTypeName("BSTR *")] char** pbstrName);

        [VtblIndex(4)]
        HRESULT get_DoesAllowUnschematizedProperties([NativeTypeName("VARIANT_BOOL *")] short* pfAllowUnschematized);

        [VtblIndex(5)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(6)]
        HRESULT get_CollectionSchema(IAppHostCollectionSchema** ppCollectionSchema);

        [VtblIndex(7)]
        HRESULT get_ChildElementSchemas(IAppHostElementSchemaCollection** ppChildSchemas);

        [VtblIndex(8)]
        HRESULT get_PropertySchemas(IAppHostPropertySchemaCollection** ppPropertySchemas);

        [VtblIndex(9)]
        HRESULT get_IsCollectionDefault([NativeTypeName("VARIANT_BOOL *")] short* pfIsCollectionDefault);
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

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_DoesAllowUnschematizedProperties;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (IAppHostCollectionSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostCollectionSchema**, int> get_CollectionSchema;

        [NativeTypeName("HRESULT (IAppHostElementSchemaCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElementSchemaCollection**, int> get_ChildElementSchemas;

        [NativeTypeName("HRESULT (IAppHostPropertySchemaCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostPropertySchemaCollection**, int> get_PropertySchemas;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsCollectionDefault;
    }
}
