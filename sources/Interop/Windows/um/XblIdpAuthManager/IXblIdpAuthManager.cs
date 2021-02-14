// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB5DDB08-8BBF-449B-AC21-B02DDEB3B136")]
    [NativeTypeName("struct IXblIdpAuthManager : IUnknown")]
    public unsafe partial struct IXblIdpAuthManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IXblIdpAuthManager*, Guid*, void**, int>)(lpVtbl[0]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXblIdpAuthManager*, uint>)(lpVtbl[1]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXblIdpAuthManager*, uint>)(lpVtbl[2]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGamerAccount([NativeTypeName("LPCWSTR")] ushort* msaAccountId, [NativeTypeName("LPCWSTR")] ushort* xuid)
        {
            return ((delegate* unmanaged<IXblIdpAuthManager*, ushort*, ushort*, int>)(lpVtbl[3]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), msaAccountId, xuid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGamerAccount([NativeTypeName("LPWSTR *")] ushort** msaAccountId, [NativeTypeName("LPWSTR *")] ushort** xuid)
        {
            return ((delegate* unmanaged<IXblIdpAuthManager*, ushort**, ushort**, int>)(lpVtbl[4]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), msaAccountId, xuid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAppViewInitialized([NativeTypeName("LPCWSTR")] ushort* appSid, [NativeTypeName("LPCWSTR")] ushort* msaAccountId)
        {
            return ((delegate* unmanaged<IXblIdpAuthManager*, ushort*, ushort*, int>)(lpVtbl[5]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), appSid, msaAccountId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnvironment([NativeTypeName("LPWSTR *")] ushort** environment)
        {
            return ((delegate* unmanaged<IXblIdpAuthManager*, ushort**, int>)(lpVtbl[6]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), environment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSandbox([NativeTypeName("LPWSTR *")] ushort** sandbox)
        {
            return ((delegate* unmanaged<IXblIdpAuthManager*, ushort**, int>)(lpVtbl[7]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), sandbox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTokenAndSignatureWithTokenResult([NativeTypeName("LPCWSTR")] ushort* msaAccountId, [NativeTypeName("LPCWSTR")] ushort* appSid, [NativeTypeName("LPCWSTR")] ushort* msaTarget, [NativeTypeName("LPCWSTR")] ushort* msaPolicy, [NativeTypeName("LPCWSTR")] ushort* httpMethod, [NativeTypeName("LPCWSTR")] ushort* uri, [NativeTypeName("LPCWSTR")] ushort* headers, [NativeTypeName("BYTE *")] byte* body, [NativeTypeName("DWORD")] uint bodySize, [NativeTypeName("BOOL")] int forceRefresh, [NativeTypeName("IXblIdpAuthTokenResult **")] IXblIdpAuthTokenResult** result)
        {
            return ((delegate* unmanaged<IXblIdpAuthManager*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, byte*, uint, int, IXblIdpAuthTokenResult**, int>)(lpVtbl[8]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), msaAccountId, appSid, msaTarget, msaPolicy, httpMethod, uri, headers, body, bodySize, forceRefresh, result);
        }
    }
}
