// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6B528900-F46E-4EB0-AA6C-38AF557CF9ED")]
    [NativeTypeName("struct IAppActivationResult : IInspectable")]
    public unsafe partial struct IAppActivationResult
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppActivationResult*, Guid*, void**, int>)(lpVtbl[0]))((IAppActivationResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppActivationResult*, uint>)(lpVtbl[1]))((IAppActivationResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppActivationResult*, uint>)(lpVtbl[2]))((IAppActivationResult*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppActivationResult*, uint*, Guid**, int>)(lpVtbl[3]))((IAppActivationResult*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppActivationResult*, IntPtr*, int>)(lpVtbl[4]))((IAppActivationResult*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppActivationResult*, TrustLevel*, int>)(lpVtbl[5]))((IAppActivationResult*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ExtendedError([NativeTypeName("HRESULT *")] int* value)
        {
            return ((delegate* unmanaged<IAppActivationResult*, int*, int>)(lpVtbl[6]))((IAppActivationResult*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppResourceGroupInfo([NativeTypeName("ABI::Windows::System::IAppResourceGroupInfo **")] IAppResourceGroupInfo** value)
        {
            return ((delegate* unmanaged<IAppActivationResult*, IAppResourceGroupInfo**, int>)(lpVtbl[7]))((IAppActivationResult*)Unsafe.AsPointer(ref this), value);
        }
    }
}
