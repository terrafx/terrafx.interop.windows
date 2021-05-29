// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF0C7CEC-CDEB-4D4A-B91C-721BF22F4E6C")]
    [NativeTypeName("struct IDCompositionInkTrailDevice : IUnknown")]
    public unsafe partial struct IDCompositionInkTrailDevice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, uint>)(lpVtbl[1]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, uint>)(lpVtbl[2]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail** inkTrail)
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[3]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), inkTrail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDelegatedInkTrailForSwapChain(IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail)
        {
            return ((delegate* unmanaged<IDCompositionInkTrailDevice*, IUnknown*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[4]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), swapChain, inkTrail);
        }
    }
}
