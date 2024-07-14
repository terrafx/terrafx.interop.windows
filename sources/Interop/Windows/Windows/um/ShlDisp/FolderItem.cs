// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='FolderItem.xml' path='doc/member[@name="FolderItem"]/*' />
[Guid("FAC32C80-CBE4-11CE-8350-444553540000")]
[NativeTypeName("struct FolderItem : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct FolderItem : FolderItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_FolderItem));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, Guid*, void**, int>)(lpVtbl[0]))((FolderItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, uint>)(lpVtbl[1]))((FolderItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, uint>)(lpVtbl[2]))((FolderItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, uint*, int>)(lpVtbl[3]))((FolderItem*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((FolderItem*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((FolderItem*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((FolderItem*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_Application"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Application(IDispatch** ppid)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, IDispatch**, int>)(lpVtbl[7]))((FolderItem*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_Parent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Parent(IDispatch** ppid)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, IDispatch**, int>)(lpVtbl[8]))((FolderItem*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] char** pbs)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, char**, int>)(lpVtbl[9]))((FolderItem*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.put_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Name([NativeTypeName("BSTR")] char* bs)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, char*, int>)(lpVtbl[10]))((FolderItem*)Unsafe.AsPointer(ref this), bs);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_Path"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Path([NativeTypeName("BSTR *")] char** pbs)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, char**, int>)(lpVtbl[11]))((FolderItem*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_GetLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_GetLink(IDispatch** ppid)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, IDispatch**, int>)(lpVtbl[12]))((FolderItem*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_GetFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_GetFolder(IDispatch** ppid)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, IDispatch**, int>)(lpVtbl[13]))((FolderItem*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_IsLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsLink([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, short*, int>)(lpVtbl[14]))((FolderItem*)Unsafe.AsPointer(ref this), pb);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_IsFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsFolder([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, short*, int>)(lpVtbl[15]))((FolderItem*)Unsafe.AsPointer(ref this), pb);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_IsFileSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsFileSystem([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, short*, int>)(lpVtbl[16]))((FolderItem*)Unsafe.AsPointer(ref this), pb);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_IsBrowsable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_IsBrowsable([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, short*, int>)(lpVtbl[17]))((FolderItem*)Unsafe.AsPointer(ref this), pb);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_ModifyDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ModifyDate([NativeTypeName("DATE *")] double* pdt)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, double*, int>)(lpVtbl[18]))((FolderItem*)Unsafe.AsPointer(ref this), pdt);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.put_ModifyDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ModifyDate([NativeTypeName("DATE")] double dt)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, double, int>)(lpVtbl[19]))((FolderItem*)Unsafe.AsPointer(ref this), dt);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Size([NativeTypeName("LONG *")] int* pul)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, int*, int>)(lpVtbl[20]))((FolderItem*)Unsafe.AsPointer(ref this), pul);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] char** pbs)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, char**, int>)(lpVtbl[21]))((FolderItem*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.Verbs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT Verbs(FolderItemVerbs** ppfic)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, FolderItemVerbs**, int>)(lpVtbl[22]))((FolderItem*)Unsafe.AsPointer(ref this), ppfic);
    }

    /// <include file='FolderItem.xml' path='doc/member[@name="FolderItem.InvokeVerb"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT InvokeVerb(VARIANT vVerb)
    {
        return ((delegate* unmanaged[MemberFunction]<FolderItem*, VARIANT, int>)(lpVtbl[23]))((FolderItem*)Unsafe.AsPointer(ref this), vVerb);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Application(IDispatch** ppid);

        [VtblIndex(8)]
        HRESULT get_Parent(IDispatch** ppid);

        [VtblIndex(9)]
        HRESULT get_Name([NativeTypeName("BSTR *")] char** pbs);

        [VtblIndex(10)]
        HRESULT put_Name([NativeTypeName("BSTR")] char* bs);

        [VtblIndex(11)]
        HRESULT get_Path([NativeTypeName("BSTR *")] char** pbs);

        [VtblIndex(12)]
        HRESULT get_GetLink(IDispatch** ppid);

        [VtblIndex(13)]
        HRESULT get_GetFolder(IDispatch** ppid);

        [VtblIndex(14)]
        HRESULT get_IsLink([NativeTypeName("VARIANT_BOOL *")] short* pb);

        [VtblIndex(15)]
        HRESULT get_IsFolder([NativeTypeName("VARIANT_BOOL *")] short* pb);

        [VtblIndex(16)]
        HRESULT get_IsFileSystem([NativeTypeName("VARIANT_BOOL *")] short* pb);

        [VtblIndex(17)]
        HRESULT get_IsBrowsable([NativeTypeName("VARIANT_BOOL *")] short* pb);

        [VtblIndex(18)]
        HRESULT get_ModifyDate([NativeTypeName("DATE *")] double* pdt);

        [VtblIndex(19)]
        HRESULT put_ModifyDate([NativeTypeName("DATE")] double dt);

        [VtblIndex(20)]
        HRESULT get_Size([NativeTypeName("LONG *")] int* pul);

        [VtblIndex(21)]
        HRESULT get_Type([NativeTypeName("BSTR *")] char** pbs);

        [VtblIndex(22)]
        HRESULT Verbs(FolderItemVerbs** ppfic);

        [VtblIndex(23)]
        HRESULT InvokeVerb(VARIANT vVerb);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatch**, int> get_Application;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatch**, int> get_Parent;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_Name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Path;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatch**, int> get_GetLink;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatch**, int> get_GetFolder;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsLink;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsFolder;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsFileSystem;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> get_IsBrowsable;

        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_ModifyDate;

        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_ModifyDate;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Size;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_Type;

        [NativeTypeName("HRESULT (FolderItemVerbs **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FolderItemVerbs**, int> Verbs;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> InvokeVerb;
    }
}
