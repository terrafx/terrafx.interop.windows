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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUri*, Guid*, void**, int>)(lpVtbl[0]))((IUri*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUri*, uint>)(lpVtbl[1]))((IUri*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUri*, uint>)(lpVtbl[2]))((IUri*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyBSTR(Uri_PROPERTY uriProp, [NativeTypeName("BSTR *")] ushort** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IUri*, Uri_PROPERTY, ushort**, uint, int>)(lpVtbl[3]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pbstrProperty, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyLength(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IUri*, Uri_PROPERTY, uint*, uint, int>)(lpVtbl[4]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pcchProperty, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDWORD(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IUri*, Uri_PROPERTY, uint*, uint, int>)(lpVtbl[5]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pdwProperty, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasProperty(Uri_PROPERTY uriProp, [NativeTypeName("BOOL *")] int* pfHasProperty)
        {
            return ((delegate* stdcall<IUri*, Uri_PROPERTY, int*, int>)(lpVtbl[6]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pfHasProperty);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAbsoluteUri([NativeTypeName("BSTR *")] ushort** pbstrAbsoluteUri)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[7]))((IUri*)Unsafe.AsPointer(ref this), pbstrAbsoluteUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthority([NativeTypeName("BSTR *")] ushort** pbstrAuthority)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[8]))((IUri*)Unsafe.AsPointer(ref this), pbstrAuthority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayUri([NativeTypeName("BSTR *")] ushort** pbstrDisplayString)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[9]))((IUri*)Unsafe.AsPointer(ref this), pbstrDisplayString);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDomain([NativeTypeName("BSTR *")] ushort** pbstrDomain)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[10]))((IUri*)Unsafe.AsPointer(ref this), pbstrDomain);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtension([NativeTypeName("BSTR *")] ushort** pbstrExtension)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[11]))((IUri*)Unsafe.AsPointer(ref this), pbstrExtension);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFragment([NativeTypeName("BSTR *")] ushort** pbstrFragment)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[12]))((IUri*)Unsafe.AsPointer(ref this), pbstrFragment);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHost([NativeTypeName("BSTR *")] ushort** pbstrHost)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[13]))((IUri*)Unsafe.AsPointer(ref this), pbstrHost);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("BSTR *")] ushort** pbstrPassword)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[14]))((IUri*)Unsafe.AsPointer(ref this), pbstrPassword);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("BSTR *")] ushort** pbstrPath)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[15]))((IUri*)Unsafe.AsPointer(ref this), pbstrPath);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPathAndQuery([NativeTypeName("BSTR *")] ushort** pbstrPathAndQuery)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[16]))((IUri*)Unsafe.AsPointer(ref this), pbstrPathAndQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuery([NativeTypeName("BSTR *")] ushort** pbstrQuery)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[17]))((IUri*)Unsafe.AsPointer(ref this), pbstrQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRawUri([NativeTypeName("BSTR *")] ushort** pbstrRawUri)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[18]))((IUri*)Unsafe.AsPointer(ref this), pbstrRawUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSchemeName([NativeTypeName("BSTR *")] ushort** pbstrSchemeName)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[19]))((IUri*)Unsafe.AsPointer(ref this), pbstrSchemeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserInfo([NativeTypeName("BSTR *")] ushort** pbstrUserInfo)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[20]))((IUri*)Unsafe.AsPointer(ref this), pbstrUserInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserNameA([NativeTypeName("BSTR *")] ushort** pbstrUserName)
        {
            return ((delegate* stdcall<IUri*, ushort**, int>)(lpVtbl[21]))((IUri*)Unsafe.AsPointer(ref this), pbstrUserName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType)
        {
            return ((delegate* stdcall<IUri*, uint*, int>)(lpVtbl[22]))((IUri*)Unsafe.AsPointer(ref this), pdwHostType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPort([NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return ((delegate* stdcall<IUri*, uint*, int>)(lpVtbl[23]))((IUri*)Unsafe.AsPointer(ref this), pdwPort);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme)
        {
            return ((delegate* stdcall<IUri*, uint*, int>)(lpVtbl[24]))((IUri*)Unsafe.AsPointer(ref this), pdwScheme);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetZone([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return ((delegate* stdcall<IUri*, uint*, int>)(lpVtbl[25]))((IUri*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags)
        {
            return ((delegate* stdcall<IUri*, uint*, int>)(lpVtbl[26]))((IUri*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IUri *")] IUri* pUri, [NativeTypeName("BOOL *")] int* pfEqual)
        {
            return ((delegate* stdcall<IUri*, IUri*, int*, int>)(lpVtbl[27]))((IUri*)Unsafe.AsPointer(ref this), pUri, pfEqual);
        }
    }
}
