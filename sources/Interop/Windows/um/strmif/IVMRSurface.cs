// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9849BBE-9EC8-4263-B764-62730F0D15D0")]
    public unsafe partial struct IVMRSurface
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVMRSurface*, Guid*, void**, int>)(lpVtbl[0]))((IVMRSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVMRSurface*, uint>)(lpVtbl[1]))((IVMRSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVMRSurface*, uint>)(lpVtbl[2]))((IVMRSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSurfaceLocked()
        {
            return ((delegate* stdcall<IVMRSurface*, int>)(lpVtbl[3]))((IVMRSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockSurface([NativeTypeName("BYTE **")] byte** lpSurface)
        {
            return ((delegate* stdcall<IVMRSurface*, byte**, int>)(lpVtbl[4]))((IVMRSurface*)Unsafe.AsPointer(ref this), lpSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockSurface()
        {
            return ((delegate* stdcall<IVMRSurface*, int>)(lpVtbl[5]))((IVMRSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSurface([NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lplpSurface)
        {
            return ((delegate* stdcall<IVMRSurface*, IDirectDrawSurface7**, int>)(lpVtbl[6]))((IVMRSurface*)Unsafe.AsPointer(ref this), lplpSurface);
        }
    }
}
