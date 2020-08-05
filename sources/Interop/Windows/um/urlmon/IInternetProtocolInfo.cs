// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9EC-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetProtocolInfo : IUnknown")]
    public unsafe partial struct IInternetProtocolInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInternetProtocolInfo*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInternetProtocolInfo*, uint>)(lpVtbl[1]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInternetProtocolInfo*, uint>)(lpVtbl[2]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ParseUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwParseFlags, [NativeTypeName("LPWSTR")] ushort* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetProtocolInfo*, ushort*, PARSEACTION, uint, ushort*, uint, uint*, uint, int>)(lpVtbl[3]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzUrl, ParseAction, dwParseFlags, pwzResult, cchResult, pcchResult, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int CombineUrl([NativeTypeName("LPCWSTR")] ushort* pwzBaseUrl, [NativeTypeName("LPCWSTR")] ushort* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] ushort* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetProtocolInfo*, ushort*, ushort*, uint, ushort*, uint, uint*, uint, int>)(lpVtbl[4]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzBaseUrl, pwzRelativeUrl, dwCombineFlags, pwzResult, cchResult, pcchResult, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareUrl([NativeTypeName("LPCWSTR")] ushort* pwzUrl1, [NativeTypeName("LPCWSTR")] ushort* pwzUrl2, [NativeTypeName("DWORD")] uint dwCompareFlags)
        {
            return ((delegate* stdcall<IInternetProtocolInfo*, ushort*, ushort*, uint, int>)(lpVtbl[5]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzUrl1, pwzUrl2, dwCompareFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInfo([NativeTypeName("LPCWSTR")] ushort* pwzUrl, QUERYOPTION OueryOption, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IInternetProtocolInfo*, ushort*, QUERYOPTION, uint, void*, uint, uint*, uint, int>)(lpVtbl[6]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzUrl, OueryOption, dwQueryFlags, pBuffer, cbBuffer, pcbBuf, dwReserved);
        }
    }
}
