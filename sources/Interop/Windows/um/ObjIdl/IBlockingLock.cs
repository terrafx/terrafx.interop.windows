// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30F3D47A-6447-11D1-8E3C-00C04FB9386D")]
    [NativeTypeName("struct IBlockingLock : IUnknown")]
    public unsafe partial struct IBlockingLock
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBlockingLock*, Guid*, void**, int>)(lpVtbl[0]))((IBlockingLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBlockingLock*, uint>)(lpVtbl[1]))((IBlockingLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBlockingLock*, uint>)(lpVtbl[2]))((IBlockingLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("DWORD")] uint dwTimeout)
        {
            return ((delegate* unmanaged<IBlockingLock*, uint, int>)(lpVtbl[3]))((IBlockingLock*)Unsafe.AsPointer(ref this), dwTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unlock()
        {
            return ((delegate* unmanaged<IBlockingLock*, int>)(lpVtbl[4]))((IBlockingLock*)Unsafe.AsPointer(ref this));
        }
    }
}
