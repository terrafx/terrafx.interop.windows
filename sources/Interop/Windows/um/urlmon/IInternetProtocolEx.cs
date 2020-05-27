// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C7A98E66-1010-492C-A1C8-C809E1F75905")]
    public unsafe partial struct IInternetProtocolEx
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IInternetProtocolEx* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IInternetProtocolEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IInternetProtocolEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Start(IInternetProtocolEx* pThis, [NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink, [NativeTypeName("IInternetBindInfo *")] IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] nuint dwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Continue(IInternetProtocolEx* pThis, [NativeTypeName("PROTOCOLDATA *")] PROTOCOLDATA* pProtocolData);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Abort(IInternetProtocolEx* pThis, [NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Terminate(IInternetProtocolEx* pThis, [NativeTypeName("DWORD")] uint dwOptions);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Suspend(IInternetProtocolEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Resume(IInternetProtocolEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Read(IInternetProtocolEx* pThis, [NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Seek(IInternetProtocolEx* pThis, LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockRequest(IInternetProtocolEx* pThis, [NativeTypeName("DWORD")] uint dwOptions);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnlockRequest(IInternetProtocolEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _StartEx(IInternetProtocolEx* pThis, [NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink, [NativeTypeName("IInternetBindInfo *")] IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] nuint dwReserved);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IInternetProtocolEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink, [NativeTypeName("IInternetBindInfo *")] IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] nuint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_Start>(lpVtbl->Start)((IInternetProtocolEx*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int Continue([NativeTypeName("PROTOCOLDATA *")] PROTOCOLDATA* pProtocolData)
        {
            return Marshal.GetDelegateForFunctionPointer<_Continue>(lpVtbl->Continue)((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pProtocolData);
        }

        [return: NativeTypeName("HRESULT")]
        public int Abort([NativeTypeName("HRESULT")] int hrReason, [NativeTypeName("DWORD")] uint dwOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_Abort>(lpVtbl->Abort)((IInternetProtocolEx*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("DWORD")] uint dwOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_Terminate>(lpVtbl->Terminate)((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return Marshal.GetDelegateForFunctionPointer<_Suspend>(lpVtbl->Suspend)((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return Marshal.GetDelegateForFunctionPointer<_Resume>(lpVtbl->Resume)((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return Marshal.GetDelegateForFunctionPointer<_Seek>(lpVtbl->Seek)((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRequest([NativeTypeName("DWORD")] uint dwOptions)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockRequest>(lpVtbl->LockRequest)((IInternetProtocolEx*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRequest()
        {
            return Marshal.GetDelegateForFunctionPointer<_UnlockRequest>(lpVtbl->UnlockRequest)((IInternetProtocolEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int StartEx([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("IInternetProtocolSink *")] IInternetProtocolSink* pOIProtSink, [NativeTypeName("IInternetBindInfo *")] IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, [NativeTypeName("HANDLE_PTR")] nuint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_StartEx>(lpVtbl->StartEx)((IInternetProtocolEx*)Unsafe.AsPointer(ref this), pUri, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))")]
            public IntPtr Start;

            [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
            public IntPtr Continue;

            [NativeTypeName("HRESULT (HRESULT, DWORD) __attribute__((stdcall))")]
            public IntPtr Abort;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Terminate;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Suspend;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Resume;

            [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public IntPtr Read;

            [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public IntPtr Seek;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr LockRequest;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr UnlockRequest;

            [NativeTypeName("HRESULT (IUri *, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))")]
            public IntPtr StartEx;
        }
    }
}
