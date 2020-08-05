// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E9CD0383-A268-4BB4-82DE-658D53574D41")]
    [NativeTypeName("struct IMFNetProxyLocator : IUnknown")]
    public unsafe partial struct IMFNetProxyLocator
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFNetProxyLocator*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetProxyLocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFNetProxyLocator*, uint>)(lpVtbl[1]))((IMFNetProxyLocator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFNetProxyLocator*, uint>)(lpVtbl[2]))((IMFNetProxyLocator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFirstProxy([NativeTypeName("LPCWSTR")] ushort* pszHost, [NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("BOOL")] int fReserved)
        {
            return ((delegate* stdcall<IMFNetProxyLocator*, ushort*, ushort*, int, int>)(lpVtbl[3]))((IMFNetProxyLocator*)Unsafe.AsPointer(ref this), pszHost, pszUrl, fReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindNextProxy()
        {
            return ((delegate* stdcall<IMFNetProxyLocator*, int>)(lpVtbl[4]))((IMFNetProxyLocator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterProxyResult([NativeTypeName("HRESULT")] int hrOp)
        {
            return ((delegate* stdcall<IMFNetProxyLocator*, int, int>)(lpVtbl[5]))((IMFNetProxyLocator*)Unsafe.AsPointer(ref this), hrOp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentProxy([NativeTypeName("LPWSTR")] ushort* pszStr, [NativeTypeName("DWORD *")] uint* pcchStr)
        {
            return ((delegate* stdcall<IMFNetProxyLocator*, ushort*, uint*, int>)(lpVtbl[6]))((IMFNetProxyLocator*)Unsafe.AsPointer(ref this), pszStr, pcchStr);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IMFNetProxyLocator **")] IMFNetProxyLocator** ppProxyLocator)
        {
            return ((delegate* stdcall<IMFNetProxyLocator*, IMFNetProxyLocator**, int>)(lpVtbl[7]))((IMFNetProxyLocator*)Unsafe.AsPointer(ref this), ppProxyLocator);
        }
    }
}
