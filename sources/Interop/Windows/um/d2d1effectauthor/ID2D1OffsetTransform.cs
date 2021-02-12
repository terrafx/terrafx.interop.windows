// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3FE6ADEA-7643-4F53-BD14-A0CE63F24042")]
    [NativeTypeName("struct ID2D1OffsetTransform : ID2D1TransformNode")]
    public unsafe partial struct ID2D1OffsetTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1OffsetTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1OffsetTransform*, uint>)(lpVtbl[1]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1OffsetTransform*, uint>)(lpVtbl[2]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            return ((delegate* unmanaged<ID2D1OffsetTransform*, uint>)(lpVtbl[3]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetOffset([NativeTypeName("D2D1_POINT_2L")] POINT offset)
        {
            ((delegate* unmanaged<ID2D1OffsetTransform*, POINT, void>)(lpVtbl[4]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D2D1_POINT_2L")]
        public POINT GetOffset()
        {
            POINT result;
            return *((delegate* unmanaged<ID2D1OffsetTransform*, POINT*, POINT*>)(lpVtbl[5]))((ID2D1OffsetTransform*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
