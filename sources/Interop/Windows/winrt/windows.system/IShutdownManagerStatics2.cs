// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0F69A02F-9C34-43C7-A8C3-70B30A7F7504")]
    [NativeTypeName("struct IShutdownManagerStatics2 : IInspectable")]
    public unsafe partial struct IShutdownManagerStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShutdownManagerStatics2*, uint>)(lpVtbl[1]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShutdownManagerStatics2*, uint>)(lpVtbl[2]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics2*, IntPtr*, int>)(lpVtbl[4]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsPowerStateSupported([NativeTypeName("ABI::Windows::System::PowerState")] PowerState powerState, [NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics2*, PowerState, byte*, int>)(lpVtbl[6]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), powerState, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnterPowerState([NativeTypeName("ABI::Windows::System::PowerState")] PowerState powerState)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics2*, PowerState, int>)(lpVtbl[7]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), powerState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnterPowerStateWithTimeSpan([NativeTypeName("ABI::Windows::System::PowerState")] PowerState powerState, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan wakeUpAfter)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics2*, PowerState, TimeSpan, int>)(lpVtbl[8]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), powerState, wakeUpAfter);
        }
    }
}
