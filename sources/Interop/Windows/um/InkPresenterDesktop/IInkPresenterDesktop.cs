// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("73F3C0D9-2E8B-48F3-895E-20CBD27B723B")]
    [NativeTypeName("struct IInkPresenterDesktop : IUnknown")]
    public unsafe partial struct IInkPresenterDesktop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInkPresenterDesktop*, Guid*, void**, int>)(lpVtbl[0]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInkPresenterDesktop*, uint>)(lpVtbl[1]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInkPresenterDesktop*, uint>)(lpVtbl[2]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRootVisual(IUnknown* rootVisual, IUnknown* device)
        {
            return ((delegate* unmanaged<IInkPresenterDesktop*, IUnknown*, IUnknown*, int>)(lpVtbl[3]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), rootVisual, device);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCommitRequestHandler(IInkCommitRequestHandler* handler)
        {
            return ((delegate* unmanaged<IInkPresenterDesktop*, IInkCommitRequestHandler*, int>)(lpVtbl[4]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize(float* width, float* height)
        {
            return ((delegate* unmanaged<IInkPresenterDesktop*, float*, float*, int>)(lpVtbl[5]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize(float width, float height)
        {
            return ((delegate* unmanaged<IInkPresenterDesktop*, float, float, int>)(lpVtbl[6]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnHighContrastChanged()
        {
            return ((delegate* unmanaged<IInkPresenterDesktop*, int>)(lpVtbl[7]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this));
        }
    }
}
