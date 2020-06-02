// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A39EE748-6A27-4817-A6F2-13914BEF5890")]
    public unsafe partial struct IUri
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IUri*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IUri*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IUri*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyBSTR(Uri_PROPERTY uriProp, [NativeTypeName("BSTR *")] ushort** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetPropertyBSTR((IUri*)Unsafe.AsPointer(ref this), uriProp, pbstrProperty, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyLength(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetPropertyLength((IUri*)Unsafe.AsPointer(ref this), uriProp, pcchProperty, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDWORD(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return lpVtbl->GetPropertyDWORD((IUri*)Unsafe.AsPointer(ref this), uriProp, pdwProperty, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasProperty(Uri_PROPERTY uriProp, [NativeTypeName("BOOL *")] int* pfHasProperty)
        {
            return lpVtbl->HasProperty((IUri*)Unsafe.AsPointer(ref this), uriProp, pfHasProperty);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAbsoluteUri([NativeTypeName("BSTR *")] ushort** pbstrAbsoluteUri)
        {
            return lpVtbl->GetAbsoluteUri((IUri*)Unsafe.AsPointer(ref this), pbstrAbsoluteUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthority([NativeTypeName("BSTR *")] ushort** pbstrAuthority)
        {
            return lpVtbl->GetAuthority((IUri*)Unsafe.AsPointer(ref this), pbstrAuthority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayUri([NativeTypeName("BSTR *")] ushort** pbstrDisplayString)
        {
            return lpVtbl->GetDisplayUri((IUri*)Unsafe.AsPointer(ref this), pbstrDisplayString);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDomain([NativeTypeName("BSTR *")] ushort** pbstrDomain)
        {
            return lpVtbl->GetDomain((IUri*)Unsafe.AsPointer(ref this), pbstrDomain);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtension([NativeTypeName("BSTR *")] ushort** pbstrExtension)
        {
            return lpVtbl->GetExtension((IUri*)Unsafe.AsPointer(ref this), pbstrExtension);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFragment([NativeTypeName("BSTR *")] ushort** pbstrFragment)
        {
            return lpVtbl->GetFragment((IUri*)Unsafe.AsPointer(ref this), pbstrFragment);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHost([NativeTypeName("BSTR *")] ushort** pbstrHost)
        {
            return lpVtbl->GetHost((IUri*)Unsafe.AsPointer(ref this), pbstrHost);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("BSTR *")] ushort** pbstrPassword)
        {
            return lpVtbl->GetPassword((IUri*)Unsafe.AsPointer(ref this), pbstrPassword);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("BSTR *")] ushort** pbstrPath)
        {
            return lpVtbl->GetPath((IUri*)Unsafe.AsPointer(ref this), pbstrPath);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPathAndQuery([NativeTypeName("BSTR *")] ushort** pbstrPathAndQuery)
        {
            return lpVtbl->GetPathAndQuery((IUri*)Unsafe.AsPointer(ref this), pbstrPathAndQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuery([NativeTypeName("BSTR *")] ushort** pbstrQuery)
        {
            return lpVtbl->GetQuery((IUri*)Unsafe.AsPointer(ref this), pbstrQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRawUri([NativeTypeName("BSTR *")] ushort** pbstrRawUri)
        {
            return lpVtbl->GetRawUri((IUri*)Unsafe.AsPointer(ref this), pbstrRawUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSchemeName([NativeTypeName("BSTR *")] ushort** pbstrSchemeName)
        {
            return lpVtbl->GetSchemeName((IUri*)Unsafe.AsPointer(ref this), pbstrSchemeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserInfo([NativeTypeName("BSTR *")] ushort** pbstrUserInfo)
        {
            return lpVtbl->GetUserInfo((IUri*)Unsafe.AsPointer(ref this), pbstrUserInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserNameA([NativeTypeName("BSTR *")] ushort** pbstrUserName)
        {
            return lpVtbl->GetUserNameA((IUri*)Unsafe.AsPointer(ref this), pbstrUserName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType)
        {
            return lpVtbl->GetHostType((IUri*)Unsafe.AsPointer(ref this), pdwHostType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPort([NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return lpVtbl->GetPort((IUri*)Unsafe.AsPointer(ref this), pdwPort);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme)
        {
            return lpVtbl->GetScheme((IUri*)Unsafe.AsPointer(ref this), pdwScheme);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZone([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return lpVtbl->GetZone((IUri*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags)
        {
            return lpVtbl->GetProperties((IUri*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("BOOL *")] int* pfEqual)
        {
            return lpVtbl->IsEqual((IUri*)Unsafe.AsPointer(ref this), pUri, pfEqual);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, uint> Release;

            [NativeTypeName("HRESULT (Uri_PROPERTY, BSTR *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, Uri_PROPERTY, ushort**, uint, int> GetPropertyBSTR;

            [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, Uri_PROPERTY, uint*, uint, int> GetPropertyLength;

            [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, Uri_PROPERTY, uint*, uint, int> GetPropertyDWORD;

            [NativeTypeName("HRESULT (Uri_PROPERTY, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, Uri_PROPERTY, int*, int> HasProperty;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetAbsoluteUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetAuthority;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetDisplayUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetDomain;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetExtension;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetFragment;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetHost;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetPassword;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetPath;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetPathAndQuery;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetQuery;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetRawUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetSchemeName;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetUserInfo;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, ushort**, int> GetUserNameA;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, uint*, int> GetHostType;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, uint*, int> GetPort;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, uint*, int> GetScheme;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, uint*, int> GetZone;

            [NativeTypeName("HRESULT (LPDWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, uint*, int> GetProperties;

            [NativeTypeName("HRESULT (IUri *, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IUri*, IUri*, int*, int> IsEqual;
        }
    }
}
