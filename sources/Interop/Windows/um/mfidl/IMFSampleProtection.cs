// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8E36395F-C7B9-43C4-A54D-512B4AF63C95")]
    [NativeTypeName("struct IMFSampleProtection : IUnknown")]
    public unsafe partial struct IMFSampleProtection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint>)(lpVtbl[1]))((IMFSampleProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint>)(lpVtbl[2]))((IMFSampleProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputProtectionVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint*, int>)(lpVtbl[3]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputProtectionVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint*, int>)(lpVtbl[4]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProtectionCertificate([NativeTypeName("DWORD")] uint dwVersion, [NativeTypeName("BYTE **")] byte** ppCert, [NativeTypeName("DWORD *")] uint* pcbCert)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint, byte**, uint*, int>)(lpVtbl[5]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), dwVersion, ppCert, pcbCert);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitOutputProtection([NativeTypeName("DWORD")] uint dwVersion, [NativeTypeName("DWORD")] uint dwOutputId, [NativeTypeName("BYTE *")] byte* pbCert, [NativeTypeName("DWORD")] uint cbCert, [NativeTypeName("BYTE **")] byte** ppbSeed, [NativeTypeName("DWORD *")] uint* pcbSeed)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint, uint, byte*, uint, byte**, uint*, int>)(lpVtbl[6]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), dwVersion, dwOutputId, pbCert, cbCert, ppbSeed, pcbSeed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitInputProtection([NativeTypeName("DWORD")] uint dwVersion, [NativeTypeName("DWORD")] uint dwInputId, [NativeTypeName("BYTE *")] byte* pbSeed, [NativeTypeName("DWORD")] uint cbSeed)
        {
            return ((delegate* unmanaged<IMFSampleProtection*, uint, uint, byte*, uint, int>)(lpVtbl[7]))((IMFSampleProtection*)Unsafe.AsPointer(ref this), dwVersion, dwInputId, pbSeed, cbSeed);
        }
    }
}
