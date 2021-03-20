// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1ADA0E3E-E4A2-4123-B451-DC96BF800419")]
    [NativeTypeName("struct ICoreImmersiveApplication : IInspectable")]
    public unsafe partial struct ICoreImmersiveApplication
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication*, Guid*, void**, int>)(lpVtbl[0]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication*, uint>)(lpVtbl[1]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication*, uint>)(lpVtbl[2]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication*, IntPtr*, int>)(lpVtbl[4]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication*, TrustLevel*, int>)(lpVtbl[5]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Views([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CCoreApplicationView_t **")] IVectorView<IntPtr>** value)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication*, IVectorView<IntPtr>**, int>)(lpVtbl[6]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNewView([NativeTypeName("HSTRING")] IntPtr runtimeType, [NativeTypeName("HSTRING")] IntPtr entryPoint, [NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** view)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication*, IntPtr, IntPtr, ICoreApplicationView**, int>)(lpVtbl[7]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), runtimeType, entryPoint, view);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MainView([NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView **")] ICoreApplicationView** value)
        {
            return ((delegate* unmanaged<ICoreImmersiveApplication*, ICoreApplicationView**, int>)(lpVtbl[8]))((ICoreImmersiveApplication*)Unsafe.AsPointer(ref this), value);
        }
    }
}
