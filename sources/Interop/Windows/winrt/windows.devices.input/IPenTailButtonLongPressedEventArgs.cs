// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F37C606E-C60A-5F42-B818-A53112406C13")]
    [NativeTypeName("struct IPenTailButtonLongPressedEventArgs : IInspectable")]
    public unsafe partial struct IPenTailButtonLongPressedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPenTailButtonLongPressedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPenTailButtonLongPressedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPenTailButtonLongPressedEventArgs*, uint>)(lpVtbl[1]))((IPenTailButtonLongPressedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPenTailButtonLongPressedEventArgs*, uint>)(lpVtbl[2]))((IPenTailButtonLongPressedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPenTailButtonLongPressedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPenTailButtonLongPressedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPenTailButtonLongPressedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IPenTailButtonLongPressedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPenTailButtonLongPressedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPenTailButtonLongPressedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }
    }
}
