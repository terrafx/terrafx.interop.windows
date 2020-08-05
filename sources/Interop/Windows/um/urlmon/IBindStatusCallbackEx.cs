// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AAA74EF9-8EE7-4659-88D9-F8C504DA73CC")]
    [NativeTypeName("struct IBindStatusCallbackEx : IBindStatusCallback")]
    public unsafe partial struct IBindStatusCallbackEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, Guid*, void**, int>)(lpVtbl[0]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, uint>)(lpVtbl[1]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, uint>)(lpVtbl[2]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IBinding *")] IBinding* pib)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, uint, IBinding*, int>)(lpVtbl[3]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), dwReserved, pib);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, int*, int>)(lpVtbl[4]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnLowResource([NativeTypeName("DWORD")] uint reserved)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, uint, int>)(lpVtbl[5]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), reserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, uint, uint, uint, ushort*, int>)(lpVtbl[6]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), ulProgress, ulProgressMax, ulStatusCode, szStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStopBinding([NativeTypeName("HRESULT")] int hresult, [NativeTypeName("LPCWSTR")] ushort* szError)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, int, ushort*, int>)(lpVtbl[7]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), hresult, szError);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, uint*, BINDINFO*, int>)(lpVtbl[8]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pstgmed)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, uint, uint, FORMATETC*, STGMEDIUM*, int>)(lpVtbl[9]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBSCF, dwSize, pformatetc, pstgmed);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, Guid*, IUnknown*, int>)(lpVtbl[10]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return ((delegate* stdcall<IBindStatusCallbackEx*, uint*, BINDINFO*, uint*, uint*, int>)(lpVtbl[11]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo, grfBINDF2, pdwReserved);
        }
    }
}
