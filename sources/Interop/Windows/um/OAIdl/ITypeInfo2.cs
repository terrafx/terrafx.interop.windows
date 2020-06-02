// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020412-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeInfo2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ITypeInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ITypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ITypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeAttr([NativeTypeName("TYPEATTR **")] TYPEATTR** ppTypeAttr)
        {
            return lpVtbl->GetTypeAttr((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTypeAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return lpVtbl->GetTypeComp((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC **")] FUNCDESC** ppFuncDesc)
        {
            return lpVtbl->GetFuncDesc((ITypeInfo2*)Unsafe.AsPointer(ref this), index, ppFuncDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC **")] VARDESC** ppVarDesc)
        {
            return lpVtbl->GetVarDesc((ITypeInfo2*)Unsafe.AsPointer(ref this), index, ppVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT *")] uint* pcNames)
        {
            return lpVtbl->GetNames((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, rgBstrNames, cMaxNames, pcNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeOfImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType)
        {
            return lpVtbl->GetRefTypeOfImplType((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT *")] int* pImplTypeFlags)
        {
            return lpVtbl->GetImplTypeFlags((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pImplTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId)
        {
            return lpVtbl->GetIDsOfNames((ITypeInfo2*)Unsafe.AsPointer(ref this), rgszNames, cNames, pMemId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return lpVtbl->Invoke((ITypeInfo2*)Unsafe.AsPointer(ref this), pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return lpVtbl->GetDocumentation((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal)
        {
            return lpVtbl->GetDllEntry((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetRefTypeInfo((ITypeInfo2*)Unsafe.AsPointer(ref this), hRefType, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv)
        {
            return lpVtbl->AddressOfMember((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return lpVtbl->CreateInstance((ITypeInfo2*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops)
        {
            return lpVtbl->GetMops((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pBstrMops);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingTypeLib([NativeTypeName("ITypeLib **")] ITypeLib** ppTLib, [NativeTypeName("UINT *")] uint* pIndex)
        {
            return lpVtbl->GetContainingTypeLib((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTLib, pIndex);
        }

        public void ReleaseTypeAttr([NativeTypeName("TYPEATTR *")] TYPEATTR* pTypeAttr)
        {
            lpVtbl->ReleaseTypeAttr((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeAttr);
        }

        public void ReleaseFuncDesc([NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            lpVtbl->ReleaseFuncDesc((ITypeInfo2*)Unsafe.AsPointer(ref this), pFuncDesc);
        }

        public void ReleaseVarDesc([NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            lpVtbl->ReleaseVarDesc((ITypeInfo2*)Unsafe.AsPointer(ref this), pVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeKind([NativeTypeName("TYPEKIND *")] TYPEKIND* pTypeKind)
        {
            return lpVtbl->GetTypeKind((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeFlags([NativeTypeName("ULONG *")] uint* pTypeFlags)
        {
            return lpVtbl->GetTypeFlags((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncIndexOfMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("UINT *")] uint* pFuncIndex)
        {
            return lpVtbl->GetFuncIndexOfMemId((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, pFuncIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarIndexOfMemId([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("UINT *")] uint* pVarIndex)
        {
            return lpVtbl->GetVarIndexOfMemId((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pVarIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->GetCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->GetFuncCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->GetParamCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->GetVarCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->GetImplTypeCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation2([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pbstrHelpString, [NativeTypeName("DWORD *")] uint* pdwHelpStringContext, [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll)
        {
            return lpVtbl->GetDocumentation2((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllCustData([NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return lpVtbl->GetAllCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return lpVtbl->GetAllFuncCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return lpVtbl->GetAllParamCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return lpVtbl->GetAllVarCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return lpVtbl->GetAllImplTypeCustData((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint> Release;

            [NativeTypeName("HRESULT (TYPEATTR **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, TYPEATTR**, int> GetTypeAttr;

            [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, ITypeComp**, int> GetTypeComp;

            [NativeTypeName("HRESULT (UINT, FUNCDESC **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, FUNCDESC**, int> GetFuncDesc;

            [NativeTypeName("HRESULT (UINT, VARDESC **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, VARDESC**, int> GetVarDesc;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, UINT, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, int, ushort**, uint, uint*, int> GetNames;

            [NativeTypeName("HRESULT (UINT, HREFTYPE *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, uint*, int> GetRefTypeOfImplType;

            [NativeTypeName("HRESULT (UINT, INT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, int*, int> GetImplTypeFlags;

            [NativeTypeName("HRESULT (LPOLESTR *, UINT, MEMBERID *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, ushort**, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (PVOID, MEMBERID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, void*, int, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, int, ushort**, ushort**, uint*, ushort**, int> GetDocumentation;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, BSTR *, BSTR *, WORD *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, int, INVOKEKIND, ushort**, ushort**, ushort*, int> GetDllEntry;

            [NativeTypeName("HRESULT (HREFTYPE, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, ITypeInfo**, int> GetRefTypeInfo;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, PVOID *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, int, INVOKEKIND, void**, int> AddressOfMember;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, PVOID *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, IUnknown*, Guid*, void**, int> CreateInstance;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, int, ushort**, int> GetMops;

            [NativeTypeName("HRESULT (ITypeLib **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, ITypeLib**, uint*, int> GetContainingTypeLib;

            [NativeTypeName("void (TYPEATTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, TYPEATTR*, void> ReleaseTypeAttr;

            [NativeTypeName("void (FUNCDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, FUNCDESC*, void> ReleaseFuncDesc;

            [NativeTypeName("void (VARDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, VARDESC*, void> ReleaseVarDesc;

            [NativeTypeName("HRESULT (TYPEKIND *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, TYPEKIND*, int> GetTypeKind;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint*, int> GetTypeFlags;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, int, INVOKEKIND, uint*, int> GetFuncIndexOfMemId;

            [NativeTypeName("HRESULT (MEMBERID, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, int, uint*, int> GetVarIndexOfMemId;

            [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, Guid*, VARIANT*, int> GetCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, Guid*, VARIANT*, int> GetFuncCustData;

            [NativeTypeName("HRESULT (UINT, UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, uint, Guid*, VARIANT*, int> GetParamCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, Guid*, VARIANT*, int> GetVarCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, Guid*, VARIANT*, int> GetImplTypeCustData;

            [NativeTypeName("HRESULT (MEMBERID, LCID, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, int, uint, ushort**, uint*, ushort**, int> GetDocumentation2;

            [NativeTypeName("HRESULT (CUSTDATA *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, CUSTDATA*, int> GetAllCustData;

            [NativeTypeName("HRESULT (UINT, CUSTDATA *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, CUSTDATA*, int> GetAllFuncCustData;

            [NativeTypeName("HRESULT (UINT, UINT, CUSTDATA *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, uint, CUSTDATA*, int> GetAllParamCustData;

            [NativeTypeName("HRESULT (UINT, CUSTDATA *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, CUSTDATA*, int> GetAllVarCustData;

            [NativeTypeName("HRESULT (UINT, CUSTDATA *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo2*, uint, CUSTDATA*, int> GetAllImplTypeCustData;
        }
    }
}
