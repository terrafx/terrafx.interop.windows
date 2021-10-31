// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106E1-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IViewObjectPresentSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IViewObjectPresentSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IViewObjectPresentSite*, Guid*, void**, int>)(lpVtbl[0]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IViewObjectPresentSite*, uint>)(lpVtbl[1]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IViewObjectPresentSite*, uint>)(lpVtbl[2]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateSurfacePresenter(IUnknown* pDevice, uint width, uint height, uint backBufferCount, DXGI_FORMAT format, VIEW_OBJECT_ALPHA_MODE mode, ISurfacePresenter** ppQueue)
        {
            return ((delegate* unmanaged<IViewObjectPresentSite*, IUnknown*, uint, uint, uint, DXGI_FORMAT, VIEW_OBJECT_ALPHA_MODE, ISurfacePresenter**, int>)(lpVtbl[3]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this), pDevice, width, height, backBufferCount, format, mode, ppQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT IsHardwareComposition(BOOL* pIsHardwareComposition)
        {
            return ((delegate* unmanaged<IViewObjectPresentSite*, BOOL*, int>)(lpVtbl[4]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this), pIsHardwareComposition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetCompositionMode(VIEW_OBJECT_COMPOSITION_MODE mode)
        {
            return ((delegate* unmanaged<IViewObjectPresentSite*, VIEW_OBJECT_COMPOSITION_MODE, int>)(lpVtbl[5]))((IViewObjectPresentSite*)Unsafe.AsPointer(ref this), mode);
        }
    }
}
