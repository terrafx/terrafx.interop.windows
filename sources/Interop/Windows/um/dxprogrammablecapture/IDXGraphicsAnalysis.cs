// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DXProgrammableCapture.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9F251514-9D4D-4902-9D60-18988AB7D4B5")]
    [NativeTypeName("struct IDXGraphicsAnalysis : IUnknown")]
    public unsafe partial struct IDXGraphicsAnalysis
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGraphicsAnalysis*, Guid*, void**, int>)(lpVtbl[0]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGraphicsAnalysis*, uint>)(lpVtbl[1]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGraphicsAnalysis*, uint>)(lpVtbl[2]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void BeginCapture()
        {
            ((delegate* unmanaged<IDXGraphicsAnalysis*, void>)(lpVtbl[3]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void EndCapture()
        {
            ((delegate* unmanaged<IDXGraphicsAnalysis*, void>)(lpVtbl[4]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
        }
    }
}
