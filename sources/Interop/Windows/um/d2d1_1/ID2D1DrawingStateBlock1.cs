// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("689F1F85-C72E-4E33-8F19-85754EFD5ACE")]
    [NativeTypeName("struct ID2D1DrawingStateBlock1 : ID2D1DrawingStateBlock")]
    [NativeInheritance("ID2D1DrawingStateBlock")]
    public unsafe partial struct ID2D1DrawingStateBlock1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1DrawingStateBlock1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1DrawingStateBlock1*, uint>)(lpVtbl[1]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1DrawingStateBlock1*, uint>)(lpVtbl[2]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[4]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[5]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, IDWriteRenderingParams*, void>)(lpVtbl[6]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, IDWriteRenderingParams**, void>)(lpVtbl[7]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION1*, void>)(lpVtbl[8]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION1*, void>)(lpVtbl[9]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (D2D1_DRAWING_STATE_DESCRIPTION *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION*, void> GetDescription;

            [NativeTypeName("void (const D2D1_DRAWING_STATE_DESCRIPTION *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION*, void> SetDescription;

            [NativeTypeName("void (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, IDWriteRenderingParams*, void> SetTextRenderingParams;

            [NativeTypeName("void (IDWriteRenderingParams **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, IDWriteRenderingParams**, void> GetTextRenderingParams;

            [NativeTypeName("void (D2D1_DRAWING_STATE_DESCRIPTION1 *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION1*, void> GetDescription1;

            [NativeTypeName("void (const D2D1_DRAWING_STATE_DESCRIPTION1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION1*, void> SetDescription1;
        }
    }
}
