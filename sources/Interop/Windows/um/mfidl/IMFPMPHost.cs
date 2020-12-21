// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F70CA1A9-FDC7-4782-B994-ADFFB1C98606")]
    [NativeTypeName("struct IMFPMPHost : IUnknown")]
    public unsafe partial struct IMFPMPHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPHost*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMPHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPHost*, uint>)(lpVtbl[1]))((IMFPMPHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPHost*, uint>)(lpVtbl[2]))((IMFPMPHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockProcess()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPHost*, int>)(lpVtbl[3]))((IMFPMPHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockProcess()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPHost*, int>)(lpVtbl[4]))((IMFPMPHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateObjectByCLSID([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("IStream *")] IStream* pStream, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMPHost*, Guid*, IStream*, Guid*, void**, int>)(lpVtbl[5]))((IMFPMPHost*)Unsafe.AsPointer(ref this), clsid, pStream, riid, ppv);
        }
    }
}
