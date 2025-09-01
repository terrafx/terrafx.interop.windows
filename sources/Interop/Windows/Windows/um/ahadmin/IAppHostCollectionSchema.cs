// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAppHostCollectionSchema.xml' path='doc/member[@name="IAppHostCollectionSchema"]/*' />
[Guid("DE095DB1-5368-4D11-81F6-EFEF619B7BCF")]
[NativeTypeName("struct IAppHostCollectionSchema : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostCollectionSchema : IAppHostCollectionSchema.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAppHostCollectionSchema);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, Guid*, void**, int>)(lpVtbl[0]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, uint>)(lpVtbl[1]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, uint>)(lpVtbl[2]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppHostCollectionSchema.xml' path='doc/member[@name="IAppHostCollectionSchema.get_AddElementNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_AddElementNames([NativeTypeName("BSTR *")] char** pbstrElementName)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, char**, int>)(lpVtbl[3]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this), pbstrElementName);
    }

    /// <include file='IAppHostCollectionSchema.xml' path='doc/member[@name="IAppHostCollectionSchema.GetAddElementSchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAddElementSchema([NativeTypeName("BSTR")] char* bstrElementName, IAppHostElementSchema** ppSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, char*, IAppHostElementSchema**, int>)(lpVtbl[4]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this), bstrElementName, ppSchema);
    }

    /// <include file='IAppHostCollectionSchema.xml' path='doc/member[@name="IAppHostCollectionSchema.get_RemoveElementSchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_RemoveElementSchema(IAppHostElementSchema** ppSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, IAppHostElementSchema**, int>)(lpVtbl[5]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this), ppSchema);
    }

    /// <include file='IAppHostCollectionSchema.xml' path='doc/member[@name="IAppHostCollectionSchema.get_ClearElementSchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ClearElementSchema(IAppHostElementSchema** ppSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, IAppHostElementSchema**, int>)(lpVtbl[6]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this), ppSchema);
    }

    /// <include file='IAppHostCollectionSchema.xml' path='doc/member[@name="IAppHostCollectionSchema.get_IsMergeAppend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsMergeAppend([NativeTypeName("VARIANT_BOOL *")] short* pfIsMergeAppend)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, short*, int>)(lpVtbl[7]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this), pfIsMergeAppend);
    }

    /// <include file='IAppHostCollectionSchema.xml' path='doc/member[@name="IAppHostCollectionSchema.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, char*, VARIANT*, int>)(lpVtbl[8]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this), bstrMetadataType, pValue);
    }

    /// <include file='IAppHostCollectionSchema.xml' path='doc/member[@name="IAppHostCollectionSchema.get_DoesAllowDuplicates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DoesAllowDuplicates([NativeTypeName("VARIANT_BOOL *")] short* pfAllowDuplicates)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppHostCollectionSchema*, short*, int>)(lpVtbl[9]))((IAppHostCollectionSchema*)Unsafe.AsPointer(ref this), pfAllowDuplicates);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_AddElementNames([NativeTypeName("BSTR *")] char** pbstrElementName);

        [VtblIndex(4)]
        HRESULT GetAddElementSchema([NativeTypeName("BSTR")] char* bstrElementName, IAppHostElementSchema** ppSchema);

        [VtblIndex(5)]
        HRESULT get_RemoveElementSchema(IAppHostElementSchema** ppSchema);

        [VtblIndex(6)]
        HRESULT get_ClearElementSchema(IAppHostElementSchema** ppSchema);

        [VtblIndex(7)]
        HRESULT get_IsMergeAppend([NativeTypeName("VARIANT_BOOL *")] short* pfIsMergeAppend);

        [VtblIndex(8)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] char* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(9)]
        HRESULT get_DoesAllowDuplicates([NativeTypeName("VARIANT_BOOL *")] short* pfAllowDuplicates);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_AddElementNames;

        [NativeTypeName("HRESULT (BSTR, IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IAppHostElementSchema**, int> GetAddElementSchema;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElementSchema**, int> get_RemoveElementSchema;

        [NativeTypeName("HRESULT (IAppHostElementSchema **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostElementSchema**, int> get_ClearElementSchema;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsMergeAppend;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_DoesAllowDuplicates;
    }
}
