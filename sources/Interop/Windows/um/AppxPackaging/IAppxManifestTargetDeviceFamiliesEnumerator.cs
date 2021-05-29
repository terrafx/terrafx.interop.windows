// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36537F36-27A4-4788-88C0-733819575017")]
    [NativeTypeName("struct IAppxManifestTargetDeviceFamiliesEnumerator : IUnknown")]
    public unsafe partial struct IAppxManifestTargetDeviceFamiliesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxManifestTargetDeviceFamily** targetDeviceFamily)
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, IAppxManifestTargetDeviceFamily**, int>)(lpVtbl[3]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this), targetDeviceFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamiliesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestTargetDeviceFamiliesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
