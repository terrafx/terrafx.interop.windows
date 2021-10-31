// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("196BF9A5-B346-4EF0-AA1E-5DCDB76768B1")]
    [NativeTypeName("struct IPreviewHandlerVisuals : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPreviewHandlerVisuals
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPreviewHandlerVisuals*, Guid*, void**, int>)(lpVtbl[0]))((IPreviewHandlerVisuals*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPreviewHandlerVisuals*, uint>)(lpVtbl[1]))((IPreviewHandlerVisuals*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPreviewHandlerVisuals*, uint>)(lpVtbl[2]))((IPreviewHandlerVisuals*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetBackgroundColor([NativeTypeName("COLORREF")] uint color)
        {
            return ((delegate* unmanaged<IPreviewHandlerVisuals*, uint, int>)(lpVtbl[3]))((IPreviewHandlerVisuals*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetFont([NativeTypeName("const LOGFONTW *")] LOGFONTW* plf)
        {
            return ((delegate* unmanaged<IPreviewHandlerVisuals*, LOGFONTW*, int>)(lpVtbl[4]))((IPreviewHandlerVisuals*)Unsafe.AsPointer(ref this), plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetTextColor([NativeTypeName("COLORREF")] uint color)
        {
            return ((delegate* unmanaged<IPreviewHandlerVisuals*, uint, int>)(lpVtbl[5]))((IPreviewHandlerVisuals*)Unsafe.AsPointer(ref this), color);
        }
    }
}
