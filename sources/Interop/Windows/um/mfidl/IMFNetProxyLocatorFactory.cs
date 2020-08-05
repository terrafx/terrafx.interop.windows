// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFNetProxyLocatorFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetProxyLocatorFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFNetProxyLocatorFactory*, uint>)(lpVtbl[1]))((IMFNetProxyLocatorFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFNetProxyLocatorFactory*, uint>)(lpVtbl[2]))((IMFNetProxyLocatorFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateProxyLocator([NativeTypeName("LPCWSTR")] ushort* pszProtocol, [NativeTypeName("IMFNetProxyLocator **")] IMFNetProxyLocator** ppProxyLocator)
        {
            return ((delegate* stdcall<IMFNetProxyLocatorFactory*, ushort*, IMFNetProxyLocator**, int>)(lpVtbl[3]))((IMFNetProxyLocatorFactory*)Unsafe.AsPointer(ref this), pszProtocol, ppProxyLocator);
        }
    }
}
