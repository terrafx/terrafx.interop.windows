// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EF6FD10E-E6FB-4814-A44E-57E8B9D9A01B")]
    [NativeTypeName("struct ILauncherOptions4 : IInspectable")]
    public unsafe partial struct ILauncherOptions4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILauncherOptions4*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherOptions4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILauncherOptions4*, uint>)(lpVtbl[1]))((ILauncherOptions4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILauncherOptions4*, uint>)(lpVtbl[2]))((ILauncherOptions4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ILauncherOptions4*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherOptions4*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ILauncherOptions4*, IntPtr*, int>)(lpVtbl[4]))((ILauncherOptions4*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ILauncherOptions4*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherOptions4*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LimitPickerToCurrentAppAndAppUriHandlers([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ILauncherOptions4*, byte*, int>)(lpVtbl[6]))((ILauncherOptions4*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_LimitPickerToCurrentAppAndAppUriHandlers([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ILauncherOptions4*, byte, int>)(lpVtbl[7]))((ILauncherOptions4*)Unsafe.AsPointer(ref this), value);
        }
    }
}
