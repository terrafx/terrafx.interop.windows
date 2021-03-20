// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/activationregistration.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EC734A06-0401-4317-BAC1-3B7E207242E3")]
    [NativeTypeName("struct IExeServerRegistration : IInspectable")]
    public unsafe partial struct IExeServerRegistration
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExeServerRegistration*, uint>)(lpVtbl[1]))((IExeServerRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExeServerRegistration*, uint>)(lpVtbl[2]))((IExeServerRegistration*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, uint*, Guid**, int>)(lpVtbl[3]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, IntPtr*, int>)(lpVtbl[4]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, TrustLevel*, int>)(lpVtbl[5]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ServerName([NativeTypeName("HSTRING *")] IntPtr* serverName)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, IntPtr*, int>)(lpVtbl[6]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), serverName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ExePath([NativeTypeName("HSTRING *")] IntPtr* exePath)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, IntPtr*, int>)(lpVtbl[7]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), exePath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CommandLine([NativeTypeName("HSTRING *")] IntPtr* commandLine)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, IntPtr*, int>)(lpVtbl[8]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), commandLine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppUserModelId([NativeTypeName("HSTRING *")] IntPtr* appUserModelId)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, IntPtr*, int>)(lpVtbl[9]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), appUserModelId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IdentityType([NativeTypeName("ABI::Windows::Foundation::IdentityType *")] IdentityType* identityType)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, IdentityType*, int>)(lpVtbl[10]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), identityType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Identity([NativeTypeName("HSTRING *")] IntPtr* identity)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, IntPtr*, int>)(lpVtbl[11]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), identity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Instancing([NativeTypeName("ABI::Windows::Foundation::InstancingType *")] InstancingType* instanceType)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, InstancingType*, int>)(lpVtbl[12]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), instanceType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Permissions([NativeTypeName("HSTRING *")] IntPtr* permissions)
        {
            return ((delegate* unmanaged<IExeServerRegistration*, IntPtr*, int>)(lpVtbl[13]))((IExeServerRegistration*)Unsafe.AsPointer(ref this), permissions);
        }
    }
}
