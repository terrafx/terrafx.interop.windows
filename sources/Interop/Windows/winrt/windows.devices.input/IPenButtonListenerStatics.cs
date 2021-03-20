// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("19A8A584-862F-5F69-BFEA-05F6584F133F")]
    [NativeTypeName("struct IPenButtonListenerStatics : IInspectable")]
    public unsafe partial struct IPenButtonListenerStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPenButtonListenerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPenButtonListenerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPenButtonListenerStatics*, uint>)(lpVtbl[1]))((IPenButtonListenerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPenButtonListenerStatics*, uint>)(lpVtbl[2]))((IPenButtonListenerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPenButtonListenerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPenButtonListenerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPenButtonListenerStatics*, IntPtr*, int>)(lpVtbl[4]))((IPenButtonListenerStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPenButtonListenerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPenButtonListenerStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefault([NativeTypeName("ABI::Windows::Devices::Input::IPenButtonListener **")] IPenButtonListener** result)
        {
            return ((delegate* unmanaged<IPenButtonListenerStatics*, IPenButtonListener**, int>)(lpVtbl[6]))((IPenButtonListenerStatics*)Unsafe.AsPointer(ref this), result);
        }
    }
}
