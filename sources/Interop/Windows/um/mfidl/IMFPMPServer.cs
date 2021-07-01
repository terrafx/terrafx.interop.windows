// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("994E23AF-1CC2-493C-B9FA-46F1CB040FA4")]
    [NativeTypeName("struct IMFPMPServer : IUnknown")]
    public unsafe partial struct IMFPMPServer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPMPServer*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMPServer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPMPServer*, uint>)(lpVtbl[1]))((IMFPMPServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPMPServer*, uint>)(lpVtbl[2]))((IMFPMPServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockProcess()
        {
            return ((delegate* unmanaged<IMFPMPServer*, int>)(lpVtbl[3]))((IMFPMPServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockProcess()
        {
            return ((delegate* unmanaged<IMFPMPServer*, int>)(lpVtbl[4]))((IMFPMPServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateObjectByCLSID([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, void** ppObject)
        {
            return ((delegate* unmanaged<IMFPMPServer*, Guid*, Guid*, void**, int>)(lpVtbl[5]))((IMFPMPServer*)Unsafe.AsPointer(ref this), clsid, riid, ppObject);
        }
    }
}
