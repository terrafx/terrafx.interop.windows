// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EAA7C309-BBEC-49D5-821D-64D966CB667F")]
    [NativeTypeName("struct FolderItems3 : FolderItems2")]
    [NativeInheritance("FolderItems2")]
    public unsafe partial struct FolderItems3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<FolderItems3*, Guid*, void**, int>)(lpVtbl[0]))((FolderItems3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<FolderItems3*, uint>)(lpVtbl[1]))((FolderItems3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<FolderItems3*, uint>)(lpVtbl[2]))((FolderItems3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<FolderItems3*, uint*, int>)(lpVtbl[3]))((FolderItems3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<FolderItems3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((FolderItems3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<FolderItems3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((FolderItems3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<FolderItems3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((FolderItems3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Count([NativeTypeName("long *")] int* plCount)
        {
            return ((delegate* unmanaged<FolderItems3*, int*, int>)(lpVtbl[7]))((FolderItems3*)Unsafe.AsPointer(ref this), plCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<FolderItems3*, IDispatch**, int>)(lpVtbl[8]))((FolderItems3*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<FolderItems3*, IDispatch**, int>)(lpVtbl[9]))((FolderItems3*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Item(VARIANT index, FolderItem** ppid)
        {
            return ((delegate* unmanaged<FolderItems3*, VARIANT, FolderItem**, int>)(lpVtbl[10]))((FolderItems3*)Unsafe.AsPointer(ref this), index, ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT _NewEnum(IUnknown** ppunk)
        {
            return ((delegate* unmanaged<FolderItems3*, IUnknown**, int>)(lpVtbl[11]))((FolderItems3*)Unsafe.AsPointer(ref this), ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT InvokeVerbEx(VARIANT vVerb, VARIANT vArgs)
        {
            return ((delegate* unmanaged<FolderItems3*, VARIANT, VARIANT, int>)(lpVtbl[12]))((FolderItems3*)Unsafe.AsPointer(ref this), vVerb, vArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Filter([NativeTypeName("long")] int grfFlags, [NativeTypeName("BSTR")] ushort* bstrFileSpec)
        {
            return ((delegate* unmanaged<FolderItems3*, int, ushort*, int>)(lpVtbl[13]))((FolderItems3*)Unsafe.AsPointer(ref this), grfFlags, bstrFileSpec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_Verbs(FolderItemVerbs** ppfic)
        {
            return ((delegate* unmanaged<FolderItems3*, FolderItemVerbs**, int>)(lpVtbl[14]))((FolderItems3*)Unsafe.AsPointer(ref this), ppfic);
        }
    }
}
