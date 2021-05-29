// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DFCD8E4D-30B5-4567-ACAA-8EB5B7853DC9")]
    [NativeTypeName("struct IMFQualityAdviseLimits : IUnknown")]
    public unsafe partial struct IMFQualityAdviseLimits
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFQualityAdviseLimits*, Guid*, void**, int>)(lpVtbl[0]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFQualityAdviseLimits*, uint>)(lpVtbl[1]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFQualityAdviseLimits*, uint>)(lpVtbl[2]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaximumDropMode(MF_QUALITY_DROP_MODE* peDropMode)
        {
            return ((delegate* unmanaged<IMFQualityAdviseLimits*, MF_QUALITY_DROP_MODE*, int>)(lpVtbl[3]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this), peDropMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinimumQualityLevel(MF_QUALITY_LEVEL* peQualityLevel)
        {
            return ((delegate* unmanaged<IMFQualityAdviseLimits*, MF_QUALITY_LEVEL*, int>)(lpVtbl[4]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this), peQualityLevel);
        }
    }
}
