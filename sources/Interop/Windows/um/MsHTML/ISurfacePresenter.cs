// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106E2-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISurfacePresenter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISurfacePresenter : ISurfacePresenter.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISurfacePresenter*, Guid*, void**, int>)(lpVtbl[0]))((ISurfacePresenter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISurfacePresenter*, uint>)(lpVtbl[1]))((ISurfacePresenter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISurfacePresenter*, uint>)(lpVtbl[2]))((ISurfacePresenter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Present(uint uBuffer, RECT* pDirty)
        {
            return ((delegate* unmanaged<ISurfacePresenter*, uint, RECT*, int>)(lpVtbl[3]))((ISurfacePresenter*)Unsafe.AsPointer(ref this), uBuffer, pDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetBuffer(uint backBufferIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppBuffer)
        {
            return ((delegate* unmanaged<ISurfacePresenter*, uint, Guid*, void**, int>)(lpVtbl[4]))((ISurfacePresenter*)Unsafe.AsPointer(ref this), backBufferIndex, riid, ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT IsCurrent(BOOL* pIsCurrent)
        {
            return ((delegate* unmanaged<ISurfacePresenter*, BOOL*, int>)(lpVtbl[5]))((ISurfacePresenter*)Unsafe.AsPointer(ref this), pIsCurrent);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Present(uint uBuffer, RECT* pDirty);

            [VtblIndex(4)]
            HRESULT GetBuffer(uint backBufferIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppBuffer);

            [VtblIndex(5)]
            HRESULT IsCurrent(BOOL* pIsCurrent);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfacePresenter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfacePresenter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfacePresenter*, uint> Release;

            [NativeTypeName("HRESULT (UINT, RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfacePresenter*, uint, RECT*, int> Present;

            [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfacePresenter*, uint, Guid*, void**, int> GetBuffer;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISurfacePresenter*, BOOL*, int> IsCurrent;
        }
    }
}
