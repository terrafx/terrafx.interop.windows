// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A39EE748-6A27-4817-A6F2-13914BEF5890")]
    [NativeTypeName("struct IUri : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUri : IUri.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUri*, Guid*, void**, int>)(lpVtbl[0]))((IUri*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUri*, uint>)(lpVtbl[1]))((IUri*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUri*, uint>)(lpVtbl[2]))((IUri*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPropertyBSTR(Uri_PROPERTY uriProp, [NativeTypeName("BSTR *")] ushort** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IUri*, Uri_PROPERTY, ushort**, uint, int>)(lpVtbl[3]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pbstrProperty, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPropertyLength(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IUri*, Uri_PROPERTY, uint*, uint, int>)(lpVtbl[4]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pcchProperty, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPropertyDWORD(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IUri*, Uri_PROPERTY, uint*, uint, int>)(lpVtbl[5]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pdwProperty, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT HasProperty(Uri_PROPERTY uriProp, BOOL* pfHasProperty)
        {
            return ((delegate* unmanaged<IUri*, Uri_PROPERTY, BOOL*, int>)(lpVtbl[6]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pfHasProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetAbsoluteUri([NativeTypeName("BSTR *")] ushort** pbstrAbsoluteUri)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[7]))((IUri*)Unsafe.AsPointer(ref this), pbstrAbsoluteUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetAuthority([NativeTypeName("BSTR *")] ushort** pbstrAuthority)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[8]))((IUri*)Unsafe.AsPointer(ref this), pbstrAuthority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDisplayUri([NativeTypeName("BSTR *")] ushort** pbstrDisplayString)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[9]))((IUri*)Unsafe.AsPointer(ref this), pbstrDisplayString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetDomain([NativeTypeName("BSTR *")] ushort** pbstrDomain)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[10]))((IUri*)Unsafe.AsPointer(ref this), pbstrDomain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetExtension([NativeTypeName("BSTR *")] ushort** pbstrExtension)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[11]))((IUri*)Unsafe.AsPointer(ref this), pbstrExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetFragment([NativeTypeName("BSTR *")] ushort** pbstrFragment)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[12]))((IUri*)Unsafe.AsPointer(ref this), pbstrFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetHost([NativeTypeName("BSTR *")] ushort** pbstrHost)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[13]))((IUri*)Unsafe.AsPointer(ref this), pbstrHost);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetPassword([NativeTypeName("BSTR *")] ushort** pbstrPassword)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[14]))((IUri*)Unsafe.AsPointer(ref this), pbstrPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetPath([NativeTypeName("BSTR *")] ushort** pbstrPath)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[15]))((IUri*)Unsafe.AsPointer(ref this), pbstrPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetPathAndQuery([NativeTypeName("BSTR *")] ushort** pbstrPathAndQuery)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[16]))((IUri*)Unsafe.AsPointer(ref this), pbstrPathAndQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetQuery([NativeTypeName("BSTR *")] ushort** pbstrQuery)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[17]))((IUri*)Unsafe.AsPointer(ref this), pbstrQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetRawUri([NativeTypeName("BSTR *")] ushort** pbstrRawUri)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[18]))((IUri*)Unsafe.AsPointer(ref this), pbstrRawUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetSchemeName([NativeTypeName("BSTR *")] ushort** pbstrSchemeName)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[19]))((IUri*)Unsafe.AsPointer(ref this), pbstrSchemeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetUserInfo([NativeTypeName("BSTR *")] ushort** pbstrUserInfo)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[20]))((IUri*)Unsafe.AsPointer(ref this), pbstrUserInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetUserName([NativeTypeName("BSTR *")] ushort** pbstrUserName)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[21]))((IUri*)Unsafe.AsPointer(ref this), pbstrUserName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[22]))((IUri*)Unsafe.AsPointer(ref this), pdwHostType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetPort([NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[23]))((IUri*)Unsafe.AsPointer(ref this), pdwPort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[24]))((IUri*)Unsafe.AsPointer(ref this), pdwScheme);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetZone([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[25]))((IUri*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[26]))((IUri*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT IsEqual(IUri* pUri, BOOL* pfEqual)
        {
            return ((delegate* unmanaged<IUri*, IUri*, BOOL*, int>)(lpVtbl[27]))((IUri*)Unsafe.AsPointer(ref this), pUri, pfEqual);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetPropertyBSTR(Uri_PROPERTY uriProp, [NativeTypeName("BSTR *")] ushort** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(4)]
            HRESULT GetPropertyLength(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(5)]
            HRESULT GetPropertyDWORD(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags);

            [VtblIndex(6)]
            HRESULT HasProperty(Uri_PROPERTY uriProp, BOOL* pfHasProperty);

            [VtblIndex(7)]
            HRESULT GetAbsoluteUri([NativeTypeName("BSTR *")] ushort** pbstrAbsoluteUri);

            [VtblIndex(8)]
            HRESULT GetAuthority([NativeTypeName("BSTR *")] ushort** pbstrAuthority);

            [VtblIndex(9)]
            HRESULT GetDisplayUri([NativeTypeName("BSTR *")] ushort** pbstrDisplayString);

            [VtblIndex(10)]
            HRESULT GetDomain([NativeTypeName("BSTR *")] ushort** pbstrDomain);

            [VtblIndex(11)]
            HRESULT GetExtension([NativeTypeName("BSTR *")] ushort** pbstrExtension);

            [VtblIndex(12)]
            HRESULT GetFragment([NativeTypeName("BSTR *")] ushort** pbstrFragment);

            [VtblIndex(13)]
            HRESULT GetHost([NativeTypeName("BSTR *")] ushort** pbstrHost);

            [VtblIndex(14)]
            HRESULT GetPassword([NativeTypeName("BSTR *")] ushort** pbstrPassword);

            [VtblIndex(15)]
            HRESULT GetPath([NativeTypeName("BSTR *")] ushort** pbstrPath);

            [VtblIndex(16)]
            HRESULT GetPathAndQuery([NativeTypeName("BSTR *")] ushort** pbstrPathAndQuery);

            [VtblIndex(17)]
            HRESULT GetQuery([NativeTypeName("BSTR *")] ushort** pbstrQuery);

            [VtblIndex(18)]
            HRESULT GetRawUri([NativeTypeName("BSTR *")] ushort** pbstrRawUri);

            [VtblIndex(19)]
            HRESULT GetSchemeName([NativeTypeName("BSTR *")] ushort** pbstrSchemeName);

            [VtblIndex(20)]
            HRESULT GetUserInfo([NativeTypeName("BSTR *")] ushort** pbstrUserInfo);

            [VtblIndex(21)]
            HRESULT GetUserName([NativeTypeName("BSTR *")] ushort** pbstrUserName);

            [VtblIndex(22)]
            HRESULT GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType);

            [VtblIndex(23)]
            HRESULT GetPort([NativeTypeName("DWORD *")] uint* pdwPort);

            [VtblIndex(24)]
            HRESULT GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme);

            [VtblIndex(25)]
            HRESULT GetZone([NativeTypeName("DWORD *")] uint* pdwZone);

            [VtblIndex(26)]
            HRESULT GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags);

            [VtblIndex(27)]
            HRESULT IsEqual(IUri* pUri, BOOL* pfEqual);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, uint> Release;

            [NativeTypeName("HRESULT (Uri_PROPERTY, BSTR *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, Uri_PROPERTY, ushort**, uint, int> GetPropertyBSTR;

            [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, Uri_PROPERTY, uint*, uint, int> GetPropertyLength;

            [NativeTypeName("HRESULT (Uri_PROPERTY, DWORD *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, Uri_PROPERTY, uint*, uint, int> GetPropertyDWORD;

            [NativeTypeName("HRESULT (Uri_PROPERTY, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, Uri_PROPERTY, BOOL*, int> HasProperty;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetAbsoluteUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetAuthority;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetDisplayUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetDomain;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetExtension;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetFragment;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetHost;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetPassword;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetPath;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetPathAndQuery;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetQuery;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetRawUri;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetSchemeName;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetUserInfo;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, ushort**, int> GetUserName;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, uint*, int> GetHostType;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, uint*, int> GetPort;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, uint*, int> GetScheme;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, uint*, int> GetZone;

            [NativeTypeName("HRESULT (LPDWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, uint*, int> GetProperties;

            [NativeTypeName("HRESULT (IUri *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUri*, IUri*, BOOL*, int> IsEqual;
        }
    }
}
