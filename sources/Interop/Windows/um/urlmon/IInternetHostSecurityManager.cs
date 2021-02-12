// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AF280B6-CB3F-11D0-891E-00C04FB6BFC4")]
    [NativeTypeName("struct IInternetHostSecurityManager : IUnknown")]
    public unsafe partial struct IInternetHostSecurityManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetHostSecurityManager*, Guid*, void**, int>)(lpVtbl[0]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetHostSecurityManager*, uint>)(lpVtbl[1]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetHostSecurityManager*, uint>)(lpVtbl[2]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSecurityId([NativeTypeName("BYTE *")] byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* unmanaged<IInternetHostSecurityManager*, byte*, uint*, nuint, int>)(lpVtbl[3]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), pbSecurityId, pcbSecurityId, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessUrlAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("BYTE *")] byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IInternetHostSecurityManager*, uint, byte*, uint, byte*, uint, uint, uint, int>)(lpVtbl[4]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryCustomPolicy([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("BYTE **")] byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, [NativeTypeName("BYTE *")] byte* pContext, [NativeTypeName("DWORD")] uint cbContext, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IInternetHostSecurityManager*, Guid*, byte**, uint*, byte*, uint, uint, int>)(lpVtbl[5]))((IInternetHostSecurityManager*)Unsafe.AsPointer(ref this), guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
        }
    }
}
