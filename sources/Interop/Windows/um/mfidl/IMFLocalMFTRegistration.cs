// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("149C4D73-B4BE-4F8D-8B87-079E926B6ADD")]
    [NativeTypeName("struct IMFLocalMFTRegistration : IUnknown")]
    public unsafe partial struct IMFLocalMFTRegistration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFLocalMFTRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IMFLocalMFTRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFLocalMFTRegistration*, uint>)(lpVtbl[1]))((IMFLocalMFTRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFLocalMFTRegistration*, uint>)(lpVtbl[2]))((IMFLocalMFTRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterMFTs(MFT_REGISTRATION_INFO* pMFTs, [NativeTypeName("DWORD")] uint cMFTs)
        {
            return ((delegate* unmanaged<IMFLocalMFTRegistration*, MFT_REGISTRATION_INFO*, uint, int>)(lpVtbl[3]))((IMFLocalMFTRegistration*)Unsafe.AsPointer(ref this), pMFTs, cMFTs);
        }
    }
}
