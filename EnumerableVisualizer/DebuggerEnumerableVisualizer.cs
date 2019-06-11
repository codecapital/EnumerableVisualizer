using CodeCapital.EnumerableVisualizer;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(WeakReference), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ApplicationTrustCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Array), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ArrayList), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(BaseChannelObjectWithProperties), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(BitArray), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Collection<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(CollectionBase), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ConcurrentDictionary<,>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ConcurrentQueue<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ConcurrentStack<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Dictionary<,>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DictionaryBase), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Evidence), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(GenericAcl), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Hashtable), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(IdentityReferenceCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(KeyContainerPermissionAccessEntryCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(List<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(PermissionSet), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Queue), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ReadOnlyCollection<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ReadOnlyCollectionBase), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ReadOnlyDictionary<,>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ResourceReader), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ResourceSet), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SortedList), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Stack), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.ArrayList+FixedSizeList, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.ArrayList+ReadOnlyList, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.ArrayList+SyncIList, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.OrderablePartitioner`1+EnumerableDropIndices, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+DynamicPartitionerForArray`1+InternalPartitionEnumerable, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable`1+InternalPartitionEnumerable, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+DynamicPartitionerForIList`1+InternalPartitionEnumerable, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.EmptyReadOnlyDictionaryInternal, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Generic.Dictionary`2+KeyCollection, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Generic.Dictionary`2+ValueCollection, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Generic.List`1+SynchronizedList, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Hashtable+KeyCollection, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Hashtable+ValueCollection, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal+NodeKeyValueCollection, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.ObjectModel.ReadOnlyDictionary`2+KeyCollection, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.ObjectModel.ReadOnlyDictionary`2+ValueCollection, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.SortedList+KeyList, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.SortedList+ValueList, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.IO.Iterator`1, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Resources.ResourceFallbackManager, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ConstantSplittableMap`2, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.DictionaryKeyCollection`2, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.DictionaryValueCollection`2, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ICustomPropertyProviderProxy`2, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ReadOnlyDictionaryKeyCollection`2, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ReadOnlyDictionaryValueCollection`2, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Runtime.Remoting.Channels.AggregateDictionary, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Runtime.Remoting.Messaging.MessageDictionary, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Threading.Tasks.SingleProducerSingleConsumerQueue`1, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__7, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<get_DeclaredNestedTypes>d__7, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<GetDeclaredMethods>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Claims.ClaimsPrincipal+<get_Claims>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Claims.RoleClaimProvider+<get_Claims>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Principal.WindowsIdentity+<get_Claims>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_DeviceClaims>d__a, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_UserClaims>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Threading.Tasks.ThreadPoolTaskScheduler+<FilterTasksFromWorkItems>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Threading.ThreadPool+<EnumerateQueuedWorkItems>d__0, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
//.net4.6
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__6, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__9, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__7, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<get_DeclaredNestedTypes>d__23, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<GetDeclaredMethods>d__9, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__51, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Claims.ClaimsPrincipal+<get_Claims>d__37, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Claims.RoleClaimProvider+<get_Claims>d__5, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Principal.WindowsIdentity+<get_Claims>d__95, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_DeviceClaims>d__13, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_UserClaims>d__11, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Threading.Tasks.ThreadPoolTaskScheduler+<FilterTasksFromWorkItems>d__7, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Threading.ThreadPool+<EnumerateQueuedWorkItems>d__21, mscorlib", Description = DebuggerEnumerableVisualizer.Description)]
// System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(AsnEncodedDataCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(AttributeCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(BlockingCollection<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(CaptureCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(CodeNamespaceImportCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ConcurrentBag<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(CookieCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(CredentialCache), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DesignerCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(EventDescriptorCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(EventLogEntryCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(GatewayIPAddressInformationCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(GroupCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(HttpListenerPrefixCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(HybridDictionary), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(IPAddressCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(IPAddressInformationCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(LinkedList<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListDictionary), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListSortDescriptionCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(MatchCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(MulticastIPAddressInformationCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(NameObjectCollectionBase), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(OidCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(OrderedDictionary), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(PropertyDescriptorCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Queue<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SettingsPropertyCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SettingsPropertyValueCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SortedDictionary<,>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SortedList<,>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SortedSet<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Stack<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(StringCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(StringDictionary), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SortedDictionary<,>.KeyCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SortedDictionary<,>.ValueCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(NameObjectCollectionBase.KeysCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DesignerOptionService.DesignerOptionCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(TypeConverter.StandardValuesCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(TempFileCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(TraceListenerCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(UnicastIPAddressInformationCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(X509ChainElementCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(X509ExtensionCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Generic.SortedList`2+KeyList, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Generic.SortedList`2+ValueList, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Specialized.ListDictionary+NodeKeyValueCollection, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Specialized.OrderedDictionary+OrderedDictionaryKeyValueCollection, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Specialized.StringDictionary+GenericAdapter, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Specialized.StringDictionary+GenericAdapter+ICollectionToGenericCollectionAdapter, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Net.ProxyChain, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Net.SpnDictionary+ValueCollection, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.BlockingCollection`1+<GetConsumingEnumerable>d__0, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Generic.SortedSet`1+<Reverse>d__12, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Concurrent.BlockingCollection`1+<GetConsumingEnumerable>d__68, System", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Generic.SortedSet`1+<Reverse>d__104, System", Description = DebuggerEnumerableVisualizer.Description)]

