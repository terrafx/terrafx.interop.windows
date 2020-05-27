// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9D1-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct ICodeInstall
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ICodeInstall* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ICodeInstall* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ICodeInstall* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindow(ICodeInstall* pThis, [NativeTypeName("const GUID &")] Guid* rguidReason, [NativeTypeName("HWND *")] IntPtr* phwnd);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnCodeInstallProblem(ICodeInstall* pThis, [NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szDestination, [NativeTypeName("LPCWSTR")] ushort* szSource, [NativeTypeName("DWORD")] uint dwReserved);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ICodeInstall*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ICodeInstall*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ICodeInstall*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, [NativeTypeName("HWND *")] IntPtr* phwnd)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindow>(lpVtbl->GetWindow)((ICodeInstall*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnCodeInstallProblem([NativeTypeName("ULONG")] uint ulStatusCode, [NativeTypeName("LPCWSTR")] ushort* szDestination, [NativeTypeName("LPCWSTR")] ushort* szSource, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnCodeInstallProblem>(lpVtbl->OnCodeInstallProblem)((ICodeInstall*)Unsafe.AsPointer(ref this), ulStatusCode, szDestination, szSource, dwReserved);
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

            [NativeTypeName("HRESULT (ULONG, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
            public IntPtr OnCodeInstallProblem;
        }
    }
}
