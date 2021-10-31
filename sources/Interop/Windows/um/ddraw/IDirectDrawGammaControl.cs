// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDrawGammaControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDrawGammaControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDrawGammaControl*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDrawGammaControl*, uint>)(lpVtbl[1]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDrawGammaControl*, uint>)(lpVtbl[2]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetGammaRamp([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDGAMMARAMP")] DDGAMMARAMP* param1)
        {
            return ((delegate* unmanaged<IDirectDrawGammaControl*, uint, DDGAMMARAMP*, int>)(lpVtbl[3]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this), param0, param1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetGammaRamp([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDDGAMMARAMP")] DDGAMMARAMP* param1)
        {
            return ((delegate* unmanaged<IDirectDrawGammaControl*, uint, DDGAMMARAMP*, int>)(lpVtbl[4]))((IDirectDrawGammaControl*)Unsafe.AsPointer(ref this), param0, param1);
        }
    }
}
