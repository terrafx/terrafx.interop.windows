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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ITypeInfo2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ITypeInfo2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ITypeInfo2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeAttr(ITypeInfo2* pThis, [NativeTypeName("TYPEATTR **")] TYPEATTR** ppTypeAttr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeComp(ITypeInfo2* pThis, [NativeTypeName("ITypeComp **")] ITypeComp** ppTComp);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFuncDesc(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC **")] FUNCDESC** ppFuncDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVarDesc(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC **")] VARDESC** ppVarDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNames(ITypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT *")] uint* pcNames);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRefTypeOfImplType(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetImplTypeFlags(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("INT *")] int* pImplTypeFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(ITypeInfo2* pThis, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(ITypeInfo2* pThis, [NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDocumentation(ITypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDllEntry(ITypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRefTypeInfo(ITypeInfo2* pThis, [NativeTypeName("HREFTYPE")] uint hRefType, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddressOfMember(ITypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(ITypeInfo2* pThis, [NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMops(ITypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainingTypeLib(ITypeInfo2* pThis, [NativeTypeName("ITypeLib **")] ITypeLib** ppTLib, [NativeTypeName("UINT *")] uint* pIndex);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ReleaseTypeAttr(ITypeInfo2* pThis, [NativeTypeName("TYPEATTR *")] TYPEATTR* pTypeAttr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ReleaseFuncDesc(ITypeInfo2* pThis, [NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _ReleaseVarDesc(ITypeInfo2* pThis, [NativeTypeName("VARDESC *")] VARDESC* pVarDesc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeKind(ITypeInfo2* pThis, [NativeTypeName("TYPEKIND *")] TYPEKIND* pTypeKind);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeFlags(ITypeInfo2* pThis, [NativeTypeName("ULONG *")] uint* pTypeFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFuncIndexOfMemId(ITypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("UINT *")] uint* pFuncIndex);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVarIndexOfMemId(ITypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("UINT *")] uint* pVarIndex);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCustData(ITypeInfo2* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFuncCustData(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParamCustData(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVarCustData(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetImplTypeCustData(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDocumentation2(ITypeInfo2* pThis, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pbstrHelpString, [NativeTypeName("DWORD *")] uint* pdwHelpStringContext, [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAllCustData(ITypeInfo2* pThis, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAllFuncCustData(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAllParamCustData(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAllVarCustData(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAllImplTypeCustData(ITypeInfo2* pThis, [NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ITypeInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ITypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ITypeInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeAttr([NativeTypeName("TYPEATTR **")] TYPEATTR** ppTypeAttr)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeAttr>(lpVtbl->GetTypeAttr)((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTypeAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeComp>(lpVtbl->GetTypeComp)((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC **")] FUNCDESC** ppFuncDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFuncDesc>(lpVtbl->GetFuncDesc)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, ppFuncDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC **")] VARDESC** ppVarDesc)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVarDesc>(lpVtbl->GetVarDesc)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, ppVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT *")] uint* pcNames)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNames>(lpVtbl->GetNames)((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, rgBstrNames, cMaxNames, pcNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeOfImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRefTypeOfImplType>(lpVtbl->GetRefTypeOfImplType)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT *")] int* pImplTypeFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetImplTypeFlags>(lpVtbl->GetImplTypeFlags)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pImplTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)((ITypeInfo2*)Unsafe.AsPointer(ref this), rgszNames, cNames, pMemId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)((ITypeInfo2*)Unsafe.AsPointer(ref this), pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDocumentation>(lpVtbl->GetDocumentation)((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDllEntry>(lpVtbl->GetDllEntry)((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRefTypeInfo>(lpVtbl->GetRefTypeInfo)((ITypeInfo2*)Unsafe.AsPointer(ref this), hRefType, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddressOfMember>(lpVtbl->AddressOfMember)((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)((ITypeInfo2*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMops>(lpVtbl->GetMops)((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pBstrMops);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingTypeLib([NativeTypeName("ITypeLib **")] ITypeLib** ppTLib, [NativeTypeName("UINT *")] uint* pIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContainingTypeLib>(lpVtbl->GetContainingTypeLib)((ITypeInfo2*)Unsafe.AsPointer(ref this), ppTLib, pIndex);
        }

        public void ReleaseTypeAttr([NativeTypeName("TYPEATTR *")] TYPEATTR* pTypeAttr)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseTypeAttr>(lpVtbl->ReleaseTypeAttr)((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeAttr);
        }

        public void ReleaseFuncDesc([NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseFuncDesc>(lpVtbl->ReleaseFuncDesc)((ITypeInfo2*)Unsafe.AsPointer(ref this), pFuncDesc);
        }

        public void ReleaseVarDesc([NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            Marshal.GetDelegateForFunctionPointer<_ReleaseVarDesc>(lpVtbl->ReleaseVarDesc)((ITypeInfo2*)Unsafe.AsPointer(ref this), pVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeKind([NativeTypeName("TYPEKIND *")] TYPEKIND* pTypeKind)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeKind>(lpVtbl->GetTypeKind)((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeFlags([NativeTypeName("ULONG *")] uint* pTypeFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeFlags>(lpVtbl->GetTypeFlags)((ITypeInfo2*)Unsafe.AsPointer(ref this), pTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncIndexOfMemId([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("UINT *")] uint* pFuncIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFuncIndexOfMemId>(lpVtbl->GetFuncIndexOfMemId)((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, invKind, pFuncIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarIndexOfMemId([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("UINT *")] uint* pVarIndex)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVarIndexOfMemId>(lpVtbl->GetVarIndexOfMemId)((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, pVarIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCustData>(lpVtbl->GetCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFuncCustData>(lpVtbl->GetFuncCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParamCustData>(lpVtbl->GetParamCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVarCustData>(lpVtbl->GetVarCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetImplTypeCustData>(lpVtbl->GetImplTypeCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation2([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pbstrHelpString, [NativeTypeName("DWORD *")] uint* pdwHelpStringContext, [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDocumentation2>(lpVtbl->GetDocumentation2)((ITypeInfo2*)Unsafe.AsPointer(ref this), memid, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllCustData([NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAllCustData>(lpVtbl->GetAllCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllFuncCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAllFuncCustData>(lpVtbl->GetAllFuncCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllParamCustData([NativeTypeName("UINT")] uint indexFunc, [NativeTypeName("UINT")] uint indexParam, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAllParamCustData>(lpVtbl->GetAllParamCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), indexFunc, indexParam, pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllVarCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAllVarCustData>(lpVtbl->GetAllVarCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllImplTypeCustData([NativeTypeName("UINT")] uint index, [NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAllImplTypeCustData>(lpVtbl->GetAllImplTypeCustData)((ITypeInfo2*)Unsafe.AsPointer(ref this), index, pCustData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (TYPEATTR **) __attribute__((stdcall))")]
            public IntPtr GetTypeAttr;

            [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
            public IntPtr GetTypeComp;

            [NativeTypeName("HRESULT (UINT, FUNCDESC **) __attribute__((stdcall))")]
            public IntPtr GetFuncDesc;

            [NativeTypeName("HRESULT (UINT, VARDESC **) __attribute__((stdcall))")]
            public IntPtr GetVarDesc;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, UINT, UINT *) __attribute__((stdcall))")]
            public IntPtr GetNames;

            [NativeTypeName("HRESULT (UINT, HREFTYPE *) __attribute__((stdcall))")]
            public IntPtr GetRefTypeOfImplType;

            [NativeTypeName("HRESULT (UINT, INT *) __attribute__((stdcall))")]
            public IntPtr GetImplTypeFlags;

            [NativeTypeName("HRESULT (LPOLESTR *, UINT, MEMBERID *) __attribute__((stdcall))")]
            public IntPtr GetIDsOfNames;

            [NativeTypeName("HRESULT (PVOID, MEMBERID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public IntPtr Invoke;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDocumentation;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, BSTR *, BSTR *, WORD *) __attribute__((stdcall))")]
            public IntPtr GetDllEntry;

            [NativeTypeName("HRESULT (HREFTYPE, ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetRefTypeInfo;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, PVOID *) __attribute__((stdcall))")]
            public IntPtr AddressOfMember;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, PVOID *) __attribute__((stdcall))")]
            public IntPtr CreateInstance;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *) __attribute__((stdcall))")]
            public IntPtr GetMops;

            [NativeTypeName("HRESULT (ITypeLib **, UINT *) __attribute__((stdcall))")]
            public IntPtr GetContainingTypeLib;

            [NativeTypeName("void (TYPEATTR *) __attribute__((stdcall))")]
            public IntPtr ReleaseTypeAttr;

            [NativeTypeName("void (FUNCDESC *) __attribute__((stdcall))")]
            public IntPtr ReleaseFuncDesc;

            [NativeTypeName("void (VARDESC *) __attribute__((stdcall))")]
            public IntPtr ReleaseVarDesc;

            [NativeTypeName("HRESULT (TYPEKIND *) __attribute__((stdcall))")]
            public IntPtr GetTypeKind;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public IntPtr GetTypeFlags;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, UINT *) __attribute__((stdcall))")]
            public IntPtr GetFuncIndexOfMemId;

            [NativeTypeName("HRESULT (MEMBERID, UINT *) __attribute__((stdcall))")]
            public IntPtr GetVarIndexOfMemId;

            [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr GetCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr GetFuncCustData;

            [NativeTypeName("HRESULT (UINT, UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr GetParamCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr GetVarCustData;

            [NativeTypeName("HRESULT (UINT, const GUID &, VARIANT *) __attribute__((stdcall))")]
            public IntPtr GetImplTypeCustData;

            [NativeTypeName("HRESULT (MEMBERID, LCID, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDocumentation2;

            [NativeTypeName("HRESULT (CUSTDATA *) __attribute__((stdcall))")]
            public IntPtr GetAllCustData;

            [NativeTypeName("HRESULT (UINT, CUSTDATA *) __attribute__((stdcall))")]
            public IntPtr GetAllFuncCustData;

            [NativeTypeName("HRESULT (UINT, UINT, CUSTDATA *) __attribute__((stdcall))")]
            public IntPtr GetAllParamCustData;

            [NativeTypeName("HRESULT (UINT, CUSTDATA *) __attribute__((stdcall))")]
            public IntPtr GetAllVarCustData;

            [NativeTypeName("HRESULT (UINT, CUSTDATA *) __attribute__((stdcall))")]
            public IntPtr GetAllImplTypeCustData;
        }
    }
}
