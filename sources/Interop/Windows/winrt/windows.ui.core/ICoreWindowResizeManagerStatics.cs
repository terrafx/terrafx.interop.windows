// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE4A9045-6D70-49DB-8E68-46FFBD17D38D")]
    [NativeTypeName("struct ICoreWindowResizeManagerStatics : IInspectable")]
    public unsafe partial struct ICoreWindowResizeManagerStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowResizeManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerStatics*, uint>)(lpVtbl[1]))((ICoreWindowResizeManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerStatics*, uint>)(lpVtbl[2]))((ICoreWindowResizeManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowResizeManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerStatics*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindowResizeManagerStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowResizeManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetForCurrentView([NativeTypeName("ABI::Windows::UI::Core::ICoreWindowResizeManager **")] ICoreWindowResizeManager** CoreWindowResizeManager)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerStatics*, ICoreWindowResizeManager**, int>)(lpVtbl[6]))((ICoreWindowResizeManagerStatics*)Unsafe.AsPointer(ref this), CoreWindowResizeManager);
        }
    }
}
