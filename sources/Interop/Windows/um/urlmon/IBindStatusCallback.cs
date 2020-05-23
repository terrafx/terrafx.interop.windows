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
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IBindStatusCallback* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IBindStatusCallback* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IBindStatusCallback* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnStartBinding(IBindStatusCallback* pThis, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IBinding *")] IBinding* pib);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPriority(IBindStatusCallback* pThis, [NativeTypeName("LONG *")] int* pnPriority);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnLowResource(IBindStatusCallback* pThis, [NativeTypeName("DWORD")] uint reserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnProgress(IBindStatusCallback* pThis, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnStopBinding(IBindStatusCallback* pThis, [NativeTypeName("HRESULT")] int hresult, [NativeTypeName("LPCWSTR")] ushort* szError);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBindInfo(IBindStatusCallback* pThis, [NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnDataAvailable(IBindStatusCallback* pThis, [NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pstgmed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnObjectAvailable(IBindStatusCallback* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punk);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IBindStatusCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IBindStatusCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IBindStatusCallback*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IBinding *")] IBinding* pib)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnStartBinding>(lpVtbl->OnStartBinding)((IBindStatusCallback*)Unsafe.AsPointer(ref this), dwReserved, pib);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPriority>(lpVtbl->GetPriority)((IBindStatusCallback*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnLowResource([NativeTypeName("DWORD")] uint reserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnLowResource>(lpVtbl->OnLowResource)((IBindStatusCallback*)Unsafe.AsPointer(ref this), reserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnProgress>(lpVtbl->OnProgress)((IBindStatusCallback*)Unsafe.AsPointer(ref this), ulProgress, ulProgressMax, ulStatusCode, szStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStopBinding([NativeTypeName("HRESULT")] int hresult, [NativeTypeName("LPCWSTR")] ushort* szError)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnStopBinding>(lpVtbl->OnStopBinding)((IBindStatusCallback*)Unsafe.AsPointer(ref this), hresult, szError);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBindInfo>(lpVtbl->GetBindInfo)((IBindStatusCallback*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pstgmed)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnDataAvailable>(lpVtbl->OnDataAvailable)((IBindStatusCallback*)Unsafe.AsPointer(ref this), grfBSCF, dwSize, pformatetc, pstgmed);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnObjectAvailable>(lpVtbl->OnObjectAvailable)((IBindStatusCallback*)Unsafe.AsPointer(ref this), riid, punk);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD, IBinding *) __attribute__((stdcall))")]
            public IntPtr OnStartBinding;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public IntPtr GetPriority;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr OnLowResource;

            [NativeTypeName("HRESULT (ULONG, ULONG, ULONG, LPCWSTR) __attribute__((stdcall))")]
            public IntPtr OnProgress;

            [NativeTypeName("HRESULT (HRESULT, LPCWSTR) __attribute__((stdcall))")]
            public IntPtr OnStopBinding;

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
            public IntPtr GetBindInfo;

            [NativeTypeName("HRESULT (DWORD, DWORD, FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public IntPtr OnDataAvailable;

            [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
            public IntPtr OnObjectAvailable;
        }
    }
}
