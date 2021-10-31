// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F69E-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDisplayPointer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDisplayPointer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDisplayPointer*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayPointer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDisplayPointer*, uint>)(lpVtbl[1]))((IDisplayPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDisplayPointer*, uint>)(lpVtbl[2]))((IDisplayPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT MoveToPoint(POINT ptPoint, COORD_SYSTEM eCoordSystem, IHTMLElement* pElementContext, [NativeTypeName("DWORD")] uint dwHitTestOptions, [NativeTypeName("DWORD *")] uint* pdwHitTestResults)
        {
            return ((delegate* unmanaged<IDisplayPointer*, POINT, COORD_SYSTEM, IHTMLElement*, uint, uint*, int>)(lpVtbl[3]))((IDisplayPointer*)Unsafe.AsPointer(ref this), ptPoint, eCoordSystem, pElementContext, dwHitTestOptions, pdwHitTestResults);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT MoveUnit(DISPLAY_MOVEUNIT eMoveUnit, [NativeTypeName("LONG")] int lXPos)
        {
            return ((delegate* unmanaged<IDisplayPointer*, DISPLAY_MOVEUNIT, int, int>)(lpVtbl[4]))((IDisplayPointer*)Unsafe.AsPointer(ref this), eMoveUnit, lXPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT PositionMarkupPointer(IMarkupPointer* pMarkupPointer)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IMarkupPointer*, int>)(lpVtbl[5]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pMarkupPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT MoveToPointer(IDisplayPointer* pDispPointer)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, int>)(lpVtbl[6]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pDispPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetPointerGravity(POINTER_GRAVITY eGravity)
        {
            return ((delegate* unmanaged<IDisplayPointer*, POINTER_GRAVITY, int>)(lpVtbl[7]))((IDisplayPointer*)Unsafe.AsPointer(ref this), eGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetPointerGravity(POINTER_GRAVITY* peGravity)
        {
            return ((delegate* unmanaged<IDisplayPointer*, POINTER_GRAVITY*, int>)(lpVtbl[8]))((IDisplayPointer*)Unsafe.AsPointer(ref this), peGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetDisplayGravity(DISPLAY_GRAVITY eGravity)
        {
            return ((delegate* unmanaged<IDisplayPointer*, DISPLAY_GRAVITY, int>)(lpVtbl[9]))((IDisplayPointer*)Unsafe.AsPointer(ref this), eGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetDisplayGravity(DISPLAY_GRAVITY* peGravity)
        {
            return ((delegate* unmanaged<IDisplayPointer*, DISPLAY_GRAVITY*, int>)(lpVtbl[10]))((IDisplayPointer*)Unsafe.AsPointer(ref this), peGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT IsPositioned(BOOL* pfPositioned)
        {
            return ((delegate* unmanaged<IDisplayPointer*, BOOL*, int>)(lpVtbl[11]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pfPositioned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Unposition()
        {
            return ((delegate* unmanaged<IDisplayPointer*, int>)(lpVtbl[12]))((IDisplayPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT IsEqualTo(IDisplayPointer* pDispPointer, BOOL* pfIsEqual)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, BOOL*, int>)(lpVtbl[13]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pDispPointer, pfIsEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT IsLeftOf(IDisplayPointer* pDispPointer, BOOL* pfIsLeftOf)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, BOOL*, int>)(lpVtbl[14]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pDispPointer, pfIsLeftOf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT IsRightOf(IDisplayPointer* pDispPointer, BOOL* pfIsRightOf)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, BOOL*, int>)(lpVtbl[15]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pDispPointer, pfIsRightOf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT IsAtBOL(BOOL* pfBOL)
        {
            return ((delegate* unmanaged<IDisplayPointer*, BOOL*, int>)(lpVtbl[16]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pfBOL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT MoveToMarkupPointer(IMarkupPointer* pPointer, IDisplayPointer* pDispLineContext)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IMarkupPointer*, IDisplayPointer*, int>)(lpVtbl[17]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pPointer, pDispLineContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT ScrollIntoView()
        {
            return ((delegate* unmanaged<IDisplayPointer*, int>)(lpVtbl[18]))((IDisplayPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetLineInfo(ILineInfo** ppLineInfo)
        {
            return ((delegate* unmanaged<IDisplayPointer*, ILineInfo**, int>)(lpVtbl[19]))((IDisplayPointer*)Unsafe.AsPointer(ref this), ppLineInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetFlowElement(IHTMLElement** ppLayoutElement)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IHTMLElement**, int>)(lpVtbl[20]))((IDisplayPointer*)Unsafe.AsPointer(ref this), ppLayoutElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT QueryBreaks([NativeTypeName("DWORD *")] uint* pdwBreaks)
        {
            return ((delegate* unmanaged<IDisplayPointer*, uint*, int>)(lpVtbl[21]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pdwBreaks);
        }
    }
}
