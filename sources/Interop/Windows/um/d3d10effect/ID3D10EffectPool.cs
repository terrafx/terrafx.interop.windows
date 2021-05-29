// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct ID3D10EffectPool : IUnknown")]
    public unsafe partial struct ID3D10EffectPool
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10EffectPool*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10EffectPool*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10EffectPool*, uint>)(lpVtbl[1]))((ID3D10EffectPool*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10EffectPool*, uint>)(lpVtbl[2]))((ID3D10EffectPool*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ID3D10Effect* AsEffect()
        {
            return ((delegate* unmanaged<ID3D10EffectPool*, ID3D10Effect*>)(lpVtbl[3]))((ID3D10EffectPool*)Unsafe.AsPointer(ref this));
        }
    }
}
