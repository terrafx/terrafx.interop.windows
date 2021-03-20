// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72E247ED-DD5B-4D6C-B1D0-C57A7BBB5F94")]
    [NativeTypeName("struct IShutdownManagerStatics : IInspectable")]
    public unsafe partial struct IShutdownManagerStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShutdownManagerStatics*, uint>)(lpVtbl[1]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShutdownManagerStatics*, uint>)(lpVtbl[2]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics*, IntPtr*, int>)(lpVtbl[4]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginShutdown([NativeTypeName("ABI::Windows::System::ShutdownKind")] ShutdownKind shutdownKind, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeout)
        {
            return ((delegate* unmanaged<IShutdownManagerStatics*, ShutdownKind, TimeSpan, int>)(lpVtbl[6]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this), shutdownKind, timeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelShutdown()
        {
            return ((delegate* unmanaged<IShutdownManagerStatics*, int>)(lpVtbl[7]))((IShutdownManagerStatics*)Unsafe.AsPointer(ref this));
        }
    }
}
