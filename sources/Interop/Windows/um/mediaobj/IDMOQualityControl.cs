// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("65ABEA96-CF36-453F-AF8A-705E98F16260")]
    [NativeTypeName("struct IDMOQualityControl : IUnknown")]
    public unsafe partial struct IDMOQualityControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMOQualityControl*, Guid*, void**, int>)(lpVtbl[0]))((IDMOQualityControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMOQualityControl*, uint>)(lpVtbl[1]))((IDMOQualityControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMOQualityControl*, uint>)(lpVtbl[2]))((IDMOQualityControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNow([NativeTypeName("REFERENCE_TIME")] long rtNow)
        {
            return ((delegate* unmanaged<IDMOQualityControl*, long, int>)(lpVtbl[3]))((IDMOQualityControl*)Unsafe.AsPointer(ref this), rtNow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStatus([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IDMOQualityControl*, uint, int>)(lpVtbl[4]))((IDMOQualityControl*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IDMOQualityControl*, uint*, int>)(lpVtbl[5]))((IDMOQualityControl*)Unsafe.AsPointer(ref this), pdwFlags);
        }
    }
}
