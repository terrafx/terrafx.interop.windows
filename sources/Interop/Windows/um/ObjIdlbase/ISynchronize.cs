// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000030-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ISynchronize : IUnknown")]
    public unsafe partial struct ISynchronize
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISynchronize*, Guid*, void**, int>)(lpVtbl[0]))((ISynchronize*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISynchronize*, uint>)(lpVtbl[1]))((ISynchronize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISynchronize*, uint>)(lpVtbl[2]))((ISynchronize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Wait([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<ISynchronize*, uint, uint, int>)(lpVtbl[3]))((ISynchronize*)Unsafe.AsPointer(ref this), dwFlags, dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Signal()
        {
            return ((delegate* unmanaged<ISynchronize*, int>)(lpVtbl[4]))((ISynchronize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<ISynchronize*, int>)(lpVtbl[5]))((ISynchronize*)Unsafe.AsPointer(ref this));
        }
    }
}
