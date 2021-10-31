// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F4AA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementBehaviorRender : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IElementBehaviorRender
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementBehaviorRender*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementBehaviorRender*, uint>)(lpVtbl[1]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementBehaviorRender*, uint>)(lpVtbl[2]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Draw([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("LONG")] int lLayer, RECT* pRect, IUnknown* pReserved)
        {
            return ((delegate* unmanaged<IElementBehaviorRender*, IntPtr, int, RECT*, IUnknown*, int>)(lpVtbl[3]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this), hdc, lLayer, pRect, pReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRenderInfo([NativeTypeName("LONG *")] int* plRenderInfo)
        {
            return ((delegate* unmanaged<IElementBehaviorRender*, int*, int>)(lpVtbl[4]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this), plRenderInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT HitTestPoint(POINT* pPoint, IUnknown* pReserved, BOOL* pbHit)
        {
            return ((delegate* unmanaged<IElementBehaviorRender*, POINT*, IUnknown*, BOOL*, int>)(lpVtbl[5]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this), pPoint, pReserved, pbHit);
        }
    }
}
