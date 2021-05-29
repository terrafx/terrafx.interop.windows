// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9849BBE-9EC8-4263-B764-62730F0D15D0")]
    [NativeTypeName("struct IVMRSurface : IUnknown")]
    public unsafe partial struct IVMRSurface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVMRSurface*, Guid*, void**, int>)(lpVtbl[0]))((IVMRSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVMRSurface*, uint>)(lpVtbl[1]))((IVMRSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVMRSurface*, uint>)(lpVtbl[2]))((IVMRSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsSurfaceLocked()
        {
            return ((delegate* unmanaged<IVMRSurface*, int>)(lpVtbl[3]))((IVMRSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockSurface([NativeTypeName("BYTE **")] byte** lpSurface)
        {
            return ((delegate* unmanaged<IVMRSurface*, byte**, int>)(lpVtbl[4]))((IVMRSurface*)Unsafe.AsPointer(ref this), lpSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockSurface()
        {
            return ((delegate* unmanaged<IVMRSurface*, int>)(lpVtbl[5]))((IVMRSurface*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurface([NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lplpSurface)
        {
            return ((delegate* unmanaged<IVMRSurface*, IDirectDrawSurface7**, int>)(lpVtbl[6]))((IVMRSurface*)Unsafe.AsPointer(ref this), lplpSurface);
        }
    }
}
