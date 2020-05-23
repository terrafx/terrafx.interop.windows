// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9D7-BAFA-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IHttpSecurity
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IHttpSecurity* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IHttpSecurity* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IHttpSecurity* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindow(IHttpSecurity* pThis, [NativeTypeName("const GUID &")] Guid* rguidReason, [NativeTypeName("HWND *")] IntPtr* phwnd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnSecurityProblem(IHttpSecurity* pThis, [NativeTypeName("DWORD")] uint dwProblem);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IHttpSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindow>(lpVtbl->GetWindow)((IHttpSecurity*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnSecurityProblem([NativeTypeName("DWORD")] uint dwProblem)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnSecurityProblem>(lpVtbl->OnSecurityProblem)((IHttpSecurity*)Unsafe.AsPointer(ref this), dwProblem);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
            public IntPtr GetWindow;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr OnSecurityProblem;
        }
    }
}
