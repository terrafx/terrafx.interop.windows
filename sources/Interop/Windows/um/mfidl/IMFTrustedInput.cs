// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("542612C4-A1B8-4632-B521-DE11EA64A0B0")]
    [NativeTypeName("struct IMFTrustedInput : IUnknown")]
    public unsafe partial struct IMFTrustedInput
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTrustedInput*, Guid*, void**, int>)(lpVtbl[0]))((IMFTrustedInput*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTrustedInput*, uint>)(lpVtbl[1]))((IMFTrustedInput*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTrustedInput*, uint>)(lpVtbl[2]))((IMFTrustedInput*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputTrustAuthority([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppunkObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTrustedInput*, uint, Guid*, IUnknown**, int>)(lpVtbl[3]))((IMFTrustedInput*)Unsafe.AsPointer(ref this), dwStreamID, riid, ppunkObject);
        }
    }
}
