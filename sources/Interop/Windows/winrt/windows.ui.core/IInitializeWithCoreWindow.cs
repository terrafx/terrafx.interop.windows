// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("188F20D6-9873-464A-ACE5-57E010F465E6")]
    [NativeTypeName("struct IInitializeWithCoreWindow : IInspectable")]
    public unsafe partial struct IInitializeWithCoreWindow
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IInitializeWithCoreWindow*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeWithCoreWindow*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInitializeWithCoreWindow*, uint>)(lpVtbl[1]))((IInitializeWithCoreWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInitializeWithCoreWindow*, uint>)(lpVtbl[2]))((IInitializeWithCoreWindow*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IInitializeWithCoreWindow*, uint*, Guid**, int>)(lpVtbl[3]))((IInitializeWithCoreWindow*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IInitializeWithCoreWindow*, IntPtr*, int>)(lpVtbl[4]))((IInitializeWithCoreWindow*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IInitializeWithCoreWindow*, TrustLevel*, int>)(lpVtbl[5]))((IInitializeWithCoreWindow*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("ABI::Windows::UI::Core::ICoreWindow *")] ICoreWindow* window)
        {
            return ((delegate* unmanaged<IInitializeWithCoreWindow*, ICoreWindow*, int>)(lpVtbl[6]))((IInitializeWithCoreWindow*)Unsafe.AsPointer(ref this), window);
        }
    }
}
