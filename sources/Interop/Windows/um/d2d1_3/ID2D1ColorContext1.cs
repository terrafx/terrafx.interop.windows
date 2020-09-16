// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1AB42875-C57F-4BE9-BD85-9CD78D6F55EE")]
    [NativeTypeName("struct ID2D1ColorContext1 : ID2D1ColorContext")]
    public unsafe partial struct ID2D1ColorContext1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1ColorContext1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1ColorContext1*, uint>)(lpVtbl[1]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1ColorContext1*, uint>)(lpVtbl[2]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1ColorContext1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_COLOR_SPACE GetColorSpace()
        {
            return ((delegate* unmanaged<ID2D1ColorContext1*, D2D1_COLOR_SPACE>)(lpVtbl[4]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetProfileSize()
        {
            return ((delegate* unmanaged<ID2D1ColorContext1*, uint>)(lpVtbl[5]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProfile([NativeTypeName("BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize)
        {
            return ((delegate* unmanaged<ID2D1ColorContext1*, byte*, uint, int>)(lpVtbl[6]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), profile, profileSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D2D1_COLOR_CONTEXT_TYPE GetColorContextType()
        {
            return ((delegate* unmanaged<ID2D1ColorContext1*, D2D1_COLOR_CONTEXT_TYPE>)(lpVtbl[7]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace()
        {
            return ((delegate* unmanaged<ID2D1ColorContext1*, DXGI_COLOR_SPACE_TYPE>)(lpVtbl[8]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSimpleColorProfile([NativeTypeName("D2D1_SIMPLE_COLOR_PROFILE *")] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile)
        {
            return ((delegate* unmanaged<ID2D1ColorContext1*, D2D1_SIMPLE_COLOR_PROFILE*, int>)(lpVtbl[9]))((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), simpleProfile);
        }
    }
}
