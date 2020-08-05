// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("153ACC21-D83B-11D1-82BF-00A0C9696C8F")]
    [NativeTypeName("struct IDDrawExclModeVideo : IUnknown")]
    public unsafe partial struct IDDrawExclModeVideo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, Guid*, void**, int>)(lpVtbl[0]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, uint>)(lpVtbl[1]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, uint>)(lpVtbl[2]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDDrawObject([NativeTypeName("IDirectDraw *")] IDirectDraw* pDDrawObject)
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, IDirectDraw*, int>)(lpVtbl[3]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pDDrawObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDDrawObject([NativeTypeName("IDirectDraw **")] IDirectDraw** ppDDrawObject, [NativeTypeName("BOOL *")] int* pbUsingExternal)
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, IDirectDraw**, int*, int>)(lpVtbl[4]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), ppDDrawObject, pbUsingExternal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDDrawSurface([NativeTypeName("IDirectDrawSurface *")] IDirectDrawSurface* pDDrawSurface)
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, IDirectDrawSurface*, int>)(lpVtbl[5]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pDDrawSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDDrawSurface([NativeTypeName("IDirectDrawSurface **")] IDirectDrawSurface** ppDDrawSurface, [NativeTypeName("BOOL *")] int* pbUsingExternal)
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, IDirectDrawSurface**, int*, int>)(lpVtbl[6]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), ppDDrawSurface, pbUsingExternal);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDrawParameters([NativeTypeName("const RECT *")] RECT* prcSource, [NativeTypeName("const RECT *")] RECT* prcTarget)
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, RECT*, RECT*, int>)(lpVtbl[7]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), prcSource, prcTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoProps([NativeTypeName("DWORD *")] uint* pdwVideoWidth, [NativeTypeName("DWORD *")] uint* pdwVideoHeight, [NativeTypeName("DWORD *")] uint* pdwPictAspectRatioX, [NativeTypeName("DWORD *")] uint* pdwPictAspectRatioY)
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, uint*, uint*, uint*, uint*, int>)(lpVtbl[8]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pdwVideoWidth, pdwVideoHeight, pdwPictAspectRatioX, pdwPictAspectRatioY);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCallbackInterface([NativeTypeName("IDDrawExclModeVideoCallback *")] IDDrawExclModeVideoCallback* pCallback, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IDDrawExclModeVideo*, IDDrawExclModeVideoCallback*, uint, int>)(lpVtbl[9]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pCallback, dwFlags);
        }
    }
}
