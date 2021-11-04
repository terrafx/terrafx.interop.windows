// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AAA74EF9-8EE7-4659-88D9-F8C504DA73CC")]
    [NativeTypeName("struct IBindStatusCallbackEx : IBindStatusCallback")]
    [NativeInheritance("IBindStatusCallback")]
    public unsafe partial struct IBindStatusCallbackEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, Guid*, void**, int>)(lpVtbl[0]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, uint>)(lpVtbl[1]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, uint>)(lpVtbl[2]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, IBinding* pib)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, uint, IBinding*, int>)(lpVtbl[3]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), dwReserved, pib);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, int*, int>)(lpVtbl[4]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnLowResource([NativeTypeName("DWORD")] uint reserved)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, uint, int>)(lpVtbl[5]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, uint, uint, uint, ushort*, int>)(lpVtbl[6]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), ulProgress, ulProgressMax, ulStatusCode, szStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnStopBinding(HRESULT hresult, [NativeTypeName("LPCWSTR")] ushort* szError)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, HRESULT, ushort*, int>)(lpVtbl[7]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), hresult, szError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, uint*, BINDINFO*, int>)(lpVtbl[8]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, FORMATETC* pformatetc, STGMEDIUM* pstgmed)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, uint, uint, FORMATETC*, STGMEDIUM*, int>)(lpVtbl[9]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBSCF, dwSize, pformatetc, pstgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, Guid*, IUnknown*, int>)(lpVtbl[10]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return ((delegate* unmanaged<IBindStatusCallbackEx*, uint*, BINDINFO*, uint*, uint*, int>)(lpVtbl[11]))((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo, grfBINDF2, pdwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IBinding *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, uint, IBinding*, int> OnStartBinding;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, int*, int> GetPriority;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, uint, int> OnLowResource;

            [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, uint, uint, uint, ushort*, int> OnProgress;

            [NativeTypeName("HRESULT (HRESULT, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, HRESULT, ushort*, int> OnStopBinding;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, uint*, BINDINFO*, int> GetBindInfo;

            [NativeTypeName("HRESULT (DWORD, DWORD, FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, uint, uint, FORMATETC*, STGMEDIUM*, int> OnDataAvailable;

            [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, Guid*, IUnknown*, int> OnObjectAvailable;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindStatusCallbackEx*, uint*, BINDINFO*, uint*, uint*, int> GetBindInfoEx;
        }
    }
}
