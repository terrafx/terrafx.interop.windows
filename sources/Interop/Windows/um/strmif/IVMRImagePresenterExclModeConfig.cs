// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E6F7CE40-4673-44F1-8F77-5499D68CB4EA")]
    [NativeTypeName("struct IVMRImagePresenterExclModeConfig : IVMRImagePresenterConfig")]
    public unsafe partial struct IVMRImagePresenterExclModeConfig
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, Guid*, void**, int>)(lpVtbl[0]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, uint>)(lpVtbl[1]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, uint>)(lpVtbl[2]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags)
        {
            return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, uint, int>)(lpVtbl[3]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderingPrefs([NativeTypeName("DWORD *")] uint* dwRenderFlags)
        {
            return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, uint*, int>)(lpVtbl[4]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetXlcModeDDObjAndPrimarySurface([NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7* lpDDObj, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* lpPrimarySurf)
        {
            return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, IDirectDraw7*, IDirectDrawSurface7*, int>)(lpVtbl[5]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), lpDDObj, lpPrimarySurf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetXlcModeDDObjAndPrimarySurface([NativeTypeName("LPDIRECTDRAW7 *")] IDirectDraw7** lpDDObj, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lpPrimarySurf)
        {
            return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, IDirectDraw7**, IDirectDrawSurface7**, int>)(lpVtbl[6]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), lpDDObj, lpPrimarySurf);
        }
    }
}
