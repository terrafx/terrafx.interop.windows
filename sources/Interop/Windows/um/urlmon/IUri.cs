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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IUri* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IUri* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IUri* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyBSTR(IUri* pThis, Uri_PROPERTY uriProp, [NativeTypeName("BSTR *")] ushort** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyLength(IUri* pThis, Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPropertyDWORD(IUri* pThis, Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HasProperty(IUri* pThis, Uri_PROPERTY uriProp, [NativeTypeName("BOOL *")] int* pfHasProperty);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAbsoluteUri(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrAbsoluteUri);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthority(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrAuthority);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDisplayUri(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrDisplayString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDomain(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrDomain);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetExtension(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrExtension);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFragment(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrFragment);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHost(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrHost);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPassword(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrPassword);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPath(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrPath);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPathAndQuery(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrPathAndQuery);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetQuery(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrQuery);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRawUri(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrRawUri);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSchemeName(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrSchemeName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUserInfo(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrUserInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUserNameA(IUri* pThis, [NativeTypeName("BSTR *")] ushort** pbstrUserName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHostType(IUri* pThis, [NativeTypeName("DWORD *")] uint* pdwHostType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPort(IUri* pThis, [NativeTypeName("DWORD *")] uint* pdwPort);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetScheme(IUri* pThis, [NativeTypeName("DWORD *")] uint* pdwScheme);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetZone(IUri* pThis, [NativeTypeName("DWORD *")] uint* pdwZone);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetProperties(IUri* pThis, [NativeTypeName("LPDWORD")] uint* pdwFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsEqual(IUri* pThis, [NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("BOOL *")] int* pfEqual);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IUri*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IUri*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IUri*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyBSTR(Uri_PROPERTY uriProp, [NativeTypeName("BSTR *")] ushort** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyBSTR>(lpVtbl->GetPropertyBSTR)((IUri*)Unsafe.AsPointer(ref this), uriProp, pbstrProperty, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyLength(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyLength>(lpVtbl->GetPropertyLength)((IUri*)Unsafe.AsPointer(ref this), uriProp, pcchProperty, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDWORD(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPropertyDWORD>(lpVtbl->GetPropertyDWORD)((IUri*)Unsafe.AsPointer(ref this), uriProp, pdwProperty, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasProperty(Uri_PROPERTY uriProp, [NativeTypeName("BOOL *")] int* pfHasProperty)
        {
            return Marshal.GetDelegateForFunctionPointer<_HasProperty>(lpVtbl->HasProperty)((IUri*)Unsafe.AsPointer(ref this), uriProp, pfHasProperty);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAbsoluteUri([NativeTypeName("BSTR *")] ushort** pbstrAbsoluteUri)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAbsoluteUri>(lpVtbl->GetAbsoluteUri)((IUri*)Unsafe.AsPointer(ref this), pbstrAbsoluteUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthority([NativeTypeName("BSTR *")] ushort** pbstrAuthority)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAuthority>(lpVtbl->GetAuthority)((IUri*)Unsafe.AsPointer(ref this), pbstrAuthority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayUri([NativeTypeName("BSTR *")] ushort** pbstrDisplayString)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDisplayUri>(lpVtbl->GetDisplayUri)((IUri*)Unsafe.AsPointer(ref this), pbstrDisplayString);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDomain([NativeTypeName("BSTR *")] ushort** pbstrDomain)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDomain>(lpVtbl->GetDomain)((IUri*)Unsafe.AsPointer(ref this), pbstrDomain);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtension([NativeTypeName("BSTR *")] ushort** pbstrExtension)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExtension>(lpVtbl->GetExtension)((IUri*)Unsafe.AsPointer(ref this), pbstrExtension);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFragment([NativeTypeName("BSTR *")] ushort** pbstrFragment)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFragment>(lpVtbl->GetFragment)((IUri*)Unsafe.AsPointer(ref this), pbstrFragment);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHost([NativeTypeName("BSTR *")] ushort** pbstrHost)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHost>(lpVtbl->GetHost)((IUri*)Unsafe.AsPointer(ref this), pbstrHost);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("BSTR *")] ushort** pbstrPassword)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPassword>(lpVtbl->GetPassword)((IUri*)Unsafe.AsPointer(ref this), pbstrPassword);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("BSTR *")] ushort** pbstrPath)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPath>(lpVtbl->GetPath)((IUri*)Unsafe.AsPointer(ref this), pbstrPath);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPathAndQuery([NativeTypeName("BSTR *")] ushort** pbstrPathAndQuery)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPathAndQuery>(lpVtbl->GetPathAndQuery)((IUri*)Unsafe.AsPointer(ref this), pbstrPathAndQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuery([NativeTypeName("BSTR *")] ushort** pbstrQuery)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetQuery>(lpVtbl->GetQuery)((IUri*)Unsafe.AsPointer(ref this), pbstrQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRawUri([NativeTypeName("BSTR *")] ushort** pbstrRawUri)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRawUri>(lpVtbl->GetRawUri)((IUri*)Unsafe.AsPointer(ref this), pbstrRawUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSchemeName([NativeTypeName("BSTR *")] ushort** pbstrSchemeName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSchemeName>(lpVtbl->GetSchemeName)((IUri*)Unsafe.AsPointer(ref this), pbstrSchemeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserInfo([NativeTypeName("BSTR *")] ushort** pbstrUserInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUserInfo>(lpVtbl->GetUserInfo)((IUri*)Unsafe.AsPointer(ref this), pbstrUserInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserNameA([NativeTypeName("BSTR *")] ushort** pbstrUserName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUserNameA>(lpVtbl->GetUserNameA)((IUri*)Unsafe.AsPointer(ref this), pbstrUserName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHostType>(lpVtbl->GetHostType)((IUri*)Unsafe.AsPointer(ref this), pdwHostType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPort([NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPort>(lpVtbl->GetPort)((IUri*)Unsafe.AsPointer(ref this), pdwPort);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetScheme>(lpVtbl->GetScheme)((IUri*)Unsafe.AsPointer(ref this), pdwScheme);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZone([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetZone>(lpVtbl->GetZone)((IUri*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetProperties>(lpVtbl->GetProperties)((IUri*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("BOOL *")] int* pfEqual)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsEqual>(lpVtbl->IsEqual)((IUri*)Unsafe.AsPointer(ref this), pUri, pfEqual);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (Uri_PROPERTY, BSTR *, DWORD) __attribute__((stdcall))")]
            public IntPtr GetPropertyBSTR;

            [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
            public IntPtr GetPropertyLength;

            [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
            public IntPtr GetPropertyDWORD;

            [NativeTypeName("HRESULT (Uri_PROPERTY, BOOL *) __attribute__((stdcall))")]
            public IntPtr HasProperty;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetAbsoluteUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetAuthority;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDisplayUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDomain;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetExtension;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetFragment;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetHost;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetPassword;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetPath;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetPathAndQuery;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetQuery;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetRawUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetSchemeName;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetUserInfo;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetUserNameA;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetHostType;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetPort;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetScheme;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetZone;

            [NativeTypeName("HRESULT (LPDWORD) __attribute__((stdcall))")]
            public IntPtr GetProperties;

            [NativeTypeName("HRESULT (IUri *, BOOL *) __attribute__((stdcall))")]
            public IntPtr IsEqual;
        }
    }
}
