// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4221B2E1-8955-46C0-BD5B-DE9897565DE7")]
    [NativeTypeName("struct IUriBuilder : IUnknown")]
    public unsafe partial struct IUriBuilder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IUriBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IUriBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IUriBuilder*, uint>)(lpVtbl[1]))((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IUriBuilder*, uint>)(lpVtbl[2]))((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return ((delegate* stdcall<IUriBuilder*, uint, nuint, IUri**, int>)(lpVtbl[3]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return ((delegate* stdcall<IUriBuilder*, uint, uint, nuint, IUri**, int>)(lpVtbl[4]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, [NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return ((delegate* stdcall<IUriBuilder*, uint, uint, uint, nuint, IUri**, int>)(lpVtbl[5]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwUriBuilderFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIUri([NativeTypeName("IUri **")] IUri** ppIUri)
        {
            return ((delegate* stdcall<IUriBuilder*, IUri**, int>)(lpVtbl[6]))((IUriBuilder*)Unsafe.AsPointer(ref this), ppIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIUri([NativeTypeName("IUri *")] IUri* pIUri)
        {
            return ((delegate* stdcall<IUriBuilder*, IUri*, int>)(lpVtbl[7]))((IUriBuilder*)Unsafe.AsPointer(ref this), pIUri);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] ushort** ppwzFragment)
        {
            return ((delegate* stdcall<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[8]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchFragment, ppwzFragment);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] ushort** ppwzHost)
        {
            return ((delegate* stdcall<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[9]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchHost, ppwzHost);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] ushort** ppwzPassword)
        {
            return ((delegate* stdcall<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[10]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPassword, ppwzPassword);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] ushort** ppwzPath)
        {
            return ((delegate* stdcall<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[11]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPath, ppwzPath);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPort([NativeTypeName("BOOL *")] int* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return ((delegate* stdcall<IUriBuilder*, int*, uint*, int>)(lpVtbl[12]))((IUriBuilder*)Unsafe.AsPointer(ref this), pfHasPort, pdwPort);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] ushort** ppwzQuery)
        {
            return ((delegate* stdcall<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[13]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchQuery, ppwzQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] ushort** ppwzSchemeName)
        {
            return ((delegate* stdcall<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[14]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchSchemeName, ppwzSchemeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserName([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] ushort** ppwzUserName)
        {
            return ((delegate* stdcall<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[15]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchUserName, ppwzUserName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFragment([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* stdcall<IUriBuilder*, ushort*, int>)(lpVtbl[16]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHost([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* stdcall<IUriBuilder*, ushort*, int>)(lpVtbl[17]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPassword([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* stdcall<IUriBuilder*, ushort*, int>)(lpVtbl[18]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPath([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* stdcall<IUriBuilder*, ushort*, int>)(lpVtbl[19]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPort([NativeTypeName("BOOL")] int fHasPort, [NativeTypeName("DWORD")] uint dwNewValue)
        {
            return ((delegate* stdcall<IUriBuilder*, int, uint, int>)(lpVtbl[20]))((IUriBuilder*)Unsafe.AsPointer(ref this), fHasPort, dwNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetQuery([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* stdcall<IUriBuilder*, ushort*, int>)(lpVtbl[21]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSchemeName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* stdcall<IUriBuilder*, ushort*, int>)(lpVtbl[22]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUserName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* stdcall<IUriBuilder*, ushort*, int>)(lpVtbl[23]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask)
        {
            return ((delegate* stdcall<IUriBuilder*, uint, int>)(lpVtbl[24]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwPropertyMask);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasBeenModified([NativeTypeName("BOOL *")] int* pfModified)
        {
            return ((delegate* stdcall<IUriBuilder*, int*, int>)(lpVtbl[25]))((IUriBuilder*)Unsafe.AsPointer(ref this), pfModified);
        }
    }
}
