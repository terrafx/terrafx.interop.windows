// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4CE7D875-A981-4140-A1FF-AD93258E8D59")]
    [NativeTypeName("struct IInkDesktopHost : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInkDesktopHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInkDesktopHost*, Guid*, void**, int>)(lpVtbl[0]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInkDesktopHost*, uint>)(lpVtbl[1]))((IInkDesktopHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInkDesktopHost*, uint>)(lpVtbl[2]))((IInkDesktopHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueueWorkItem(IInkHostWorkItem* workItem)
        {
            return ((delegate* unmanaged<IInkDesktopHost*, IInkHostWorkItem*, int>)(lpVtbl[3]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), workItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateInkPresenter([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IInkDesktopHost*, Guid*, void**, int>)(lpVtbl[4]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateAndInitializeInkPresenter(IUnknown* rootVisual, float width, float height, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IInkDesktopHost*, IUnknown*, float, float, Guid*, void**, int>)(lpVtbl[5]))((IInkDesktopHost*)Unsafe.AsPointer(ref this), rootVisual, width, height, riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInkDesktopHost*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInkDesktopHost*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInkDesktopHost*, uint> Release;

            [NativeTypeName("HRESULT (IInkHostWorkItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInkDesktopHost*, IInkHostWorkItem*, int> QueueWorkItem;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInkDesktopHost*, Guid*, void**, int> CreateInkPresenter;

            [NativeTypeName("HRESULT (IUnknown *, float, float, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInkDesktopHost*, IUnknown*, float, float, Guid*, void**, int> CreateAndInitializeInkPresenter;
        }
    }
}