// System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(EnumerableQuery<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ExpandoObject), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(HashSet<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Lookup<,>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ParallelQuery), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ReadOnlyCollectionBuilder<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+KeyCollection, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+ValueCollection, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+Iterator`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Expressions.BlockExpressionList, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Expressions.ListArgumentProvider, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Expressions.Set`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable`3, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable`4, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Lookup`2+Grouping, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.EnumerableWrapperWeakToStrong, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.GroupByGrouping`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.ListChunk`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.Lookup`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.MergeExecutor`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.OrderedGroupByGrouping`3, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.QueryResults`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+MetaExpando+<GetDynamicMemberNames>d__1b, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Select>d__0`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Where>d__6`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<CastIterator>d__b1`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<ConcatIterator>d__71`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<DefaultIfEmptyIterator>d__a5`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<DistinctIterator>d__81`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<ExceptIterator>d__99`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<GroupJoinIterator>d__6a`4, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<IntersectIterator>d__92`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<JoinIterator>d__61`4, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<OfTypeIterator>d__aa`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<RangeIterator>d__b8, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<RepeatIterator>d__bc`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<ReverseIterator>d__a0`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectIterator>d__7`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__14`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__1d`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__27`3, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__31`3, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipIterator>d__4d`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__52`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__59`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeIterator>d__3a`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__40`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__46`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<UnionIterator>d__88`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<WhereIterator>d__0`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<ZipIterator>d__7a`3, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Lookup`2+<ApplyResultSelector>d__3`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.CancellableEnumerable+<Wrap>d__0`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapEnumerable>d__0`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapQueryEnumerator>d__6`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.PartitionerQueryOperator`1+<AsSequentialQuery>d__0, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.ZipQueryOperator`3+<AsSequentialQuery>d__0, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
//.net4.6
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+MetaExpando+<GetDynamicMemberNames>d__6, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Select>d__3`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Where>d__5`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<CastIterator>d__94`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<ConcatIterator>d__58`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<DefaultIfEmptyIterator>d__90`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<DistinctIterator>d__63`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<ExceptIterator>d__72`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<GroupJoinIterator>d__40`4, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<IntersectIterator>d__69`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<JoinIterator>d__37`4, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<OfTypeIterator>d__92`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<RangeIterator>d__110, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<RepeatIterator>d__112`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<ReverseIterator>d__74`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectIterator>d__5`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__16`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__18`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__20`3, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__22`3, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipIterator>d__30`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__32`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__34`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeIterator>d__24`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__26`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__28`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<UnionIterator>d__66`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<WhereIterator>d__2`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Enumerable+<ZipIterator>d__60`3, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Lookup`2+<ApplyResultSelector>d__13`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer),typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.CancellableEnumerable+<Wrap>d__0`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer),typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapEnumerable>d__0`1, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapQueryEnumerator>d__1`2, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.PartitionerQueryOperator`1+<AsSequentialQuery>d__5, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Linq.Parallel.ZipQueryOperator`3+<AsSequentialQuery>d__9, System.Core", Description = DebuggerEnumerableVisualizer.Description)]
// System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ArrangedElementCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(AutoCompleteStringCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(BaseCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(BindingContext), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(BindingSource), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DataGridViewRowCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(GridItemCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(HtmlElementCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(HtmlWindowCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListViewGroupCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(NumericUpDownAccelerationCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ResXResourceReader), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(CheckedListBox.CheckedIndexCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(CheckedListBox.CheckedItemCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ComboBox.ObjectCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DataGridViewComboBoxCell.ObjectCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ImageList.ImageCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(LinkLabel.LinkCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListBox.IntegerCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListBox.ObjectCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListBox.SelectedIndexCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListBox.SelectedObjectCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListView.CheckedIndexCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListView.CheckedListViewItemCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListView.ColumnHeaderCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListView.ListViewItemCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListView.SelectedIndexCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListView.SelectedListViewItemCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ListViewItem.ListViewSubItemCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Menu.MenuItemCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(PropertyGrid.PropertyTabCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(StatusBar.StatusBarPanelCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(TabControl.TabPageCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ToolBar.ToolBarButtonCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(TableLayoutStyleCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(TreeNodeCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Forms.ClientUtils+WeakRefCollection, System.Windows.Forms", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Forms.DataGridViewCellLinkedList, System.Windows.Forms", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Forms.DataGridViewIntLinkedList, System.Windows.Forms", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Forms.PropertyGridInternal.MergePropertyDescriptor+MultiMergeCollection, System.Windows.Forms", Description = DebuggerEnumerableVisualizer.Description)]

// PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Annotations.ObservableDictionary, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Controls.EmptyEnumerable, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Data.IndexedEnumerable, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Data.LiveShapingList, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Data.RBTree`1, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Documents.ContentElementCollection`2, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.ListOfObject, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.WeakDictionary`2, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.WeakDictionary`2+KeyCollection`2, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.WeakDictionary`2+ValueCollection`2, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.WeakHashSet`1, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.ColumnDefinitionCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.CustomDictionarySources, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.DataGridColumnHeaderCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.MultipleCopiesCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.Selector+InternalSelectedItemsStorage, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.RowDefinitionCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.UIElementCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.VirtualizedCellInfoCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Data.CollectionView, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Data.CompositeCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentReferenceCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.FigureStructure, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.ListItemStructure, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.ListStructure, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.ParagraphStructure, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.SectionStructure, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.StoryFragment, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.StoryFragments, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.TableCellStructure, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.TableRowGroupStructure, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.TableRowStructure, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.TableStructure, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.FixedTextBuilder+FlowModelBuilder+LogicalHyperlinkContainer, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.PageContentCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.TableCellCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.TableColumnCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.TableRowCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.TableRowGroupCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Documents.TextElementCollection`1, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.LogicalTreeHelper+EnumeratorWrapper, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Localizer.BamlLocalizationDictionary, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+PartiallyOrderedList`2, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.XmlnsDictionary, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Media.Animation.ThicknessKeyFrameCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Navigation.JournalEntryStack, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Navigation.LimitedJournalEntryStackEnumerable, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Navigation.UnifiedJournalEntryStackEnumerable, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.ResourceDictionary, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.ResourceDictionary+ResourceValuesCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.TriggerActionCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.WindowCollection, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Ink.ClipboardProcessor+<get_PreferredFormats>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Ink.InkCanvasSelection+<get_SelectedElementsBoundsEnumerator>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarButtons>d__7, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarDayButtons>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.SelectedDatesCollection+<GetDaysInRange>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.SpellingError+<get_Suggestions>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementDictionaryItemsPseudoProperty+<get_Items>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementItemsPseudoProperty+<get_Items>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementMarkupObject+<GetProperties>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementPropertyBase+<get_Items>d__2, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ExtensionSimplifierMarkupObject+<GetProperties>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ExtensionSimplifierProperty+<get_Items>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.FrameworkElementFactoryContent+<get_Items>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.FrameworkElementFactoryMarkupObject+<GetProperties>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+Scope+<get_EnumerateAllMappings>d__f, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+Scope+<get_EnumerateLocalMappings>d__9, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.XmlnsDictionary+<GetNamespacePrefixes>d__0, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
//.net4.6
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Ink.ClipboardProcessor+<get_PreferredFormats>d__5, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Ink.InkCanvasSelection+<get_SelectedElementsBoundsEnumerator>d__39, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarButtons>d__56, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarDayButtons>d__51, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.SelectedDatesCollection+<GetDaysInRange>d__28, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Controls.SpellingError+<get_Suggestions>d__4, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementDictionaryItemsPseudoProperty+<get_Items>d__8, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementItemsPseudoProperty+<get_Items>d__8, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementMarkupObject+<GetProperties>d__5, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementPropertyBase+<get_Items>d__6, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ExtensionSimplifierMarkupObject+<GetProperties>d__3, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ExtensionSimplifierProperty+<get_Items>d__6, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.FrameworkElementFactoryContent+<get_Items>d__8, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.FrameworkElementFactoryMarkupObject+<GetProperties>d__8, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+Scope+<get_EnumerateAllMappings>d__19, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+Scope+<get_EnumerateLocalMappings>d__17, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Windows.Markup.XmlnsDictionary+<GetNamespacePrefixes>d__15, PresentationFramework", Description = DebuggerEnumerableVisualizer.Description)]
// System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DataColumnMappingCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DataTableMappingCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DataView), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DataViewManager), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DataViewSettingCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DbConnectionStringBuilder), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DbDataReader), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DbParameterCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(InternalDataCollectionBase), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(OdbcErrorCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(OleDbErrorCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SqlErrorCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Data.Common.ReadOnlyCollection`1, System.Data", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Data.RBTree`1, System.Data", Description = DebuggerEnumerableVisualizer.Description)]

