// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("544C8934-86D8-4991-8E75-ECE8A43B6B6D")]
    [NativeTypeName("struct IProcessLauncherResult : IInspectable")]
    public unsafe partial struct IProcessLauncherResult
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IProcessLauncherResult*, Guid*, void**, int>)(lpVtbl[0]))((IProcessLauncherResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProcessLauncherResult*, uint>)(lpVtbl[1]))((IProcessLauncherResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProcessLauncherResult*, uint>)(lpVtbl[2]))((IProcessLauncherResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IProcessLauncherResult*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessLauncherResult*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IProcessLauncherResult*, IntPtr*, int>)(lpVtbl[4]))((IProcessLauncherResult*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IProcessLauncherResult*, TrustLevel*, int>)(lpVtbl[5]))((IProcessLauncherResult*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ExitCode([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IProcessLauncherResult*, uint*, int>)(lpVtbl[6]))((IProcessLauncherResult*)Unsafe.AsPointer(ref this), value);
        }
    }
}
