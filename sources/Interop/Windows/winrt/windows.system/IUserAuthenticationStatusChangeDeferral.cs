// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("88B59568-BB30-42FB-A270-E9902E40EFA7")]
    [NativeTypeName("struct IUserAuthenticationStatusChangeDeferral : IInspectable")]
    public unsafe partial struct IUserAuthenticationStatusChangeDeferral
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangeDeferral*, Guid*, void**, int>)(lpVtbl[0]))((IUserAuthenticationStatusChangeDeferral*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangeDeferral*, uint>)(lpVtbl[1]))((IUserAuthenticationStatusChangeDeferral*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangeDeferral*, uint>)(lpVtbl[2]))((IUserAuthenticationStatusChangeDeferral*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangeDeferral*, uint*, Guid**, int>)(lpVtbl[3]))((IUserAuthenticationStatusChangeDeferral*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangeDeferral*, IntPtr*, int>)(lpVtbl[4]))((IUserAuthenticationStatusChangeDeferral*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangeDeferral*, TrustLevel*, int>)(lpVtbl[5]))((IUserAuthenticationStatusChangeDeferral*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Complete()
        {
            return ((delegate* unmanaged<IUserAuthenticationStatusChangeDeferral*, int>)(lpVtbl[6]))((IUserAuthenticationStatusChangeDeferral*)Unsafe.AsPointer(ref this));
        }
    }
}