// System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(XmlNamedNodeMap), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(XmlNamespaceManager), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(XmlNode), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(XmlNodeList), Description = DebuggerEnumerableVisualizer.Description)]
#pragma warning disable 618
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(XmlSchemaCollection), Description = DebuggerEnumerableVisualizer.Description)]
#pragma warning restore 618
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(XPathNodeIterator), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+NamesCollection, System.Xml", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+ValuesCollection, System.Xml", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Schema.SchemaInfo+<System.Xml.IDtdInfo.GetAttributeLists>d__0, System.Xml", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Schema.SchemaInfo+<System-Xml-IDtdInfo-GetAttributeLists>d__60, System.Xml", Description = DebuggerEnumerableVisualizer.Description)]
// System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "MS.Internal.Xml.Linq.ComponentModel.XDeferredAxis`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAncestors>d__f`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAttributes>d__8, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendantNodes>d__16`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendants>d__1f`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetElements>d__29`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<Nodes>d__0`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendantNodes>d__4, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendants>d__a, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<Nodes>d__0, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XElement+<GetAttributes>d__0, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetAncestors>d__8, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsAfterSelf>d__c, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsBeforeSelf>d__11, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesAfterSelf>d__0, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesBeforeSelf>d__4, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<Annotations>d__6`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<AnnotationsIterator>d__0, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.XPath.XPathEvaluator+<EvaluateIterator>d__0`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
//.net4.6
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAncestors>d__19`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAttributes>d__18, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendantNodes>d__20`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendants>d__21`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetElements>d__22`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<Nodes>d__6`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendantNodes>d__38, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendants>d__39, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__40, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<Nodes>d__18, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XElement+<GetAttributes>d__104, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetAncestors>d__40, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsAfterSelf>d__41, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsBeforeSelf>d__42, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesAfterSelf>d__21, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesBeforeSelf>d__22, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<Annotations>d__16`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<AnnotationsIterator>d__15, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Xml.XPath.XPathEvaluator+<EvaluateIterator>d__1`1, System.Xml.Linq", Description = DebuggerEnumerableVisualizer.Description)]

// System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Caching.Cache, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Caching.CacheInternal, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Hosting.MapPathBasedVirtualPathCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.HttpSessionStateBase, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.HttpStaticObjectsCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.HttpStaticObjectsCollectionBase, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.ModelBinderDictionary, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.ModelStateDictionary, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Profile.ProfileInfoCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Routing.RouteValueDictionary, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.SessionState.HttpSessionState, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.SiteMapNodeCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.ControlCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.DataBindingCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.ExpressionBindingCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.FilteredAttributeDictionary, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.HtmlControls.HtmlTableCellCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.HtmlControls.HtmlTableRowCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.ParsedAttributeCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.StateBag, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.StateManagedCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.ValidatorCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataGridColumnCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataGridItemCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataKeyArray, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataKeyCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataListItemCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.DetailsViewRowCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.DummyDataSource, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.GridViewRowCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.ListItemCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.MenuItemCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.MethodParametersDictionary, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.PagedDataSource, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.RepeaterItemCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.SelectedDatesCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.TableCellCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.TableRowCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.TreeNodeCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.WebParts.PersonalizationDictionary, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.WebParts.PersonalizationStateInfoCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.WizardStepCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.XmlDataSourceView+XmlDataSourceNodeDescriptorEnumeration, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.UI.WebControls.XmlHierarchicalEnumerable, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Util.EmptyCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Util.FileEnumerator, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Util.ObjectSet, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Util.SingleObjectCollection, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.ModelValidator+CompositeModelValidator+<Validate>d__1, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
//.net4.5
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Hosting.ApplicationManager+<CreateFutureMicrosoftWebInfrastructureStrongNames>d__19, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.AssociatedMetadataProvider+<GetMetadataForPropertiesImpl>d__0, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.CollectionModelBinderUtil+<GetZeroBasedIndexes>d__0, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.DataAnnotationsModelValidator+<Validate>d__15, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.DictionaryHelpers+<FindKeysWithPrefix>d__0`1, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.ValidatableObjectAdapter+<ConvertResults>d__2, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Security.AntiXss.CssEncoder+<CssSafeList>d__0, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Security.AntiXss.HtmlParameterEncoder+<UrlParameterSafeList>d__0, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Security.AntiXss.HtmlParameterEncoder+<UrlPathSafeList>d__6, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Security.RoleClaimProvider+<get_Claims>d__0, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
//.net4.6
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Hosting.ApplicationManager+<CreateFutureMicrosoftWebInfrastructureStrongNames>d__73, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.AssociatedMetadataProvider+<GetMetadataForPropertiesImpl>d__4, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.CollectionModelBinderUtil+<GetZeroBasedIndexes>d__4, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.DataAnnotationsModelValidator+<Validate>d__11, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer),typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.DictionaryHelpers+<FindKeysWithPrefix>d__0`1, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer),typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.ModelValidator+CompositeModelValidator+<Validate>d__1, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer),typeof(EnumerableObjectSource), TargetTypeName = "System.Web.ModelBinding.ValidatableObjectAdapter+<ConvertResults>d__2, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Security.AntiXss.CssEncoder+<CssSafeList>d__3, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Security.AntiXss.HtmlParameterEncoder+<UrlParameterSafeList>d__8, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Security.AntiXss.HtmlParameterEncoder+<UrlPathSafeList>d__12, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Security.RoleClaimProvider+<get_Claims>d__4, System.Web", Description = DebuggerEnumerableVisualizer.Description)]
// System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.ComponentModel.AttributeList, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.CopyOnWriteDictionary`2, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.GlobalFilterCollection, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ModelBinderDictionary, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ModelStateDictionary, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.MultiSelectList, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.Routing.RouteCollectionRoute, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.Routing.SubRouteCollection, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.TempDataDictionary, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ValueProviderDictionary, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ViewDataDictionary, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Generic.DictionaryExtensions+<FindKeysWithPrefix>d__1`1, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ClientDataTypeModelValidatorProvider+<GetValidatorsImpl>d__0, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.CompareAttribute+<GetClientValidationRules>d__8, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.CompareAttributeAdapter+<GetClientValidationRules>d__0, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ControllerInstanceFilterProvider+<GetFilters>d__0, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.DataErrorInfoModelValidatorProvider+<GetValidatorsImpl>d__0, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.DataTypeAttributeAdapter+<GetClientValidationRules>d__1, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.DefaultModelBinder+<GetZeroBasedIndexes>d__18, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.DictionaryHelpers+<FindKeysWithPrefix>d__0`1, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.FileExtensionsAttributeAdapter+<GetClientValidationRules>d__1, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.FilterAttributeFilterProvider+<GetFilters>d__0, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.Html.TemplateHelpers+<GetViewNames>d__4, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.MembershipPasswordAttributeAdapter+<GetClientValidationRules>d__0, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ModelValidator+CompositeModelValidator+<Validate>d__1, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ModelValidatorProviderCollection+<GetValidators>d__0, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.RemoteAttribute+<GetClientValidationRules>d__0, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ValidatableObjectAdapter+<ConvertResults>d__2, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Web.Mvc.ViewDataDictionary+ViewDataEvaluator+<GetRightToLeftExpressions>d__2, System.Web.Mvc", Description = DebuggerEnumerableVisualizer.Description)]

