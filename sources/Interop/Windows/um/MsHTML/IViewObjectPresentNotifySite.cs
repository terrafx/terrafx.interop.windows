// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305107FA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IViewObjectPresentNotifySite : IViewObjectPresentSite")]
    [NativeInheritance("IViewObjectPresentSite")]
    public unsafe partial struct IViewObjectPresentNotifySite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IViewObjectPresentNotifySite*, Guid*, void**, int>)(lpVtbl[0]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IViewObjectPresentNotifySite*, uint>)(lpVtbl[1]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IViewObjectPresentNotifySite*, uint>)(lpVtbl[2]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSurfacePresenter(IUnknown* pDevice, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, [NativeTypeName("UINT")] uint backBufferCount, DXGI_FORMAT format, VIEW_OBJECT_ALPHA_MODE mode, ISurfacePresenter** ppQueue)
        {
            return ((delegate* unmanaged<IViewObjectPresentNotifySite*, IUnknown*, uint, uint, uint, DXGI_FORMAT, VIEW_OBJECT_ALPHA_MODE, ISurfacePresenter**, int>)(lpVtbl[3]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this), pDevice, width, height, backBufferCount, format, mode, ppQueue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int IsHardwareComposition(BOOL* pIsHardwareComposition)
        {
            return ((delegate* unmanaged<IViewObjectPresentNotifySite*, BOOL*, int>)(lpVtbl[4]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this), pIsHardwareComposition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositionMode(VIEW_OBJECT_COMPOSITION_MODE mode)
        {
            return ((delegate* unmanaged<IViewObjectPresentNotifySite*, VIEW_OBJECT_COMPOSITION_MODE, int>)(lpVtbl[5]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int RequestFrame()
        {
            return ((delegate* unmanaged<IViewObjectPresentNotifySite*, int>)(lpVtbl[6]))((IViewObjectPresentNotifySite*)Unsafe.AsPointer(ref this));
        }
    }
}
