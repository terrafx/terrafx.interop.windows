// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [NativeTypeName("struct IDirectDrawColorControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectDrawColorControl : IDirectDrawColorControl.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, uint>)(lpVtbl[1]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, uint>)(lpVtbl[2]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0)
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, DDCOLORCONTROL*, int>)(lpVtbl[3]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0)
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, DDCOLORCONTROL*, int>)(lpVtbl[4]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this), param0);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0);

            [VtblIndex(4)]
            HRESULT SetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawColorControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawColorControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawColorControl*, uint> Release;

            [NativeTypeName("HRESULT (LPDDCOLORCONTROL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawColorControl*, DDCOLORCONTROL*, int> GetColorControls;

            [NativeTypeName("HRESULT (LPDDCOLORCONTROL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectDrawColorControl*, DDCOLORCONTROL*, int> SetColorControls;
        }
    }
}
