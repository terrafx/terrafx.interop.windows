// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1CDE6309-CAE0-4940-907E-C1EC9C3D1D4A")]
    [NativeTypeName("struct IMFRemoteDesktopPlugin : IUnknown")]
    public unsafe partial struct IMFRemoteDesktopPlugin
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFRemoteDesktopPlugin*, Guid*, void**, int>)(lpVtbl[0]))((IMFRemoteDesktopPlugin*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFRemoteDesktopPlugin*, uint>)(lpVtbl[1]))((IMFRemoteDesktopPlugin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFRemoteDesktopPlugin*, uint>)(lpVtbl[2]))((IMFRemoteDesktopPlugin*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTopology([NativeTypeName("IMFTopology *")] IMFTopology* pTopology)
        {
            return ((delegate* unmanaged<IMFRemoteDesktopPlugin*, IMFTopology*, int>)(lpVtbl[3]))((IMFRemoteDesktopPlugin*)Unsafe.AsPointer(ref this), pTopology);
        }
    }
}
