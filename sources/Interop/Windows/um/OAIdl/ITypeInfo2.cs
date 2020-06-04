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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ITypeInfo2*, Guid*, void**, int>)(lpVtbl[0]))((ITypeInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ITypeInfo2*, uint>)(lpVtbl[1]))((ITypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ITypeInfo2*, uint>)(lpVtbl[2]))((ITypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeAttr([NativeTypeName("TYPEATTR **")] TYPEATTR** ppTypeAttr)
        {
            return ((delegate* stdcall<ITypeInfo2*, TYPEATTR**, int>)(lpVtbl[3]))((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTypeAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return ((delegate* stdcall<ITypeInfo2*, ITypeComp**, int>)(lpVtbl[4]))((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC **")] FUNCDESC** ppFuncDesc)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, FUNCDESC**, int>)(lpVtbl[5]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, ppFuncDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC **")] VARDESC** ppVarDesc)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, VARDESC**, int>)(lpVtbl[6]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, ppVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT *")] uint* pcNames)
        {
            return ((delegate* stdcall<ITypeInfo2*, int, ushort**, uint, uint*, int>)(lpVtbl[7]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, rgBstrNames, cMaxNames, pcNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeOfImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, uint*, int>)(lpVtbl[8]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT *")] int* pImplTypeFlags)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, int*, int>)(lpVtbl[9]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pImplTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId)
        {
            return ((delegate* stdcall<ITypeInfo2*, ushort**, uint, int*, int>)(lpVtbl[10]))((ITypeInfo2*)Unsafe.AsPointer(ref this), rgszNames, cNames, pMemId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ITypeInfo2*, void*, int, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[11]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return ((delegate* stdcall<ITypeInfo2*, int, ushort**, ushort**, uint*, ushort**, int>)(lpVtbl[12]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal)
        {
            return ((delegate* stdcall<ITypeInfo2*, int, INVOKEKIND, ushort**, ushort**, ushort*, int>)(lpVtbl[13]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, ITypeInfo**, int>)(lpVtbl[14]))((ITypeInfo2*)Unsafe.AsPointer(ref this), hRefType, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv)
        {
            return ((delegate* stdcall<ITypeInfo2*, int, INVOKEKIND, void**, int>)(lpVtbl[15]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return ((delegate* stdcall<ITypeInfo2*, IUnknown*, Guid*, void**, int>)(lpVtbl[16]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops)
        {
            return ((delegate* stdcall<ITypeInfo2*, int, ushort**, int>)(lpVtbl[17]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pBstrMops);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingTypeLib([NativeTypeName("ITypeLib **")] ITypeLib** ppTLib, [NativeTypeName("UINT *")] uint* pIndex)
        {
            return ((delegate* stdcall<ITypeInfo2*, ITypeLib**, uint*, int>)(lpVtbl[18]))((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTLib, pIndex);
        }

        public void ReleaseTypeAttr([NativeTypeName("TYPEATTR *")] TYPEATTR* pTypeAttr)
        {
            ((delegate* stdcall<ITypeInfo2*, TYPEATTR*, void>)(lpVtbl[19]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeAttr);
        }

        public void ReleaseFuncDesc([NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            ((delegate* stdcall<ITypeInfo2*, FUNCDESC*, void>)(lpVtbl[20]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pFuncDesc);
        }

        public void ReleaseVarDesc([NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            ((delegate* stdcall<ITypeInfo2*, VARDESC*, void>)(lpVtbl[21]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeKind([NativeTypeName("TYPEKIND *")] TYPEKIND* pTypeKind)
        {
            return ((delegate* stdcall<ITypeInfo2*, TYPEKIND*, int>)(lpVtbl[22]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeFlags([NativeTypeName("ULONG *")] uint* pTypeFlags)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint*, int>)(lpVtbl[23]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncIndexOfMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("UINT *")] uint* pFuncIndex)
        {
            return ((delegate* stdcall<ITypeInfo2*, int, INVOKEKIND, uint*, int>)(lpVtbl[24]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, pFuncIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarIndexOfMemId([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("UINT *")] uint* pVarIndex)
        {
            return ((delegate* stdcall<ITypeInfo2*, int, uint*, int>)(lpVtbl[25]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pVarIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* stdcall<ITypeInfo2*, Guid*, VARIANT*, int>)(lpVtbl[26]))((ITypeInfo2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[27]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, uint, Guid*, VARIANT*, int>)(lpVtbl[28]))((ITypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[29]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, Guid*, VARIANT*, int>)(lpVtbl[30]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation2([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pbstrHelpString, [NativeTypeName("DWORD *")] uint* pdwHelpStringContext, [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll)
        {
            return ((delegate* stdcall<ITypeInfo2*, int, uint, ushort**, uint*, ushort**, int>)(lpVtbl[31]))((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllCustData([NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return ((delegate* stdcall<ITypeInfo2*, CUSTDATA*, int>)(lpVtbl[32]))((ITypeInfo2*)Unsafe.AsPointer(ref this), pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, CUSTDATA*, int>)(lpVtbl[33]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, uint, CUSTDATA*, int>)(lpVtbl[34]))((ITypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, CUSTDATA*, int>)(lpVtbl[35]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return ((delegate* stdcall<ITypeInfo2*, uint, CUSTDATA*, int>)(lpVtbl[36]))((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }
    }
}
