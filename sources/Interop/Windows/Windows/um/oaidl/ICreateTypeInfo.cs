// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo"]/*' />
[Guid("00020405-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICreateTypeInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICreateTypeInfo : ICreateTypeInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ICreateTypeInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint>)(lpVtbl[1]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint>)(lpVtbl[2]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, Guid*, int>)(lpVtbl[3]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), guid);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetTypeFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTypeFlags(uint uTypeFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, int>)(lpVtbl[4]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), uTypeFlags);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetDocString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDocString([NativeTypeName("LPOLESTR")] char* pStrDoc)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, char*, int>)(lpVtbl[5]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrDoc);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetHelpContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, int>)(lpVtbl[6]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, ushort, ushort, int>)(lpVtbl[7]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.AddRefTypeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddRefTypeInfo(ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, ITypeInfo*, uint*, int>)(lpVtbl[8]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTInfo, phRefType);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.AddFuncDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddFuncDesc(uint index, FUNCDESC* pFuncDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, FUNCDESC*, int>)(lpVtbl[9]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pFuncDesc);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.AddImplType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddImplType(uint index, [NativeTypeName("HREFTYPE")] uint hRefType)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[10]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, hRefType);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetImplTypeFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetImplTypeFlags(uint index, int implTypeFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, int, int>)(lpVtbl[11]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, implTypeFlags);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetAlignment([NativeTypeName("WORD")] ushort cbAlignment)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, ushort, int>)(lpVtbl[12]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), cbAlignment);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetSchema"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetSchema([NativeTypeName("LPOLESTR")] char* pStrSchema)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, char*, int>)(lpVtbl[13]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pStrSchema);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.AddVarDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddVarDesc(uint index, VARDESC* pVarDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, VARDESC*, int>)(lpVtbl[14]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, pVarDesc);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetFuncAndParamNames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetFuncAndParamNames(uint index, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, char**, uint, int>)(lpVtbl[15]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, rgszNames, cNames);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetVarName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetVarName(uint index, [NativeTypeName("LPOLESTR")] char* szName)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, char*, int>)(lpVtbl[16]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szName);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetTypeDescAlias"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTypeDescAlias(TYPEDESC* pTDescAlias)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, TYPEDESC*, int>)(lpVtbl[17]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pTDescAlias);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.DefineFuncAsDllEntry"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DefineFuncAsDllEntry(uint index, [NativeTypeName("LPOLESTR")] char* szDllName, [NativeTypeName("LPOLESTR")] char* szProcName)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, char*, char*, int>)(lpVtbl[18]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDllName, szProcName);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetFuncDocString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetFuncDocString(uint index, [NativeTypeName("LPOLESTR")] char* szDocString)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, char*, int>)(lpVtbl[19]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetVarDocString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetVarDocString(uint index, [NativeTypeName("LPOLESTR")] char* szDocString)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, char*, int>)(lpVtbl[20]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, szDocString);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetFuncHelpContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetFuncHelpContext(uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[21]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetVarHelpContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetVarHelpContext(uint index, [NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, uint, int>)(lpVtbl[22]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, dwHelpContext);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetMops"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetMops(uint index, [NativeTypeName("BSTR")] char* bstrMops)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, uint, char*, int>)(lpVtbl[23]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), index, bstrMops);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.SetTypeIdldesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetTypeIdldesc(IDLDESC* pIdlDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, IDLDESC*, int>)(lpVtbl[24]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this), pIdlDesc);
    }

    /// <include file='ICreateTypeInfo.xml' path='doc/member[@name="ICreateTypeInfo.LayOut"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT LayOut()
    {
        return ((delegate* unmanaged[MemberFunction]<ICreateTypeInfo*, int>)(lpVtbl[25]))((ICreateTypeInfo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid);

        [VtblIndex(4)]
        HRESULT SetTypeFlags(uint uTypeFlags);

        [VtblIndex(5)]
        HRESULT SetDocString([NativeTypeName("LPOLESTR")] char* pStrDoc);

        [VtblIndex(6)]
        HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext);

        [VtblIndex(7)]
        HRESULT SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum);

        [VtblIndex(8)]
        HRESULT AddRefTypeInfo(ITypeInfo* pTInfo, [NativeTypeName("HREFTYPE *")] uint* phRefType);

        [VtblIndex(9)]
        HRESULT AddFuncDesc(uint index, FUNCDESC* pFuncDesc);

        [VtblIndex(10)]
        HRESULT AddImplType(uint index, [NativeTypeName("HREFTYPE")] uint hRefType);

        [VtblIndex(11)]
        HRESULT SetImplTypeFlags(uint index, int implTypeFlags);

        [VtblIndex(12)]
        HRESULT SetAlignment([NativeTypeName("WORD")] ushort cbAlignment);

        [VtblIndex(13)]
        HRESULT SetSchema([NativeTypeName("LPOLESTR")] char* pStrSchema);

        [VtblIndex(14)]
        HRESULT AddVarDesc(uint index, VARDESC* pVarDesc);

        [VtblIndex(15)]
        HRESULT SetFuncAndParamNames(uint index, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames);

        [VtblIndex(16)]
        HRESULT SetVarName(uint index, [NativeTypeName("LPOLESTR")] char* szName);

        [VtblIndex(17)]
        HRESULT SetTypeDescAlias(TYPEDESC* pTDescAlias);

        [VtblIndex(18)]
        HRESULT DefineFuncAsDllEntry(uint index, [NativeTypeName("LPOLESTR")] char* szDllName, [NativeTypeName("LPOLESTR")] char* szProcName);

        [VtblIndex(19)]
        HRESULT SetFuncDocString(uint index, [NativeTypeName("LPOLESTR")] char* szDocString);

        [VtblIndex(20)]
        HRESULT SetVarDocString(uint index, [NativeTypeName("LPOLESTR")] char* szDocString);

        [VtblIndex(21)]
        HRESULT SetFuncHelpContext(uint index, [NativeTypeName("DWORD")] uint dwHelpContext);

        [VtblIndex(22)]
        HRESULT SetVarHelpContext(uint index, [NativeTypeName("DWORD")] uint dwHelpContext);

        [VtblIndex(23)]
        HRESULT SetMops(uint index, [NativeTypeName("BSTR")] char* bstrMops);

        [VtblIndex(24)]
        HRESULT SetTypeIdldesc(IDLDESC* pIdlDesc);

        [VtblIndex(25)]
        HRESULT LayOut();
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

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> SetGuid;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetTypeFlags;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetDocString;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetHelpContext;

        [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, ushort, int> SetVersion;

        [NativeTypeName("HRESULT (ITypeInfo *, HREFTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypeInfo*, uint*, int> AddRefTypeInfo;

        [NativeTypeName("HRESULT (UINT, FUNCDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, FUNCDESC*, int> AddFuncDesc;

        [NativeTypeName("HRESULT (UINT, HREFTYPE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> AddImplType;

        [NativeTypeName("HRESULT (UINT, INT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int, int> SetImplTypeFlags;

        [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int> SetAlignment;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetSchema;

        [NativeTypeName("HRESULT (UINT, VARDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, VARDESC*, int> AddVarDesc;

        [NativeTypeName("HRESULT (UINT, LPOLESTR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, uint, int> SetFuncAndParamNames;

        [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> SetVarName;

        [NativeTypeName("HRESULT (TYPEDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TYPEDESC*, int> SetTypeDescAlias;

        [NativeTypeName("HRESULT (UINT, LPOLESTR, LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, int> DefineFuncAsDllEntry;

        [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> SetFuncDocString;

        [NativeTypeName("HRESULT (UINT, LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> SetVarDocString;

        [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> SetFuncHelpContext;

        [NativeTypeName("HRESULT (UINT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> SetVarHelpContext;

        [NativeTypeName("HRESULT (UINT, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, int> SetMops;

        [NativeTypeName("HRESULT (IDLDESC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDLDESC*, int> SetTypeIdldesc;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> LayOut;
    }
}
