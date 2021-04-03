// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4CE7D875-A981-4140-A1FF-AD93258E8D59")]
    [NativeTypeName("struct IInkDesktopHost : IUnknown")]
    public unsafe partial struct IInkDesktopHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInkDesktopHost*, Guid*, void**, int>)(lpVtbl[0]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInkDesktopHost*, uint>)(lpVtbl[1]))((IInkDesktopHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInkDesktopHost*, uint>)(lpVtbl[2]))((IInkDesktopHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueueWorkItem(IInkHostWorkItem* workItem)
        {
            return ((delegate* unmanaged<IInkDesktopHost*, IInkHostWorkItem*, int>)(lpVtbl[3]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), workItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInkPresenter([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IInkDesktopHost*, Guid*, void**, int>)(lpVtbl[4]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAndInitializeInkPresenter(IUnknown* rootVisual, float width, float height, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IInkDesktopHost*, IUnknown*, float, float, Guid*, void**, int>)(lpVtbl[5]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), rootVisual, width, height, riid, ppv);
        }
    }
}
