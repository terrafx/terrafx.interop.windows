// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Unknwnbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000E0000-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIUnknown : IUnknown")]
    public unsafe partial struct AsyncIUnknown
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIUnknown*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIUnknown*, uint>)(lpVtbl[1]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIUnknown*, uint>)(lpVtbl[2]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_QueryInterface([NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIUnknown*, Guid*, int>)(lpVtbl[3]))((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_QueryInterface([NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIUnknown*, void**, int>)(lpVtbl[4]))((AsyncIUnknown*)Unsafe.AsPointer(ref this), ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIUnknown*, int>)(lpVtbl[5]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Finish_AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIUnknown*, uint>)(lpVtbl[6]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_Release()
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIUnknown*, int>)(lpVtbl[7]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Finish_Release()
        {
            return ((delegate* unmanaged[Stdcall]<AsyncIUnknown*, uint>)(lpVtbl[8]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }
    }
}
