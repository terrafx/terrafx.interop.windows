// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020402-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeLib : IUnknown")]
    public unsafe partial struct ITypeLib
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITypeLib*, Guid*, void**, int>)(lpVtbl[0]))((ITypeLib*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITypeLib*, uint>)(lpVtbl[1]))((ITypeLib*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITypeLib*, uint>)(lpVtbl[2]))((ITypeLib*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetTypeInfoCount()
        {
            return ((delegate* unmanaged<ITypeLib*, uint>)(lpVtbl[3]))((ITypeLib*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint index, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ITypeLib*, uint, ITypeInfo**, int>)(lpVtbl[4]))((ITypeLib*)Unsafe.AsPointer(ref this), index, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoType([NativeTypeName("UINT")] uint index, [NativeTypeName("TYPEKIND *")] TYPEKIND* pTKind)
        {
            return ((delegate* unmanaged<ITypeLib*, uint, TYPEKIND*, int>)(lpVtbl[5]))((ITypeLib*)Unsafe.AsPointer(ref this), index, pTKind);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoOfGuid([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTinfo)
        {
            return ((delegate* unmanaged<ITypeLib*, Guid*, ITypeInfo**, int>)(lpVtbl[6]))((ITypeLib*)Unsafe.AsPointer(ref this), guid, ppTinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLibAttr([NativeTypeName("TLIBATTR **")] TLIBATTR** ppTLibAttr)
        {
            return ((delegate* unmanaged<ITypeLib*, TLIBATTR**, int>)(lpVtbl[7]))((ITypeLib*)Unsafe.AsPointer(ref this), ppTLibAttr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return ((delegate* unmanaged<ITypeLib*, ITypeComp**, int>)(lpVtbl[8]))((ITypeLib*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("INT")] int index, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return ((delegate* unmanaged<ITypeLib*, int, ushort**, ushort**, uint*, ushort**, int>)(lpVtbl[9]))((ITypeLib*)Unsafe.AsPointer(ref this), index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("BOOL *")] int* pfName)
        {
            return ((delegate* unmanaged<ITypeLib*, ushort*, uint, int*, int>)(lpVtbl[10]))((ITypeLib*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, pfName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID *")] int* rgMemId, [NativeTypeName("USHORT *")] ushort* pcFound)
        {
            return ((delegate* unmanaged<ITypeLib*, ushort*, uint, ITypeInfo**, int*, ushort*, int>)(lpVtbl[11]))((ITypeLib*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ReleaseTLibAttr([NativeTypeName("TLIBATTR *")] TLIBATTR* pTLibAttr)
        {
            ((delegate* unmanaged<ITypeLib*, TLIBATTR*, void>)(lpVtbl[12]))((ITypeLib*)Unsafe.AsPointer(ref this), pTLibAttr);
        }
    }
}
