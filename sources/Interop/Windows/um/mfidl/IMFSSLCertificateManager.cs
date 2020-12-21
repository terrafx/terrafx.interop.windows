// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("61F7D887-1230-4A8B-AEBA-8AD434D1A64D")]
    [NativeTypeName("struct IMFSSLCertificateManager : IUnknown")]
    public unsafe partial struct IMFSSLCertificateManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSSLCertificateManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFSSLCertificateManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSSLCertificateManager*, uint>)(lpVtbl[1]))((IMFSSLCertificateManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSSLCertificateManager*, uint>)(lpVtbl[2]))((IMFSSLCertificateManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClientCertificate([NativeTypeName("LPCWSTR")] ushort* pszURL, [NativeTypeName("BYTE **")] byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData)
        {
            return ((delegate* unmanaged<IMFSSLCertificateManager*, ushort*, byte**, uint*, int>)(lpVtbl[3]))((IMFSSLCertificateManager*)Unsafe.AsPointer(ref this), pszURL, ppbData, pcbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginGetClientCertificate([NativeTypeName("LPCWSTR")] ushort* pszURL, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState)
        {
            return ((delegate* unmanaged<IMFSSLCertificateManager*, ushort*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFSSLCertificateManager*)Unsafe.AsPointer(ref this), pszURL, pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndGetClientCertificate([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("BYTE **")] byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData)
        {
            return ((delegate* unmanaged<IMFSSLCertificateManager*, IMFAsyncResult*, byte**, uint*, int>)(lpVtbl[5]))((IMFSSLCertificateManager*)Unsafe.AsPointer(ref this), pResult, ppbData, pcbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificatePolicy([NativeTypeName("LPCWSTR")] ushort* pszURL, [NativeTypeName("BOOL *")] int* pfOverrideAutomaticCheck, [NativeTypeName("BOOL *")] int* pfClientCertificateAvailable)
        {
            return ((delegate* unmanaged<IMFSSLCertificateManager*, ushort*, int*, int*, int>)(lpVtbl[6]))((IMFSSLCertificateManager*)Unsafe.AsPointer(ref this), pszURL, pfOverrideAutomaticCheck, pfClientCertificateAvailable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnServerCertificate([NativeTypeName("LPCWSTR")] ushort* pszURL, [NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BOOL *")] int* pfIsGood)
        {
            return ((delegate* unmanaged<IMFSSLCertificateManager*, ushort*, byte*, uint, int*, int>)(lpVtbl[7]))((IMFSSLCertificateManager*)Unsafe.AsPointer(ref this), pszURL, pbData, cbData, pfIsGood);
        }
    }
}
