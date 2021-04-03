// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3D8CEC0-7E5A-11CF-BBC5-00805F6CEF20")]
    [NativeTypeName("struct IAMovieSetup : IUnknown")]
    public unsafe partial struct IAMovieSetup
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMovieSetup*, Guid*, void**, int>)(lpVtbl[0]))((IAMovieSetup*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMovieSetup*, uint>)(lpVtbl[1]))((IAMovieSetup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMovieSetup*, uint>)(lpVtbl[2]))((IAMovieSetup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Register()
        {
            return ((delegate* unmanaged<IAMovieSetup*, int>)(lpVtbl[3]))((IAMovieSetup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unregister()
        {
            return ((delegate* unmanaged<IAMovieSetup*, int>)(lpVtbl[4]))((IAMovieSetup*)Unsafe.AsPointer(ref this));
        }
    }
}
