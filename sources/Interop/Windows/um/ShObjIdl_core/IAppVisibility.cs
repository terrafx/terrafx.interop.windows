// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2246EA2D-CAEA-4444-A3C4-6DE827E44313")]
    [NativeTypeName("struct IAppVisibility : IUnknown")]
    public unsafe partial struct IAppVisibility
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppVisibility*, Guid*, void**, int>)(lpVtbl[0]))((IAppVisibility*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppVisibility*, uint>)(lpVtbl[1]))((IAppVisibility*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppVisibility*, uint>)(lpVtbl[2]))((IAppVisibility*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAppVisibilityOnMonitor([NativeTypeName("HMONITOR")] IntPtr hMonitor, MONITOR_APP_VISIBILITY* pMode)
        {
            return ((delegate* unmanaged<IAppVisibility*, IntPtr, MONITOR_APP_VISIBILITY*, int>)(lpVtbl[3]))((IAppVisibility*)Unsafe.AsPointer(ref this), hMonitor, pMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsLauncherVisible([NativeTypeName("BOOL *")] int* pfVisible)
        {
            return ((delegate* unmanaged<IAppVisibility*, int*, int>)(lpVtbl[4]))((IAppVisibility*)Unsafe.AsPointer(ref this), pfVisible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Advise(IAppVisibilityEvents* pCallback, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IAppVisibility*, IAppVisibilityEvents*, uint*, int>)(lpVtbl[5]))((IAppVisibility*)Unsafe.AsPointer(ref this), pCallback, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IAppVisibility*, uint, int>)(lpVtbl[6]))((IAppVisibility*)Unsafe.AsPointer(ref this), dwCookie);
        }
    }
}
