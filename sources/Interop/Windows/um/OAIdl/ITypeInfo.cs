// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020401-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeInfo
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ITypeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ITypeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ITypeInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeAttr([NativeTypeName("TYPEATTR **")] TYPEATTR** ppTypeAttr)
        {
            return lpVtbl->GetTypeAttr((ITypeInfo*)Unsafe.AsPointer(ref this), ppTypeAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return lpVtbl->GetTypeComp((ITypeInfo*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC **")] FUNCDESC** ppFuncDesc)
        {
            return lpVtbl->GetFuncDesc((ITypeInfo*)Unsafe.AsPointer(ref this), index, ppFuncDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC **")] VARDESC** ppVarDesc)
        {
            return lpVtbl->GetVarDesc((ITypeInfo*)Unsafe.AsPointer(ref this), index, ppVarDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT *")] uint* pcNames)
        {
            return lpVtbl->GetNames((ITypeInfo*)Unsafe.AsPointer(ref this), memid, rgBstrNames, cMaxNames, pcNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeOfImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType)
        {
            return lpVtbl->GetRefTypeOfImplType((ITypeInfo*)Unsafe.AsPointer(ref this), index, pRefType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT *")] int* pImplTypeFlags)
        {
            return lpVtbl->GetImplTypeFlags((ITypeInfo*)Unsafe.AsPointer(ref this), index, pImplTypeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId)
        {
            return lpVtbl->GetIDsOfNames((ITypeInfo*)Unsafe.AsPointer(ref this), rgszNames, cNames, pMemId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return lpVtbl->Invoke((ITypeInfo*)Unsafe.AsPointer(ref this), pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return lpVtbl->GetDocumentation((ITypeInfo*)Unsafe.AsPointer(ref this), memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal)
        {
            return lpVtbl->GetDllEntry((ITypeInfo*)Unsafe.AsPointer(ref this), memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetRefTypeInfo((ITypeInfo*)Unsafe.AsPointer(ref this), hRefType, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv)
        {
            return lpVtbl->AddressOfMember((ITypeInfo*)Unsafe.AsPointer(ref this), memid, invKind, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return lpVtbl->CreateInstance((ITypeInfo*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops)
        {
            return lpVtbl->GetMops((ITypeInfo*)Unsafe.AsPointer(ref this), memid, pBstrMops);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainingTypeLib([NativeTypeName("ITypeLib **")] ITypeLib** ppTLib, [NativeTypeName("UINT *")] uint* pIndex)
        {
            return lpVtbl->GetContainingTypeLib((ITypeInfo*)Unsafe.AsPointer(ref this), ppTLib, pIndex);
        }

        public void ReleaseTypeAttr([NativeTypeName("TYPEATTR *")] TYPEATTR* pTypeAttr)
        {
            lpVtbl->ReleaseTypeAttr((ITypeInfo*)Unsafe.AsPointer(ref this), pTypeAttr);
        }

        public void ReleaseFuncDesc([NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            lpVtbl->ReleaseFuncDesc((ITypeInfo*)Unsafe.AsPointer(ref this), pFuncDesc);
        }

        public void ReleaseVarDesc([NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            lpVtbl->ReleaseVarDesc((ITypeInfo*)Unsafe.AsPointer(ref this), pVarDesc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, uint> Release;

            [NativeTypeName("HRESULT (TYPEATTR **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, TYPEATTR**, int> GetTypeAttr;

            [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, ITypeComp**, int> GetTypeComp;

            [NativeTypeName("HRESULT (UINT, FUNCDESC **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, uint, FUNCDESC**, int> GetFuncDesc;

            [NativeTypeName("HRESULT (UINT, VARDESC **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, uint, VARDESC**, int> GetVarDesc;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, UINT, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, int, ushort**, uint, uint*, int> GetNames;

            [NativeTypeName("HRESULT (UINT, HREFTYPE *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, uint, uint*, int> GetRefTypeOfImplType;

            [NativeTypeName("HRESULT (UINT, INT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, uint, int*, int> GetImplTypeFlags;

            [NativeTypeName("HRESULT (LPOLESTR *, UINT, MEMBERID *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, ushort**, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (PVOID, MEMBERID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, void*, int, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, int, ushort**, ushort**, uint*, ushort**, int> GetDocumentation;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, BSTR *, BSTR *, WORD *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, int, INVOKEKIND, ushort**, ushort**, ushort*, int> GetDllEntry;

            [NativeTypeName("HRESULT (HREFTYPE, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, uint, ITypeInfo**, int> GetRefTypeInfo;

            [NativeTypeName("HRESULT (MEMBERID, INVOKEKIND, PVOID *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, int, INVOKEKIND, void**, int> AddressOfMember;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, PVOID *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, IUnknown*, Guid*, void**, int> CreateInstance;

            [NativeTypeName("HRESULT (MEMBERID, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, int, ushort**, int> GetMops;

            [NativeTypeName("HRESULT (ITypeLib **, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, ITypeLib**, uint*, int> GetContainingTypeLib;

            [NativeTypeName("void (TYPEATTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, TYPEATTR*, void> ReleaseTypeAttr;

            [NativeTypeName("void (FUNCDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, FUNCDESC*, void> ReleaseFuncDesc;

            [NativeTypeName("void (VARDESC *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeInfo*, VARDESC*, void> ReleaseVarDesc;
        }
    }
}
