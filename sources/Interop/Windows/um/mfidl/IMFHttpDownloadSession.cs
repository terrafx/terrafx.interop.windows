// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71FA9A2C-53CE-4662-A132-1A7E8CBF62DB")]
    [NativeTypeName("struct IMFHttpDownloadSession : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFHttpDownloadSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, uint>)(lpVtbl[1]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, uint>)(lpVtbl[2]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetServer([NativeTypeName("LPCWSTR")] ushort* szServerName, [NativeTypeName("DWORD")] uint nPort)
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, ushort*, uint, int>)(lpVtbl[3]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), szServerName, nPort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRequest([NativeTypeName("LPCWSTR")] ushort* szObjectName, BOOL fBypassProxyCache, BOOL fSecure, [NativeTypeName("LPCWSTR")] ushort* szVerb, [NativeTypeName("LPCWSTR")] ushort* szReferrer, IMFHttpDownloadRequest** ppRequest)
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, ushort*, BOOL, BOOL, ushort*, ushort*, IMFHttpDownloadRequest**, int>)(lpVtbl[4]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), szObjectName, fBypassProxyCache, fSecure, szVerb, szReferrer, ppRequest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, int>)(lpVtbl[5]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
        }
    }
}
