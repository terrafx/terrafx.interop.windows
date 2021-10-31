// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4221B2E1-8955-46C0-BD5B-DE9897565DE7")]
    [NativeTypeName("struct IUriBuilder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUriBuilder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUriBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IUriBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUriBuilder*, uint>)(lpVtbl[1]))((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUriBuilder*, uint>)(lpVtbl[2]))((IUriBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateUriSimple([NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint, nuint, IUri**, int>)(lpVtbl[3]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateUri([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint, uint, nuint, IUri**, int>)(lpVtbl[4]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateUriWithFlags([NativeTypeName("DWORD")] uint dwCreateFlags, [NativeTypeName("DWORD")] uint dwUriBuilderFlags, [NativeTypeName("DWORD")] uint dwAllowEncodingPropertyMask, [NativeTypeName("DWORD_PTR")] nuint dwReserved, IUri** ppIUri)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint, uint, uint, nuint, IUri**, int>)(lpVtbl[5]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwCreateFlags, dwUriBuilderFlags, dwAllowEncodingPropertyMask, dwReserved, ppIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetIUri(IUri** ppIUri)
        {
            return ((delegate* unmanaged<IUriBuilder*, IUri**, int>)(lpVtbl[6]))((IUriBuilder*)Unsafe.AsPointer(ref this), ppIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetIUri(IUri* pIUri)
        {
            return ((delegate* unmanaged<IUriBuilder*, IUri*, int>)(lpVtbl[7]))((IUriBuilder*)Unsafe.AsPointer(ref this), pIUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetFragment([NativeTypeName("DWORD *")] uint* pcchFragment, [NativeTypeName("LPCWSTR *")] ushort** ppwzFragment)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[8]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchFragment, ppwzFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetHost([NativeTypeName("DWORD *")] uint* pcchHost, [NativeTypeName("LPCWSTR *")] ushort** ppwzHost)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[9]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchHost, ppwzHost);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetPassword([NativeTypeName("DWORD *")] uint* pcchPassword, [NativeTypeName("LPCWSTR *")] ushort** ppwzPassword)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[10]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPassword, ppwzPassword);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetPath([NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("LPCWSTR *")] ushort** ppwzPath)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[11]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchPath, ppwzPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetPort(BOOL* pfHasPort, [NativeTypeName("DWORD *")] uint* pdwPort)
        {
            return ((delegate* unmanaged<IUriBuilder*, BOOL*, uint*, int>)(lpVtbl[12]))((IUriBuilder*)Unsafe.AsPointer(ref this), pfHasPort, pdwPort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetQuery([NativeTypeName("DWORD *")] uint* pcchQuery, [NativeTypeName("LPCWSTR *")] ushort** ppwzQuery)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[13]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchQuery, ppwzQuery);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetSchemeName([NativeTypeName("DWORD *")] uint* pcchSchemeName, [NativeTypeName("LPCWSTR *")] ushort** ppwzSchemeName)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[14]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchSchemeName, ppwzSchemeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetUserName([NativeTypeName("DWORD *")] uint* pcchUserName, [NativeTypeName("LPCWSTR *")] ushort** ppwzUserName)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint*, ushort**, int>)(lpVtbl[15]))((IUriBuilder*)Unsafe.AsPointer(ref this), pcchUserName, ppwzUserName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetFragment([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[16]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetHost([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[17]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetPassword([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[18]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetPath([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[19]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SetPort(BOOL fHasPort, [NativeTypeName("DWORD")] uint dwNewValue)
        {
            return ((delegate* unmanaged<IUriBuilder*, BOOL, uint, int>)(lpVtbl[20]))((IUriBuilder*)Unsafe.AsPointer(ref this), fHasPort, dwNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetQuery([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[21]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetSchemeName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[22]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetUserName([NativeTypeName("LPCWSTR")] ushort* pwzNewValue)
        {
            return ((delegate* unmanaged<IUriBuilder*, ushort*, int>)(lpVtbl[23]))((IUriBuilder*)Unsafe.AsPointer(ref this), pwzNewValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT RemoveProperties([NativeTypeName("DWORD")] uint dwPropertyMask)
        {
            return ((delegate* unmanaged<IUriBuilder*, uint, int>)(lpVtbl[24]))((IUriBuilder*)Unsafe.AsPointer(ref this), dwPropertyMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT HasBeenModified(BOOL* pfModified)
        {
            return ((delegate* unmanaged<IUriBuilder*, BOOL*, int>)(lpVtbl[25]))((IUriBuilder*)Unsafe.AsPointer(ref this), pfModified);
        }
    }
}
