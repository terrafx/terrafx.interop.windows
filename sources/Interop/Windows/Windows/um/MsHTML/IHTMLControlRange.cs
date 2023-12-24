// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange"]/*' />
[Guid("3050F29C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLControlRange : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLControlRange : IHTMLControlRange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLControlRange));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, uint>)(lpVtbl[1]))((IHTMLControlRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, uint>)(lpVtbl[2]))((IHTMLControlRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, uint*, int>)(lpVtbl[3]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.select"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT select()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, int>)(lpVtbl[7]))((IHTMLControlRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.add"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add(IHTMLControlElement* item)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, IHTMLControlElement*, int>)(lpVtbl[8]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), item);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove([NativeTypeName("long")] int index)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, int, int>)(lpVtbl[9]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), index);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT item([NativeTypeName("long")] int index, IHTMLElement** pdisp)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, int, IHTMLElement**, int>)(lpVtbl[10]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), index, pdisp);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.scrollIntoView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT scrollIntoView(VARIANT varargStart)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, VARIANT, int>)(lpVtbl[11]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), varargStart);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.queryCommandSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT queryCommandSupported([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, char*, short*, int>)(lpVtbl[12]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.queryCommandEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT queryCommandEnabled([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, char*, short*, int>)(lpVtbl[13]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.queryCommandState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT queryCommandState([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, char*, short*, int>)(lpVtbl[14]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.queryCommandIndeterm"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT queryCommandIndeterm([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, char*, short*, int>)(lpVtbl[15]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.queryCommandText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT queryCommandText([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("BSTR *")] char** pcmdText)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, char*, char**, int>)(lpVtbl[16]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pcmdText);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.queryCommandValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT queryCommandValue([NativeTypeName("BSTR")] char* cmdID, VARIANT* pcmdValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, char*, VARIANT*, int>)(lpVtbl[17]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pcmdValue);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.execCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT execCommand([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, char*, short, VARIANT, short*, int>)(lpVtbl[18]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, showUI, value, pfRet);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.execCommandShowHelp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT execCommandShowHelp([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, char*, short*, int>)(lpVtbl[19]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), cmdID, pfRet);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.commonParentElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT commonParentElement(IHTMLElement** parent)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, IHTMLElement**, int>)(lpVtbl[20]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), parent);
    }

    /// <include file='IHTMLControlRange.xml' path='doc/member[@name="IHTMLControlRange.get_length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLControlRange*, int*, int>)(lpVtbl[21]))((IHTMLControlRange*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT select();

        [VtblIndex(8)]
        HRESULT add(IHTMLControlElement* item);

        [VtblIndex(9)]
        HRESULT remove([NativeTypeName("long")] int index);

        [VtblIndex(10)]
        HRESULT item([NativeTypeName("long")] int index, IHTMLElement** pdisp);

        [VtblIndex(11)]
        HRESULT scrollIntoView(VARIANT varargStart);

        [VtblIndex(12)]
        HRESULT queryCommandSupported([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(13)]
        HRESULT queryCommandEnabled([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(14)]
        HRESULT queryCommandState([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(15)]
        HRESULT queryCommandIndeterm([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(16)]
        HRESULT queryCommandText([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("BSTR *")] char** pcmdText);

        [VtblIndex(17)]
        HRESULT queryCommandValue([NativeTypeName("BSTR")] char* cmdID, VARIANT* pcmdValue);

        [VtblIndex(18)]
        HRESULT execCommand([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL")] short showUI, VARIANT value, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(19)]
        HRESULT execCommandShowHelp([NativeTypeName("BSTR")] char* cmdID, [NativeTypeName("VARIANT_BOOL *")] short* pfRet);

        [VtblIndex(20)]
        HRESULT commonParentElement(IHTMLElement** parent);

        [VtblIndex(21)]
        HRESULT get_length([NativeTypeName("long *")] int* p);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> select;

        [NativeTypeName("HRESULT (IHTMLControlElement *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHTMLControlElement*, int> add;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> remove;

        [NativeTypeName("HRESULT (long, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IHTMLElement**, int> item;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> scrollIntoView;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> queryCommandSupported;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> queryCommandEnabled;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> queryCommandState;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> queryCommandIndeterm;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> queryCommandText;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, VARIANT*, int> queryCommandValue;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short, VARIANT, short*, int> execCommand;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short*, int> execCommandShowHelp;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHTMLElement**, int> commonParentElement;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_length;
    }
}
