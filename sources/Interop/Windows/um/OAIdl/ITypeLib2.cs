// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020411-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeLib2 : ITypeLib")]
    public unsafe partial struct ITypeLib2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ITypeLib2*, Guid*, void**, int>)(lpVtbl[0]))((ITypeLib2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ITypeLib2*, uint>)(lpVtbl[1]))((ITypeLib2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ITypeLib2*, uint>)(lpVtbl[2]))((ITypeLib2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetTypeInfoCount()
        {
            return ((delegate* stdcall<ITypeLib2*, uint>)(lpVtbl[3]))((ITypeLib2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint index, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ITypeLib2*, uint, ITypeInfo**, int>)(lpVtbl[4]))((ITypeLib2*)Unsafe.AsPointer(ref this), index, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoType([NativeTypeName("UINT")] uint index, [NativeTypeName("TYPEKIND *")] TYPEKIND* pTKind)
        {
            return ((delegate* stdcall<ITypeLib2*, uint, TYPEKIND*, int>)(lpVtbl[5]))((ITypeLib2*)Unsafe.AsPointer(ref this), index, pTKind);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoOfGuid([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTinfo)
        {
            return ((delegate* stdcall<ITypeLib2*, Guid*, ITypeInfo**, int>)(lpVtbl[6]))((ITypeLib2*)Unsafe.AsPointer(ref this), guid, ppTinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLibAttr([NativeTypeName("TLIBATTR **")] TLIBATTR** ppTLibAttr)
        {
            return ((delegate* stdcall<ITypeLib2*, TLIBATTR**, int>)(lpVtbl[7]))((ITypeLib2*)Unsafe.AsPointer(ref this), ppTLibAttr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return ((delegate* stdcall<ITypeLib2*, ITypeComp**, int>)(lpVtbl[8]))((ITypeLib2*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("INT")] int index, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return ((delegate* stdcall<ITypeLib2*, int, ushort**, ushort**, uint*, ushort**, int>)(lpVtbl[9]))((ITypeLib2*)Unsafe.AsPointer(ref this), index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("BOOL *")] int* pfName)
        {
            return ((delegate* stdcall<ITypeLib2*, ushort*, uint, int*, int>)(lpVtbl[10]))((ITypeLib2*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, pfName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID *")] int* rgMemId, [NativeTypeName("USHORT *")] ushort* pcFound)
        {
            return ((delegate* stdcall<ITypeLib2*, ushort*, uint, ITypeInfo**, int*, ushort*, int>)(lpVtbl[11]))((ITypeLib2*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseTLibAttr([NativeTypeName("TLIBATTR *")] TLIBATTR* pTLibAttr)
        {
            ((delegate* stdcall<ITypeLib2*, TLIBATTR*, void>)(lpVtbl[12]))((ITypeLib2*)Unsafe.AsPointer(ref this), pTLibAttr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCustData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("VARIANT *")] VARIANT* pVarVal)
        {
            return ((delegate* stdcall<ITypeLib2*, Guid*, VARIANT*, int>)(lpVtbl[13]))((ITypeLib2*)Unsafe.AsPointer(ref this), guid, pVarVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLibStatistics([NativeTypeName("ULONG *")] uint* pcUniqueNames, [NativeTypeName("ULONG *")] uint* pcchUniqueNames)
        {
            return ((delegate* stdcall<ITypeLib2*, uint*, uint*, int>)(lpVtbl[14]))((ITypeLib2*)Unsafe.AsPointer(ref this), pcUniqueNames, pcchUniqueNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation2([NativeTypeName("INT")] int index, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("BSTR *")] ushort** pbstrHelpString, [NativeTypeName("DWORD *")] uint* pdwHelpStringContext, [NativeTypeName("BSTR *")] ushort** pbstrHelpStringDll)
        {
            return ((delegate* stdcall<ITypeLib2*, int, uint, ushort**, uint*, ushort**, int>)(lpVtbl[15]))((ITypeLib2*)Unsafe.AsPointer(ref this), index, lcid, pbstrHelpString, pdwHelpStringContext, pbstrHelpStringDll);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllCustData([NativeTypeName("CUSTDATA *")] CUSTDATA* pCustData)
        {
            return ((delegate* stdcall<ITypeLib2*, CUSTDATA*, int>)(lpVtbl[16]))((ITypeLib2*)Unsafe.AsPointer(ref this), pCustData);
        }
    }
}
