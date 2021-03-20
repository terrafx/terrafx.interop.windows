// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F3DFB96A-3306-5903-A1C5-FF9757A8689E")]
    [NativeTypeName("struct IManipulationUpdatedEventArgs2 : IInspectable")]
    public unsafe partial struct IManipulationUpdatedEventArgs2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IManipulationUpdatedEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IManipulationUpdatedEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IManipulationUpdatedEventArgs2*, uint>)(lpVtbl[1]))((IManipulationUpdatedEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IManipulationUpdatedEventArgs2*, uint>)(lpVtbl[2]))((IManipulationUpdatedEventArgs2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IManipulationUpdatedEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IManipulationUpdatedEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IManipulationUpdatedEventArgs2*, IntPtr*, int>)(lpVtbl[4]))((IManipulationUpdatedEventArgs2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IManipulationUpdatedEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IManipulationUpdatedEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IManipulationUpdatedEventArgs2*, uint*, int>)(lpVtbl[6]))((IManipulationUpdatedEventArgs2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentContactCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IManipulationUpdatedEventArgs2*, uint*, int>)(lpVtbl[7]))((IManipulationUpdatedEventArgs2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
