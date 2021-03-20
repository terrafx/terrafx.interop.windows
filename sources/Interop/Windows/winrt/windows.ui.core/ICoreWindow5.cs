// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4B4AE1E1-2E6D-4EAA-BDA1-1C5CC1BEE141")]
    [NativeTypeName("struct ICoreWindow5 : IInspectable")]
    public unsafe partial struct ICoreWindow5
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindow5*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindow5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindow5*, uint>)(lpVtbl[1]))((ICoreWindow5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindow5*, uint>)(lpVtbl[2]))((ICoreWindow5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindow5*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindow5*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindow5*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindow5*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindow5*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindow5*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DispatcherQueue([NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue** value)
        {
            return ((delegate* unmanaged<ICoreWindow5*, IDispatcherQueue**, int>)(lpVtbl[6]))((ICoreWindow5*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ActivationMode([NativeTypeName("ABI::Windows::UI::Core::CoreWindowActivationMode *")] CoreWindowActivationMode* value)
        {
            return ((delegate* unmanaged<ICoreWindow5*, CoreWindowActivationMode*, int>)(lpVtbl[7]))((ICoreWindow5*)Unsafe.AsPointer(ref this), value);
        }
    }
}
