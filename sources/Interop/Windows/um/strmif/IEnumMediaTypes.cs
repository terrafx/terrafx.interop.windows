// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("89C31040-846B-11CE-97D3-00AA0055595A")]
    [NativeTypeName("struct IEnumMediaTypes : IUnknown")]
    public unsafe partial struct IEnumMediaTypes
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumMediaTypes*, Guid*, void**, int>)(lpVtbl[0]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumMediaTypes*, uint>)(lpVtbl[1]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumMediaTypes*, uint>)(lpVtbl[2]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cMediaTypes, [NativeTypeName("AM_MEDIA_TYPE **")] AM_MEDIA_TYPE** ppMediaTypes, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumMediaTypes*, uint, AM_MEDIA_TYPE**, uint*, int>)(lpVtbl[3]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this), cMediaTypes, ppMediaTypes, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cMediaTypes)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumMediaTypes*, uint, int>)(lpVtbl[4]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this), cMediaTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged[Stdcall]<IEnumMediaTypes*, int>)(lpVtbl[5]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumMediaTypes **")] IEnumMediaTypes** ppEnum)
        {
            return ((delegate* unmanaged[Stdcall]<IEnumMediaTypes*, IEnumMediaTypes**, int>)(lpVtbl[6]))((IEnumMediaTypes*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
