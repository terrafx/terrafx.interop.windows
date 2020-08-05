// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71FA9A2C-53CE-4662-A132-1A7E8CBF62DB")]
    [NativeTypeName("struct IMFHttpDownloadSession : IUnknown")]
    public unsafe partial struct IMFHttpDownloadSession
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFHttpDownloadSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFHttpDownloadSession*, uint>)(lpVtbl[1]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFHttpDownloadSession*, uint>)(lpVtbl[2]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetServer([NativeTypeName("LPCWSTR")] ushort* szServerName, [NativeTypeName("DWORD")] uint nPort)
        {
            return ((delegate* stdcall<IMFHttpDownloadSession*, ushort*, uint, int>)(lpVtbl[3]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), szServerName, nPort);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRequest([NativeTypeName("LPCWSTR")] ushort* szObjectName, [NativeTypeName("BOOL")] int fBypassProxyCache, [NativeTypeName("BOOL")] int fSecure, [NativeTypeName("LPCWSTR")] ushort* szVerb, [NativeTypeName("LPCWSTR")] ushort* szReferrer, [NativeTypeName("IMFHttpDownloadRequest **")] IMFHttpDownloadRequest** ppRequest)
        {
            return ((delegate* stdcall<IMFHttpDownloadSession*, ushort*, int, int, ushort*, ushort*, IMFHttpDownloadRequest**, int>)(lpVtbl[4]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), szObjectName, fBypassProxyCache, fSecure, szVerb, szReferrer, ppRequest);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* stdcall<IMFHttpDownloadSession*, int>)(lpVtbl[5]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
        }
    }
}
