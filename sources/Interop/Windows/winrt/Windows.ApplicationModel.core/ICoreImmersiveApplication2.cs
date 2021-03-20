// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("828E1E36-E9E3-4CFC-9B66-48B78EA9BB2C")]
    [NativeTypeName("struct ICoreImmersiveApplication2 : IInspectable")]
    public unsafe partial struct ICoreImmersiveApplication2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication2*, Guid*, void**, int>)(lpVtbl[0]))((ICoreImmersiveApplication2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication2*, uint>)(lpVtbl[1]))((ICoreImmersiveApplication2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication2*, uint>)(lpVtbl[2]))((ICoreImmersiveApplication2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication2*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreImmersiveApplication2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication2*, IntPtr*, int>)(lpVtbl[4]))((ICoreImmersiveApplication2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication2*, TrustLevel*, int>)(lpVtbl[5]))((ICoreImmersiveApplication2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNewViewFromMainView([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** view)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication2*, ICoreApplicationView**, int>)(lpVtbl[6]))((ICoreImmersiveApplication2*)Unsafe.AsPointer(ref this), view);
        }
    }
}
