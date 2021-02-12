// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("18C9E2B6-3F43-4116-9F2B-FF935D7770D2")]
    [NativeTypeName("struct IXamlDiagnostics : IUnknown")]
    public unsafe partial struct IXamlDiagnostics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, Guid*, void**, int>)(lpVtbl[0]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, uint>)(lpVtbl[1]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, uint>)(lpVtbl[2]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDispatcher([NativeTypeName("IInspectable **")] IInspectable** ppDispatcher)
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable**, int>)(lpVtbl[3]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), ppDispatcher);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUiLayer([NativeTypeName("IInspectable **")] IInspectable** ppLayer)
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable**, int>)(lpVtbl[4]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), ppLayer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetApplication([NativeTypeName("IInspectable **")] IInspectable** ppApplication)
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable**, int>)(lpVtbl[5]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), ppApplication);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIInspectableFromHandle([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("IInspectable **")] IInspectable** ppInstance)
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, ulong, IInspectable**, int>)(lpVtbl[6]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), instanceHandle, ppInstance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHandleFromIInspectable([NativeTypeName("IInspectable *")] IInspectable* pInstance, [NativeTypeName("InstanceHandle *")] ulong* pHandle)
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable*, ulong*, int>)(lpVtbl[7]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), pInstance, pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HitTest(RECT rect, [NativeTypeName("unsigned int *")] uint* pCount, [NativeTypeName("InstanceHandle **")] ulong** ppInstanceHandles)
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, RECT, uint*, ulong**, int>)(lpVtbl[8]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), rect, pCount, ppInstanceHandles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterInstance([NativeTypeName("IInspectable *")] IInspectable* pInstance, [NativeTypeName("InstanceHandle *")] ulong* pInstanceHandle)
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable*, ulong*, int>)(lpVtbl[9]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), pInstance, pInstanceHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInitializationData([NativeTypeName("BSTR *")] ushort** pInitializationData)
        {
            return ((delegate* unmanaged<IXamlDiagnostics*, ushort**, int>)(lpVtbl[10]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), pInitializationData);
        }
    }
}
