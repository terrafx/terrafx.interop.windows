// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C9CDB0DD-F8C9-4E70-B7C2-301C80292C5E")]
    [NativeTypeName("struct ID2D1SvgAttribute : ID2D1Resource")]
    public unsafe partial struct ID2D1SvgAttribute
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1SvgAttribute*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1SvgAttribute*, uint>)(lpVtbl[1]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1SvgAttribute*, uint>)(lpVtbl[2]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1SvgAttribute*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetElement([NativeTypeName("ID2D1SvgElement **")] ID2D1SvgElement** element)
        {
            ((delegate* stdcall<ID2D1SvgAttribute*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** attribute)
        {
            return ((delegate* stdcall<ID2D1SvgAttribute*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), attribute);
        }
    }
}
