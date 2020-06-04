// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C1-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IBindStatusCallback
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IBindStatusCallback*, Guid*, void**, int>)(lpVtbl[0]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IBindStatusCallback*, uint>)(lpVtbl[1]))((IBindStatusCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IBindStatusCallback*, uint>)(lpVtbl[2]))((IBindStatusCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IBinding *")] IBinding* pib)
        {
            return ((delegate* stdcall<IBindStatusCallback*, uint, IBinding*, int>)(lpVtbl[3]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), dwReserved, pib);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return ((delegate* stdcall<IBindStatusCallback*, int*, int>)(lpVtbl[4]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnLowResource([NativeTypeName("DWORD")] uint reserved)
        {
            return ((delegate* stdcall<IBindStatusCallback*, uint, int>)(lpVtbl[5]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), reserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText)
        {
            return ((delegate* stdcall<IBindStatusCallback*, uint, uint, uint, ushort*, int>)(lpVtbl[6]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), ulProgress, ulProgressMax, ulStatusCode, szStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStopBinding([NativeTypeName("HRESULT")] int hresult, [NativeTypeName("LPCWSTR")] ushort* szError)
        {
            return ((delegate* stdcall<IBindStatusCallback*, int, ushort*, int>)(lpVtbl[7]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), hresult, szError);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo)
        {
            return ((delegate* stdcall<IBindStatusCallback*, uint*, BINDINFO*, int>)(lpVtbl[8]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pstgmed)
        {
            return ((delegate* stdcall<IBindStatusCallback*, uint, uint, FORMATETC*, STGMEDIUM*, int>)(lpVtbl[9]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), grfBSCF, dwSize, pformatetc, pstgmed);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* stdcall<IBindStatusCallback*, Guid*, IUnknown*, int>)(lpVtbl[10]))((IBindStatusCallback*)Unsafe.AsPointer(ref this), riid, punk);
        }
    }
}
