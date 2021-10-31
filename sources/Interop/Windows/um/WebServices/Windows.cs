// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int WS_HTTP_HEADER_MAPPING_COMMA_SEPARATOR = 0x1;
        public const int WS_HTTP_HEADER_MAPPING_SEMICOLON_SEPARATOR = 0x2;
        public const int WS_HTTP_HEADER_MAPPING_QUOTED_VALUE = 0x4;

        public const int WS_HTTP_RESPONSE_MAPPING_STATUS_CODE = 0x1;
        public const int WS_HTTP_RESPONSE_MAPPING_STATUS_TEXT = 0x2;

        public const int WS_HTTP_REQUEST_MAPPING_VERB = 0x2;

        public const int WS_MATCH_URL_DNS_HOST = 0x1;
        public const int WS_MATCH_URL_DNS_FULLY_QUALIFIED_HOST = 0x2;
        public const int WS_MATCH_URL_NETBIOS_HOST = 0x4;
        public const int WS_MATCH_URL_LOCAL_HOST = 0x8;
        public const int WS_MATCH_URL_HOST_ADDRESSES = 0x10;
        public const int WS_MATCH_URL_THIS_HOST = (WS_MATCH_URL_DNS_HOST | WS_MATCH_URL_DNS_FULLY_QUALIFIED_HOST | WS_MATCH_URL_NETBIOS_HOST | WS_MATCH_URL_LOCAL_HOST | WS_MATCH_URL_HOST_ADDRESSES);
        public const int WS_MATCH_URL_PORT = 0x20;
        public const int WS_MATCH_URL_EXACT_PATH = 0x40;
        public const int WS_MATCH_URL_PREFIX_PATH = 0x80;
        public const int WS_MATCH_URL_NO_QUERY = 0x100;

        public const int WS_MUST_UNDERSTAND_HEADER_ATTRIBUTE = 0x1;
        public const int WS_RELAY_HEADER_ATTRIBUTE = 0x2;

        public const int WS_HTTP_HEADER_AUTH_SCHEME_NONE = 0x1;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_BASIC = 0x2;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_DIGEST = 0x4;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_NTLM = 0x8;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_NEGOTIATE = 0x10;
        public const int WS_HTTP_HEADER_AUTH_SCHEME_PASSPORT = 0x20;

        public const int WS_CERT_FAILURE_CN_MISMATCH = 0x1;
        public const int WS_CERT_FAILURE_INVALID_DATE = 0x2;
        public const int WS_CERT_FAILURE_UNTRUSTED_ROOT = 0x4;
        public const int WS_CERT_FAILURE_WRONG_USAGE = 0x8;
        public const int WS_CERT_FAILURE_REVOCATION_OFFLINE = 0x10;

        public const int WS_STRUCT_ABSTRACT = 0x1;
        public const int WS_STRUCT_IGNORE_TRAILING_ELEMENT_CONTENT = 0x2;
        public const int WS_STRUCT_IGNORE_UNHANDLED_ATTRIBUTES = 0x4;

        public const int WS_FIELD_POINTER = 0x1;
        public const int WS_FIELD_OPTIONAL = 0x2;
        public const int WS_FIELD_NILLABLE = 0x4;
        public const int WS_FIELD_NILLABLE_ITEM = 0x8;
        public const int WS_FIELD_OTHER_NAMESPACE = 0x10;

        public const int WS_SERVICE_OPERATION_MESSAGE_NILLABLE_ELEMENT = 0x1;

        public const int WS_URL_FLAGS_ALLOW_HOST_WILDCARDS = 0x1;
        public const int WS_URL_FLAGS_NO_PATH_COLLAPSE = 0x2;
        public const int WS_URL_FLAGS_ZERO_TERMINATE = 0x4;

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsStartReaderCanonicalization(IntPtr reader, [NativeTypeName("WS_WRITE_CALLBACK")] delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> writeCallback, void* writeCallbackState, [NativeTypeName("const WS_XML_CANONICALIZATION_PROPERTY *")] WS_XML_CANONICALIZATION_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsEndReaderCanonicalization(IntPtr reader, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsStartWriterCanonicalization(IntPtr writer, [NativeTypeName("WS_WRITE_CALLBACK")] delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> writeCallback, void* writeCallbackState, [NativeTypeName("const WS_XML_CANONICALIZATION_PROPERTY *")] WS_XML_CANONICALIZATION_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsEndWriterCanonicalization(IntPtr writer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateXmlBuffer(IntPtr heap, [NativeTypeName("const WS_XML_BUFFER_PROPERTY *")] WS_XML_BUFFER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* buffer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsRemoveNode([NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateReader([NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_READER **")] IntPtr* reader, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetInput(IntPtr reader, [NativeTypeName("const WS_XML_READER_ENCODING *")] WS_XML_READER_ENCODING* encoding, [NativeTypeName("const WS_XML_READER_INPUT *")] WS_XML_READER_INPUT* input, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetInputToBuffer(IntPtr reader, IntPtr buffer, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeReader(IntPtr reader);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetReaderProperty(IntPtr reader, WS_XML_READER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetReaderNode(IntPtr xmlReader, [NativeTypeName("const WS_XML_NODE **")] WS_XML_NODE** node, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsFillReader(IntPtr reader, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadStartElement(IntPtr reader, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadToStartElement(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL* found, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadStartAttribute(IntPtr reader, [NativeTypeName("ULONG")] uint attributeIndex, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadEndAttribute(IntPtr reader, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadNode(IntPtr reader, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSkipNode(IntPtr reader, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadEndElement(IntPtr reader, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsFindAttribute(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL required, [NativeTypeName("ULONG *")] uint* attributeIndex, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadValue(IntPtr reader, WS_VALUE_TYPE valueType, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadChars(IntPtr reader, [NativeTypeName("WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint maxCharCount, [NativeTypeName("ULONG *")] uint* actualCharCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadCharsUtf8(IntPtr reader, byte* bytes, [NativeTypeName("ULONG")] uint maxByteCount, [NativeTypeName("ULONG *")] uint* actualByteCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadBytes(IntPtr reader, void* bytes, [NativeTypeName("ULONG")] uint maxByteCount, [NativeTypeName("ULONG *")] uint* actualByteCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadArray(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, WS_VALUE_TYPE valueType, void* array, [NativeTypeName("ULONG")] uint arraySize, [NativeTypeName("ULONG")] uint itemOffset, [NativeTypeName("ULONG")] uint itemCount, [NativeTypeName("ULONG *")] uint* actualItemCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetReaderPosition(IntPtr reader, WS_XML_NODE_POSITION* nodePosition, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetReaderPosition(IntPtr reader, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsMoveReader(IntPtr reader, WS_MOVE_TO moveTo, BOOL* found, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateWriter([NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_WRITER **")] IntPtr* writer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeWriter(IntPtr writer);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetOutput(IntPtr writer, [NativeTypeName("const WS_XML_WRITER_ENCODING *")] WS_XML_WRITER_ENCODING* encoding, [NativeTypeName("const WS_XML_WRITER_OUTPUT *")] WS_XML_WRITER_OUTPUT* output, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetOutputToBuffer(IntPtr writer, IntPtr buffer, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetWriterProperty(IntPtr writer, WS_XML_WRITER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsFlushWriter(IntPtr writer, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteStartElement(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteEndStartElement(IntPtr writer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteXmlnsAttribute(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL singleQuote, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteStartAttribute(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL singleQuote, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteEndAttribute(IntPtr writer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteValue(IntPtr writer, WS_VALUE_TYPE valueType, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteXmlBuffer(IntPtr writer, IntPtr xmlBuffer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadXmlBuffer(IntPtr reader, IntPtr heap, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* xmlBuffer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteXmlBufferToBytes(IntPtr writer, IntPtr xmlBuffer, [NativeTypeName("const WS_XML_WRITER_ENCODING *")] WS_XML_WRITER_ENCODING* encoding, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, IntPtr heap, void** bytes, [NativeTypeName("ULONG *")] uint* byteCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadXmlBufferFromBytes(IntPtr reader, [NativeTypeName("const WS_XML_READER_ENCODING *")] WS_XML_READER_ENCODING* encoding, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const void *")] void* bytes, [NativeTypeName("ULONG")] uint byteCount, IntPtr heap, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* xmlBuffer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteArray(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, WS_VALUE_TYPE valueType, [NativeTypeName("const void *")] void* array, [NativeTypeName("ULONG")] uint arraySize, [NativeTypeName("ULONG")] uint itemOffset, [NativeTypeName("ULONG")] uint itemCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteQualifiedName(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteChars(IntPtr writer, [NativeTypeName("const WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint charCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteCharsUtf8(IntPtr writer, [NativeTypeName("const BYTE *")] byte* bytes, [NativeTypeName("ULONG")] uint byteCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteBytes(IntPtr writer, [NativeTypeName("const void *")] void* bytes, [NativeTypeName("ULONG")] uint byteCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsPushBytes(IntPtr writer, [NativeTypeName("WS_PUSH_BYTES_CALLBACK")] delegate* unmanaged<void*, delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT>, void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> callback, void* callbackState, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsPullBytes(IntPtr writer, [NativeTypeName("WS_PULL_BYTES_CALLBACK")] delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> callback, void* callbackState, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteEndElement(IntPtr writer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteText(IntPtr writer, [NativeTypeName("const WS_XML_TEXT *")] WS_XML_TEXT* text, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteStartCData(IntPtr writer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteEndCData(IntPtr writer, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteNode(IntPtr writer, [NativeTypeName("const WS_XML_NODE *")] WS_XML_NODE* node, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetPrefixFromNamespace(IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL required, [NativeTypeName("const WS_XML_STRING **")] WS_XML_STRING** prefix, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetWriterPosition(IntPtr writer, WS_XML_NODE_POSITION* nodePosition, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetWriterPosition(IntPtr writer, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsMoveWriter(IntPtr writer, WS_MOVE_TO moveTo, BOOL* found, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsTrimXmlWhitespace([NativeTypeName("WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint charCount, [NativeTypeName("WCHAR **")] ushort** trimmedChars, [NativeTypeName("ULONG *")] uint* trimmedCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsVerifyXmlNCName([NativeTypeName("const WCHAR *")] ushort* ncNameChars, [NativeTypeName("ULONG")] uint ncNameCharCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsXmlStringEquals([NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* string1, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* string2, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetNamespaceFromPrefix(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, BOOL required, [NativeTypeName("const WS_XML_STRING **")] WS_XML_STRING** ns, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadQualifiedName(IntPtr reader, IntPtr heap, WS_XML_STRING* prefix, WS_XML_STRING* localName, WS_XML_STRING* ns, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetXmlAttribute(IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, IntPtr heap, [NativeTypeName("WCHAR **")] ushort** valueChars, [NativeTypeName("ULONG *")] uint* valueCharCount, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCopyNode(IntPtr writer, IntPtr reader, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAsyncExecute(WS_ASYNC_STATE* asyncState, [NativeTypeName("WS_ASYNC_FUNCTION")] delegate* unmanaged<HRESULT, WS_CALLBACK_MODEL, void*, WS_ASYNC_OPERATION*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> operation, WS_CALLBACK_MODEL callbackModel, void* callbackState, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateChannel(WS_CHANNEL_TYPE channelType, WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("WS_CHANNEL **")] IntPtr* channel, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsOpenChannel(IntPtr channel, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* endpointAddress, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSendMessage(IntPtr channel, IntPtr message, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* messageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* bodyValue, [NativeTypeName("ULONG")] uint bodyValueSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReceiveMessage(IntPtr channel, IntPtr message, [NativeTypeName("const WS_MESSAGE_DESCRIPTION **")] WS_MESSAGE_DESCRIPTION** messageDescriptions, [NativeTypeName("ULONG")] uint messageDescriptionCount, WS_RECEIVE_OPTION receiveOption, WS_READ_OPTION readBodyOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG *")] uint* index, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsRequestReply(IntPtr channel, IntPtr requestMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* requestMessageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* requestBodyValue, [NativeTypeName("ULONG")] uint requestBodyValueSize, IntPtr replyMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* replyMessageDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSendReplyMessage(IntPtr channel, IntPtr replyMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* replyMessageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* replyBodyValue, [NativeTypeName("ULONG")] uint replyBodyValueSize, IntPtr requestMessage, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSendFaultMessageForError(IntPtr channel, IntPtr replyMessage, IntPtr faultError, HRESULT faultErrorCode, WS_FAULT_DISCLOSURE faultDisclosure, IntPtr requestMessage, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetChannelProperty(IntPtr channel, WS_CHANNEL_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetChannelProperty(IntPtr channel, WS_CHANNEL_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteMessageStart(IntPtr channel, IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteMessageEnd(IntPtr channel, IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadMessageStart(IntPtr channel, IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadMessageEnd(IntPtr channel, IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCloseChannel(IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAbortChannel(IntPtr channel, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeChannel(IntPtr channel);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsResetChannel(IntPtr channel, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAbandonMessage(IntPtr channel, IntPtr message, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsShutdownSessionChannel(IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetOperationContextProperty([NativeTypeName("const WS_OPERATION_CONTEXT *")] IntPtr context, [NativeTypeName("const WS_OPERATION_CONTEXT_PROPERTY_ID")] WS_OPERATION_CONTEXT_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetDictionary(WS_ENCODING encoding, WS_XML_DICTIONARY** dictionary, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadEndpointAddressExtension(IntPtr reader, WS_ENDPOINT_ADDRESS* endpointAddress, WS_ENDPOINT_ADDRESS_EXTENSION_TYPE extensionType, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateError([NativeTypeName("const WS_ERROR_PROPERTY *")] WS_ERROR_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR **")] IntPtr* error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAddErrorString(IntPtr error, [NativeTypeName("const WS_STRING *")] WS_STRING* @string);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetErrorString(IntPtr error, [NativeTypeName("ULONG")] uint index, WS_STRING* @string);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCopyError(IntPtr source, IntPtr destination);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetErrorProperty(IntPtr error, WS_ERROR_PROPERTY_ID id, void* buffer, [NativeTypeName("ULONG")] uint bufferSize);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetErrorProperty(IntPtr error, WS_ERROR_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsResetError(IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeError(IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetFaultErrorProperty(IntPtr error, WS_FAULT_ERROR_PROPERTY_ID id, void* buffer, [NativeTypeName("ULONG")] uint bufferSize);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetFaultErrorProperty(IntPtr error, WS_FAULT_ERROR_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateFaultFromError(IntPtr error, HRESULT faultErrorCode, WS_FAULT_DISCLOSURE faultDisclosure, IntPtr heap, WS_FAULT* fault);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetFaultErrorDetail(IntPtr error, [NativeTypeName("const WS_FAULT_DETAIL_DESCRIPTION *")] WS_FAULT_DETAIL_DESCRIPTION* faultDetailDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetFaultErrorDetail(IntPtr error, [NativeTypeName("const WS_FAULT_DETAIL_DESCRIPTION *")] WS_FAULT_DETAIL_DESCRIPTION* faultDetailDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateHeap([NativeTypeName("SIZE_T")] nuint maxSize, [NativeTypeName("SIZE_T")] nuint trimSize, [NativeTypeName("const WS_HEAP_PROPERTY *")] WS_HEAP_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_HEAP **")] IntPtr* heap, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAlloc(IntPtr heap, [NativeTypeName("SIZE_T")] nuint size, void** ptr, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetHeapProperty(IntPtr heap, WS_HEAP_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsResetHeap(IntPtr heap, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeHeap(IntPtr heap);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateListener(WS_CHANNEL_TYPE channelType, WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_LISTENER_PROPERTY *")] WS_LISTENER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("WS_LISTENER **")] IntPtr* listener, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsOpenListener(IntPtr listener, [NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAcceptChannel(IntPtr listener, IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCloseListener(IntPtr listener, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAbortListener(IntPtr listener, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsResetListener(IntPtr listener, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeListener(IntPtr listener);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetListenerProperty(IntPtr listener, WS_LISTENER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetListenerProperty(IntPtr listener, WS_LISTENER_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateChannelForListener(IntPtr listener, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_CHANNEL **")] IntPtr* channel, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateMessage(WS_ENVELOPE_VERSION envelopeVersion, WS_ADDRESSING_VERSION addressingVersion, [NativeTypeName("const WS_MESSAGE_PROPERTY *")] WS_MESSAGE_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_MESSAGE **")] IntPtr* message, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateMessageForChannel(IntPtr channel, [NativeTypeName("const WS_MESSAGE_PROPERTY *")] WS_MESSAGE_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_MESSAGE **")] IntPtr* message, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsInitializeMessage(IntPtr message, WS_MESSAGE_INITIALIZATION initialization, IntPtr sourceMessage, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsResetMessage(IntPtr message, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeMessage(IntPtr message);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetHeaderAttributes(IntPtr message, IntPtr reader, [NativeTypeName("ULONG *")] uint* headerAttributes, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetHeader(IntPtr message, WS_HEADER_TYPE headerType, WS_TYPE valueType, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetCustomHeader(IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* customHeaderDescription, WS_REPEATING_HEADER_OPTION repeatingOption, [NativeTypeName("ULONG")] uint headerIndex, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG *")] uint* headerAttributes, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsRemoveHeader(IntPtr message, WS_HEADER_TYPE headerType, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetHeader(IntPtr message, WS_HEADER_TYPE headerType, WS_TYPE valueType, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsRemoveCustomHeader(IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerNs, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAddCustomHeader(IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* headerDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG")] uint headerAttributes, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAddMappedHeader(IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, WS_TYPE valueType, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsRemoveMappedHeader(IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetMappedHeader(IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, WS_REPEATING_HEADER_OPTION repeatingOption, [NativeTypeName("ULONG")] uint headerIndex, WS_TYPE valueType, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteBody(IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* bodyDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadBody(IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* bodyDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteEnvelopeStart(IntPtr message, IntPtr writer, [NativeTypeName("WS_MESSAGE_DONE_CALLBACK")] delegate* unmanaged<void*, void> doneCallback, void* doneCallbackState, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteEnvelopeEnd(IntPtr message, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadEnvelopeStart(IntPtr message, IntPtr reader, [NativeTypeName("WS_MESSAGE_DONE_CALLBACK")] delegate* unmanaged<void*, void> doneCallback, void* doneCallbackState, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadEnvelopeEnd(IntPtr message, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetMessageProperty(IntPtr message, WS_MESSAGE_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsSetMessageProperty(IntPtr message, WS_MESSAGE_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAddressMessage(IntPtr message, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* address, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCheckMustUnderstandHeaders(IntPtr message, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsMarkHeaderAsUnderstood(IntPtr message, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* headerPosition, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsFillBody(IntPtr message, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsFlushBody(IntPtr message, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsRequestSecurityToken(IntPtr channel, [NativeTypeName("const WS_REQUEST_SECURITY_TOKEN_PROPERTY *")] WS_REQUEST_SECURITY_TOKEN_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_SECURITY_TOKEN **")] IntPtr* token, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetSecurityTokenProperty(IntPtr securityToken, WS_SECURITY_TOKEN_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr heap, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateXmlSecurityToken(IntPtr tokenXml, WS_SECURITY_KEY_HANDLE* tokenKey, [NativeTypeName("const WS_XML_SECURITY_TOKEN_PROPERTY *")] WS_XML_SECURITY_TOKEN_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_SECURITY_TOKEN **")] IntPtr* token, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeSecurityToken(IntPtr token);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsRevokeSecurityContext(IntPtr securityContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetSecurityContextProperty(IntPtr securityContext, WS_SECURITY_CONTEXT_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadElement(IntPtr reader, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* elementDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadAttribute(IntPtr reader, [NativeTypeName("const WS_ATTRIBUTE_DESCRIPTION *")] WS_ATTRIBUTE_DESCRIPTION* attributeDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadType(IntPtr reader, WS_TYPE_MAPPING typeMapping, WS_TYPE type, [NativeTypeName("const void *")] void* typeDescription, WS_READ_OPTION readOption, IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteElement(IntPtr writer, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* elementDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteAttribute(IntPtr writer, [NativeTypeName("const WS_ATTRIBUTE_DESCRIPTION *")] WS_ATTRIBUTE_DESCRIPTION* attributeDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsWriteType(IntPtr writer, WS_TYPE_MAPPING typeMapping, WS_TYPE type, [NativeTypeName("const void *")] void* typeDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsRegisterOperationForCancel([NativeTypeName("const WS_OPERATION_CONTEXT *")] IntPtr context, [NativeTypeName("WS_OPERATION_CANCEL_CALLBACK")] delegate* unmanaged<WS_SERVICE_CANCEL_REASON, void*, void> cancelCallback, [NativeTypeName("WS_OPERATION_FREE_STATE_CALLBACK")] delegate* unmanaged<void*, void> freestateCallback, void* userState, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetServiceHostProperty(IntPtr serviceHost, [NativeTypeName("const WS_SERVICE_PROPERTY_ID")] WS_SERVICE_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateServiceHost([NativeTypeName("const WS_SERVICE_ENDPOINT **")] WS_SERVICE_ENDPOINT** endpoints, [NativeTypeName("const USHORT")] ushort endpointCount, [NativeTypeName("const WS_SERVICE_PROPERTY *")] WS_SERVICE_PROPERTY* serviceProperties, [NativeTypeName("ULONG")] uint servicePropertyCount, [NativeTypeName("WS_SERVICE_HOST **")] IntPtr* serviceHost, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsOpenServiceHost(IntPtr serviceHost, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCloseServiceHost(IntPtr serviceHost, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAbortServiceHost(IntPtr serviceHost, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeServiceHost(IntPtr serviceHost);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsResetServiceHost(IntPtr serviceHost, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetServiceProxyProperty(IntPtr serviceProxy, [NativeTypeName("const WS_PROXY_PROPERTY_ID")] WS_PROXY_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateServiceProxy([NativeTypeName("const WS_CHANNEL_TYPE")] WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_CHANNEL_BINDING")] WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("const WS_PROXY_PROPERTY *")] WS_PROXY_PROPERTY* properties, [NativeTypeName("const ULONG")] uint propertyCount, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* channelProperties, [NativeTypeName("const ULONG")] uint channelPropertyCount, [NativeTypeName("WS_SERVICE_PROXY **")] IntPtr* serviceProxy, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsOpenServiceProxy(IntPtr serviceProxy, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* address, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCloseServiceProxy(IntPtr serviceProxy, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAbortServiceProxy(IntPtr serviceProxy, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeServiceProxy(IntPtr serviceProxy);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsResetServiceProxy(IntPtr serviceProxy, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsAbandonCall(IntPtr serviceProxy, [NativeTypeName("ULONG")] uint callId, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCall(IntPtr serviceProxy, [NativeTypeName("const WS_OPERATION_DESCRIPTION *")] WS_OPERATION_DESCRIPTION* operation, [NativeTypeName("const void **")] void** arguments, IntPtr heap, [NativeTypeName("const WS_CALL_PROPERTY *")] WS_CALL_PROPERTY* callProperties, [NativeTypeName("const ULONG")] uint callPropertyCount, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsDecodeUrl([NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("ULONG")] uint flags, IntPtr heap, WS_URL** outUrl, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsEncodeUrl([NativeTypeName("const WS_URL *")] WS_URL* url, [NativeTypeName("ULONG")] uint flags, IntPtr heap, WS_STRING* outUrl, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCombineUrl([NativeTypeName("const WS_STRING *")] WS_STRING* baseUrl, [NativeTypeName("const WS_STRING *")] WS_STRING* referenceUrl, [NativeTypeName("ULONG")] uint flags, IntPtr heap, WS_STRING* resultUrl, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsDateTimeToFileTime([NativeTypeName("const WS_DATETIME *")] WS_DATETIME* dateTime, FILETIME* fileTime, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsFileTimeToDateTime([NativeTypeName("const FILETIME *")] FILETIME* fileTime, WS_DATETIME* dateTime, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateMetadata([NativeTypeName("const WS_METADATA_PROPERTY *")] WS_METADATA_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_METADATA **")] IntPtr* metadata, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsReadMetadata(IntPtr metadata, IntPtr reader, [NativeTypeName("const WS_STRING *")] WS_STRING* url, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern void WsFreeMetadata(IntPtr metadata);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsResetMetadata(IntPtr metadata, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetMetadataProperty(IntPtr metadata, WS_METADATA_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetMissingMetadataDocumentAddress(IntPtr metadata, WS_ENDPOINT_ADDRESS** address, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetMetadataEndpoints(IntPtr metadata, WS_METADATA_ENDPOINTS* endpoints, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsMatchPolicyAlternative(IntPtr policy, [NativeTypeName("ULONG")] uint alternativeIndex, WS_POLICY_CONSTRAINTS* policyConstraints, BOOL matchRequired, IntPtr heap, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetPolicyProperty(IntPtr policy, WS_POLICY_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsGetPolicyAlternativeCount(IntPtr policy, [NativeTypeName("ULONG *")] uint* count, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateServiceProxyFromTemplate(WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_PROXY_PROPERTY *")] WS_PROXY_PROPERTY* properties, [NativeTypeName("const ULONG")] uint propertyCount, WS_BINDING_TEMPLATE_TYPE templateType, void* templateValue, [NativeTypeName("ULONG")] uint templateSize, [NativeTypeName("const void *")] void* templateDescription, [NativeTypeName("ULONG")] uint templateDescriptionSize, [NativeTypeName("WS_SERVICE_PROXY **")] IntPtr* serviceProxy, IntPtr error);

        [DllImport("webservices", ExactSpelling = true)]
        public static extern HRESULT WsCreateServiceEndpointFromTemplate(WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_SERVICE_ENDPOINT_PROPERTY *")] WS_SERVICE_ENDPOINT_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_STRING *")] WS_STRING* addressUrl, [NativeTypeName("const WS_SERVICE_CONTRACT *")] WS_SERVICE_CONTRACT* contract, [NativeTypeName("WS_SERVICE_SECURITY_CALLBACK")] delegate* unmanaged<IntPtr, BOOL*, IntPtr, HRESULT> authorizationCallback, IntPtr heap, WS_BINDING_TEMPLATE_TYPE templateType, void* templateValue, [NativeTypeName("ULONG")] uint templateSize, [NativeTypeName("const void *")] void* templateDescription, [NativeTypeName("ULONG")] uint templateDescriptionSize, WS_SERVICE_ENDPOINT** serviceEndpoint, IntPtr error);
    }
}
