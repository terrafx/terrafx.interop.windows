// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D577EF7-4CEE-11E6-B535-001BDC06AB3B")]
    [NativeTypeName("struct IKnownSimpleHapticsControllerWaveformsStatics : IInspectable")]
    public unsafe partial struct IKnownSimpleHapticsControllerWaveformsStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, uint>)(lpVtbl[1]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, uint>)(lpVtbl[2]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, IntPtr*, int>)(lpVtbl[4]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Click([NativeTypeName("UINT16 *")] ushort* value)
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[6]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BuzzContinuous([NativeTypeName("UINT16 *")] ushort* value)
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[7]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RumbleContinuous([NativeTypeName("UINT16 *")] ushort* value)
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[8]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Press([NativeTypeName("UINT16 *")] ushort* value)
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[9]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Release([NativeTypeName("UINT16 *")] ushort* value)
        {
            return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics*, ushort*, int>)(lpVtbl[10]))((IKnownSimpleHapticsControllerWaveformsStatics*)Unsafe.AsPointer(ref this), value);
        }
    }
}