// Microsoft.Web.Administration, Version=7.9.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationAttributeCollection, Microsoft.Web.Administration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationAttributeSchemaCollection, Microsoft.Web.Administration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationChildElementCollection, Microsoft.Web.Administration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationElementCollectionBase`1, Microsoft.Web.Administration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationElementSchemaCollection, Microsoft.Web.Administration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationEnumValueCollection, Microsoft.Web.Administration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationMethodCollection, Microsoft.Web.Administration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Web.Administration.SectionDefinitionCollection, Microsoft.Web.Administration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Web.Administration.SectionGroupCollection, Microsoft.Web.Administration", Description = DebuggerEnumerableVisualizer.Description)]

// System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ConfigurationElementCollection), Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ConfigurationLockCollection), Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ConfigurationPropertyCollection), Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ProviderCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Configuration.ConfigurationValues+ConfigurationElementsCollection, System.Configuration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Configuration.ConfigurationValues+EmptyCollection, System.Configuration", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Configuration.ConfigurationValues+InvalidValuesCollection, System.Configuration", Description = DebuggerEnumerableVisualizer.Description)]

// System.DirectoryServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.DirectoryServices.DirectoryEntries, System.DirectoryServices", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.DirectoryServices.PropertyCollection, System.DirectoryServices", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.DirectoryServices.PropertyCollection+ValuesCollection, System.DirectoryServices", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.DirectoryServices.SchemaNameCollection, System.DirectoryServices", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.DirectoryServices.SearchResultCollection, System.DirectoryServices", Description = DebuggerEnumerableVisualizer.Description)]

