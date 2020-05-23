// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4221B2E1-8955-46C0-BD5B-DE9897565DE7")]
    public unsafe partial struct IUriBuilder
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IUriBuilder* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IUriBuilder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IUriBuilder* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateUriSimple(IUriBuilder* pThis, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateUri(IUriBuilder* pThis, [NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateUriWithFlags(IUriBuilder* pThis, [NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIUri(IUriBuilder* pThis, [NativeTypeName("IUri **")] IUri** ppIUri);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetIUri(IUriBuilder* pThis, [NativeTypeName("IUri *")] IUri* pIUri);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFragment(IUriBuilder* pThis, [NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] ushort** ppwzFragment);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHost(IUriBuilder* pThis, [NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] ushort** ppwzHost);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPassword(IUriBuilder* pThis, [NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] ushort** ppwzPassword);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPath(IUriBuilder* pThis, [NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] ushort** ppwzPath);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPort(IUriBuilder* pThis, [NativeTypeName("BOOL *")] int* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetQuery(IUriBuilder* pThis, [NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] ushort** ppwzQuery);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSchemeName(IUriBuilder* pThis, [NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] ushort** ppwzSchemeName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUserNameA(IUriBuilder* pThis, [NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] ushort** ppwzUserName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFragment(IUriBuilder* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHost(IUriBuilder* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPassword(IUriBuilder* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPath(IUriBuilder* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPortA(IUriBuilder* pThis, [NativeTypeName("BOOL")] int fHasPort, [NativeTypeName("DWORD")] uint dwNewValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetQuery(IUriBuilder* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSchemeName(IUriBuilder* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetUserName(IUriBuilder* pThis, [NativeTypeName("LPCWSTR")] ushort* pwzNewValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RemoveProperties(IUriBuilder* pThis, [NativeTypeName("DWORD")] uint dwPropertyMask);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HasBeenModified(IUriBuilder* pThis, [NativeTypeName("BOOL *")] int* pfModified);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IUriBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateUriSimple>(lpVtbl->CreateUriSimple)((IUriBuilder*)Unsafe.AsPointer(ref this), dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateUri>(lpVtbl->CreateUri)((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateUriWithFlags>(lpVtbl->CreateUriWithFlags)((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwUriBuilderFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIUri([NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIUri>(lpVtbl->GetIUri)((IUriBuilder*)Unsafe.AsPointer(ref this), ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIUri([NativeTypeName("IUri *")] IUri* pIUri)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetIUri>(lpVtbl->SetIUri)((IUriBuilder*)Unsafe.AsPointer(ref this), pIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] ushort** ppwzFragment)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFragment>(lpVtbl->GetFragment)((IUriBuilder*)Unsafe.AsPointer(ref this), pcchFragment, ppwzFragment);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] ushort** ppwzHost)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHost>(lpVtbl->GetHost)((IUriBuilder*)Unsafe.AsPointer(ref this), pcchHost, ppwzHost);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] ushort** ppwzPassword)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPassword>(lpVtbl->GetPassword)((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPassword, ppwzPassword);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] ushort** ppwzPath)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPath>(lpVtbl->GetPath)((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPath, ppwzPath);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPort([NativeTypeName("BOOL *")] int* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPort>(lpVtbl->GetPort)((IUriBuilder*)Unsafe.AsPointer(ref this), pfHasPort, pdwPort);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] ushort** ppwzQuery)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetQuery>(lpVtbl->GetQuery)((IUriBuilder*)Unsafe.AsPointer(ref this), pcchQuery, ppwzQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] ushort** ppwzSchemeName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSchemeName>(lpVtbl->GetSchemeName)((IUriBuilder*)Unsafe.AsPointer(ref this), pcchSchemeName, ppwzSchemeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserNameA([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] ushort** ppwzUserName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUserNameA>(lpVtbl->GetUserNameA)((IUriBuilder*)Unsafe.AsPointer(ref this), pcchUserName, ppwzUserName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFragment([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFragment>(lpVtbl->SetFragment)((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHost([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHost>(lpVtbl->SetHost)((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPassword([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPassword>(lpVtbl->SetPassword)((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPath([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPath>(lpVtbl->SetPath)((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPortA([NativeTypeName("BOOL")] int fHasPort, [NativeTypeName("DWORD")] uint dwNewValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPortA>(lpVtbl->SetPortA)((IUriBuilder*)Unsafe.AsPointer(ref this), fHasPort, dwNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetQuery([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetQuery>(lpVtbl->SetQuery)((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSchemeName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSchemeName>(lpVtbl->SetSchemeName)((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUserName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetUserName>(lpVtbl->SetUserName)((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask)
        {
            return Marshal.GetDelegateForFunctionPointer<_RemoveProperties>(lpVtbl->RemoveProperties)((IUriBuilder*)Unsafe.AsPointer(ref this), dwPropertyMask);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasBeenModified([NativeTypeName("BOOL *")] int* pfModified)
        {
            return Marshal.GetDelegateForFunctionPointer<_HasBeenModified>(lpVtbl->HasBeenModified)((IUriBuilder*)Unsafe.AsPointer(ref this), pfModified);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
            public IntPtr CreateUriSimple;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
            public IntPtr CreateUri;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
            public IntPtr CreateUriWithFlags;

            [NativeTypeName("HRESULT (IUri **) __attribute__((stdcall))")]
            public IntPtr GetIUri;

            [NativeTypeName("HRESULT (IUri *) __attribute__((stdcall))")]
            public IntPtr SetIUri;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public IntPtr GetFragment;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public IntPtr GetHost;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public IntPtr GetPassword;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public IntPtr GetPath;

            [NativeTypeName("HRESULT (BOOL *, DWORD *) __attribute__((stdcall))")]
            public IntPtr GetPort;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public IntPtr GetQuery;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public IntPtr GetSchemeName;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public IntPtr GetUserNameA;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetFragment;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetHost;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetPassword;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetPath;

            [NativeTypeName("HRESULT (BOOL, DWORD) __attribute__((stdcall))")]
            public IntPtr SetPortA;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetQuery;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetSchemeName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetUserName;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr RemoveProperties;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr HasBeenModified;
        }
    }
}
