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
    public unsafe partial struct IUri
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUri*, Guid*, void**, int>)(lpVtbl[0]))((IUri*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUri*, uint>)(lpVtbl[1]))((IUri*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUri*, uint>)(lpVtbl[2]))((IUri*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyBSTR(Uri_PROPERTY uriProp, [NativeTypeName("BSTR *")] ushort** pbstrProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IUri*, Uri_PROPERTY, ushort**, uint, int>)(lpVtbl[3]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pbstrProperty, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyLength(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pcchProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IUri*, Uri_PROPERTY, uint*, uint, int>)(lpVtbl[4]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pcchProperty, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyDWORD(Uri_PROPERTY uriProp, [NativeTypeName("DWORD *")] uint* pdwProperty, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IUri*, Uri_PROPERTY, uint*, uint, int>)(lpVtbl[5]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pdwProperty, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasProperty(Uri_PROPERTY uriProp, [NativeTypeName("BOOL *")] int* pfHasProperty)
        {
            return ((delegate* unmanaged<IUri*, Uri_PROPERTY, int*, int>)(lpVtbl[6]))((IUri*)Unsafe.AsPointer(ref this), uriProp, pfHasProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAbsoluteUri([NativeTypeName("BSTR *")] ushort** pbstrAbsoluteUri)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[7]))((IUri*)Unsafe.AsPointer(ref this), pbstrAbsoluteUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthority([NativeTypeName("BSTR *")] ushort** pbstrAuthority)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[8]))((IUri*)Unsafe.AsPointer(ref this), pbstrAuthority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayUri([NativeTypeName("BSTR *")] ushort** pbstrDisplayString)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[9]))((IUri*)Unsafe.AsPointer(ref this), pbstrDisplayString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDomain([NativeTypeName("BSTR *")] ushort** pbstrDomain)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[10]))((IUri*)Unsafe.AsPointer(ref this), pbstrDomain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtension([NativeTypeName("BSTR *")] ushort** pbstrExtension)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[11]))((IUri*)Unsafe.AsPointer(ref this), pbstrExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFragment([NativeTypeName("BSTR *")] ushort** pbstrFragment)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[12]))((IUri*)Unsafe.AsPointer(ref this), pbstrFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHost([NativeTypeName("BSTR *")] ushort** pbstrHost)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[13]))((IUri*)Unsafe.AsPointer(ref this), pbstrHost);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPassword([NativeTypeName("BSTR *")] ushort** pbstrPassword)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[14]))((IUri*)Unsafe.AsPointer(ref this), pbstrPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("BSTR *")] ushort** pbstrPath)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[15]))((IUri*)Unsafe.AsPointer(ref this), pbstrPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPathAndQuery([NativeTypeName("BSTR *")] ushort** pbstrPathAndQuery)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[16]))((IUri*)Unsafe.AsPointer(ref this), pbstrPathAndQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetQuery([NativeTypeName("BSTR *")] ushort** pbstrQuery)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[17]))((IUri*)Unsafe.AsPointer(ref this), pbstrQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRawUri([NativeTypeName("BSTR *")] ushort** pbstrRawUri)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[18]))((IUri*)Unsafe.AsPointer(ref this), pbstrRawUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSchemeName([NativeTypeName("BSTR *")] ushort** pbstrSchemeName)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[19]))((IUri*)Unsafe.AsPointer(ref this), pbstrSchemeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUserInfo([NativeTypeName("BSTR *")] ushort** pbstrUserInfo)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[20]))((IUri*)Unsafe.AsPointer(ref this), pbstrUserInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUserName([NativeTypeName("BSTR *")] ushort** pbstrUserName)
        {
            return ((delegate* unmanaged<IUri*, ushort**, int>)(lpVtbl[21]))((IUri*)Unsafe.AsPointer(ref this), pbstrUserName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHostType([NativeTypeName("DWORD *")] uint* pdwHostType)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[22]))((IUri*)Unsafe.AsPointer(ref this), pdwHostType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPort([NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[23]))((IUri*)Unsafe.AsPointer(ref this), pdwPort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScheme([NativeTypeName("DWORD *")] uint* pdwScheme)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[24]))((IUri*)Unsafe.AsPointer(ref this), pdwScheme);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetZone([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[25]))((IUri*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("LPDWORD")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IUri*, uint*, int>)(lpVtbl[26]))((IUri*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqual(IUri* pUri, [NativeTypeName("BOOL *")] int* pfEqual)
        {
            return ((delegate* unmanaged<IUri*, IUri*, int*, int>)(lpVtbl[27]))((IUri*)Unsafe.AsPointer(ref this), pUri, pfEqual);
        }
    }
}
