// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D19F8E95-B126-4446-890C-5DCB7AD71453")]
    public unsafe partial struct IMFTrustedOutput
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTrustedOutput*, Guid*, void**, int>)(lpVtbl[0]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTrustedOutput*, uint>)(lpVtbl[1]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTrustedOutput*, uint>)(lpVtbl[2]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputTrustAuthorityCount([NativeTypeName("DWORD *")] uint* pcOutputTrustAuthorities)
        {
            return ((delegate* stdcall<IMFTrustedOutput*, uint*, int>)(lpVtbl[3]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this), pcOutputTrustAuthorities);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputTrustAuthorityByIndex([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IMFOutputTrustAuthority **")] IMFOutputTrustAuthority** ppauthority)
        {
            return ((delegate* stdcall<IMFTrustedOutput*, uint, IMFOutputTrustAuthority**, int>)(lpVtbl[4]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this), dwIndex, ppauthority);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsFinal([NativeTypeName("BOOL *")] int* pfIsFinal)
        {
            return ((delegate* stdcall<IMFTrustedOutput*, int*, int>)(lpVtbl[5]))((IMFTrustedOutput*)Unsafe.AsPointer(ref this), pfIsFinal);
        }
    }
}
