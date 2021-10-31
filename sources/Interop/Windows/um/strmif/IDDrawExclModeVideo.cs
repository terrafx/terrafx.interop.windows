// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("153ACC21-D83B-11D1-82BF-00A0C9696C8F")]
    [NativeTypeName("struct IDDrawExclModeVideo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDDrawExclModeVideo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, Guid*, void**, int>)(lpVtbl[0]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, uint>)(lpVtbl[1]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, uint>)(lpVtbl[2]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetDDrawObject(IDirectDraw* pDDrawObject)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, IDirectDraw*, int>)(lpVtbl[3]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pDDrawObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetDDrawObject(IDirectDraw** ppDDrawObject, BOOL* pbUsingExternal)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, IDirectDraw**, BOOL*, int>)(lpVtbl[4]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), ppDDrawObject, pbUsingExternal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetDDrawSurface(IDirectDrawSurface* pDDrawSurface)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, IDirectDrawSurface*, int>)(lpVtbl[5]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pDDrawSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDDrawSurface(IDirectDrawSurface** ppDDrawSurface, BOOL* pbUsingExternal)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, IDirectDrawSurface**, BOOL*, int>)(lpVtbl[6]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), ppDDrawSurface, pbUsingExternal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetDrawParameters([NativeTypeName("const RECT *")] RECT* prcSource, [NativeTypeName("const RECT *")] RECT* prcTarget)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, RECT*, RECT*, int>)(lpVtbl[7]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), prcSource, prcTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoProps([NativeTypeName("DWORD *")] uint* pdwVideoWidth, [NativeTypeName("DWORD *")] uint* pdwVideoHeight, [NativeTypeName("DWORD *")] uint* pdwPictAspectRatioX, [NativeTypeName("DWORD *")] uint* pdwPictAspectRatioY)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, uint*, uint*, uint*, uint*, int>)(lpVtbl[8]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pdwVideoWidth, pdwVideoHeight, pdwPictAspectRatioX, pdwPictAspectRatioY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetCallbackInterface(IDDrawExclModeVideoCallback* pCallback, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IDDrawExclModeVideo*, IDDrawExclModeVideoCallback*, uint, int>)(lpVtbl[9]))((IDDrawExclModeVideo*)Unsafe.AsPointer(ref this), pCallback, dwFlags);
        }
    }
}
