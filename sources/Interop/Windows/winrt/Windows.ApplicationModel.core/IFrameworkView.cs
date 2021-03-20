// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FAAB5CD0-8924-45AC-AD0F-A08FAE5D0324")]
    [NativeTypeName("struct IFrameworkView : IInspectable")]
    public unsafe partial struct IFrameworkView
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IFrameworkView*, Guid*, void**, int>)(lpVtbl[0]))((IFrameworkView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFrameworkView*, uint>)(lpVtbl[1]))((IFrameworkView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFrameworkView*, uint>)(lpVtbl[2]))((IFrameworkView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IFrameworkView*, uint*, Guid**, int>)(lpVtbl[3]))((IFrameworkView*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IFrameworkView*, IntPtr*, int>)(lpVtbl[4]))((IFrameworkView*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IFrameworkView*, TrustLevel*, int>)(lpVtbl[5]))((IFrameworkView*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView *")] ICoreApplicationView* applicationView)
        {
            return ((delegate* unmanaged<IFrameworkView*, ICoreApplicationView*, int>)(lpVtbl[6]))((IFrameworkView*)Unsafe.AsPointer(ref this), applicationView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWindow([NativeTypeName("ABI::Windows::UI::Core::ICoreWindow *")] ICoreWindow* window)
        {
            return ((delegate* unmanaged<IFrameworkView*, ICoreWindow*, int>)(lpVtbl[7]))((IFrameworkView*)Unsafe.AsPointer(ref this), window);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("HSTRING")] IntPtr entryPoint)
        {
            return ((delegate* unmanaged<IFrameworkView*, IntPtr, int>)(lpVtbl[8]))((IFrameworkView*)Unsafe.AsPointer(ref this), entryPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Run()
        {
            return ((delegate* unmanaged<IFrameworkView*, int>)(lpVtbl[9]))((IFrameworkView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Uninitialize()
        {
            return ((delegate* unmanaged<IFrameworkView*, int>)(lpVtbl[10]))((IFrameworkView*)Unsafe.AsPointer(ref this));
        }
    }
}
