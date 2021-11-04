// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020412-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeInfo2 : ITypeInfo")]
    [NativeInheritance("ITypeInfo")]
    public unsafe partial struct ITypeInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITypeInfo2*, Guid*, void**, int>)(lpVtbl[0]))((ITypeInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint>)(lpVtbl[1]))((ITypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint>)(lpVtbl[2]))((ITypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeAttr(TYPEATTR** ppTypeAttr)
        {
            return ((delegate* unmanaged<ITypeInfo2*, TYPEATTR**, int>)(lpVtbl[3]))((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTypeAttr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeComp(ITypeComp** ppTComp)
        {
            return ((delegate* unmanaged<ITypeInfo2*, ITypeComp**, int>)(lpVtbl[4]))((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetFuncDesc(uint index, FUNCDESC** ppFuncDesc)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, FUNCDESC**, int>)(lpVtbl[5]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, ppFuncDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetVarDesc(uint index, VARDESC** ppVarDesc)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, VARDESC**, int>)(lpVtbl[6]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, ppVarDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, uint cMaxNames, uint* pcNames)
        {
            return ((delegate* unmanaged<ITypeInfo2*, int, ushort**, uint, uint*, int>)(lpVtbl[7]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, rgBstrNames, cMaxNames, pcNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetRefTypeOfImplType(uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, uint*, int>)(lpVtbl[8]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetImplTypeFlags(uint index, int* pImplTypeFlags)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, int*, int>)(lpVtbl[9]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pImplTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetIDsOfNames([NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId)
        {
            return ((delegate* unmanaged<ITypeInfo2*, ushort**, uint, int*, int>)(lpVtbl[10]))((ITypeInfo2*)Unsafe.AsPointer(ref this), rgszNames, cNames, pMemId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ITypeInfo2*, void*, int, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[11]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetDocumentation([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return ((delegate* unmanaged<ITypeInfo2*, int, ushort**, ushort**, uint*, ushort**, int>)(lpVtbl[12]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal)
        {
            return ((delegate* unmanaged<ITypeInfo2*, int, INVOKEKIND, ushort**, ushort**, ushort*, int>)(lpVtbl[13]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, ITypeInfo**, int>)(lpVtbl[14]))((ITypeInfo2*)Unsafe.AsPointer(ref this), hRefType, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<ITypeInfo2*, int, INVOKEKIND, void**, int>)(lpVtbl[15]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return ((delegate* unmanaged<ITypeInfo2*, IUnknown*, Guid*, void**, int>)(lpVtbl[16]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops)
        {
            return ((delegate* unmanaged<ITypeInfo2*, int, ushort**, int>)(lpVtbl[17]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pBstrMops);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetContainingTypeLib(ITypeLib** ppTLib, uint* pIndex)
        {
            return ((delegate* unmanaged<ITypeInfo2*, ITypeLib**, uint*, int>)(lpVtbl[18]))((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTLib, pIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void ReleaseTypeAttr(TYPEATTR* pTypeAttr)
        {
            ((delegate* unmanaged<ITypeInfo2*, TYPEATTR*, void>)(lpVtbl[19]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeAttr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void ReleaseFuncDesc(FUNCDESC* pFuncDesc)
        {
            ((delegate* unmanaged<ITypeInfo2*, FUNCDESC*, void>)(lpVtbl[20]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pFuncDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void ReleaseVarDesc(VARDESC* pVarDesc)
        {
            ((delegate* unmanaged<ITypeInfo2*, VARDESC*, void>)(lpVtbl[21]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pVarDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetTypeKind(TYPEKIND* pTypeKind)
        {
            return ((delegate* unmanaged<ITypeInfo2*, TYPEKIND*, int>)(lpVtbl[22]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeKind);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetTypeFlags([NativeTypeName("ULONG *")] uint* pTypeFlags)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint*, int>)(lpVtbl[23]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetFuncIndexOfMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, uint* pFuncIndex)
        {
            return ((delegate* unmanaged<ITypeInfo2*, int, INVOKEKIND, uint*, int>)(lpVtbl[24]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, pFuncIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetVarIndexOfMemId([NativeTypeName("MEMBERID")] int memid, uint* pVarIndex)
        {
            return ((delegate* unmanaged<ITypeInfo2*, int, uint*, int>)(lpVtbl[25]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pVarIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ITypeInfo2*, Guid*, VARIANT*, int>)(lpVtbl[26]))((ITypeInfo2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetFuncCustData(uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[27]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetParamCustData(uint indexFunc, uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, uint, Guid*, VARIANT*, int>)(lpVtbl[28]))((ITypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetVarCustData(uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[29]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetImplTypeCustData(uint index, [NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[30]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetDocumentation2([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pbstrHelpString, [NativeTypeName("DWORD *")] uint* pdwHelpStringContext, [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll)
        {
            return ((delegate* unmanaged<ITypeInfo2*, int, uint, ushort**, uint*, ushort**, int>)(lpVtbl[31]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT GetAllCustData(CUSTDATA* pCustData)
        {
            return ((delegate* unmanaged<ITypeInfo2*, CUSTDATA*, int>)(lpVtbl[32]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pCustData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetAllFuncCustData(uint index, CUSTDATA* pCustData)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, CUSTDATA*, int>)(lpVtbl[33]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetAllParamCustData(uint indexFunc, uint indexParam, CUSTDATA* pCustData)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, uint, CUSTDATA*, int>)(lpVtbl[34]))((ITypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, pCustData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetAllVarCustData(uint index, CUSTDATA* pCustData)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, CUSTDATA*, int>)(lpVtbl[35]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetAllImplTypeCustData(uint index, CUSTDATA* pCustData)
        {
            return ((delegate* unmanaged<ITypeInfo2*, uint, CUSTDATA*, int>)(lpVtbl[36]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint> Release;

            [NativeTypeName("HRESULT (TYPEATTR **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, TYPEATTR**, int> GetTypeAttr;

            [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, ITypeComp**, int> GetTypeComp;

            [NativeTypeName("HRESULT (UINT, FUNCDESC **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, FUNCDESC**, int> GetFuncDesc;

            [NativeTypeName("HRESULT (UINT, VARDESC **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, VARDESC**, int> GetVarDesc;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, UINT, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, int, ushort**, uint, uint*, int> GetNames;

            [NativeTypeName("HRESULT (UINT, HREFTYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, uint*, int> GetRefTypeOfImplType;

            [NativeTypeName("HRESULT (UINT, INT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, int*, int> GetImplTypeFlags;

            [NativeTypeName("HRESULT (LPOLESTR *, UINT, MEMBERID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, ushort**, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (PVOID, MEMBERID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, void*, int, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, int, ushort**, ushort**, uint*, ushort**, int> GetDocumentation;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, BSTR *, BSTR *, WORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, int, INVOKEKIND, ushort**, ushort**, ushort*, int> GetDllEntry;

            [NativeTypeName("HRESULT (HREFTYPE, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, ITypeInfo**, int> GetRefTypeInfo;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, PVOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, int, INVOKEKIND, void**, int> AddressOfMember;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, PVOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, IUnknown*, Guid*, void**, int> CreateInstance;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, int, ushort**, int> GetMops;

            [NativeTypeName("HRESULT (ITypeLib **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, ITypeLib**, uint*, int> GetContainingTypeLib;

            [NativeTypeName("void (TYPEATTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, TYPEATTR*, void> ReleaseTypeAttr;

            [NativeTypeName("void (FUNCDESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, FUNCDESC*, void> ReleaseFuncDesc;

            [NativeTypeName("void (VARDESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, VARDESC*, void> ReleaseVarDesc;

            [NativeTypeName("HRESULT (TYPEKIND *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, TYPEKIND*, int> GetTypeKind;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint*, int> GetTypeFlags;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, int, INVOKEKIND, uint*, int> GetFuncIndexOfMemId;

            [NativeTypeName("HRESULT (MEMBERID, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, int, uint*, int> GetVarIndexOfMemId;

            [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, Guid*, VARIANT*, int> GetCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, Guid*, VARIANT*, int> GetFuncCustData;

            [NativeTypeName("HRESULT (UINT, UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, uint, Guid*, VARIANT*, int> GetParamCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, Guid*, VARIANT*, int> GetVarCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, Guid*, VARIANT*, int> GetImplTypeCustData;

            [NativeTypeName("HRESULT (MEMBERID, LCID, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, int, uint, ushort**, uint*, ushort**, int> GetDocumentation2;

            [NativeTypeName("HRESULT (CUSTDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, CUSTDATA*, int> GetAllCustData;

            [NativeTypeName("HRESULT (UINT, CUSTDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, CUSTDATA*, int> GetAllFuncCustData;

            [NativeTypeName("HRESULT (UINT, UINT, CUSTDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, uint, CUSTDATA*, int> GetAllParamCustData;

            [NativeTypeName("HRESULT (UINT, CUSTDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, CUSTDATA*, int> GetAllVarCustData;

            [NativeTypeName("HRESULT (UINT, CUSTDATA *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeInfo2*, uint, CUSTDATA*, int> GetAllImplTypeCustData;
        }
    }
}
