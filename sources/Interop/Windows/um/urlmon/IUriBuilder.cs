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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IUriBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return lpVtbl->CreateUriSimple((IUriBuilder*)Unsafe.AsPointer(ref this), dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return lpVtbl->CreateUri((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return lpVtbl->CreateUriWithFlags((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwUriBuilderFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIUri([NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return lpVtbl->GetIUri((IUriBuilder*)Unsafe.AsPointer(ref this), ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIUri([NativeTypeName("IUri *")] IUri* pIUri)
        {
            return lpVtbl->SetIUri((IUriBuilder*)Unsafe.AsPointer(ref this), pIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] ushort** ppwzFragment)
        {
            return lpVtbl->GetFragment((IUriBuilder*)Unsafe.AsPointer(ref this), pcchFragment, ppwzFragment);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] ushort** ppwzHost)
        {
            return lpVtbl->GetHost((IUriBuilder*)Unsafe.AsPointer(ref this), pcchHost, ppwzHost);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] ushort** ppwzPassword)
        {
            return lpVtbl->GetPassword((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPassword, ppwzPassword);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] ushort** ppwzPath)
        {
            return lpVtbl->GetPath((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPath, ppwzPath);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPort([NativeTypeName("BOOL *")] int* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return lpVtbl->GetPort((IUriBuilder*)Unsafe.AsPointer(ref this), pfHasPort, pdwPort);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] ushort** ppwzQuery)
        {
            return lpVtbl->GetQuery((IUriBuilder*)Unsafe.AsPointer(ref this), pcchQuery, ppwzQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] ushort** ppwzSchemeName)
        {
            return lpVtbl->GetSchemeName((IUriBuilder*)Unsafe.AsPointer(ref this), pcchSchemeName, ppwzSchemeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserNameA([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] ushort** ppwzUserName)
        {
            return lpVtbl->GetUserNameA((IUriBuilder*)Unsafe.AsPointer(ref this), pcchUserName, ppwzUserName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFragment([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return lpVtbl->SetFragment((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHost([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return lpVtbl->SetHost((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPassword([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return lpVtbl->SetPassword((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPath([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return lpVtbl->SetPath((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPortA([NativeTypeName("BOOL")] int fHasPort, [NativeTypeName("DWORD")] uint dwNewValue)
        {
            return lpVtbl->SetPortA((IUriBuilder*)Unsafe.AsPointer(ref this), fHasPort, dwNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetQuery([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return lpVtbl->SetQuery((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSchemeName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return lpVtbl->SetSchemeName((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUserName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return lpVtbl->SetUserName((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask)
        {
            return lpVtbl->RemoveProperties((IUriBuilder*)Unsafe.AsPointer(ref this), dwPropertyMask);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasBeenModified([NativeTypeName("BOOL *")] int* pfModified)
        {
            return lpVtbl->HasBeenModified((IUriBuilder*)Unsafe.AsPointer(ref this), pfModified);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint, nuint, IUri**, int> CreateUriSimple;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint, uint, nuint, IUri**, int> CreateUri;

            [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD_PTR, IUri **) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint, uint, uint, nuint, IUri**, int> CreateUriWithFlags;

            [NativeTypeName("HRESULT (IUri **) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, IUri**, int> GetIUri;

            [NativeTypeName("HRESULT (IUri *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, IUri*, int> SetIUri;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint*, ushort**, int> GetFragment;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint*, ushort**, int> GetHost;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint*, ushort**, int> GetPassword;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint*, ushort**, int> GetPath;

            [NativeTypeName("HRESULT (BOOL *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, int*, uint*, int> GetPort;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint*, ushort**, int> GetQuery;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint*, ushort**, int> GetSchemeName;

            [NativeTypeName("HRESULT (DWORD *, LPCWSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint*, ushort**, int> GetUserNameA;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, ushort*, int> SetFragment;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, ushort*, int> SetHost;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, ushort*, int> SetPassword;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, ushort*, int> SetPath;

            [NativeTypeName("HRESULT (BOOL, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, int, uint, int> SetPortA;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, ushort*, int> SetQuery;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, ushort*, int> SetSchemeName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, ushort*, int> SetUserName;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, uint, int> RemoveProperties;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IUriBuilder*, int*, int> HasBeenModified;
        }
    }
}
