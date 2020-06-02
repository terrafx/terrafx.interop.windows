// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020411-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeLib2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ITypeLib2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ITypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ITypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetTypeInfoCount()
        {
            return lpVtbl->GetTypeInfoCount((ITypeLib2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint index, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((ITypeLib2*)Unsafe.AsPointer(ref this), index, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoType([NativeTypeName("UINT")] uint index, [NativeTypeName("TYPEKIND *")] TYPEKIND* pTKind)
        {
            return lpVtbl->GetTypeInfoType((ITypeLib2*)Unsafe.AsPointer(ref this), index, pTKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoOfGuid([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTinfo)
        {
            return lpVtbl->GetTypeInfoOfGuid((ITypeLib2*)Unsafe.AsPointer(ref this), guid, ppTinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLibAttr([NativeTypeName("TLIBATTR **")] TLIBATTR** ppTLibAttr)
        {
            return lpVtbl->GetLibAttr((ITypeLib2*)Unsafe.AsPointer(ref this), ppTLibAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return lpVtbl->GetTypeComp((ITypeLib2*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("INT")] int index, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return lpVtbl->GetDocumentation((ITypeLib2*)Unsafe.AsPointer(ref this), index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("BOOL *")] int* pfName)
        {
            return lpVtbl->IsName((ITypeLib2*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, pfName);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID *")] int* rgMemId, [NativeTypeName("USHORT *")] ushort* pcFound)
        {
            return lpVtbl->FindName((ITypeLib2*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
        }

        public void ReleaseTLibAttr([NativeTypeName("TLIBATTR *")] TLIBATTR* pTLibAttr)
        {
            lpVtbl->ReleaseTLibAttr((ITypeLib2*)Unsafe.AsPointer(ref this), pTLibAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return lpVtbl->GetCustData((ITypeLib2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLibStatistics([NativeTypeName("ULONG *")] uint* pcUniqueNames, [NativeTypeName("ULONG *")] uint* pcchUniqueNames)
        {
            return lpVtbl->GetLibStatistics((ITypeLib2*)Unsafe.AsPointer(ref this), pcUniqueNames, pcchUniqueNames);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation2([NativeTypeName("INT")] int index, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pbstrHelpString, [NativeTypeName("DWORD *")] uint* pdwHelpStringContext, [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll)
        {
            return lpVtbl->GetDocumentation2((ITypeLib2*)Unsafe.AsPointer(ref this), index, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllCustData([NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return lpVtbl->GetAllCustData((ITypeLib2*)Unsafe.AsPointer(ref this), pCustData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, uint> Release;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, uint> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (UINT, TYPEKIND *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, uint, TYPEKIND*, int> GetTypeInfoType;

            [NativeTypeName("HRESULT (const GUID &, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, Guid*, ITypeInfo**, int> GetTypeInfoOfGuid;

            [NativeTypeName("HRESULT (TLIBATTR **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, TLIBATTR**, int> GetLibAttr;

            [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, ITypeComp**, int> GetTypeComp;

            [NativeTypeName("HRESULT (INT, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, int, ushort**, ushort**, uint*, ushort**, int> GetDocumentation;

            [NativeTypeName("HRESULT (LPOLESTR, ULONG, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, ushort*, uint, int*, int> IsName;

            [NativeTypeName("HRESULT (LPOLESTR, ULONG, ITypeInfo **, MEMBERID *, USHORT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, ushort*, uint, ITypeInfo**, int*, ushort*, int> FindName;

            [NativeTypeName("void (TLIBATTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, TLIBATTR*, void> ReleaseTLibAttr;

            [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, Guid*, VARIANT*, int> GetCustData;

            [NativeTypeName("HRESULT (ULONG *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, uint*, uint*, int> GetLibStatistics;

            [NativeTypeName("HRESULT (INT, LCID, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, int, uint, ushort**, uint*, ushort**, int> GetDocumentation2;

            [NativeTypeName("HRESULT (CUSTDATA *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib2*, CUSTDATA*, int> GetAllCustData;
        }
    }
}
