// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9556DC99-828C-11CF-A37E-00AA003240C7")]
    [NativeTypeName("struct IWbemServices : IUnknown")]
    public unsafe partial struct IWbemServices
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemServices*, Guid*, void**, int>)(lpVtbl[0]))((IWbemServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemServices*, uint>)(lpVtbl[1]))((IWbemServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemServices*, uint>)(lpVtbl[2]))((IWbemServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenNamespace([NativeTypeName("const BSTR")] ushort* strNamespace, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemServices** ppWorkingNamespace, IWbemCallResult** ppResult)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IWbemServices**, IWbemCallResult**, int>)(lpVtbl[3]))((IWbemServices*)Unsafe.AsPointer(ref this), strNamespace, lFlags, pCtx, ppWorkingNamespace, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelAsyncCall(IWbemObjectSink* pSink)
        {
            return ((delegate* unmanaged<IWbemServices*, IWbemObjectSink*, int>)(lpVtbl[4]))((IWbemServices*)Unsafe.AsPointer(ref this), pSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryObjectSink([NativeTypeName("long")] int lFlags, IWbemObjectSink** ppResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, int, IWbemObjectSink**, int>)(lpVtbl[5]))((IWbemServices*)Unsafe.AsPointer(ref this), lFlags, ppResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectW([NativeTypeName("const BSTR")] ushort* strObjectPath, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemClassObject** ppObject, IWbemCallResult** ppCallResult)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IWbemClassObject**, IWbemCallResult**, int>)(lpVtbl[6]))((IWbemServices*)Unsafe.AsPointer(ref this), strObjectPath, lFlags, pCtx, ppObject, ppCallResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectAsync([NativeTypeName("const BSTR")] ushort* strObjectPath, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IWbemObjectSink*, int>)(lpVtbl[7]))((IWbemServices*)Unsafe.AsPointer(ref this), strObjectPath, lFlags, pCtx, pResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PutClass(IWbemClassObject* pObject, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemCallResult** ppCallResult)
        {
            return ((delegate* unmanaged<IWbemServices*, IWbemClassObject*, int, IWbemContext*, IWbemCallResult**, int>)(lpVtbl[8]))((IWbemServices*)Unsafe.AsPointer(ref this), pObject, lFlags, pCtx, ppCallResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PutClassAsync(IWbemClassObject* pObject, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, IWbemClassObject*, int, IWbemContext*, IWbemObjectSink*, int>)(lpVtbl[9]))((IWbemServices*)Unsafe.AsPointer(ref this), pObject, lFlags, pCtx, pResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteClass([NativeTypeName("const BSTR")] ushort* strClass, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemCallResult** ppCallResult)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IWbemCallResult**, int>)(lpVtbl[10]))((IWbemServices*)Unsafe.AsPointer(ref this), strClass, lFlags, pCtx, ppCallResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteClassAsync([NativeTypeName("const BSTR")] ushort* strClass, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IWbemObjectSink*, int>)(lpVtbl[11]))((IWbemServices*)Unsafe.AsPointer(ref this), strClass, lFlags, pCtx, pResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateClassEnum([NativeTypeName("const BSTR")] ushort* strSuperclass, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IEnumWbemClassObject** ppEnum)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IEnumWbemClassObject**, int>)(lpVtbl[12]))((IWbemServices*)Unsafe.AsPointer(ref this), strSuperclass, lFlags, pCtx, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateClassEnumAsync([NativeTypeName("const BSTR")] ushort* strSuperclass, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IWbemObjectSink*, int>)(lpVtbl[13]))((IWbemServices*)Unsafe.AsPointer(ref this), strSuperclass, lFlags, pCtx, pResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PutInstance(IWbemClassObject* pInst, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemCallResult** ppCallResult)
        {
            return ((delegate* unmanaged<IWbemServices*, IWbemClassObject*, int, IWbemContext*, IWbemCallResult**, int>)(lpVtbl[14]))((IWbemServices*)Unsafe.AsPointer(ref this), pInst, lFlags, pCtx, ppCallResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PutInstanceAsync(IWbemClassObject* pInst, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, IWbemClassObject*, int, IWbemContext*, IWbemObjectSink*, int>)(lpVtbl[15]))((IWbemServices*)Unsafe.AsPointer(ref this), pInst, lFlags, pCtx, pResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteInstance([NativeTypeName("const BSTR")] ushort* strObjectPath, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemCallResult** ppCallResult)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IWbemCallResult**, int>)(lpVtbl[16]))((IWbemServices*)Unsafe.AsPointer(ref this), strObjectPath, lFlags, pCtx, ppCallResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteInstanceAsync([NativeTypeName("const BSTR")] ushort* strObjectPath, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IWbemObjectSink*, int>)(lpVtbl[17]))((IWbemServices*)Unsafe.AsPointer(ref this), strObjectPath, lFlags, pCtx, pResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstanceEnum([NativeTypeName("const BSTR")] ushort* strFilter, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IEnumWbemClassObject** ppEnum)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IEnumWbemClassObject**, int>)(lpVtbl[18]))((IWbemServices*)Unsafe.AsPointer(ref this), strFilter, lFlags, pCtx, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstanceEnumAsync([NativeTypeName("const BSTR")] ushort* strFilter, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, int, IWbemContext*, IWbemObjectSink*, int>)(lpVtbl[19]))((IWbemServices*)Unsafe.AsPointer(ref this), strFilter, lFlags, pCtx, pResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ExecQuery([NativeTypeName("const BSTR")] ushort* strQueryLanguage, [NativeTypeName("const BSTR")] ushort* strQuery, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IEnumWbemClassObject** ppEnum)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, ushort*, int, IWbemContext*, IEnumWbemClassObject**, int>)(lpVtbl[20]))((IWbemServices*)Unsafe.AsPointer(ref this), strQueryLanguage, strQuery, lFlags, pCtx, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ExecQueryAsync([NativeTypeName("const BSTR")] ushort* strQueryLanguage, [NativeTypeName("const BSTR")] ushort* strQuery, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, ushort*, int, IWbemContext*, IWbemObjectSink*, int>)(lpVtbl[21]))((IWbemServices*)Unsafe.AsPointer(ref this), strQueryLanguage, strQuery, lFlags, pCtx, pResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ExecNotificationQuery([NativeTypeName("const BSTR")] ushort* strQueryLanguage, [NativeTypeName("const BSTR")] ushort* strQuery, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IEnumWbemClassObject** ppEnum)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, ushort*, int, IWbemContext*, IEnumWbemClassObject**, int>)(lpVtbl[22]))((IWbemServices*)Unsafe.AsPointer(ref this), strQueryLanguage, strQuery, lFlags, pCtx, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ExecNotificationQueryAsync([NativeTypeName("const BSTR")] ushort* strQueryLanguage, [NativeTypeName("const BSTR")] ushort* strQuery, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, ushort*, int, IWbemContext*, IWbemObjectSink*, int>)(lpVtbl[23]))((IWbemServices*)Unsafe.AsPointer(ref this), strQueryLanguage, strQuery, lFlags, pCtx, pResponseHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ExecMethod([NativeTypeName("const BSTR")] ushort* strObjectPath, [NativeTypeName("const BSTR")] ushort* strMethodName, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemClassObject* pInParams, IWbemClassObject** ppOutParams, IWbemCallResult** ppCallResult)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, ushort*, int, IWbemContext*, IWbemClassObject*, IWbemClassObject**, IWbemCallResult**, int>)(lpVtbl[24]))((IWbemServices*)Unsafe.AsPointer(ref this), strObjectPath, strMethodName, lFlags, pCtx, pInParams, ppOutParams, ppCallResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ExecMethodAsync([NativeTypeName("const BSTR")] ushort* strObjectPath, [NativeTypeName("const BSTR")] ushort* strMethodName, [NativeTypeName("long")] int lFlags, IWbemContext* pCtx, IWbemClassObject* pInParams, IWbemObjectSink* pResponseHandler)
        {
            return ((delegate* unmanaged<IWbemServices*, ushort*, ushort*, int, IWbemContext*, IWbemClassObject*, IWbemObjectSink*, int>)(lpVtbl[25]))((IWbemServices*)Unsafe.AsPointer(ref this), strObjectPath, strMethodName, lFlags, pCtx, pInParams, pResponseHandler);
        }
    }
}
