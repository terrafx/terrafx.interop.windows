// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AAA74EF9-8EE7-4659-88D9-F8C504DA73CC")]
    public unsafe partial struct IBindStatusCallbackEx
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IBindStatusCallbackEx* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IBindStatusCallbackEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IBindStatusCallbackEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnStartBinding(IBindStatusCallbackEx* pThis, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IBinding *")] IBinding* pib);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPriority(IBindStatusCallbackEx* pThis, [NativeTypeName("LONG *")] int* pnPriority);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnLowResource(IBindStatusCallbackEx* pThis, [NativeTypeName("DWORD")] uint reserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnProgress(IBindStatusCallbackEx* pThis, [NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnStopBinding(IBindStatusCallbackEx* pThis, [NativeTypeName("HRESULT")] int hresult, [NativeTypeName("LPCWSTR")] ushort* szError);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBindInfo(IBindStatusCallbackEx* pThis, [NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnDataAvailable(IBindStatusCallbackEx* pThis, [NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pstgmed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnObjectAvailable(IBindStatusCallbackEx* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBindInfoEx(IBindStatusCallbackEx* pThis, [NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStartBinding([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IBinding *")] IBinding* pib)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnStartBinding>(lpVtbl->OnStartBinding)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), dwReserved, pib);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPriority>(lpVtbl->GetPriority)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnLowResource([NativeTypeName("DWORD")] uint reserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnLowResource>(lpVtbl->OnLowResource)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), reserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnProgress([NativeTypeName("ULONG")] uint ulProgress, [NativeTypeName("ULONG")] uint ulProgressMax, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szStatusText)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnProgress>(lpVtbl->OnProgress)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), ulProgress, ulProgressMax, ulStatusCode, szStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnStopBinding([NativeTypeName("HRESULT")] int hresult, [NativeTypeName("LPCWSTR")] ushort* szError)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnStopBinding>(lpVtbl->OnStopBinding)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), hresult, szError);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBindInfo>(lpVtbl->GetBindInfo)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnDataAvailable([NativeTypeName("DWORD")] uint grfBSCF, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pstgmed)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnDataAvailable>(lpVtbl->OnDataAvailable)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBSCF, dwSize, pformatetc, pstgmed);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnObjectAvailable([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnObjectAvailable>(lpVtbl->OnObjectAvailable)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), riid, punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBindInfoEx>(lpVtbl->GetBindInfoEx)((IBindStatusCallbackEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo, grfBINDF2, pdwReserved);
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

            [NativeTypeName("HRESULT (DWORD *, BINDINFO *, DWORD *, DWORD *) __attribute__((stdcall))")]
            public IntPtr GetBindInfoEx;
        }
    }
}