// Microsoft.VisualBasic, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.VisualBasic.Collection, Microsoft.VisualBasic", Description = DebuggerEnumerableVisualizer.Description)]

// System.Data.DataSetExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Data.EnumerableRowCollection, System.Data.DataSetExtensions", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Data.TypedTableBase`1, System.Data.DataSetExtensions", Description = DebuggerEnumerableVisualizer.Description)]

// SD.LLBLGen.Pro.ORMSupportClasses, Version=4.2.0.0, Culture=neutral, PublicKeyToken=ca73b74ba4e3ff27
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.Grouping`2, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.GroupByCollection, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.TypedListBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.TypedListBase2`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.TypedViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.UniqueList`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.QuerySpec.Grouping`2, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]

//// V4
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetDependentRelatedEntityCoreInstances>d__6, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetDependingRelatedEntityCoreInstances>d__0, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetMemberEntityCollectionCoreInstances>d__c, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetDependentRelatedEntityCoreInstances>d__8, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetDependingRelatedEntityCoreInstances>d__2, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetMemberEntityCollectionCoreInstances>d__e, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.Description)]

//// V5
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetDependentRelatedEntityCoreInstances>d__31, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.DescriptionV47)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetDependingRelatedEntityCoreInstances>d__30, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.DescriptionV47)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetMemberEntityCollectionCoreInstances>d__32, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.DescriptionV47)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetDependentRelatedEntityCoreInstances>d__11, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.DescriptionV47)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetDependingRelatedEntityCoreInstances>d__10, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.DescriptionV47)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetMemberEntityCollectionCoreInstances>d__12, SD.LLBLGen.Pro.ORMSupportClasses", Description = DebuggerEnumerableVisualizer.DescriptionV47)]

