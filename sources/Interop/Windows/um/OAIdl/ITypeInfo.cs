// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020401-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeInfo : IUnknown")]
    public unsafe partial struct ITypeInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ITypeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ITypeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ITypeInfo*, uint>)(lpVtbl[1]))((ITypeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ITypeInfo*, uint>)(lpVtbl[2]))((ITypeInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeAttr([NativeTypeName("TYPEATTR **")] TYPEATTR** ppTypeAttr)
        {
            return ((delegate* stdcall<ITypeInfo*, TYPEATTR**, int>)(lpVtbl[3]))((ITypeInfo*)Unsafe.AsPointer(ref this), ppTypeAttr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return ((delegate* stdcall<ITypeInfo*, ITypeComp**, int>)(lpVtbl[4]))((ITypeInfo*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFuncDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("FUNCDESC **")] FUNCDESC** ppFuncDesc)
        {
            return ((delegate* stdcall<ITypeInfo*, uint, FUNCDESC**, int>)(lpVtbl[5]))((ITypeInfo*)Unsafe.AsPointer(ref this), index, ppFuncDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVarDesc([NativeTypeName("UINT")] uint index, [NativeTypeName("VARDESC **")] VARDESC** ppVarDesc)
        {
            return ((delegate* stdcall<ITypeInfo*, uint, VARDESC**, int>)(lpVtbl[6]))((ITypeInfo*)Unsafe.AsPointer(ref this), index, ppVarDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNames([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** rgBstrNames, [NativeTypeName("UINT")] uint cMaxNames, [NativeTypeName("UINT *")] uint* pcNames)
        {
            return ((delegate* stdcall<ITypeInfo*, int, ushort**, uint, uint*, int>)(lpVtbl[7]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, rgBstrNames, cMaxNames, pcNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeOfImplType([NativeTypeName("UINT")] uint index, [NativeTypeName("HREFTYPE *")] uint* pRefType)
        {
            return ((delegate* stdcall<ITypeInfo*, uint, uint*, int>)(lpVtbl[8]))((ITypeInfo*)Unsafe.AsPointer(ref this), index, pRefType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImplTypeFlags([NativeTypeName("UINT")] uint index, [NativeTypeName("INT *")] int* pImplTypeFlags)
        {
            return ((delegate* stdcall<ITypeInfo*, uint, int*, int>)(lpVtbl[9]))((ITypeInfo*)Unsafe.AsPointer(ref this), index, pImplTypeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("MEMBERID *")] int* pMemId)
        {
            return ((delegate* stdcall<ITypeInfo*, ushort**, uint, int*, int>)(lpVtbl[10]))((ITypeInfo*)Unsafe.AsPointer(ref this), rgszNames, cNames, pMemId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("PVOID")] void* pvInstance, [NativeTypeName("MEMBERID")] int memid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ITypeInfo*, void*, int, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[11]))((ITypeInfo*)Unsafe.AsPointer(ref this), pvInstance, memid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return ((delegate* stdcall<ITypeInfo*, int, ushort**, ushort**, uint*, ushort**, int>)(lpVtbl[12]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDllEntry([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("BSTR *")] ushort** pBstrDllName, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("WORD *")] ushort* pwOrdinal)
        {
            return ((delegate* stdcall<ITypeInfo*, int, INVOKEKIND, ushort**, ushort**, ushort*, int>)(lpVtbl[13]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, invKind, pBstrDllName, pBstrName, pwOrdinal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRefTypeInfo([NativeTypeName("HREFTYPE")] uint hRefType, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ITypeInfo*, uint, ITypeInfo**, int>)(lpVtbl[14]))((ITypeInfo*)Unsafe.AsPointer(ref this), hRefType, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddressOfMember([NativeTypeName("MEMBERID")] int memid, INVOKEKIND invKind, [NativeTypeName("PVOID *")] void** ppv)
        {
            return ((delegate* stdcall<ITypeInfo*, int, INVOKEKIND, void**, int>)(lpVtbl[15]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, invKind, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IUnknown *")] IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppvObj)
        {
            return ((delegate* stdcall<ITypeInfo*, IUnknown*, Guid*, void**, int>)(lpVtbl[16]))((ITypeInfo*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMops([NativeTypeName("MEMBERID")] int memid, [NativeTypeName("BSTR *")] ushort** pBstrMops)
        {
            return ((delegate* stdcall<ITypeInfo*, int, ushort**, int>)(lpVtbl[17]))((ITypeInfo*)Unsafe.AsPointer(ref this), memid, pBstrMops);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainingTypeLib([NativeTypeName("ITypeLib **")] ITypeLib** ppTLib, [NativeTypeName("UINT *")] uint* pIndex)
        {
            return ((delegate* stdcall<ITypeInfo*, ITypeLib**, uint*, int>)(lpVtbl[18]))((ITypeInfo*)Unsafe.AsPointer(ref this), ppTLib, pIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseTypeAttr([NativeTypeName("TYPEATTR *")] TYPEATTR* pTypeAttr)
        {
            ((delegate* stdcall<ITypeInfo*, TYPEATTR*, void>)(lpVtbl[19]))((ITypeInfo*)Unsafe.AsPointer(ref this), pTypeAttr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseFuncDesc([NativeTypeName("FUNCDESC *")] FUNCDESC* pFuncDesc)
        {
            ((delegate* stdcall<ITypeInfo*, FUNCDESC*, void>)(lpVtbl[20]))((ITypeInfo*)Unsafe.AsPointer(ref this), pFuncDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseVarDesc([NativeTypeName("VARDESC *")] VARDESC* pVarDesc)
        {
            ((delegate* stdcall<ITypeInfo*, VARDESC*, void>)(lpVtbl[21]))((ITypeInfo*)Unsafe.AsPointer(ref this), pVarDesc);
        }
    }
}
