// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct IDirectDrawColorControl : IUnknown")]
    public unsafe partial struct IDirectDrawColorControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, uint>)(lpVtbl[1]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, uint>)(lpVtbl[2]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0)
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, DDCOLORCONTROL*, int>)(lpVtbl[3]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this), param0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0)
        {
            return ((delegate* unmanaged<IDirectDrawColorControl*, DDCOLORCONTROL*, int>)(lpVtbl[4]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this), param0);
        }
    }
}
