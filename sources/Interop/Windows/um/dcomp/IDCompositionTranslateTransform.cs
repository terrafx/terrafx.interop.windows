// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("06791122-C6F0-417D-8323-269E987F5954")]
    [NativeTypeName("struct IDCompositionTranslateTransform : IDCompositionTransform")]
    public unsafe partial struct IDCompositionTranslateTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, uint>)(lpVtbl[1]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, uint>)(lpVtbl[2]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, float, int>)(lpVtbl[4]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), offsetX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, float, int>)(lpVtbl[6]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionTranslateTransform*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
