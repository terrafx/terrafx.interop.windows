// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A116FF71-F8BF-4C8A-9C98-70779A32A9C8")]
    [NativeTypeName("struct ICompositionGraphicsDeviceInterop : IUnknown")]
    public unsafe partial struct ICompositionGraphicsDeviceInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, uint>)(lpVtbl[1]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, uint>)(lpVtbl[2]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRenderingDevice(IUnknown** value)
        {
            return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, IUnknown**, int>)(lpVtbl[3]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRenderingDevice(IUnknown* value)
        {
            return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop*, IUnknown*, int>)(lpVtbl[4]))((ICompositionGraphicsDeviceInterop*)Unsafe.AsPointer(ref this), value);
        }
    }
}
