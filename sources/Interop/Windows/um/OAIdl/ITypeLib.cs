// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020402-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeLib
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ITypeLib*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ITypeLib*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ITypeLib*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetTypeInfoCount()
        {
            return lpVtbl->GetTypeInfoCount((ITypeLib*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint index, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((ITypeLib*)Unsafe.AsPointer(ref this), index, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoType([NativeTypeName("UINT")] uint index, [NativeTypeName("TYPEKIND *")] TYPEKIND* pTKind)
        {
            return lpVtbl->GetTypeInfoType((ITypeLib*)Unsafe.AsPointer(ref this), index, pTKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoOfGuid([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTinfo)
        {
            return lpVtbl->GetTypeInfoOfGuid((ITypeLib*)Unsafe.AsPointer(ref this), guid, ppTinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLibAttr([NativeTypeName("TLIBATTR **")] TLIBATTR** ppTLibAttr)
        {
            return lpVtbl->GetLibAttr((ITypeLib*)Unsafe.AsPointer(ref this), ppTLibAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return lpVtbl->GetTypeComp((ITypeLib*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("INT")] int index, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return lpVtbl->GetDocumentation((ITypeLib*)Unsafe.AsPointer(ref this), index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("BOOL *")] int* pfName)
        {
            return lpVtbl->IsName((ITypeLib*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, pfName);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID *")] int* rgMemId, [NativeTypeName("USHORT *")] ushort* pcFound)
        {
            return lpVtbl->FindName((ITypeLib*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
        }

        public void ReleaseTLibAttr([NativeTypeName("TLIBATTR *")] TLIBATTR* pTLibAttr)
        {
            lpVtbl->ReleaseTLibAttr((ITypeLib*)Unsafe.AsPointer(ref this), pTLibAttr);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, uint> Release;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, uint> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (UINT, TYPEKIND *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, uint, TYPEKIND*, int> GetTypeInfoType;

            [NativeTypeName("HRESULT (const GUID &, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, Guid*, ITypeInfo**, int> GetTypeInfoOfGuid;

            [NativeTypeName("HRESULT (TLIBATTR **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, TLIBATTR**, int> GetLibAttr;

            [NativeTypeName("HRESULT (ITypeComp **) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, ITypeComp**, int> GetTypeComp;

            [NativeTypeName("HRESULT (INT, BSTR *, BSTR *, DWORD *, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, int, ushort**, ushort**, uint*, ushort**, int> GetDocumentation;

            [NativeTypeName("HRESULT (LPOLESTR, ULONG, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, ushort*, uint, int*, int> IsName;

            [NativeTypeName("HRESULT (LPOLESTR, ULONG, ITypeInfo **, MEMBERID *, USHORT *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, ushort*, uint, ITypeInfo**, int*, ushort*, int> FindName;

            [NativeTypeName("void (TLIBATTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ITypeLib*, TLIBATTR*, void> ReleaseTLibAttr;
        }
    }
}
