// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E57AA735-DCDB-4C72-9C61-0591F58889EE")]
    [NativeTypeName("struct IDCompositionSkewTransform : IDCompositionTransform")]
    public unsafe partial struct IDCompositionSkewTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, uint>)(lpVtbl[1]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, uint>)(lpVtbl[2]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAngleX(float angleX)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, float, int>)(lpVtbl[4]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAngleX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAngleY(float angleY)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, float, int>)(lpVtbl[6]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), angleY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAngleY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, float, int>)(lpVtbl[8]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, float, int>)(lpVtbl[10]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), centerY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionSkewTransform*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionSkewTransform*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
