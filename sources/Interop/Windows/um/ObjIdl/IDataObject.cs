// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IDataObject : IUnknown")]
    public unsafe partial struct IDataObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, Guid*, void**, int>)(lpVtbl[0]))((IDataObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, uint>)(lpVtbl[1]))((IDataObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, uint>)(lpVtbl[2]))((IDataObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetcIn, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)(lpVtbl[3]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetcIn, pmedium);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataHere([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, FORMATETC*, STGMEDIUM*, int>)(lpVtbl[4]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, pmedium);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryGetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, FORMATETC*, int>)(lpVtbl[5]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalFormatEtc([NativeTypeName("FORMATETC *")] FORMATETC* pformatectIn, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetcOut)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, FORMATETC*, FORMATETC*, int>)(lpVtbl[6]))((IDataObject*)Unsafe.AsPointer(ref this), pformatectIn, pformatetcOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium, [NativeTypeName("BOOL")] int fRelease)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, FORMATETC*, STGMEDIUM*, int, int>)(lpVtbl[7]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumFormatEtc([NativeTypeName("DWORD")] uint dwDirection, [NativeTypeName("IEnumFORMATETC **")] IEnumFORMATETC** ppenumFormatEtc)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, uint, IEnumFORMATETC**, int>)(lpVtbl[8]))((IDataObject*)Unsafe.AsPointer(ref this), dwDirection, ppenumFormatEtc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DAdvise([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)(lpVtbl[9]))((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, advf, pAdvSink, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DUnadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, uint, int>)(lpVtbl[10]))((IDataObject*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumDAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* unmanaged[Stdcall]<IDataObject*, IEnumSTATDATA**, int>)(lpVtbl[11]))((IDataObject*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }
    }
}
