// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEC87AAF-35F9-447A-ADB7-20234491401A")]
    [NativeTypeName("struct IPreviewHandlerFrame : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPreviewHandlerFrame
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPreviewHandlerFrame*, Guid*, void**, int>)(lpVtbl[0]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPreviewHandlerFrame*, uint>)(lpVtbl[1]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPreviewHandlerFrame*, uint>)(lpVtbl[2]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindowContext(PREVIEWHANDLERFRAMEINFO* pinfo)
        {
            return ((delegate* unmanaged<IPreviewHandlerFrame*, PREVIEWHANDLERFRAMEINFO*, int>)(lpVtbl[3]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this), pinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT TranslateAcceleratorW(MSG* pmsg)
        {
            return ((delegate* unmanaged<IPreviewHandlerFrame*, MSG*, int>)(lpVtbl[4]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this), pmsg);
        }
    }
}
