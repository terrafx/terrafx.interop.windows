// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E9CD0384-A268-4BB4-82DE-658D53574D41")]
    [NativeTypeName("struct IMFNetProxyLocatorFactory : IUnknown")]
    public unsafe partial struct IMFNetProxyLocatorFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFNetProxyLocatorFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetProxyLocatorFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFNetProxyLocatorFactory*, uint>)(lpVtbl[1]))((IMFNetProxyLocatorFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFNetProxyLocatorFactory*, uint>)(lpVtbl[2]))((IMFNetProxyLocatorFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateProxyLocator([NativeTypeName("LPCWSTR")] ushort* pszProtocol, IMFNetProxyLocator** ppProxyLocator)
        {
            return ((delegate* unmanaged<IMFNetProxyLocatorFactory*, ushort*, IMFNetProxyLocator**, int>)(lpVtbl[3]))((IMFNetProxyLocatorFactory*)Unsafe.AsPointer(ref this), pszProtocol, ppProxyLocator);
        }
    }
}