////-LLBL 3
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase2`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = DebuggerEnumerableVisualizer.Description)]



//misc
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataSource+DataProviderCollection, Microsoft.Data.ConnectionUI.Dialog", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = DebuggerEnumerableVisualizer.Description)]

//.net core
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Collections.Generic.List`1, mscorlib", Description = "aaa")]

//-Other classes
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Data.Linq.Table`1, System.Data.Linq", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ObjectListView), Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ObjectListView<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(DataTable), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SqlErrorCollection), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(SqlParameterCollection), Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), TargetTypeName = "Oracle.DataAccess.Client.OracleParameterCollection, Oracle.DataAccess.Client", Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(StringVisualizer), typeof(VisualizerObjectSource), Target = typeof(System.String), Description = "My String Visualizer")]

//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(List<>), Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Array), Description = DebuggerEnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ArrayList), Description = DebuggerEnumerableVisualizer.Description)]
namespace CodeCapital.EnumerableVisualizer
{
    public class StringVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            Console.WriteLine("Some Text Version 1");
            Trace.Write("Aaaaa Text Version 1");
        }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            //var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerVisualizer));
            var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(StringVisualizer), typeof(EnumerableObjectSource));

            visualizerHost.ShowVisualizer();
        }
    }

    public class DebuggerEnumerableVisualizer : DialogDebuggerVisualizer
    {
        public const string Description = "Enumerable Visualizer 1.2";

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            Trace.Write(Description);

            try
            {
                ShowVisualizer(objectProvider);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception getting object data: " + ex.Message);
            }
        }

        private static void ShowVisualizer(IVisualizerObjectProvider objectProvider)
        {
            Trace.WriteLine("Hello Update 3");

            var dataStream = objectProvider.GetData();

            if (dataStream != null && dataStream.Length > 0)
            {
                var dataTable = JsonHelper.Deserialize(dataStream);

                ShowVisualizerForm(dataTable);
            }
        }

        private static void ShowVisualizerForm(DataTable data)
        {
            var form = new VisualizerForm(data);

            form.ShowDialog();
        }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            //var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerVisualizer));
            var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource));

            visualizerHost.ShowVisualizer();
        }
    }
}
