// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C0-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IBinding
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IBinding* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IBinding* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IBinding* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Abort(IBinding* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Suspend(IBinding* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Resume(IBinding* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPriority(IBinding* pThis, [NativeTypeName("LONG")] int nPriority);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPriority(IBinding* pThis, [NativeTypeName("LONG *")] int* pnPriority);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBindResult(IBinding* pThis, [NativeTypeName("CLSID *")] Guid* pclsidProtocol, [NativeTypeName("DWORD *")] uint* pdwResult, [NativeTypeName("LPOLESTR *")] ushort** pszResult, [NativeTypeName("DWORD *")] uint* pdwReserved);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IBinding*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IBinding*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IBinding*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Abort()
        {
            return Marshal.GetDelegateForFunctionPointer<_Abort>(lpVtbl->Abort)((IBinding*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Suspend()
        {
            return Marshal.GetDelegateForFunctionPointer<_Suspend>(lpVtbl->Suspend)((IBinding*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return Marshal.GetDelegateForFunctionPointer<_Resume>(lpVtbl->Resume)((IBinding*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPriority([NativeTypeName("LONG")] int nPriority)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPriority>(lpVtbl->SetPriority)((IBinding*)Unsafe.AsPointer(ref this), nPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPriority>(lpVtbl->GetPriority)((IBinding*)Unsafe.AsPointer(ref this), pnPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindResult([NativeTypeName("CLSID *")] Guid* pclsidProtocol, [NativeTypeName("DWORD *")] uint* pdwResult, [NativeTypeName("LPOLESTR *")] ushort** pszResult, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBindResult>(lpVtbl->GetBindResult)((IBinding*)Unsafe.AsPointer(ref this), pclsidProtocol, pdwResult, pszResult, pdwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Abort;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Suspend;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Resume;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public IntPtr SetPriority;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public IntPtr GetPriority;

            [NativeTypeName("HRESULT (CLSID *, DWORD *, LPOLESTR *, DWORD *) __attribute__((stdcall))")]
            public IntPtr GetBindResult;
        }
    }
}
