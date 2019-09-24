// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Interface describing SVG path data. Path data can be set as the 'd' attribute on a 'path' element. The path data set is factored into two arrays. The segment data array stores all numbers and the commands array stores the set of commands. Unlike the string data set in the d attribute, each command in this representation uses a fixed number of elements in the segment data array. Therefore, the path 'M 0,0 100,0 0,100 Z' is represented as: 'M0,0 L100,0 L0,100 Z'. This is split into two arrays, with the segment data containing '0,0 100,0 0,100', and the commands containing 'M L L Z'.</summary>
    [Guid("C095E4F4-BB98-43D6-9745-4D1B84EC9888")]
    public unsafe struct ID2D1SvgPathData
    {
        public readonly Vtbl* lpVtbl;

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1SvgPathData* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1SvgPathData* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1SvgPathData* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1SvgPathData* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Returns the element on which this attribute is set. Returns null if the attribute is not set on any element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetElement(
            [In] ID2D1SvgPathData* This,
            [Out] ID2D1SvgElement** element
        );

        /// <summary>Creates a clone of this attribute value. On creation, the cloned attribute is not set on any element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Clone(
            [In] ID2D1SvgPathData* This,
            [Out] ID2D1SvgAttribute** attribute
        );

        /// <summary>Removes data from the end of the segment data array.</summary>
        /// <param name="dataCount">Specifies how much data to remove.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemoveSegmentDataAtEnd(
            [In] ID2D1SvgPathData* This,
            [In, NativeTypeName("UINT32")] uint dataCount
        );

        /// <summary>Updates the segment data array. Existing segment data not updated by this method are preserved. The array is resized larger if necessary to accomodate the new segment data.</summary>
        /// <param name="data">The data array.</param>
        /// <param name="dataCount">The number of data to update.</param>
        /// <param name="startIndex">The index at which to begin updating segment data. Must be less than or equal to the size of the segment data array.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _UpdateSegmentData(
            [In] ID2D1SvgPathData* This,
            [In, NativeTypeName("FLOAT[]")] float* data,
            [In, NativeTypeName("UINT32")] uint dataCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        );

        /// <summary>Gets data from the segment data array.</summary>
        /// <param name="data">Buffer to contain the segment data array.</param>
        /// <param name="dataCount">The element count of the buffer.</param>
        /// <param name="startIndex">The index of the first segment data to retrieve.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSegmentData(
            [In] ID2D1SvgPathData* This,
            [Out, NativeTypeName("FLOAT[]")] float* data,
            [In, NativeTypeName("UINT32")] uint dataCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        );

        /// <summary>Gets the size of the segment data array.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetSegmentDataCount(
            [In] ID2D1SvgPathData* This
        );

        /// <summary>Removes commands from the end of the commands array.</summary>
        /// <param name="commandsCount">Specifies how many commands to remove.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemoveCommandsAtEnd(
            [In] ID2D1SvgPathData* This,
            [In, NativeTypeName("UINT32")] uint commandsCount
        );

        /// <summary>Updates the commands array. Existing commands not updated by this method are preserved. The array is resized larger if necessary to accomodate the new commands.</summary>
        /// <param name="commands">The commands array.</param>
        /// <param name="commandsCount">The number of commands to update.</param>
        /// <param name="startIndex">The index at which to begin updating commands. Must be less than or equal to the size of the commands array.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _UpdateCommands(
            [In] ID2D1SvgPathData* This,
            [In, NativeTypeName("D2D1_SVG_PATH_COMMAND")] D2D1_SVG_PATH_COMMAND* commands,
            [In, NativeTypeName("UINT32")] uint commandsCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        );

        /// <summary>Gets commands from the commands array.</summary>
        /// <param name="commands">Buffer to contain the commands</param>
        /// <param name="commandsCount">The element count of the buffer.</param>
        /// <param name="startIndex">The index of the first commands to retrieve.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCommands(
            [In] ID2D1SvgPathData* This,
            [Out, NativeTypeName("D2D1_SVG_PATH_COMMAND[]")] D2D1_SVG_PATH_COMMAND* commands,
            [In, NativeTypeName("UINT32")] uint commandsCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        );

        /// <summary>Gets the size of the commands array.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetCommandsCount(
            [In] ID2D1SvgPathData* This
        );

        /// <summary>Creates a path geometry object representing the path data.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreatePathGeometry(
            [In] ID2D1SvgPathData* This,
            [In] D2D1_FILL_MODE fillMode,
            [Out] ID2D1PathGeometry1** pathGeometry
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        public void GetElement(
            [Out] ID2D1SvgElement** element
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetElement>(lpVtbl->GetElement)(
                    This,
                    element
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(
            [Out] ID2D1SvgAttribute** attribute
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(
                    This,
                    attribute
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveSegmentDataAtEnd(
            [In, NativeTypeName("UINT32")] uint dataCount
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveSegmentDataAtEnd>(lpVtbl->RemoveSegmentDataAtEnd)(
                    This,
                    dataCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateSegmentData(
            [In, NativeTypeName("FLOAT[]")] float* data,
            [In, NativeTypeName("UINT32")] uint dataCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UpdateSegmentData>(lpVtbl->UpdateSegmentData)(
                    This,
                    data,
                    dataCount,
                    startIndex
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSegmentData(
            [Out, NativeTypeName("FLOAT[]")] float* data,
            [In, NativeTypeName("UINT32")] uint dataCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSegmentData>(lpVtbl->GetSegmentData)(
                    This,
                    data,
                    dataCount,
                    startIndex
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSegmentDataCount()
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSegmentDataCount>(lpVtbl->GetSegmentDataCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveCommandsAtEnd(
            [In, NativeTypeName("UINT32")] uint commandsCount
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveCommandsAtEnd>(lpVtbl->RemoveCommandsAtEnd)(
                    This,
                    commandsCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateCommands(
            [In, NativeTypeName("D2D1_SVG_PATH_COMMAND")] D2D1_SVG_PATH_COMMAND* commands,
            [In, NativeTypeName("UINT32")] uint commandsCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UpdateCommands>(lpVtbl->UpdateCommands)(
                    This,
                    commands,
                    commandsCount,
                    startIndex
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCommands(
            [Out, NativeTypeName("D2D1_SVG_PATH_COMMAND[]")] D2D1_SVG_PATH_COMMAND* commands,
            [In, NativeTypeName("UINT32")] uint commandsCount,
            [In, NativeTypeName("UINT32")] uint startIndex = 0
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCommands>(lpVtbl->GetCommands)(
                    This,
                    commands,
                    commandsCount,
                    startIndex
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCommandsCount()
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCommandsCount>(lpVtbl->GetCommandsCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathGeometry(
            [In] D2D1_FILL_MODE fillMode,
            [Out] ID2D1PathGeometry1** pathGeometry
        )
        {
            fixed (ID2D1SvgPathData* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePathGeometry>(lpVtbl->CreatePathGeometry)(
                    This,
                    fillMode,
                    pathGeometry
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetElement;

            public IntPtr Clone;

            public IntPtr RemoveSegmentDataAtEnd;

            public IntPtr UpdateSegmentData;

            public IntPtr GetSegmentData;

            public IntPtr GetSegmentDataCount;

            public IntPtr RemoveCommandsAtEnd;

            public IntPtr UpdateCommands;

            public IntPtr GetCommands;

            public IntPtr GetCommandsCount;

            public IntPtr CreatePathGeometry;
        }
    }
}
